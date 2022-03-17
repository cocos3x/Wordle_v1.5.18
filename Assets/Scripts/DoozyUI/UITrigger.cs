using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

namespace DoozyUI
{
	public class UITrigger : MonoBehaviour
	{
		[Serializable]
		public class TriggerEvent : UnityEvent<string>
		{
		}

		private sealed class _003CSendGameEventsInTheNextFrame_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UITrigger _003C_003E4__this;

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
			public _003CSendGameEventsInTheNextFrame_003Ed__21(int _003C_003E1__state)
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

		public bool triggerOnGameEvent;

		public string gameEvent;

		public bool triggerOnButtonClick;

		public bool triggerOnButtonDoubleClick;

		public bool triggerOnButtonLongClick;

		public string buttonCategory;

		public string buttonName;

		public bool dispatchAll;

		public List<string> gameEvents;

		[SerializeField]
		private TriggerEvent onTriggerEvent;

		public DUI.EventType ListeningFor => (DUI.EventType)null;

		public bool Enabled => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected void RegisterToUIManager()
		{
		}

		protected void UnregisterFromUIManager()
		{
		}

		public void TriggerTheTrigger(string triggerValue)
		{
		}

		private IEnumerator SendGameEventsInTheNextFrame()
		{
			return null;
		}
	}
}
