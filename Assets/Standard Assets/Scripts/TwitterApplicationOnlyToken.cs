using SA.Common.Pattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TwitterApplicationOnlyToken : Singleton<TwitterApplicationOnlyToken>
{
	private sealed class _003CLoad_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TwitterApplicationOnlyToken _003C_003E4__this;

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
		public _003CLoad_003Ed__12(int _003C_003E1__state)
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

		public static Action _003C_003E9__13_0;

		internal void _003C_002Ector_003Eb__13_0()
		{
		}
	}

	private string _currentToken;

	private const string TWITTER_CONSUMER_KEY = "wEvDyAUr2QabVAsWPDiGwg";

	private const string TWITTER_CONSUMER_SECRET = "igRxZbOrkLQPNLSvibNC3mdNJ5tOlVOPH3HNNKDY0";

	private const string BEARER_TOKEN_KEY = "bearer_token_key";

	private Dictionary<string, string> Headers;

	public string currentToken => "";

	public event Action ActionComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void RetrieveToken()
	{
	}

	private IEnumerator Load()
	{
		return null;
	}
}
