namespace SA.Fitness
{
	public sealed class LoginApi
	{
		public static LoginApi SENSORS_API;

		public static LoginApi RECORDING_API;

		public static LoginApi SESSIONS_API;

		public static LoginApi HISTORY_API;

		public static LoginApi GOALS_API;

		public static LoginApi CONFIG_API;

		public static LoginApi BLE_API;

		private string value;

		public string Value => "";

		private LoginApi()
		{
		}

		private LoginApi(string api)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
