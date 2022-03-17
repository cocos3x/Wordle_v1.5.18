using System;

namespace SA.Fitness
{
	public class ReadDailyTotalRequest
	{
		public class Builder
		{
			private ReadDailyTotalRequest request;

			public Builder SetDataType(DataType dataType)
			{
				return null;
			}

			public ReadDailyTotalRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<ReadDailyTotalResult> _003C_003E9__5_0;

			internal void _003C_002Ector_003Eb__5_0(ReadDailyTotalResult _003Cp0_003E)
			{
			}
		}

		private int id;

		private DataType dataType;

		public int Id => 0;

		public DataType DataType => null;

		public event Action<ReadDailyTotalResult> OnRequestFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private ReadDailyTotalRequest()
		{
		}

		public void DispatchResult(string[] bundle)
		{
		}
	}
}
