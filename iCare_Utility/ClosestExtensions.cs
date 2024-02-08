using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace iCareGames._Common.Core
{
    public static class ClosestExtensions
    {
        public static T GetClosestIn<T>(this Transform myTransform, IEnumerable<T> targets, IgnoreAxis ignoreAxis = IgnoreAxis.None) where T : Component {
            if (targets == null || !targets.Any()) {
                Printer.LogError("Couldn't find closest collection is empty");
                return null;
            }

            T bestTarget = null;
            var closestDistanceSqr = Mathf.Infinity;
            var currentPosition = myTransform.position;

            foreach (var target in targets) {
                var directionToTarget = target.transform.position - currentPosition;

                IgnoreAxisHelper.Ignore(ref directionToTarget, ignoreAxis);

                var sqrDistanceToTarget = directionToTarget.sqrMagnitude;

                if (!(sqrDistanceToTarget < closestDistanceSqr)) continue;
                closestDistanceSqr = sqrDistanceToTarget;
                bestTarget = target;
            }

            return bestTarget;
        }
        
        
    }
}
