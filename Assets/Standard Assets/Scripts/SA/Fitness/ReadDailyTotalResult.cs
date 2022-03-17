using SA.Common.Models;

namespace SA.Fitness
{
	public class ReadDailyTotalResult : Result
	{
		private int id;

		private DataSet dataSet;

		public int Id => 0;

		public DataSet DataSet => null;

		public ReadDailyTotalResult(int id)
		{
		}

		public ReadDailyTotalResult(int id, int resultCode, string message)
		{
		}

		public void SetData(DataSet dataSet)
		{
		}
	}
}
