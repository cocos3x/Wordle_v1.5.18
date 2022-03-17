using SA.Common.Pattern;
using System.Collections.Generic;

namespace SA.Fitness
{
	public sealed class History : Singleton<History>
	{
		private Dictionary<int, ReadDailyTotalRequest> dailyTotalRequests;

		private Dictionary<int, ReadHistoryRequest> readRequests;

		private void Awake()
		{
		}

		public void ReadData(ReadHistoryRequest request)
		{
		}

		public void ReadDailyTotal(ReadDailyTotalRequest request)
		{
		}

		public void ReadDailyTotalFromLocalDevice(ReadDailyTotalRequest request)
		{
		}

		public void InsertData()
		{
		}

		public void UpdateData()
		{
		}

		public void DeleteData(DeleteDataRequest request)
		{
		}

		private void DispatchReadDailyTotalRequest(string data)
		{
		}

		private void DispatchReadHistoryRequest(string data)
		{
		}
	}
}
