using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TW_OAuthAPIRequest : MonoBehaviour
{
	private sealed class _003CRequest_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TW_OAuthAPIRequest _003C_003E4__this;

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
		public _003CRequest_003Ed__13(int _003C_003E1__state)
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

		public static Action<TW_APIRequstResult> _003C_003E9__14_0;

		internal void _003C_002Ector_003Eb__14_0(TW_APIRequstResult _003Cp0_003E)
		{
		}
	}

	private bool IsFirst;

	private string GetParams;

	private string requestUrl;

	private Dictionary<string, string> Headers;

	private SortedDictionary<string, string> requestParams;

	public event Action<TW_APIRequstResult> OnResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static TW_OAuthAPIRequest Create()
	{
		return null;
	}

	public void Send(string url)
	{
	}

	public void AddParam(string name, int value)
	{
	}

	public void AddParam(string name, string value)
	{
	}

	protected void SetUrl(string url)
	{
	}

	private IEnumerator Request()
	{
		return null;
	}
}
