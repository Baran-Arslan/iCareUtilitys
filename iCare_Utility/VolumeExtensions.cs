using DG.Tweening;
using UnityEngine.Rendering;

namespace iCareGames._Common.Core
{
    public static class VolumeExtensions
    {
        public static void SetVolumeWeight(this Volume volume, float targetWeight, float duration)
            => DOTween.To(() => volume.weight, x => volume.weight = x, targetWeight, duration)
                .SetUpdate(true)
                .SetEase(Ease.Linear);
    }
}
