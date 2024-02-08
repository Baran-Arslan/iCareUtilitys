using UnityEngine;

namespace iCareGames._Common.Core
{
    public static class LayerExtensions
    {
        public static bool ContainsLayer(this LayerMask layerMask, int layer) {
            return (layerMask.value & (1 << layer)) != 0;
        }
        public static void ChangeLayersRecursively(this GameObject obj, string name) {
            obj.layer = LayerMask.NameToLayer(name);
            foreach (Transform child in obj.transform) {
                child.gameObject.ChangeLayersRecursively(name);
            }
        }
    }
}