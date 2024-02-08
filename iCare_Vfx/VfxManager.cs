using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace iCareGames._Common.Core {
    public sealed class VfxManager : UnitySingeleton<VfxManager> {
        [SerializeField]
        private VfxSO[] vfxToPreload;
        
        private readonly Dictionary<VfxSO, VFXPool> _vfxPools = new Dictionary<VfxSO, VFXPool>();


        private void Awake() {
            foreach (var vfxSo in vfxToPreload) {
                _vfxPools.Add(vfxSo, new VFXPool(transform, vfxSo, vfxSo.PreloadAmount));
            }
        }
        
        [Button]
        public void Play(VfxSO vfxSo, Vector3 position, Quaternion rotation = default, Transform parent = null, Vector3 customScale = default) {
            if (!_vfxPools.ContainsKey(vfxSo)) {
                _vfxPools.Add(vfxSo, new VFXPool(transform, vfxSo, 0));
            }
            var vfxTransform = _vfxPools[vfxSo].Get().transform;
            if (parent != null) {
                vfxTransform.SetParent(parent);
                vfxTransform.localPosition = position;
            }
            else
                vfxTransform.position = position;
            
            if(customScale != default) vfxTransform.localScale = customScale;
            vfxTransform.rotation = rotation;
        }
    }
}