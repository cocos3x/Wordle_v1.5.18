using System;

public class FB_AppRequest
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<FB_Result> _003C_003E9__15_0;

		internal void _003C_002Ector_003Eb__15_0(FB_Result _003Cp0_003E)
		{
		}
	}

	public string Id;

	public string ApplicationId;

	public string Message;

	public FB_RequestActionType ActionType;

	public FB_AppRequestState State;

	public string FromId;

	public string FromName;

	public DateTime CreatedTime;

	public string CreatedTimeString;

	public string Data;

	public FB_Object Object;

	public Action<FB_Result> OnDeleteRequestFinished;

	public void SetCreatedTime(string time_string)
	{
	}

	public void Delete()
	{
	}

	private void OnDeleteActionFinish(FB_Result result)
	{
	}
}
