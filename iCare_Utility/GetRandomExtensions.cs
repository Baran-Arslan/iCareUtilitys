using UnityEngine;

namespace iCareGames._Common.Core {
    public static class GetRandomExtensions {
        public static T GetRandom<T>(this T[] array) {
            if (array is not { Length: > 0 }) {
                Printer.LogError("Array is empty!");
            }
            return array[UnityEngine.Random.Range(0, array.Length)];
        }

        public static T GetRandom<T>(this System.Collections.Generic.List<T> list) {
            if (list is not { Count: > 0 }) {
                Printer.LogError("List is empty!");
            }
            return list[UnityEngine.Random.Range(0, list.Count)];
        }
        
        public static Vector3 GetRandomPositionInCircle(this Transform transform, float radius) {
            var randomPoint = UnityEngine.Random.insideUnitCircle * radius;
            return transform.position + new Vector3(randomPoint.x, 0, randomPoint.y);
        }
        
    }
}