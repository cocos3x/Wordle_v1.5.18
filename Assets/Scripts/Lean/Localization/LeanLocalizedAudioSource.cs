using UnityEngine;

namespace Lean.Localization
{
	public class LeanLocalizedAudioSource : LeanLocalizedBehaviour
	{
		public AudioClip FallbackAudioClip;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
