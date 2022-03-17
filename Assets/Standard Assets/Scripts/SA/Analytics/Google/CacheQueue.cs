using SA.Common.Pattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace SA.Analytics.Google
{
	public class CacheQueue : Singleton<CacheQueue>
	{
		private sealed class _003CSend_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CachedRequest request;

			public CacheQueue _003C_003E4__this;

			private WWW _003Cwww_003E5__2;

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
			public _003CSend_003Ed__7(int _003C_003E1__state)
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

		private bool IsWorking;

		private CachedRequest _CurrentRequest;

		private List<CachedRequest> _CurrentQueue;

		private void Awake()
		{
		}

		public void Run()
		{
		}

		private void Stop()
		{
		}

		private void Continue()
		{
		}

		private IEnumerator Send(CachedRequest request)
		{
			return null;
		}
	}
}
