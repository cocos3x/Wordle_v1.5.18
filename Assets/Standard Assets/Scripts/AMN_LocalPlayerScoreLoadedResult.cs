public class AMN_LocalPlayerScoreLoadedResult : AMN_Result
{
	private string _LeaderboardId;

	private GC_ScoreTimeSpan _TimeSpan;

	private int _Rank;

	private long _Score;

	private string _Error;

	public string LeaderboardId => "";

	public GC_ScoreTimeSpan TimeSpan => (GC_ScoreTimeSpan)null;

	public int Rank => 0;

	public long Score => 0L;

	public string Error => "";

	public AMN_LocalPlayerScoreLoadedResult(string leaderboardId, GC_ScoreTimeSpan timeSpan, int rank, long score)
	{
	}

	public AMN_LocalPlayerScoreLoadedResult(string leaderboardId, GC_ScoreTimeSpan timeSpan, string error)
	{
	}
}
