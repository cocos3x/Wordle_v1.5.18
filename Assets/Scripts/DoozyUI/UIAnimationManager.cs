using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class UIAnimationManager : MonoBehaviour
	{
		public enum AnimationType
		{
			IN,
			LOOP,
			OUT,
			OnClick,
			ButtonLoops
		}

		public enum ButtonLoopType
		{
			None,
			Normal,
			Highlighted
		}

		[Serializable]
		public class InAnimations
		{
			public string inAnimationsPresetName;

			public UIAnimator.MoveIn moveIn;

			public UIAnimator.RotationIn rotationIn;

			public UIAnimator.ScaleIn scaleIn;

			public UIAnimator.FadeIn fadeIn;
		}

		[Serializable]
		public class LoopAnimations
		{
			public string loopAnimationsPresetName;

			public UIAnimator.MoveLoop moveLoop;

			public UIAnimator.RotationLoop rotationLoop;

			public UIAnimator.ScaleLoop scaleLoop;

			public UIAnimator.FadeLoop fadeLoop;
		}

		[Serializable]
		public class OutAnimations
		{
			public string outAnimationsPresetName;

			public UIAnimator.MoveOut moveOut;

			public UIAnimator.RotationOut rotationOut;

			public UIAnimator.ScaleOut scaleOut;

			public UIAnimator.FadeOut fadeOut;
		}

		[Serializable]
		public class OnClickAnimations
		{
			public string onClickAnimationsPresetName;

			public bool punchPositionEnabled;

			public Vector2 punchPositionPunch;

			public bool punchPositionSnapping;

			public float punchPositionDuration;

			public int punchPositionVibrato;

			public float punchPositionElasticity;

			public float punchPositionDelay;

			public bool punchRotationEnabled;

			public Vector3 punchRotationPunch;

			public float punchRotationDuration;

			public int punchRotationVibrato;

			public float punchRotationElasticity;

			public float punchRotationDelay;

			public bool punchScaleEnabled;

			public Vector3 punchScalePunch;

			public float punchScaleDuration;

			public int punchScaleVibrato;

			public float punchScaleElasticity;

			public float punchScaleDelay;
		}

		[Serializable]
		public class ButtonLoopsAnimations
		{
			public string animationsPresetName;

			public UIAnimator.MoveLoop moveLoop;

			public UIAnimator.RotationLoop rotationLoop;

			public UIAnimator.ScaleLoop scaleLoop;

			public UIAnimator.FadeLoop fadeLoop;
		}

		public const string DEFAULT_PRESET_NAME = "DefaultPreset";

		private UIElement uiElement;

		private UIButton uiButton;

		private string uiAnimationsFolderPath;

		private string fileNameExtension;

		public UIElement GetUIElement => null;

		public UIButton GetUIButton => null;

		private string GetUIAnimationsFolderPath => "";

		public void SavePreset(string presetName, AnimationType animationType, ButtonLoopType buttonLoopType = ButtonLoopType.None)
		{
		}

		public void LoadPreset(string presetName, AnimationType animationType, ButtonLoopType buttonLoopType = ButtonLoopType.None)
		{
		}

		public void LoadPresetList(AnimationType animationType)
		{
		}

		public void DeletePreset(string presetName, AnimationType animationType, ButtonLoopType buttonLoopType = ButtonLoopType.None)
		{
		}
	}
}
