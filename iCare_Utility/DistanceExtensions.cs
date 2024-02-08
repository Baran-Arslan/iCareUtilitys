using UnityEngine;

namespace iCareGames._Common.Core {
    public static class DistanceExtensions {
        private static float SqrDistanceTo(this Vector3 from, Vector3 to, IgnoreAxis ignoreAxis = IgnoreAxis.None) {
            var modifiedFrom = from;
            var modifiedTo = to;

            IgnoreAxisHelper.Ignore(ref modifiedFrom, ignoreAxis);
            IgnoreAxisHelper.Ignore(ref modifiedTo, ignoreAxis);

            return (modifiedFrom - modifiedTo).sqrMagnitude;
        }

        public static bool IsInRange(this Vector3 from, Vector3 to, float range,
            IgnoreAxis ignoreAxis = IgnoreAxis.None) {
            return SqrDistanceTo(from, to, ignoreAxis) <= range * range;
        }

        public static bool IsInRange(this Transform from, Transform to, float range,
            IgnoreAxis ignoreAxis = IgnoreAxis.None) {
            return IsInRange(from.position, to.position, range, ignoreAxis);
        }
    }
}