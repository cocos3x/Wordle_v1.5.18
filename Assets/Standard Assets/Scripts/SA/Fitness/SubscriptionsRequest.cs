using System;

namespace SA.Fitness
{
	public class SubscriptionsRequest
	{
		public class Builder
		{
			private SubscriptionsRequest request;

			public Builder SetDataType(DataType dataType)
			{
				return null;
			}

			public SubscriptionsRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<SubscriptionsRequestResult> _003C_003E9__5_0;

			internal void _003C_002Ector_003Eb__5_0(SubscriptionsRequestResult _003Cp0_003E)
			{
			}
		}

		private int id;

		private DataType dataType;

		public int Id => 0;

		public DataType DataType => null;

		public event Action<SubscriptionsRequestResult> OnRequestFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private SubscriptionsRequest()
		{
		}

		public void DispatchRequestResult(string[] bundle)
		{
		}
	}
}
