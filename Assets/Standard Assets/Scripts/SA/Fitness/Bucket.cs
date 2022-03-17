using System.Collections.Generic;

namespace SA.Fitness
{
	public sealed class Bucket
	{
		public enum Type
		{
			ActivitySegment = 4,
			ActivityType = 3,
			Session = 2,
			Time = 1
		}

		private List<DataSet> dataSets;

		private Type type;

		private long startTime;

		private long endTime;

		public Type Bucketing => (Type)null;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public List<DataSet> DataSets => null;

		public Bucket(Type type)
		{
		}

		public void SetTimeRange(long startTime, long endTime)
		{
		}

		public void AddDataSet(DataSet dataSet)
		{
		}
	}
}
