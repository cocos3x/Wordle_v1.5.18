using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace SA.Common.Models
{
	public class PrefabAsyncLoader : MonoBehaviour
	{
		private sealed class _003CLoad_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PrefabAsyncLoader _003C_003E4__this;

			private ResourceRequest _003Crequest_003E5__2;

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
			public _003CLoad_003Ed__7(int _003C_003E1__state)
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

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<GameObject> _003C_003E9__8_0;

			internal void _003C_002Ector_003Eb__8_0(GameObject _003Cp0_003E)
			{
			}
		}

		private string PrefabPath;

		public event Action<GameObject> ObjectLoadedAction
		{
			add
			{
			}
			remove
			{
			}
		}

		public static PrefabAsyncLoader Create()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void LoadAsync(string name)
		{
		}

		private IEnumerator Load()
		{
			return null;
		}
	}
}
