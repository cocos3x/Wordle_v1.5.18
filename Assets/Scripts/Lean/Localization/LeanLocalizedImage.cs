using UnityEngine;

namespace Lean.Localization
{
	public class LeanLocalizedImage : LeanLocalizedBehaviour
	{
		public Sprite FallbackSprite;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
