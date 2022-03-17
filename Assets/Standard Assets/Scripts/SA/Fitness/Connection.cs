using SA.Common.Pattern;
using System;
using System.Collections.Generic;

namespace SA.Fitness
{
	public sealed class Connection : Singleton<Connection>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<ConnectionResult> _003C_003E9__22_0;

			internal void _003C_002Ector_003Eb__22_0(ConnectionResult _003Cp0_003E)
			{
			}
		}

		public const string SEPARATOR1 = "|";

		public const string SEPARATOR2 = "~";

		public const string SEPARATOR3 = "$";

		public const string SEPARATOR4 = "%";

		public const string SEPARATOR5 = "^";

		private const int RESULT_OK = -1;

		private List<LoginApi> apis;

		private List<LoginScope> scopes;

		private ConnectionState connectionState;

		private bool shouldManageReconnection;

		public ConnectionState ConnectionState => (ConnectionState)null;

		public event Action<ConnectionResult> OnConnectionFinished
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

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public void AddApi(LoginApi api)
		{
		}

		public void AddScope(LoginScope scope)
		{
		}

		public void Connect()
		{
		}

		private void Disconnect()
		{
		}

		private void ConnectionResultHandler(string data)
		{
		}
	}
}
