public class GP_RTM_Result
{
	public GP_GamesStatusCodes _status;

	public string _roomId;

	public GP_GamesStatusCodes status => (GP_GamesStatusCodes)null;

	public string roomId => "";

	public GP_RTM_Result(string r_status, string r_roomId)
	{
	}
}
