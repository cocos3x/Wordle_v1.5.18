using SA.Common.Models;
using System;

namespace SA.Fitness
{
	public class StartSessionRequest
	{
		public class Builder
		{
			private StartSessionRequest request;

			public Builder SetName(string name)
			{
				return null;
			}

			public Builder SetIdentifier(string id)
			{
				return null;
			}

			public Builder SetDescription(string description)
			{
				return null;
			}

			public Builder SetStartTime(long startTime, TimeUnit timeUnit)
			{
				return null;
			}

			public Builder SetActivity(Activity activity)
			{
				return null;
			}

			public StartSessionRequest Build()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<Result> _003C_003E9__10_0;

			internal void _003C_002Ector_003Eb__10_0(Result _003Cp0_003E)
			{
			}
		}

		private int id;

		private string name;

		private string sessionId;

		private string description;

		private long startTime;

		private TimeUnit timeUnit;

		private Activity activity;

		public int Id => 0;

		public string Name => "";

		public string SessionId => "";

		public string Description => "";

		public long StartTime => 0L;

		public TimeUnit TimeUnit => (TimeUnit)null;

		public Activity Activity => null;

		public event Action<Result> OnSessionStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		private StartSessionRequest()
		{
		}

		public void DispatchSessionStartResult(Result result)
		{
		}
	}
}
