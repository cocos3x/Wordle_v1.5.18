using SA.Common.Models;
using System.Collections.Generic;

namespace SA.Fitness
{
	public class SensorRequestResult : Result
	{
		private int id;

		private List<DataSource> dataSources;

		public int Id => 0;

		public List<DataSource> DataSources => null;

		public SensorRequestResult(int id)
		{
		}

		public SensorRequestResult(int id, int resultCode, string message)
		{
		}

		public void AddDataSource(DataSource source)
		{
		}
	}
}
