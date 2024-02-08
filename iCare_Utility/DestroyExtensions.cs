using UnityEngine;

namespace iCareGames._Common.Core
{
    public static class DestroyExtensions
    {
        public static void DestroyIfNotNull(this Object obj, float destroyTime = 0)
        {
            if (obj != null)
            {
                Object.Destroy(obj, destroyTime);
            }
        }
    }
}