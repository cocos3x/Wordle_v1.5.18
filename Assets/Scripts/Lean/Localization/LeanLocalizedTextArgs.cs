using System;

namespace Lean.Localization
{
	public class LeanLocalizedTextArgs : LeanLocalizedBehaviour
	{
		public string FallbackText;

		[NonSerialized]
		public object[] Args;

		public void SetArg(object arg, int index)
		{
		}

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
