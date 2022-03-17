using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DoozyUI
{
	public class UIButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler
	{
		[Serializable]
		public class ButtonName
		{
			public string buttonName;
		}

		[Serializable]
		public class ButtonSound
		{
			public string onClickSound;
		}

		public enum ButtonActionType
		{
			OnPointerEnter,
			OnPointerExit,
			OnPointerDown,
			OnPointerUp,
			OnClick,
			OnDoubleClick,
			OnLongClick
		}

		public enum ButtonClickType
		{
			OnClick,
			OnDoubleClick,
			OnLongClick
		}

		public enum SingleClickMode
		{
			Instant,
			Delayed
		}

		private sealed class _003CiDeselectButton_003Ed__169 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UIButton _003C_003E4__this;

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
			public _003CiDeselectButton_003Ed__169(int _003C_003E1__state)
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

		private sealed class _003CiExecuteClickActionsWithDelay_003Ed__177 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CiExecuteClickActionsWithDelay_003Ed__177(int _003C_003E1__state)
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

		private sealed class _003CiExecuteDoubleClickActionsWithDelay_003Ed__181 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CiExecuteDoubleClickActionsWithDelay_003Ed__181(int _003C_003E1__state)
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

		private sealed class _003CiExecuteLongClickActionsWithDelay_003Ed__185 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CiExecuteLongClickActionsWithDelay_003Ed__185(int _003C_003E1__state)
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

		private sealed class _003CiDisableButton_003Ed__192 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

			public float duration;

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
			public _003CiDisableButton_003Ed__192(int _003C_003E1__state)
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

		private sealed class _003CDisableOnPointerEnter_003Ed__196 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CDisableOnPointerEnter_003Ed__196(int _003C_003E1__state)
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

		private sealed class _003CDisableOnPointerExit_003Ed__199 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CDisableOnPointerExit_003Ed__199(int _003C_003E1__state)
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

		private sealed class _003CClickRegistered_003Ed__206 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CClickRegistered_003Ed__206(int _003C_003E1__state)
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

		private sealed class _003CLongClickRegistered_003Ed__213 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CLongClickRegistered_003Ed__213(int _003C_003E1__state)
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

		public ButtonName buttonNameReference;

		public ButtonSound onClickSoundReference;

		public bool useNormalStateAnimations;

		public bool useHighlightedStateAnimations;

		public UIAnimationManager.OnClickAnimations onClickAnimationSettings;

		public UIAnimationManager.ButtonLoopsAnimations normalAnimationSettings;

		public UIAnimationManager.ButtonLoopsAnimations highlightedAnimationSettings;

		public bool backButton;

		public List<string> showElements;

		public List<string> hideElements;

		public List<string> gameEvents;

		public const float BETWEEN_CLICKS_DISABLE_INTERVAL = 0.4f;

		public const float ON_POINTER_ENTER_DISABLE_INTERVAL = 0.4f;

		public const float ON_POINTER_EXIT_DISABLE_INTERVAL = 0.4f;

		public const float DOUBLE_CLICK_REGISTER_INTERVAL = 0.2f;

		public const float LONG_CLICK_REGISTER_INTERVAL = 0.5f;

		public const float DESELECT_BUTTON_DELAY = 0.1f;

		public const string NORMAL_LOOP_ID = "ButtonNormalLoop";

		public const string SELECTED_LOOP_ID = "ButtonSelectedLoop";

		public bool debug;

		public string buttonCategory;

		public string buttonName;

		public bool allowMultipleClicks;

		public bool deselectButtonOnClick;

		public float disableButtonInterval;

		public bool addToNavigationHistory;

		public bool useOnPointerEnter;

		public float onPointerEnterDisableInterval;

		private bool onPointerEnterReady;

		public string onPointerEnterSound;

		public bool customOnPointerEnterSound;

		public UnityEvent OnPointerEnter;

		public string onPointerEnterPunchPresetCategory;

		public string onPointerEnterPunchPresetName;

		public bool loadOnPointerEnterPunchPresetAtRuntime;

		public Punch onPointerEnterPunch;

		public List<string> onPointerEnterGameEvents;

		public NavigationPointerData onPointerEnterNavigation;

		public bool useOnPointerExit;

		public float onPointerExitDisableInterval;

		private bool onPointerExitReady;

		public string onPointerExitSound;

		public bool customOnPointerExitSound;

		public UnityEvent OnPointerExit;

		public string onPointerExitPunchPresetCategory;

		public string onPointerExitPunchPresetName;

		public bool loadOnPointerExitPunchPresetAtRuntime;

		public Punch onPointerExitPunch;

		public List<string> onPointerExitGameEvents;

		public NavigationPointerData onPointerExitNavigation;

		public bool useOnPointerDown;

		public string onPointerDownSound;

		public bool customOnPointerDownSound;

		public UnityEvent OnPointerDown;

		public string onPointerDownPunchPresetCategory;

		public string onPointerDownPunchPresetName;

		public bool loadOnPointerDownPunchPresetAtRuntime;

		public Punch onPointerDownPunch;

		public List<string> onPointerDownGameEvents;

		public NavigationPointerData onPointerDownNavigation;

		public bool useOnPointerUp;

		public string onPointerUpSound;

		public bool customOnPointerUpSound;

		public UnityEvent OnPointerUp;

		public string onPointerUpPunchPresetCategory;

		public string onPointerUpPunchPresetName;

		public bool loadOnPointerUpPunchPresetAtRuntime;

		public Punch onPointerUpPunch;

		public List<string> onPointerUpGameEvents;

		public NavigationPointerData onPointerUpNavigation;

		public bool useOnClickAnimations;

		public bool waitForOnClickAnimation;

		public SingleClickMode singleClickMode;

		public string onClickSound;

		public bool customOnClickSound;

		public UnityEvent OnClick;

		public string onClickPunchPresetCategory;

		public string onClickPunchPresetName;

		public bool loadOnClickPunchPresetAtRuntime;

		public Punch onClickPunch;

		public List<string> onClickGameEvents;

		public NavigationPointerData onClickNavigation;

		public bool useOnDoubleClick;

		public bool waitForOnDoubleClickAnimation;

		public float doubleClickRegisterInterval;

		private float doubleClickTimeoutCounter;

		private bool clickedOnce;

		public string onDoubleClickSound;

		public bool customOnDoubleClickSound;

		public UnityEvent OnDoubleClick;

		public string onDoubleClickPunchPresetCategory;

		public string onDoubleClickPunchPresetName;

		public bool loadOnDoubleClickPunchPresetAtRuntime;

		public Punch onDoubleClickPunch;

		public List<string> onDoubleClickGameEvents;

		public NavigationPointerData onDoubleClickNavigation;

		public bool useOnLongClick;

		public bool waitForOnLongClickAnimation;

		public float longClickRegisterInterval;

		private Coroutine cLongClickRegistered;

		private float longClickTimeoutCounter;

		private bool executedLongClick;

		public string onLongClickSound;

		public bool customOnLongClickSound;

		public UnityEvent OnLongClick;

		public string onLongClickPunchPresetCategory;

		public string onLongClickPunchPresetName;

		public bool loadOnLongClickPunchPresetAtRuntime;

		public Punch onLongClickPunch;

		public List<string> onLongClickGameEvents;

		public NavigationPointerData onLongClickNavigation;

		public string normalLoopPresetCategory;

		public string normalLoopPresetName;

		public bool loadNormalLoopPresetAtRuntime;

		public Loop normalLoop;

		private bool normalLoopIsPlaying;

		public string selectedLoopPresetCategory;

		public string selectedLoopPresetName;

		public bool loadSelectedLoopPresetAtRuntime;

		public Loop selectedLoop;

		private bool selectedLoopIsPlaying;

		private RectTransform m_rectTransform;

		private Button m_button;

		private Vector3 startPosition;

		private Vector3 startRotation;

		private Vector3 startScale;

		private float startAlpha;

		private Coroutine cDisableButton;

		private bool Initialized;

		public bool interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsSelected => false;

		public bool IsBackButton => false;

		public RectTransform RectTransform => null;

		public Button Button => null;

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void StartOnClickAnimations()
		{
		}

		public void StartNormalStateAnimations()
		{
		}

		public void StopNormalStateAnimations()
		{
		}

		public void StartHighlightedStateAnimations()
		{
		}

		public void StopHighlightedSteateAnimations()
		{
		}

		public void ExecuteButtonClick()
		{
		}

		public void SendButtonClickAndGameEvents()
		{
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LoadRuntimePunchPresets()
		{
		}

		private void LoadRuntimeLoopPresets()
		{
		}

		private void AddPunchListeners()
		{
		}

		private void StartNormalLoop(bool forced = false)
		{
		}

		private void StopNormalLoop()
		{
		}

		private void StartSelectedLoop(bool forced = false)
		{
		}

		private void StopSelectedLoop()
		{
		}

		private void ResetRectTransform()
		{
		}

		private void DeselectButton(float delay)
		{
		}

		private IEnumerator iDeselectButton(float delay)
		{
			return null;
		}

		private void ExecuteOnPoinerEnterActions()
		{
		}

		private void ExecuteOnPoinerExitActions()
		{
		}

		private void ExecuteOnPointerDownActions()
		{
		}

		private void ExecuteOnPointerUpActions()
		{
		}

		private void ExecuteOnClickActions()
		{
		}

		public void SendButtonClick()
		{
		}

		public void SendButtonClick(bool playSound, bool animate, bool sendGameEvents, bool forced = false)
		{
		}

		private IEnumerator iExecuteClickActionsWithDelay()
		{
			return null;
		}

		private void ExecuteOnDoubleClickActions()
		{
		}

		public void SendButtonDoubleClick()
		{
		}

		public void SendButtonDoubleClick(bool playSound, bool animate, bool sendGameEvents, bool forced = false)
		{
		}

		private IEnumerator iExecuteDoubleClickActionsWithDelay()
		{
			return null;
		}

		private void ExecuteOnLongClickActions()
		{
		}

		public void SendButtonLongClick()
		{
		}

		public void SendButtonLongClick(bool playSound, bool animate, bool sendGameEvents, bool forced = false)
		{
		}

		private IEnumerator iExecuteLongClickActionsWithDelay()
		{
			return null;
		}

		private void PlaySound(string soundName)
		{
		}

		private void ExecutePunch(Punch punch, bool deselectButton = false, bool forced = false)
		{
		}

		private void SendGameEvents(List<string> gameEvents)
		{
		}

		public void EnableButton()
		{
		}

		public void DisableButton()
		{
		}

		public void DisableButton(float duration)
		{
		}

		private IEnumerator iDisableButton(float duration)
		{
			return null;
		}

		private void DisableButtonAfterClick()
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerEnterHandler_002EOnPointerEnter(PointerEventData eventData)
		{
		}

		public void ExecuteOnPointerEnter(bool forced = false)
		{
		}

		private IEnumerator DisableOnPointerEnter()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerExitHandler_002EOnPointerExit(PointerEventData eventData)
		{
		}

		private void ExecutePointerExit(bool forced = false)
		{
		}

		private IEnumerator DisableOnPointerExit()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		public void ExecutePointerDown(bool forced = false)
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		public void ExecutePointerUp(bool forced = false)
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerClickHandler_002EOnPointerClick(PointerEventData eventData)
		{
		}

		private void RegisterClick()
		{
		}

		private IEnumerator ClickRegistered()
		{
			return null;
		}

		public void ExecuteClick(bool forced = false)
		{
		}

		public void ExecuteDoubleClick(bool forced = false)
		{
		}

		public void ExecuteLongClick(bool forced = false)
		{
		}

		private void RegisterLongClick()
		{
		}

		private void StopLongClickListener()
		{
		}

		private void ResetLongClickListener()
		{
		}

		private IEnumerator LongClickRegistered()
		{
			return null;
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void AddGameEvent(string eventName, ButtonActionType buttonActionType = ButtonActionType.OnClick)
		{
		}

		public void RemoveGameEvent(string eventName, ButtonActionType buttonActionType = ButtonActionType.OnClick)
		{
		}

		public void ResetAnimations()
		{
		}

		public static ButtonActionType GetButtonActionType(ButtonClickType clickType)
		{
			//IL_0003: Expected I4, but got O
			return (ButtonActionType)null;
		}

		public static ButtonClickType GetButtonClickType(ButtonActionType actionType)
		{
			//IL_0003: Expected I4, but got O
			return (ButtonClickType)null;
		}
	}
}
