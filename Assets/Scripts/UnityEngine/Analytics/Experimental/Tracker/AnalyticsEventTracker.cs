using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	public class AnalyticsEventTracker : MonoBehaviour
	{
		private sealed class _003CTimedTrigger_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnalyticsEventTracker _003C_003E4__this;

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
			public _003CTimedTrigger_003Ed__12(int _003C_003E1__state)
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

		[SerializeField]
		public EventTrigger m_Trigger;

		[SerializeField]
		private StandardEventPayload m_EventPayload;

		public StandardEventPayload payload => null;

		public void TriggerEvent()
		{
		}

		private AnalyticsResult SendEvent()
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
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

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator TimedTrigger()
		{
			return null;
		}
	}
}
