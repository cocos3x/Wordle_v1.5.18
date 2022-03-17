using UnityEngine;
using UnityEngine.UI;

namespace Lean.Localization
{
	public class LeanSliderToArg : MonoBehaviour
	{
		public Slider Slider;

		public LeanLocalizedTextArgs LocalizedTextArgs;

		public void OnValueChanged(float value)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
