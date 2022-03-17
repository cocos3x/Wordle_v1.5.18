using UnityEngine;

namespace Lean.Localization
{
	public abstract class LeanLocalizedBehaviour : MonoBehaviour
	{
		[SerializeField]
		private string phraseName;

		public string PhraseName
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public abstract void UpdateTranslation(LeanTranslation translation);

		public void UpdateLocalization()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
