using System;

public class UM_TBM_Invite
{
	private string _Id;

	private DateTime _CreationTimestamp;

	private UM_TBM_Participant _Inviter;

	public string Id => "";

	public DateTime CreationTimestamp => (DateTime)null;

	public UM_TBM_Participant Inviter => null;

	public UM_TBM_Invite(GP_Invite invite)
	{
	}

	public UM_TBM_Invite(GK_TBM_Match match)
	{
	}

	public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
	{
		return (DateTime)null;
	}
}
