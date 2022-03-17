using System.Collections.Generic;

namespace SA.Fitness
{
	public class Session
	{
		public string Id;

		public long StartTime;

		public long EndTime;

		public string Name;

		public string Description;

		public string AppPackageName;

		public Activity Activity;

		private List<DataSet> dataSets;

		public List<DataSet> DataSets => null;

		public void AddDataSet(DataSet data)
		{
		}
	}
}
