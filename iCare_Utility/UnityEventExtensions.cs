using UnityEngine.Events;

namespace iCareGames._Common.Core {
    public static class UnityEventExtensions {
        public static bool HasEventListener(this UnityEventBase unityEvent, string methodName) {
            var eventListenerCount = unityEvent.GetPersistentEventCount();
            var hasEventListener = false;

            for (var i = 0; i < eventListenerCount; i++) {
                var listenerMethodName = unityEvent.GetPersistentMethodName(i);
                if (listenerMethodName != methodName) continue;
                hasEventListener = true;
                break;
            }

            return hasEventListener;
        }
    }
}