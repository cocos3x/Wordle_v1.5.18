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
	public class UIToggle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler
	{
		public enum ToggleActionType
		{
			OnPointerEnter,
			OnPointerExit,
			OnClick
		}

		private sealed class _003CiDeselectButton_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UIToggle _003C_003E4__this;

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
			public _003CiDeselectButton_003Ed__88(int _003C_003E1__state)
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

		private sealed class _003CiExecuteClickActionsWithDelay_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIToggle _003C_003E4__this;

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
			public _003CiExecuteClickActionsWithDelay_003Ed__92(int _003C_003E1__state)
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

		private sealed class _003CiDisableButton_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIToggle _003C_003E4__this;

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
			public _003CiDisableButton_003Ed__99(int _003C_003E1__state)
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

		private sealed class _003CDisableOnPointerEnter_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIToggle _003C_003E4__this;

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
			public _003CDisableOnPointerEnter_003Ed__103(int _003C_003E1__state)
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

		private sealed class _003CDisableOnPointerExit_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIToggle _003C_003E4__this;

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
			public _003CDisableOnPointerExit_003Ed__106(int _003C_003E1__state)
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

		private sealed class _003CClickRegistered_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIToggle _003C_003E4__this;

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
			public _003CClickRegistered_003Ed__109(int _003C_003E1__state)
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

		public const float BETWEEN_CLICKS_DISABLE_INTERVAL = 0.4f;

		public const float ON_POINTER_ENTER_DISABLE_INTERVAL = 0.4f;

		public const float ON_POINTER_EXIT_DISABLE_INTERVAL = 0.4f;

		public const float DESELECT_BUTTON_DELAY = 0.1f;

		public bool debug;

		public bool allowMultipleClicks;

		public bool deselectButtonOnClick;

		public float disableButtonInterval;

		public bool useOnPointerEnter;

		public float onPointerEnterDisableInterval;

		private bool onPointerEnterReady;

		public string onPointerEnterSoundToggleOn;

		public string onPointerEnterSoundToggleOff;

		public bool customOnPointerEnterSoundToggleOn;

		public bool customOnPointerEnterSoundToggleOff;

		public UnityEvent OnPointerEnterToggleOn;

		public UnityEvent OnPointerEnterToggleOff;

		public string onPointerEnterPunchPresetCategory;

		public string onPointerEnterPunchPresetName;

		public bool loadOnPointerEnterPunchPresetAtRuntime;

		public Punch onPointerEnterPunch;

		public List<string> onPointerEnterGameEventsToggleOn;

		public List<string> onPointerEnterGameEventsToggleOff;

		public NavigationPointerData onPointerEnterNavigationToggleOn;

		public NavigationPointerData onPointerEnterNavigationToggleOff;

		public bool useOnPointerExit;

		public float onPointerExitDisableInterval;

		private bool onPointerExitReady;

		public string onPointerExitSoundToggleOn;

		public string onPointerExitSoundToggleOff;

		public bool customOnPointerExitSoundToggleOn;

		public bool customOnPointerExitSoundToggleOff;

		public UnityEvent OnPointerExitToggleOn;

		public UnityEvent OnPointerExitToggleOff;

		public string onPointerExitPunchPresetCategory;

		public string onPointerExitPunchPresetName;

		public bool loadOnPointerExitPunchPresetAtRuntime;

		public Punch onPointerExitPunch;

		public List<string> onPointerExitGameEventsToggleOn;

		public List<string> onPointerExitGameEventsToggleOff;

		public NavigationPointerData onPointerExitNavigationToggleOn;

		public NavigationPointerData onPointerExitNavigationToggleOff;

		public bool useOnClick;

		public bool waitForOnClick;

		public string onClickSoundToggleOn;

		public string onClickSoundToggleOff;

		public bool customOnClickSoundToggleOn;

		public bool customOnClickSoundToggleOff;

		public UnityEvent OnClickToggleOn;

		public UnityEvent OnClickToggleOff;

		public string onClickPunchPresetCategory;

		public string onClickPunchPresetName;

		public bool loadOnClickPunchPresetAtRuntime;

		public Punch onClickPunch;

		public List<string> onClickGameEventsToggleOn;

		public List<string> onClickGameEventsToggleOff;

		public NavigationPointerData onClickNavigationToggleOn;

		public NavigationPointerData onClickNavigationToggleOff;

		private RectTransform m_rectTransform;

		private Toggle m_toggle;

		private Vector3 startPosition;

		private Vector3 startRotation;

		private Vector3 startScale;

		private float startAlpha;

		private Coroutine cDisableButton;

		private bool Initialized;

		public bool IsSelected => false;

		public RectTransform RectTransform => null;

		public Toggle Toggle => null;

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

		public bool IsOn
		{
			get
			{
				return false;
			}
			set
			{
			}
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

		private void AddPunchListeners()
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

		private void ExecuteOnClickActions()
		{
		}

		private IEnumerator iExecuteClickActionsWithDelay()
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

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void AddGameEvent(string eventName, bool whenToggleIsOn, ToggleActionType toggleActionType = ToggleActionType.OnClick)
		{
		}

		public void RemoveGameEvent(string eventName, bool whenToggleIsOn, ToggleActionType toggleActionType = ToggleActionType.OnClick)
		{
		}
	}
}
