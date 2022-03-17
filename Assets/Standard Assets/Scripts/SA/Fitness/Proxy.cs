namespace SA.Fitness
{
	public static class Proxy
	{
		private const string CLASS_NAME = "com.stansassets.fitness.Bridge";

		private static void Call(string methodName, params object[] args)
		{
		}

		private static ReturnType Call<ReturnType>(string methodName, params object[] args)
		{
			return (ReturnType)null;
		}

		public static void Connect(string connectionRequest)
		{
		}

		public static void Disconnect()
		{
		}

		public static void RequestDataSources(string request)
		{
		}

		public static void RegisterSensorListener(string request)
		{
		}

		public static void ListSubscriptions(string request)
		{
		}

		public static void Subscribe(string request)
		{
		}

		public static void Unsubscribe(string request)
		{
		}

		public static void ReadData(string request)
		{
		}

		public static void ReadDailyTotal(string request)
		{
		}

		public static void ReadDailyTotalFromLocalDevice(string request)
		{
		}

		public static void InsertData(string request)
		{
		}

		public static void UpdateData(string request)
		{
		}

		public static void DeleteData(string request)
		{
		}

		public static void StartSession(string request)
		{
		}

		public static void StopSession(string request)
		{
		}

		public static void ReadSession(string request)
		{
		}

		public static void InsertSesison(string request)
		{
		}
	}
}
