using System.Collections.Generic;

namespace SA.Fitness
{
	public class DataPoint
	{
		private long startTime;

		private long endTime;

		private DataType dataType;

		private Dictionary<string, object> fields;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public DataType DataType => null;

		public Dictionary<string, object> Fields => null;

		public DataPoint(DataType type, string[] bundle, string key)
		{
		}
	}
}
