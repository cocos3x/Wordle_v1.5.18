using UnityEngine;

namespace Lean.Localization
{
	public class LeanLocalizedTextFont : LeanLocalizedBehaviour
	{
		public Font FallbackFont;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
