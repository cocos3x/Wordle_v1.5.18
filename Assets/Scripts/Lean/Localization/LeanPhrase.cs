using System;
using System.Collections.Generic;

namespace Lean.Localization
{
	[Serializable]
	public class LeanPhrase
	{
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public string language;

			internal bool _003CFindTranslation_003Eb__0(LeanTranslation t)
			{
				return false;
			}
		}

		public string Name;

		public List<LeanTranslation> Translations;

		public LeanTranslation FindTranslation(string language)
		{
			return null;
		}

		public LeanTranslation AddTranslation(string language)
		{
			return null;
		}
	}
}
