using System;

namespace SA.Fitness
{
	public class ReadHistoryRequest
	{
		public class Builder
		{
			private ReadHistoryRequest request;

			public Builder Aggregate(DataType inputDataType, DataType outputDataType)
			{
				return null;
			}

			public Builder Read(DataType dataType)
			{
				return null;
			}

			public Builder BucketByActivitySegment(int minDuration, TimeUnit timeUnit)
			{
				return null;
			}

			public Builder BucketByActivityType(int minDuration, TimeUnit timeUnit)
			{
				return null;
			}

			public Builder BucketBySession(int minDuration, TimeUnit timeUnit)
			{
				return null;
			}

			public Builder BucketByTime(int minDuration, TimeUnit timeUnit)
			{
				return null;
			}

			public Builder SetLimit(int limit)
			{
				return null;
			}

			public Builder SetTimeRange(long startTime, long endTime, TimeUnit unit)
			{
				return null;
			}

			public ReadHistoryRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<ReadHistoryResult> _003C_003E9__14_0;

			internal void _003C_002Ector_003Eb__14_0(ReadHistoryResult _003Cp0_003E)
			{
			}
		}

		private int id;

		private long startTime;

		private long endTime;

		private TimeUnit timeUnit;

		private DataType dataType;

		private DataType aggregateType;

		private int limit;

		private bool isAggregated;

		private int minDuration;

		private TimeUnit bucketUnit;

		private Bucket.Type bucketingType;

		public bool IsAggregated => false;

		public Bucket.Type BucketingType => (Bucket.Type)null;

		public TimeUnit BucketUnit => (TimeUnit)null;

		public int MinDuration => 0;

		public int Limit => 0;

		public DataType AggregateType => null;

		public DataType DataType => null;

		public TimeUnit TimeUnit => (TimeUnit)null;

		public long EndTime => 0L;

		public long StartTime => 0L;

		public int Id => 0;

		public event Action<ReadHistoryResult> OnReadFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private ReadHistoryRequest()
		{
		}

		public void DispatchReadResult(string[] bundle)
		{
		}

		public void DispatchAggregatedResult(string[] bundle)
		{
		}
	}
}
