using UnityEngine;
using UnityEngine.Pool;

namespace iCareGames._Common.Core {
    public sealed class VFXPool {
        private readonly VfxSO _vfxData;
        private readonly Transform _parent;
        private readonly ObjectPool<Vfx> _pool;
        
        public VFXPool(Transform parent , VfxSO vfxSo, int preloadAmount = 5) {
            _pool = new ObjectPool<Vfx>(OnCreate, OnGet, OnRelease, OnClear, true, 30);
            _vfxData = vfxSo;
            _parent = parent;
            Preload(preloadAmount);
        }

        public Vfx Get() {
            return _pool.Get();
        }
        public void Release(Vfx vfx) {
            _pool.Release(vfx);
        }
        
        private static void OnClear(Vfx obj) {
            Object.Destroy(obj.gameObject);
        }
        private void OnRelease(Vfx obj) {
            var vfxTransform = obj.transform;
            vfxTransform.rotation = Quaternion.Euler(Vector3.zero);
            vfxTransform.localScale = _vfxData.Scale;
            obj.gameObject.SetActive(false);
            
        }
        private static void OnGet(Vfx obj) {
            obj.gameObject.SetActive(true);
        }
        private Vfx OnCreate() {
            var vfx = Object.Instantiate(_vfxData.Prefab).GetOrAddComponent<Vfx>();
            vfx.Pool = this;
            var vfxTransform = vfx.transform;
            vfxTransform.SetParent(_parent);
            vfxTransform.localScale = _vfxData.Scale;
            return vfx;
        }
        private void Preload(int amount) {
            var vfxArray = new Vfx[amount];
            for (var i = 0; i < amount; i++) {
                vfxArray[i] = _pool.Get();
            }
            for (var i = 0; i < amount; i++) {
                _pool.Release(vfxArray[i]);
            }
        }
    }
}