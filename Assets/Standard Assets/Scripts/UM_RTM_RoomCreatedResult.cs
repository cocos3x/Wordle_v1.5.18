public class UM_RTM_RoomCreatedResult
{
	private bool _IsSuccess;

	public bool IsSuccess => false;

	public UM_RTM_RoomCreatedResult(GP_GamesStatusCodes status)
	{
	}

	public UM_RTM_RoomCreatedResult(GK_RTM_MatchStartedResult result)
	{
	}
}
