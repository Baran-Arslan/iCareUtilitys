using UnityEngine;

namespace iCareGames._Common.Core
{
    public enum IgnoreAxis
    {
        None,
        X,
        Y,
        Z,
        XY,
        XZ,
        YZ,
    }

    public static class IgnoreAxisHelper
    {
        public static void Ignore(ref Vector3 vector, IgnoreAxis ignoreAxis) {
            switch (ignoreAxis) {
                case IgnoreAxis.X:
                    vector.x = 0f;
                    break;
                case IgnoreAxis.Y:
                    vector.y = 0f;
                    break;
                case IgnoreAxis.Z:
                    vector.z = 0f;
                    break;
                case IgnoreAxis.XY:
                    vector.x = vector.y = 0f;
                    break;
                case IgnoreAxis.XZ:
                    vector.x = vector.z = 0f;
                    break;
                case IgnoreAxis.YZ:
                    vector.y = vector.z = 0f;
                    break;
            }
        }

    }
}