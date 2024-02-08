using System.Collections;
using UnityEngine;

namespace iCareGames._Common.Core {
    [RequireComponent(typeof(ParticleSystem))]
    public sealed class Vfx : MonoBehaviour {
        public VFXPool Pool { get; set; }
        private ParticleSystem _particleSystem;
        
        private void Awake() {
            _particleSystem = GetComponent<ParticleSystem>();
        }

        private void OnEnable() {
            StartCoroutine(ReleaseParticle(_particleSystem.main.duration));
        }

        private void OnDisable() {
            StopAllCoroutines();
        }

        private IEnumerator ReleaseParticle(float duration) {
            yield return new WaitForSeconds(duration);
            Pool.Release(this);
        }
    }
}