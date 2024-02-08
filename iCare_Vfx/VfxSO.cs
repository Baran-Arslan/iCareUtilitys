using Sirenix.OdinInspector;
using UnityEngine;

namespace iCareGames._Common.Core {
    [CreateAssetMenu(fileName = "Vfx", menuName = "iCareGames/Vfx")]
    public sealed class VfxSO : ScriptableObject {
        [AssetsOnly, Required]
        public GameObject Prefab;
        public int PreloadAmount = 2;
        public Vector3 Scale = Vector3.one;
    }
}