using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Lean.Localization
{
	public class LeanLocalization : MonoBehaviour
	{
		public enum DetectType
		{
			None,
			SystemLanguage,
			CurrentCulture,
			CurrentUICulture
		}

		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public string language;
		}

		private sealed class _003C_003Ec__DisplayClass33_1
		{
			public string alias;

			public _003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals1;

			internal bool _003CAddLanguage_003Eb__0(LeanCulture c)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public string language;

			public string alias;

			internal bool _003CAddCulture_003Eb__0(LeanCulture c)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass35_0
		{
			public string phraseName;

			internal bool _003CAddPhrase_003Eb__0(LeanPhrase p)
			{
				return false;
			}
		}

		public string DefaultLanguage;

		public DetectType DetectLanguage;

		public bool SaveLanguage;

		public List<string> Languages;

		public List<LeanCulture> Cultures;

		public List<LeanPhrase> Phrases;

		public static Action OnLocalizationChanged;

		public static List<LeanLocalization> AllLocalizations;

		private static string currentLanguage;

		private static string currentDictionary;

		private static List<string> currentLanguages;

		private static List<string> currentPhrases;

		private static Dictionary<string, LeanTranslation> currentTranslations;

		public static List<string> CurrentLanguages => null;

		public static List<string> CurrentPhrases => null;

		public static bool CurrentSaveLanguage => false;

		public static string CurrentLanguage
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public static string CurrentDictionary
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void ClearSave()
		{
		}

		public void SetCurrentLanguage(string newLanguage)
		{
		}

		public void SetCurrentDictionary(string newLanguage)
		{
		}

		public static LeanTranslation GetTranslation(string phraseName)
		{
			return null;
		}

		public static string GetTranslationText(string phraseName)
		{
			return "";
		}

		public static UnityEngine.Object GetTranslationObject(string phraseName)
		{
			return null;
		}

		public void AddLanguage(string language, [Optional] string[] aliases)
		{
		}

		public LeanCulture AddCulture(string language, string alias)
		{
			return null;
		}

		public LeanPhrase AddPhrase(string phraseName)
		{
			return null;
		}

		public LeanTranslation AddTranslation(string language, string phraseName)
		{
			return null;
		}

		public static void UpdateTranslations()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private string FindLanguageName(string alias)
		{
			return "";
		}
	}
}
