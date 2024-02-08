using UnityEngine;

namespace iCareGames._Common.Core {
    public class TransformData {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Scale;
    }
    public static class TransformExtensions {
        public static TransformData Hold(this Transform transform) {
            return new TransformData {
                Position = transform.position,
                Rotation = transform.rotation,
                Scale = transform.localScale
            };
        }
        public static void Restore(this Transform transform, TransformData data) {
            transform.position = data.Position;
            transform.rotation = data.Rotation;
            transform.localScale = data.Scale;
        }
    }
}