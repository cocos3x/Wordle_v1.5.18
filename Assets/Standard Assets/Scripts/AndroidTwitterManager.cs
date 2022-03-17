using SA.Common.Pattern;
using System;
using UnityEngine;

public class AndroidTwitterManager : Singleton<AndroidTwitterManager>, TwitterManagerInterface
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__54_0;

		public static Action _003C_003E9__54_1;

		public static Action _003C_003E9__54_2;

		public static Action<TWResult> _003C_003E9__54_3;

		public static Action<TWResult> _003C_003E9__54_4;

		public static Action<TWResult> _003C_003E9__54_5;

		public static Action<TWResult> _003C_003E9__54_6;

		internal void _003C_002Ector_003Eb__54_0()
		{
		}

		internal void _003C_002Ector_003Eb__54_1()
		{
		}

		internal void _003C_002Ector_003Eb__54_2()
		{
		}

		internal void _003C_002Ector_003Eb__54_3(TWResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__54_4(TWResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__54_5(TWResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__54_6(TWResult _003Cp0_003E)
		{
		}
	}

	private bool _IsAuthed;

	private bool _IsInited;

	private string _AccessToken;

	private string _AccessTokenSecret;

	private TwitterUserInfo _userInfo;

	public bool IsAuthed => false;

	public bool IsInited => false;

	public TwitterUserInfo userInfo => null;

	public string AccessToken => "";

	public string AccessTokenSecret => "";

	public event Action OnTwitterLoginStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnTwitterLogOut
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnTwitterPostStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<TWResult> OnTwitterInitedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<TWResult> OnAuthCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<TWResult> OnPostingCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<TWResult> OnUserDataRequestCompleteAction
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

	public void Init()
	{
	}

	public void Init(string consumer_key, string consumer_secret)
	{
	}

	public void AuthenticateUser()
	{
	}

	public void LoadUserData()
	{
	}

	public void Post(string status)
	{
	}

	public void Post(string status, Texture2D texture)
	{
	}

	public TwitterPostingTask PostWithAuthCheck(string status)
	{
		return null;
	}

	public TwitterPostingTask PostWithAuthCheck(string status, Texture2D texture)
	{
		return null;
	}

	public void LogOut()
	{
	}

	private void OnInited(string data)
	{
	}

	private void OnAuthSuccess()
	{
	}

	private void OnAuthFailed()
	{
	}

	private void OnPostSuccess()
	{
	}

	private void OnPostFailed()
	{
	}

	private void OnUserDataLoaded(string data)
	{
	}

	private void OnUserDataLoadFailed()
	{
	}

	private void OnAuthInfoReceived(string data)
	{
	}
}
