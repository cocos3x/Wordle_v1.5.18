using UnityEngine;

namespace Lean.Localization
{
	public class LeanLocalizedSpriteRenderer : LeanLocalizedBehaviour
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
