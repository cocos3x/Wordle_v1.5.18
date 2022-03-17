using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace SIS
{
	public class UpdateFunds : MonoBehaviour
	{
		private sealed class _003CCountTo_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UpdateFunds _003C_003E4__this;

			public int target;

			private int _003Cstart_003E5__2;

			private float _003Ctimer_003E5__3;

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
			public _003CCountTo_003Ed__8(int _003C_003E1__state)
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

		public Text label;

		public string currency;

		public float duration;

		private int curValue;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateValue()
		{
		}

		private void UpdateValue(string s)
		{
		}

		private IEnumerator CountTo(int target)
		{
			return null;
		}
	}
}
