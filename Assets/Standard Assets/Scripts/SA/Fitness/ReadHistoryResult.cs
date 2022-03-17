using SA.Common.Models;
using System.Collections.Generic;

namespace SA.Fitness
{
	public class ReadHistoryResult : Result
	{
		private List<Bucket> buckets;

		private List<DataSet> dataSets;

		private int id;

		private bool isAggregated;

		public int Id => 0;

		public bool IsAggregated => false;

		public List<Bucket> Buckets => null;

		public List<DataSet> DataSets => null;

		public ReadHistoryResult(int id, bool isAggregated)
		{
		}

		public ReadHistoryResult(int id, int resultCode, string message)
		{
		}

		public void AddDataSet(DataSet dataSet)
		{
		}

		public void AddBucket(Bucket bucket)
		{
		}
	}
}
