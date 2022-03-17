using System;

namespace SA.Fitness
{
	public class SensorListener
	{
		public class Builder
		{
			private SensorListener listener;

			public Builder SetDataType(DataType dataType)
			{
				return null;
			}

			public Builder SetSamplingRate(long amount, TimeUnit unit)
			{
				return null;
			}

			public SensorListener Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<int> _003C_003E9__13_0;

			public static Action<int> _003C_003E9__13_1;

			public static Action<int, DataPoint> _003C_003E9__13_2;

			internal void _003C_002Ector_003Eb__13_0(int _003Cp0_003E)
			{
			}

			internal void _003C_002Ector_003Eb__13_1(int _003Cp0_003E)
			{
			}

			internal void _003C_002Ector_003Eb__13_2(int _003Cp0_003E, DataPoint _003Cp1_003E)
			{
			}
		}

		private int id;

		private DataType dataType;

		private long rateAmount;

		private TimeUnit rateTimeUnit;

		public int Id => 0;

		public DataType DataType => null;

		public long RateAmount => 0L;

		public TimeUnit RateTimeUnit => (TimeUnit)null;

		public event Action<int> OnRegisterSuccess
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<int> OnRegisterFail
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<int, DataPoint> OnDataPointReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		private SensorListener()
		{
		}

		public void DispatchRegisterSuccess()
		{
		}

		public void DispatchRegisterFail()
		{
		}

		public void DispatchDataPointEvent(string[] bundle)
		{
		}
	}
}
