using SA.Common.Pattern;
using System.Collections.Generic;

namespace SA.Fitness
{
	public sealed class Sessions : Singleton<Sessions>
	{
		private Dictionary<int, StartSessionRequest> startSessionRequests;

		private Dictionary<int, StopSessionRequest> stopSessionRequests;

		private Dictionary<int, ReadSessionRequest> readSessionRequests;

		private void Awake()
		{
		}

		public void StartSession(StartSessionRequest request)
		{
		}

		public void StopSession(StopSessionRequest request)
		{
		}

		public void InsertSession()
		{
		}

		public void ReadSession(ReadSessionRequest request)
		{
		}

		private void SessionStartCallbackHandler(string data)
		{
		}

		private void SessionStopCallbackHandler(string data)
		{
		}

		private void SessionReadCallbackHandler(string data)
		{
		}
	}
}
