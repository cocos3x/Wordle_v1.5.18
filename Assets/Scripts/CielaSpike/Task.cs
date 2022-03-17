using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CielaSpike
{
	public class Task : IEnumerator
	{
		private enum RunningState
		{
			Init,
			RunningAsync,
			PendingYield,
			ToBackground,
			RunningSync,
			CancellationRequested,
			Done,
			Error
		}

		private sealed class _003CWait_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Task _003C_003E4__this;

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
			public _003CWait_003Ed__19(int _003C_003E1__state)
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

		private object _003CCurrent_003Ek__BackingField;

		private readonly IEnumerator _innerRoutine;

		private RunningState _state;

		private RunningState _previousState;

		private object _pendingCurrent;

		private Exception _003CException_003Ek__BackingField;

		public object Current
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public TaskState State => (TaskState)null;

		public Exception Exception
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public Task(IEnumerator routine)
		{
		}

		public void Cancel()
		{
		}

		public IEnumerator Wait()
		{
			return null;
		}

		private void GotoState(RunningState state)
		{
		}

		private void SetPendingCurrentObject(object current)
		{
		}

		private bool OnMoveNext()
		{
			return false;
		}

		private void MoveNextAsync()
		{
		}

		private void BackgroundRunner(object state)
		{
		}

		private void MoveNextUnity()
		{
		}
	}
}
