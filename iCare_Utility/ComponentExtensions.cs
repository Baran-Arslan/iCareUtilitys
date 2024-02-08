using UnityEngine;

namespace iCareGames._Common.Core
{
    public static class ComponentExtensions
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component {
            var component = gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
            return component;
        }
        
        
        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component) where T : Component
        {
            component = gameObject.GetComponentInChildren<T>();
            return component != null;
        }
        public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T component) where T : Component
        {
            component = gameObject.GetComponentInParent<T>();
            return component != null;
        }
    }
}
