using System;

namespace SA.Fitness
{
	public class ReadSessionRequest
	{
		public class Builder
		{
			private ReadSessionRequest request;

			public Builder SetTimeinterval(long startTime, long endTime, TimeUnit timeUnit)
			{
				return null;
			}

			public Builder SetIdentifier(string sessionId)
			{
				return null;
			}

			public Builder SetDataTypeToRead(DataType dataType)
			{
				return null;
			}

			public ReadSessionRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<ReadSessionResult> _003C_003E9__9_0;

			internal void _003C_002Ector_003Eb__9_0(ReadSessionResult _003Cp0_003E)
			{
			}
		}

		private long startTime;

		private long endTime;

		private TimeUnit timeUnit;

		private string sessionId;

		private DataType dataType;

		private int id;

		public int Id => 0;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public TimeUnit TimeUnit => (TimeUnit)null;

		public string SessionId => "";

		public DataType DataType => null;

		public event Action<ReadSessionResult> OnSessionReadFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private ReadSessionRequest()
		{
		}

		public void DispatchResult(string[] bundle)
		{
		}
	}
}
