public class GP_RetrieveAppInviteResult : GooglePlayResult
{
	private GP_AppInvite _AppInvite;

	public GP_AppInvite AppInvite => null;

	public GP_RetrieveAppInviteResult(string code)
	{
	}

	public GP_RetrieveAppInviteResult(GP_AppInvite invite)
	{
	}
}
