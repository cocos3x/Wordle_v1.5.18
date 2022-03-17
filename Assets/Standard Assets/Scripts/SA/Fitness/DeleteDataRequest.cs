using System;
using System.Collections.Generic;

namespace SA.Fitness
{
	public class DeleteDataRequest
	{
		public class Builder
		{
			private DeleteDataRequest request;

			public Builder SetTimeInterval(long startTime, long endTime, TimeUnit unit)
			{
				return null;
			}

			public Builder AddDataType(DataType dataType)
			{
				return null;
			}

			public Builder AddSession(string sessionId)
			{
				return null;
			}

			public Builder DeleteAllSessions()
			{
				return null;
			}

			public DeleteDataRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__9_0;

			internal void _003C_002Ector_003Eb__9_0()
			{
			}
		}

		private int id;

		private long startTime;

		private long endTime;

		private TimeUnit timeUnit;

		private List<DataType> dataTypes;

		private List<string> sessions;

		public int Id => 0;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public TimeUnit TimeUnit => (TimeUnit)null;

		public List<DataType> DataTypes => null;

		public List<string> Sessions => null;

		public event Action OnRequestFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public void DispatchRequestResult()
		{
		}
	}
}
