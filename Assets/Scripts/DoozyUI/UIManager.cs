using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace DoozyUI
{
	public class UIManager : MonoBehaviour
	{
		public enum Orientation
		{
			Landscape,
			Portrait,
			Unknown
		}

		private sealed class _003CExecuteTriggerTheTriggersInTheNextFrame_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIManager _003C_003E4__this;

			public string triggerValue;

			public DUI.EventType triggerType;

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
			public _003CExecuteTriggerTheTriggersInTheNextFrame_003Ed__117(int _003C_003E1__state)
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

		private sealed class _003CGCCollectInTheNextFrame_003Ed__164 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public object obj;

			public GCCollectionMode collectMode;

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
			public _003CGCCollectInTheNextFrame_003Ed__164(int _003C_003E1__state)
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

		private static UIManager _instance;

		public Camera uiCamera;

		public bool debugGameEvents;

		public bool debugUIButtons;

		public bool debugUIElements;

		public bool debugUINotifications;

		public bool debugUICanvases;

		public bool autoDisableButtonClicks;

		private int buttonClicksDisableLevel;

		private int backButtonDisableLevel;

		public bool gamePaused;

		public float currentGameTimeScale;

		public bool isSoundOn;

		public bool isMusicOn;

		public static bool useOrientationManager;

		public Orientation currentOrientation;

		public static bool usesTMPro;

		public bool useTextMeshPro;

		public static bool useSceneLoader;

		private static Dictionary<string, UICanvas> m_canvasDatabase;

		private static Dictionary<string, List<UIElement>> m_elementDatabase;

		private static List<UIElement> showElementsList;

		private static List<UIElement> hideElementsList;

		private static List<UIElement> getUIElementsList;

		private static List<UIElement> getVisibleUIElements;

		private static Dictionary<string, List<UIEffect>> m_effectDatabase;

		private static List<UIEffect> showEffectsList;

		private static List<UIEffect> hideEffectsList;

		private static List<UIEffect> getUIEffectsList;

		private static Dictionary<string, List<UITrigger>> m_gameEventsTriggerDatabase;

		private static Dictionary<string, List<UITrigger>> m_buttonClicksTriggerDatabase;

		private static Dictionary<string, List<UITrigger>> m_buttonDoubleClicksTriggerDatabase;

		private static Dictionary<string, List<UITrigger>> m_buttonLongClicksTriggerDatabase;

		private static List<UITrigger> triggerTheTriggersList;

		private static List<UITrigger> getUITriggersList;

		private SceneLoader m_SceneLoader;

		private static UICanvas masterCanvas;

		private static Soundy m_Soundy;

		private static UINotificationManager m_NotificationManager;

		private OrientationManager m_orientationManager;

		private static int len;

		private static int count;

		public static UIManager Instance => null;

		public static Camera GetUICamera => null;

		public static Transform GetUiContainer => null;

		public Camera UICamera => null;

		public bool ButtonClicksDisabled => false;

		public static bool IsNavigationEnabled => false;

		public bool BackButtonDisabled => false;

		public static Dictionary<string, UICanvas> CanvasDatabase => null;

		public static Dictionary<string, List<UIElement>> ElementDatabase => null;

		public static Dictionary<string, List<UIEffect>> EffectDatabase => null;

		public static Dictionary<string, List<UITrigger>> GameEventsTriggerDatabase => null;

		public static Dictionary<string, List<UITrigger>> ButtonClicksTriggerDatabase => null;

		public static Dictionary<string, List<UITrigger>> ButtonDoubleClicksTriggerDatabase => null;

		public static Dictionary<string, List<UITrigger>> ButtonLongClicksTriggerRegistry => null;

		public SceneLoader SceneLoader => null;

		public static Soundy Soundy => null;

		public static UINotificationManager NotificationManager => null;

		public OrientationManager OrientationManager => null;

		protected UIManager()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGameEvent(string gameEvent)
		{
		}

		public static void SendGameEvent(string gameEvent)
		{
		}

		public static void SendGameEvents(List<string> gameEvents)
		{
		}

		private void OnButtonAction(string buttonName, [Optional] UIButton uiButton, UIButton.ButtonActionType actionType = UIButton.ButtonActionType.OnClick)
		{
		}

		private void OnToggleAction(UIToggle uiToggle, UIToggle.ToggleActionType actionType)
		{
		}

		public static void SendButtonClick(string buttonName, bool addToNavigationHistory = false, [Optional] List<string> showElements, [Optional] List<string> hideElements, [Optional] List<string> gameEvents)
		{
		}

		public void SendButtonAction(UIButton uiButton, UIButton.ButtonActionType actionType)
		{
		}

		public void SendButtonAction(string buttonName, UIButton.ButtonActionType actionType)
		{
		}

		public void SendButtonAction(string buttonName, UIButton.ButtonClickType clickType)
		{
		}

		public void SendToggleAction(UIToggle uiToggle, UIToggle.ToggleActionType actionType)
		{
		}

		private void ListenForBackButton()
		{
		}

		public static void BackButtonEvent()
		{
		}

		public static void DisableBackButton()
		{
		}

		public static void EnableBackButton()
		{
		}

		public static void EnableBackButtonByForce()
		{
		}

		public static void DisableButtonClicks()
		{
		}

		public static void EnableButtonClicks()
		{
		}

		public static void EnableButtonClicksByForce()
		{
		}

		public static UICanvas GetMasterCanvas(bool createMasterCanvasIfNotFound = true)
		{
			return null;
		}

		public static UICanvas GetCanvas(string canvasName, bool createCanvasIfNotFound = false, bool returnMasterCanvasIfTargetCanvasNotFound = true)
		{
			return null;
		}

		public static UICanvas CreateCanvas(string canvasName)
		{
			return null;
		}

		public static List<UIElement> GetUiElements(string elementName, string elementCategory = "Uncategorized")
		{
			return null;
		}

		public static List<UIElement> GetVisibleUIElements()
		{
			return null;
		}

		public static void ShowUiElement(string elementName, string elementCategory = "Uncategorized")
		{
		}

		public static void ShowUiElement(string elementName, bool instantAction)
		{
		}

		public static void ShowUiElement(string elementName, string elementCategory, bool instantAction)
		{
		}

		private void ExecuteShow(string elementName, string elementCategory, bool instantAction)
		{
		}

		public static void HideUiElement(string elementName, string elementCategory)
		{
		}

		public static void HideUiElement(string elementName, bool instantAction = false)
		{
		}

		public static void HideUiElement(string elementName, string elementCategory, bool instantAction)
		{
		}

		private void ExecuteHide(string elementName, string elementCategory, bool instantAction)
		{
		}

		public static List<UIEffect> GetUiEffects(string elementName, string elementCategory = "Uncategorized")
		{
			return null;
		}

		public List<UITrigger> GetUiTriggers(string triggerValue, DUI.EventType triggerType)
		{
			return null;
		}

		public void TriggerTheTriggers(string triggerValue, DUI.EventType triggerType)
		{
		}

		private IEnumerator ExecuteTriggerTheTriggersInTheNextFrame(string triggerValue, DUI.EventType triggerType)
		{
			return null;
		}

		public void RegisterToNotificationQueue(UINotification.NotificationData nData)
		{
		}

		public void UnregisterFromNotificationQueue(UINotification.NotificationData nData)
		{
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public static UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public void ChangeOrientation(Orientation newOrientation)
		{
		}

		public static void TogglePause()
		{
		}

		public static void ApplicationQuit()
		{
		}

		public static void SoundCheck()
		{
		}

		public static void MusicCheck()
		{
		}

		public static void ToggleSound()
		{
		}

		public static void ToggleMusic()
		{
		}

		public static void PlaySound(AudioClip aClip)
		{
		}

		public static void PlaySound(AudioClip aClip, float volume)
		{
		}

		public static void PlaySound(AudioClip aClip, float volume, float pitch)
		{
		}

		public static void PlaySound(string soundName)
		{
		}

		public static void PlaySound(string soundName, float volume)
		{
		}

		public static void PlaySound(string soundName, float volume, float pitch)
		{
		}

		public static void PlaySoundFromResources(string soundName)
		{
		}

		public static void PlaySoundFromResources(string soundName, float volume)
		{
		}

		public static void PlaySoundFromResources(string soundName, float volume, float pitch)
		{
		}

		public static void UpdateCanvasSortingLayerName(GameObject targetObject, string sortingLayerName)
		{
		}

		public static void UpdateRendererSortingLayerName(GameObject targetObject, string sortingLayerName)
		{
		}

		internal static void ShowNotification(string nName, float nLifetime, object nAddToQueue)
		{
		}

		public void GCCollect(object obj, GCCollectionMode collectMode = GCCollectionMode.Default)
		{
		}

		private IEnumerator GCCollectInTheNextFrame(object obj, GCCollectionMode collectMode)
		{
			return null;
		}
	}
}
