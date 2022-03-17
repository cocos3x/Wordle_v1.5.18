using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace DoozyUI
{
	public class UINotificationManager : MonoBehaviour
	{
		[Serializable]
		public class NotificationItem
		{
			public string notificationName;

			public UINotification notificationPrefab;
		}

		public List<NotificationItem> NotificationItems;

		private List<UINotification.NotificationData> m_notificationQueue;

		private int count;

		public List<UINotification.NotificationData> NotificationQueue => null;

		public UINotification GetUINotification(string notificationName)
		{
			return null;
		}

		public void RegisterToNotificationQueue(UINotification.NotificationData nData)
		{
		}

		public void UnregisterFromNotificationQueue(UINotification.NotificationData nData)
		{
		}

		private void ShowNextNotificationInQueue()
		{
		}

		private UINotification SetupNotification(UINotification.NotificationData nData)
		{
			return null;
		}

		private UINotification LoadNotification(UINotification.NotificationData nData)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string _message, Sprite _icon, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, Sprite _icon, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(string _prefabName, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}

		public UINotification ShowNotification(GameObject _prefab, float _lifetime, bool _addToNotificationQueue, string _title, string[] _buttonNames, string[] _buttonTexts, [Optional] UnityAction[] _buttonCallback, [Optional] UnityAction _hideCallback)
		{
			return null;
		}
	}
}
