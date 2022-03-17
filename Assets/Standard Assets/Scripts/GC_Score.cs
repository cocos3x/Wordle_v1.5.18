using System;

public class GC_Score
{
	private string _playerId;

	private string _leaderboardId;

	private int _rank;

	private long _score;

	private GC_ScoreTimeSpan _timeSpan;

	public string PlayerId => "";

	public GC_Player Player => null;

	public string LeaderboardId => "";

	public int Rank => 0;

	public long Score => 0L;

	public float CurrencyScore => 0f;

	public TimeSpan TimeScore => (TimeSpan)null;

	public GC_ScoreTimeSpan TimeSpan => (GC_ScoreTimeSpan)null;

	public GC_Score(string playerId, string leaderboardId, int rank, long score, GC_ScoreTimeSpan timeSpan)
	{
	}
}
