using System;

namespace SA.Fitness
{
	public class StopSessionRequest
	{
		public class Builder
		{
			private StopSessionRequest request;

			public Builder SetIdentifier(string sessionId)
			{
				return null;
			}

			public StopSessionRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<StopSessionResult> _003C_003E9__5_0;

			internal void _003C_002Ector_003Eb__5_0(StopSessionResult _003Cp0_003E)
			{
			}
		}

		private int id;

		private string sessionId;

		public int Id => 0;

		public string SessionId => "";

		public event Action<StopSessionResult> OnSessionStopped
		{
			add
			{
			}
			remove
			{
			}
		}

		private StopSessionRequest()
		{
		}

		public void DispatchResult(string[] bundle)
		{
		}
	}
}
