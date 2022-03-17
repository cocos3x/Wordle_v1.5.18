public class GP_ParticipantResult
{
	private int _Placing;

	private GP_TBM_ParticipantResult _Result;

	private int _VersionCode;

	private string _ParticipantId;

	public int Placing => 0;

	public GP_TBM_ParticipantResult Result => (GP_TBM_ParticipantResult)null;

	public int VersionCode => 0;

	public string ParticipantId => "";

	public GP_ParticipantResult(string participantId, GP_TBM_ParticipantResult result, int placing)
	{
	}

	public GP_ParticipantResult(int versionCode, string participantId, GP_TBM_ParticipantResult result, int placing)
	{
	}

	public GP_ParticipantResult(string[] data, int index)
	{
	}
}
