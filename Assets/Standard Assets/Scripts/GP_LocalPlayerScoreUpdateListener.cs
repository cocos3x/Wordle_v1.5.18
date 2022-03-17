using System.Collections.Generic;

public class GP_LocalPlayerScoreUpdateListener
{
	private int _RequestId;

	private string _leaderboardId;

	private string _ErrorData;

	private List<GPScore> Scores;

	public int RequestId => 0;

	public GP_LocalPlayerScoreUpdateListener(int requestId, string leaderboardId)
	{
	}

	public void ReportScoreUpdate(GPScore score)
	{
	}

	public void ReportScoreUpdateFail(string errorData)
	{
	}

	private void DispatchUpdate()
	{
	}
}
