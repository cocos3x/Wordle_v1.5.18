using System;

[Serializable]
public class GPScore
{
	private int _rank;

	private long _score;

	private string _playerId;

	private string _leaderboardId;

	private string _tag;

	private GPCollectionType _collection;

	private GPBoardTimeSpan _timeSpan;

	public int rank => 0;

	public int Rank => 0;

	public long score => 0L;

	public long LongScore => 0L;

	public float CurrencyScore => 0f;

	public TimeSpan TimeScore => (TimeSpan)null;

	public string Tag => "";

	public string playerId => "";

	public string PlayerId => "";

	public GooglePlayerTemplate Player => null;

	public string leaderboardId => "";

	public string LeaderboardId => "";

	public GPCollectionType collection => (GPCollectionType)null;

	public GPCollectionType Collection => (GPCollectionType)null;

	public GPBoardTimeSpan timeSpan => (GPBoardTimeSpan)null;

	public GPBoardTimeSpan TimeSpan => (GPBoardTimeSpan)null;

	public GPScore(long vScore, int vRank, GPBoardTimeSpan vTimeSpan, GPCollectionType sCollection, string lid, string pid, string tag)
	{
	}

	public void UpdateScore(long vScore)
	{
	}
}
