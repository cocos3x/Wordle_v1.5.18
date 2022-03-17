using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class TW_APIRequest : MonoBehaviour
{
	private sealed class _003CRequest_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TW_APIRequest _003C_003E4__this;

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
		public _003CRequest_003Ed__12(int _003C_003E1__state)
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

		public static Action<TW_APIRequstResult> _003C_003E9__15_0;

		internal void _003C_002Ector_003Eb__15_0(TW_APIRequstResult _003Cp0_003E)
		{
		}
	}

	private bool IsFirst;

	private string GetParams;

	private string requestUrl;

	private Dictionary<string, string> Headers;

	public event Action<TW_APIRequstResult> ActionComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Send()
	{
	}

	public void AddParam(string name, int value)
	{
	}

	public void AddParam(string name, string value)
	{
	}

	protected void SendCompleteResult(TW_APIRequstResult res)
	{
	}

	protected void SetUrl(string url)
	{
	}

	private IEnumerator Request()
	{
		return null;
	}

	protected abstract void OnResult(string data);

	private void OnTokenLoaded()
	{
	}
}
