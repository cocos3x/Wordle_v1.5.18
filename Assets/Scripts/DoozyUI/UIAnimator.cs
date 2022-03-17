using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace DoozyUI
{
	public class UIAnimator
	{
		public enum MoveDetails
		{
			ParentPosition,
			LocalPosition,
			TopScreenEdge,
			RightScreenEdge,
			BottomScreenEdge,
			LeftScreenEdge,
			TopLeft,
			TopCenter,
			TopRight,
			MiddleLeft,
			MiddleCenter,
			MiddleRight,
			BottomLeft,
			BottomCenter,
			BottomRight
		}

		public enum SoundOutput
		{
			AudioSource,
			MasterAudioPlaySoundAndForget,
			MasterAudioFireCustomEvent
		}

		public enum ButtonAnimationType
		{
			None,
			PunchPosition,
			PunchRotation,
			PunchScale
		}

		public enum AnimationTarget
		{
			None,
			UIElement,
			UIButton
		}

		public enum ResetType
		{
			All,
			Position,
			Rotation,
			Scale,
			Fade
		}

		[Serializable]
		public class InitialData
		{
			public Vector3 startPosition;

			public Vector3 startRotation;

			public Vector3 startScale;

			public float startAlpha;

			public bool soundOn;
		}

		[Serializable]
		public class SoundDetails
		{
			public string soundName;
		}

		[Serializable]
		public class MoveIn
		{
			public bool enabled;

			public MoveDetails moveFrom;

			public Vector3 positionAdjustment;

			public Vector3 positionFrom;

			public Ease easeType;

			public float time;

			public float delay;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class RotationIn
		{
			public bool enabled;

			public Vector3 rotateFrom;

			public Ease easeType;

			public float time;

			public float delay;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class ScaleIn
		{
			public bool enabled;

			public Vector3 scaleBegin;

			public Ease easeType;

			public float time;

			public float delay;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class FadeIn
		{
			public bool enabled;

			public Ease easeType;

			public float time;

			public float delay;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class MoveLoop
		{
			public bool enabled;

			public bool autoStart;

			public Vector3 movement;

			public Ease easeType;

			public int loops;

			public LoopType loopType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class RotationLoop
		{
			public bool enabled;

			public bool autoStart;

			public Vector3 rotation;

			public Ease easeType;

			public int loops;

			public LoopType loopType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class ScaleLoop
		{
			public bool enabled;

			public bool autoStart;

			public Vector3 min;

			public Vector3 max;

			public Ease easeType;

			public int loops;

			public LoopType loopType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class FadeLoop
		{
			public bool enabled;

			public bool autoStart;

			public float min;

			public float max;

			public Ease easeType;

			public int loops;

			public LoopType loopType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class MoveOut
		{
			public bool enabled;

			public MoveDetails moveTo;

			public Vector3 positionAdjustment;

			public Vector3 positionTo;

			public Ease easeType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class RotationOut
		{
			public bool enabled;

			public Vector3 rotateTo;

			public Ease easeType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class ScaleOut
		{
			public bool enabled;

			public Vector3 scaleEnd;

			public Ease easeType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		[Serializable]
		public class FadeOut
		{
			public bool enabled;

			public Ease easeType;

			public float time;

			public float delay;

			public SoundDetails soundAtStartReference;

			public SoundDetails soundAtFinishReference;

			public string soundAtStart;

			public string soundAtFinish;
		}

		public enum EaseType
		{
			Ease,
			AnimationCurve
		}

		public enum TweenIdType
		{
			Move,
			Rotate,
			Scale,
			Fade
		}

		public enum TweenIdAnimation
		{
			In,
			Out,
			Loop,
			Punch
		}

		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public UnityAction OnStart;

			public UnityAction OnComplete;

			internal void _003CMove_003Eb__0()
			{
			}

			internal void _003CMove_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass36_0
		{
			public UnityAction OnStart;

			public UnityAction OnComplete;

			internal void _003CRotate_003Eb__0()
			{
			}

			internal void _003CRotate_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass37_0
		{
			public UnityAction OnStart;

			public UnityAction OnComplete;

			internal void _003CScale_003Eb__0()
			{
			}

			internal void _003CScale_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass38_0
		{
			public UnityAction OnStart;

			public UnityAction OnComplete;

			internal void _003CFade_003Eb__0()
			{
			}

			internal void _003CFade_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass40_0
		{
			public UnityAction OnStart;

			public RectTransform target;

			public Vector3 poistionB;

			public Loop loop;

			public string id;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CLoopMove_003Eb__0()
			{
			}

			internal void _003CLoopMove_003Eb__1()
			{
			}

			internal void _003CLoopMove_003Eb__2()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass41_0
		{
			public UnityAction OnStart;

			public RectTransform target;

			public Vector3 rotationB;

			public Loop loop;

			public RotateMode rotateMode;

			public string id;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CLoopRotate_003Eb__0()
			{
			}

			internal void _003CLoopRotate_003Eb__1()
			{
			}

			internal void _003CLoopRotate_003Eb__2()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass42_0
		{
			public UnityAction OnStart;

			public RectTransform target;

			public Loop loop;

			public string id;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CLoopScale_003Eb__0()
			{
			}

			internal void _003CLoopScale_003Eb__1()
			{
			}

			internal void _003CLoopScale_003Eb__2()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass43_0
		{
			public UnityAction OnStart;

			public CanvasGroup canvasGroup;

			public Loop loop;

			public RectTransform target;

			public string id;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CLoopFade_003Eb__0()
			{
			}

			internal void _003CLoopFade_003Eb__1()
			{
			}

			internal void _003CLoopFade_003Eb__2()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass47_0
		{
			public UnityAction OnStart;

			public RectTransform target;

			public Vector3 startPosition;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CPunchMove_003Eb__0()
			{
			}

			internal void _003CPunchMove_003Eb__1()
			{
			}

			internal void _003CPunchMove_003Eb__2()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass48_0
		{
			public UnityAction OnStart;

			public RectTransform target;

			public Vector3 startRotation;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CPunchRotate_003Eb__0()
			{
			}

			internal void _003CPunchRotate_003Eb__1()
			{
			}

			internal void _003CPunchRotate_003Eb__2()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass49_0
		{
			public UnityAction OnStart;

			public RectTransform target;

			public Vector3 startScale;

			public UnityAction OnComplete;

			public TweenCallback _003C_003E9__2;

			internal void _003CPunchScale_003Eb__0()
			{
			}

			internal void _003CPunchScale_003Eb__1()
			{
			}

			internal void _003CPunchScale_003Eb__2()
			{
			}
		}

		public const float DEFAULT_DURATION = 0.5f;

		public const float DEFAULT_START_DELAY = 0f;

		public const Ease DEFAULT_EASE = Ease.Linear;

		public const int DEFAULT_LOOPS = -1;

		public const float DEFAULT_DURATION_ONCOMPLETE = 0.1f;

		public const float DEFAULT_DURATION_INIT_LOOP = 0.2f;

		public const float DEFAULT_DURATION_RESET_TARGET = 0.1f;

		public static bool isTimeScaleIndependent;

		public static Move.MoveDirection GetDirection(MoveDetails moveDetails)
		{
			//IL_0003: Expected I4, but got O
			return (Move.MoveDirection)null;
		}

		public static Ease Reverse(Ease ease)
		{
			//IL_0003: Expected I4, but got O
			return (Ease)null;
		}

		public static string GetTweenId(RectTransform target, TweenIdType idType, TweenIdAnimation idAnimation)
		{
			return "";
		}

		public static void ResetTarget(RectTransform target, Vector3 startPosition, Vector3 startRotation, Vector3 startScale, float startAlpha, bool instantAnimation = true)
		{
		}

		public static void Move(RectTransform target, Vector3 startPosition, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		private static Vector3 GetTargetPosition(RectTransform target, Vector3 startPosition, Anim animation)
		{
			return (Vector3)null;
		}

		public static void Rotate(RectTransform target, Vector3 startRotation, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		public static void Scale(RectTransform target, Vector3 startScale, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		public static void Fade(RectTransform target, float startAlpha, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		public static void StopAnimations(RectTransform target, Anim.AnimationType aType)
		{
		}

		public static void LoopMove(RectTransform target, Vector3 startPosition, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool forced = false)
		{
		}

		public static void LoopRotate(RectTransform target, Vector3 startRotation, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool forced = false)
		{
		}

		public static void LoopScale(RectTransform target, Vector3 startScale, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool forced = false)
		{
		}

		public static void LoopFade(RectTransform target, float startAlpha, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool blocksRaycasts = false, bool forced = false)
		{
		}

		public static void SetupLoops(RectTransform target, Vector3 startPosition, Vector3 startRotation, Vector3 startScale, float startAlpha, Loop loop, UnityAction OnStartMoveLoop, UnityAction OnCompleteMoveLoop, UnityAction OnStartRotateLoop, UnityAction OnCompleteRotateLoop, UnityAction OnStartScaleLoop, UnityAction OnCompleteScaleLoop, UnityAction OnStartFadeLoop, UnityAction OnCompleteFadeLoop, string id = "", bool blocksRaycasts = false, bool forced = false)
		{
		}

		public static void PlayLoops(RectTransform target, string id = "")
		{
		}

		public static void StopLoops(RectTransform target, string id = "")
		{
		}

		public static void PunchMove(RectTransform target, Vector3 startPosition, Punch punch, UnityAction OnStart, UnityAction OnComplete, bool forced = false)
		{
		}

		public static void PunchRotate(RectTransform target, Vector3 startRotation, Punch punch, UnityAction OnStart, UnityAction OnComplete, bool forced = false)
		{
		}

		public static void PunchScale(RectTransform target, Vector3 startScale, Punch punch, UnityAction OnStart, UnityAction OnComplete, bool forced = false)
		{
		}
	}
}
