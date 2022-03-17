using System;

public class GK_Score
{
	private int _Rank;

	private long _Score;

	private long _Context;

	private string _PlayerId;

	private string _LeaderboardId;

	private GK_CollectionType _Collection;

	private GK_TimeSpan _TimeSpan;

	public int Rank => 0;

	public long LongScore => 0L;

	public float CurrencyScore => 0f;

	public float DecimalFloat_1 => 0f;

	public float DecimalFloat_2 => 0f;

	public float DecimalFloat_3 => 0f;

	public long Context => 0L;

	public TimeSpan Minutes => (TimeSpan)null;

	public TimeSpan Seconds => (TimeSpan)null;

	public TimeSpan Milliseconds => (TimeSpan)null;

	public string PlayerId => "";

	public GK_Player Player => null;

	public string LeaderboardId => "";

	public GK_Leaderboard Leaderboard => null;

	public GK_CollectionType Collection => (GK_CollectionType)null;

	public GK_TimeSpan TimeSpan => (GK_TimeSpan)null;

	public int rank => 0;

	public long score => 0L;

	public string playerId => "";

	public string leaderboardId => "";

	public GK_TimeSpan timeSpan => (GK_TimeSpan)null;

	public GK_CollectionType collection => (GK_CollectionType)null;

	public GK_Score(long vScore, int vRank, long vContext, GK_TimeSpan vTimeSpan, GK_CollectionType sCollection, string lid, string pid)
	{
	}
}
