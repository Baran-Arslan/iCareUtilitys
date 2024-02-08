using UnityEngine;

namespace iCareGames._Common.Core {
    public static class VfxExtensions {
        public static void Play(this VfxSO vfx, Vector3 position, Quaternion rotation = default, Transform parent = null, Vector3 customScale = default) {
            if (vfx == null) {
                Printer.LogInfo("VfxSO is null returning");
                return;
            }
            VfxManager.Instance.Play(vfx, position, rotation, parent, customScale);
        }
        
    }
}