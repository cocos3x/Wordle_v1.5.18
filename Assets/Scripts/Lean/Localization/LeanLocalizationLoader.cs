using UnityEngine;

namespace Lean.Localization
{
	public class LeanLocalizationLoader : MonoBehaviour
	{
		public LeanLocalization Target;

		public TextAsset Source;

		public string SourceLanguage;

		public string Separator;

		public string NewLine;

		public string Comment;

		private static readonly char[] newlineCharacters;

		protected virtual void Start()
		{
		}

		public void LoadFromSource()
		{
		}
	}
}
