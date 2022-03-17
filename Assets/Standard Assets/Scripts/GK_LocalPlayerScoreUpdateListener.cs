using System.Collections.Generic;

public class GK_LocalPlayerScoreUpdateListener
{
	private int _RequestId;

	private bool _IsInternal;

	private string _leaderboardId;

	private string _ErrorData;

	private List<GK_Score> Scores;

	public int RequestId => 0;

	public GK_LocalPlayerScoreUpdateListener(int requestId, string leaderboardId, bool isInternal)
	{
	}

	public void ReportScoreUpdate(GK_Score score)
	{
	}

	public void ReportScoreUpdateFail(string errorData)
	{
	}

	private void DispatchUpdate()
	{
	}
}
