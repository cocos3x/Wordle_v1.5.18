using SA.Common.Pattern;
using System;

public class GooglePlayConnection : Singleton<GooglePlayConnection>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__39_0(GooglePlayConnectionResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__39_1(GPConnectionState _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__39_2()
		{
		}

		internal void _003C_002Ecctor_003Eb__39_3()
		{
		}
	}

	private bool _IsInitialized;

	private static GPConnectionState _State;

	public bool IsConnected => false;

	public static GPConnectionState state => (GPConnectionState)null;

	public static GPConnectionState State => (GPConnectionState)null;

	public bool isInitialized => false;

	public bool IsInitialized => false;

	public static event Action<GooglePlayConnectionResult> ActionConnectionResultReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GPConnectionState> ActionConnectionStateChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionPlayerConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionPlayerDisconnected
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

	private void Init()
	{
	}

	public void connect()
	{
	}

	public void Connect()
	{
	}

	public void connect(string accountName)
	{
	}

	public void Connect(string accountName)
	{
	}

	public void disconnect()
	{
	}

	public void Disconnect()
	{
	}

	public void SignOut()
	{
	}

	public static bool CheckState()
	{
		return false;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnPlayServiceDisconnected(string data)
	{
	}

	private void OnConnectionResult(string resultCode)
	{
	}

	private void OnStateChange(GPConnectionState connectionState)
	{
	}
}
