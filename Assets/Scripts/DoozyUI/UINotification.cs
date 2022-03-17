using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DoozyUI
{
	public class UINotification : MonoBehaviour
	{
		[Serializable]
		public class NotificationData
		{
			public string targetCanvasName;

			public string prefabName;

			public GameObject prefab;

			public float lifetime;

			public bool addToNotificationQueue;

			public string title;

			public string message;

			public Sprite icon;

			public string[] buttonNames;

			public string[] buttonTexts;

			public UnityAction hideCallback;

			public UnityAction[] buttonCallback;
		}

		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public UINotification _003C_003E4__this;

			public NotificationData ndata;
		}

		private sealed class _003C_003Ec__DisplayClass34_1
		{
			public float onClickDelay;

			public _003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowNotification_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass34_2
		{
			public int index;

			public _003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals2;

			internal void _003CShowNotification_003Eb__1()
			{
			}
		}

		private sealed class _003CShowNotification_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UINotification _003C_003E4__this;

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
			public _003CShowNotification_003Ed__35(int _003C_003E1__state)
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

		private sealed class _003CHideNotification_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UINotification _003C_003E4__this;

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
			public _003CHideNotification_003Ed__36(int _003C_003E1__state)
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

		private sealed class _003CDestroyAfterTime_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UINotification _003C_003E4__this;

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
			public _003CDestroyAfterTime_003Ed__44(int _003C_003E1__state)
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

		public const float DEFAULT_LIFETIME = 3f;

		public const bool DEFAULT_ADD_TO_NOTIFICATION_QUEUE = true;

		public const string DEFAULT_TITLE = null;

		public const string DEFAULT_MESSAGE = null;

		public const Sprite DEFAULT_ICON = null;

		public const string[] DEFAULT_BUTTON_NAMES = null;

		public const string[] DEFAULT_BUTTON_TEXT = null;

		public bool listenForBackButton;

		public string targetCanvasName;

		public bool customTargetCanvasName;

		public UIElement notificationContainer;

		public UIElement overlay;

		public GameObject title;

		public GameObject message;

		public Image icon;

		public UIButton[] buttons;

		public Button closeButton;

		public UIElement[] specialElements;

		public UIEffect[] effects;

		public NotificationData data;

		private RectTransform m_rectTransform;

		private string notificationName;

		private bool closeOnClick;

		private int len;

		public RectTransform RectTransform => null;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void ShowNotification(NotificationData ndata, UICanvas targetCanvas)
		{
		}

		private IEnumerator ShowNotification()
		{
			return null;
		}

		private IEnumerator HideNotification(float delay)
		{
			return null;
		}

		public void HideNotification(bool hideAndDestroy = true)
		{
		}

		private void RegisterToUIManager()
		{
		}

		private void UnregisterFromUIManager()
		{
		}

		private void UnregisterFromNotificationQueue()
		{
		}

		private float GetInAnimationsTimeAndDelay()
		{
			return 0f;
		}

		private float GetOutAnimationsTimeAndDelay()
		{
			return 0f;
		}

		private void BackButtonEvent()
		{
		}

		private IEnumerator DestroyAfterTime(float delay)
		{
			return null;
		}
	}
}
