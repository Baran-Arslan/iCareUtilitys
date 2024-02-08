using UnityEngine;

namespace iCareGames._Common.Core {
    public struct AudioPlayData {
        public AudioSO AudioSO;
        public Vector3 PlayPosition;
        public Transform Parent;
        public bool Loop;
        public bool Is2D;
        public AudioType AudioType;
    }
}