using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DoozyUI
{
	public class UIElement : MonoBehaviour
	{
		[Serializable]
		public class ElementName
		{
			public string elementName;
		}

		private sealed class _003CiShow_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public bool instantAction;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CiShow_003Ed__102(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CiSetSelectedGameObject_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CiSetSelectedGameObject_003Ed__111(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CiHide_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public bool instantAction;

			public bool shouldDisable;

			private float _003Cstart_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CiHide_003Ed__115(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CiAutoHide_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UIElement _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CiAutoHide_003Ed__126(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CInvokeEventAfterDelay_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UnityEvent @event;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInvokeEventAfterDelay_003Ed__131(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CDisableButtonClicksForTime_003Ed__140 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public float delay;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDisableButtonClicksForTime_003Ed__140(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CGetOrientation_003Ed__142 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetOrientation_003Ed__142(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CTriggerShowInTheNextFrame_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public bool instantAction;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTriggerShowInTheNextFrame_003Ed__144(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public UIAnimator.MoveIn moveIn;

		public UIAnimator.RotationIn rotationIn;

		public UIAnimator.ScaleIn scaleIn;

		public UIAnimator.FadeIn fadeIn;

		public UIAnimator.MoveLoop moveLoop;

		public UIAnimator.RotationLoop rotationLoop;

		public UIAnimator.ScaleLoop scaleLoop;

		public UIAnimator.FadeLoop fadeLoop;

		public UIAnimator.MoveOut moveOut;

		public UIAnimator.RotationOut rotationOut;

		public UIAnimator.ScaleOut scaleOut;

		public UIAnimator.FadeOut fadeOut;

		public const string LOOP_ANIMATIONS_ID = "UIElementLoopAnimations";

		public string elementCategory;

		public string elementName;

		public bool LANDSCAPE;

		public bool PORTRAIT;

		public bool startHidden;

		public bool animateAtStart;

		public bool disableWhenHidden;

		public bool autoHide;

		public float autoHideDelay;

		public bool useCustomStartAnchoredPosition;

		public Vector3 customStartAnchoredPosition;

		public bool executeLayoutFix;

		public GameObject selectedButton;

		public bool linkedToNotification;

		public bool autoRegister;

		public bool isVisible;

		private bool containsChildUIElements;

		public Anim inAnimations;

		public UnityEvent OnInAnimationsStart;

		public UnityEvent OnInAnimationsFinish;

		public string inAnimationsPresetCategoryName;

		public string inAnimationsPresetName;

		public bool loadInAnimationsPresetAtRuntime;

		public string inAnimationsSoundAtStart;

		public bool customInAnimationsSoundAtStart;

		public string inAnimationsSoundAtFinish;

		public bool customInAnimationsSoundAtFinish;

		public Anim outAnimations;

		public UnityEvent OnOutAnimationsStart;

		public UnityEvent OnOutAnimationsFinish;

		public string outAnimationsPresetCategoryName;

		public string outAnimationsPresetName;

		public bool loadOutAnimationsPresetAtRuntime;

		public string outAnimationsSoundAtStart;

		public bool customOutAnimationsSoundAtStart;

		public string outAnimationsSoundAtFinish;

		public bool customOutAnimationsSoundAtFinish;

		public Loop loopAnimations;

		private bool loopAnimationsArePlaying;

		public string loopAnimationsPresetCategoryName;

		public string loopAnimationsPresetName;

		public bool loadLoopAnimationsPresetAtRuntime;

		private RectTransform m_rectTransform;

		private Canvas m_canvas;

		private GraphicRaycaster m_graphicRaycaster;

		private CanvasGroup m_canvasGroup;

		private Vector3 startPosition;

		private Vector3 startRotation;

		private Vector3 startScale;

		private float startAlpha;

		private float disableTimeBuffer;

		private Coroutine cShow;

		private Coroutine cHide;

		private Coroutine cAutoHide;

		private Coroutine cDisableButtonClicks;

		private bool inTransition;

		private Canvas[] childCanvas;

		private UIButton[] childButtons;

		public UIAnimator.InitialData InitialData => null;

		public RectTransform RectTransform => null;

		public Canvas Canvas => null;

		public GraphicRaycaster GraphicRaycaster => null;

		public CanvasGroup CanvasGroup => null;

		public bool InAnimationsEnabled => false;

		public bool LoopAnimationsEnabled => false;

		public bool OutAnimationsEnabled => false;

		public void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void MoveToCustomStartPosition()
		{
		}

		public void RegisterToUIManager()
		{
		}

		public void UnregisterFromUIManager()
		{
		}

		private void SetupElement()
		{
		}

		private void ResetRectTransform()
		{
		}

		private void LoadRuntimeInAnimationsPreset()
		{
		}

		private void ResetBeforeShow(bool resetPosition, bool resetAlpha)
		{
		}

		public void Show(bool instantAction)
		{
		}

		private IEnumerator iShow(bool instantAction)
		{
			return null;
		}

		private void StartMoveIn()
		{
		}

		private void FinishMoveIn()
		{
		}

		private void StartRotateIn()
		{
		}

		private void FinishRotateIn()
		{
		}

		private void StartScaleIn()
		{
		}

		private void FinishScaleIn()
		{
		}

		private void StartFadeIn()
		{
		}

		private void FinishFadeIn()
		{
		}

		private IEnumerator iSetSelectedGameObject()
		{
			return null;
		}

		private void LoadRuntimeOutAnimationsPreset()
		{
		}

		public void Hide(bool instantAction)
		{
		}

		public void Hide(bool instantAction, bool shouldDisable)
		{
		}

		private IEnumerator iHide(bool instantAction, bool shouldDisable = true)
		{
			return null;
		}

		private void StartMoveOut()
		{
		}

		private void FinishMoveOut()
		{
		}

		private void StartRotateOut()
		{
		}

		private void FinishRotateOut()
		{
		}

		private void StartScaleOut()
		{
		}

		private void FinishScaleOut()
		{
		}

		private void StartFadeOut()
		{
		}

		private void FinishFadeOut()
		{
		}

		public void AutoHide(bool enabled, float delay)
		{
		}

		public void CancelAutoHide()
		{
		}

		private IEnumerator iAutoHide(float delay)
		{
			return null;
		}

		private void InitLoopAnimations(bool forced = false)
		{
		}

		private void PlayLoopAnimations()
		{
		}

		private void StopLoopAnimations()
		{
		}

		private Coroutine InvokeEvent(UnityEvent @event, float delay)
		{
			return null;
		}

		private IEnumerator InvokeEventAfterDelay(UnityEvent @event, float delay)
		{
			return null;
		}

		private void TriggerInAnimationsEvents()
		{
		}

		private void TriggerOutAnimationsEvents()
		{
		}

		private void InAnimationsStart()
		{
		}

		private void InAnimationsFinish()
		{
		}

		private void OutAnimationsStart()
		{
		}

		private void OutAnimationsFinish()
		{
		}

		private void EnableButtonClicks()
		{
		}

		private void DisableButtonClicks(float time)
		{
		}

		private IEnumerator DisableButtonClicksForTime(float delay)
		{
			return null;
		}

		private void ToggleCanvasAndGraphicRaycaster(bool isEnabled)
		{
		}

		private IEnumerator GetOrientation()
		{
			return null;
		}

		private void ExecuteLayoutFix()
		{
		}

		private IEnumerator TriggerShowInTheNextFrame(bool instantAction)
		{
			return null;
		}
	}
}
