using System;
using System.Collections.Generic;

namespace SA.Fitness
{
	public class SensorRequest
	{
		public class Builder
		{
			private SensorRequest request;

			public Builder AddDataType(DataType dataType)
			{
				return null;
			}

			public Builder AddDataSourceType(DataSourceType dataSourceType)
			{
				return null;
			}

			public SensorRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<SensorRequestResult> _003C_003E9__6_0;

			internal void _003C_002Ector_003Eb__6_0(SensorRequestResult _003Cp0_003E)
			{
			}
		}

		private int id;

		private List<DataType> dataTypes;

		private List<DataSourceType> dataSourceTypes;

		public int Id => 0;

		public List<DataType> DataTypes => null;

		public List<DataSourceType> DataSourceTypes => null;

		public event Action<SensorRequestResult> OnRequestFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private SensorRequest()
		{
		}

		public void DispatchResult(string[] bundle)
		{
		}
	}
}
