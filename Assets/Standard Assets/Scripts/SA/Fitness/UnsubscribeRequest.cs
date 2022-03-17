using SA.Common.Models;
using System;

namespace SA.Fitness
{
	public class UnsubscribeRequest
	{
		public class Builder
		{
			private UnsubscribeRequest request;

			public Builder SetDataType(DataType dataType)
			{
				return null;
			}

			public UnsubscribeRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<Result> _003C_003E9__5_0;

			internal void _003C_002Ector_003Eb__5_0(Result _003Cp0_003E)
			{
			}
		}

		private int id;

		private DataType dataType;

		public int Id => 0;

		public DataType DataType => null;

		public event Action<Result> OnUnsubscribeFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private UnsubscribeRequest()
		{
		}

		public void DispatchUnsubscribeResult(Result result)
		{
		}
	}
}
