using System;

public class UM_Score
{
	private UM_Player player;

	private GK_Score _GK_Score;

	private GPScore _GP_Score;

	private GC_Score _GC_Score;

	public bool IsValid => false;

	public int Rank => 0;

	public long LongScore => 0L;

	public float CurrencyScore => 0f;

	public TimeSpan TimeScore => (TimeSpan)null;

	public string LeaderboardId => "";

	public UM_TimeSpan TimeSpan => (UM_TimeSpan)null;

	public UM_CollectionType Collection => (UM_CollectionType)null;

	public UM_Player Player => null;

	public GK_Score GameCenterScore => null;

	public GPScore GooglePlayScore => null;

	public GC_Score GameCircleScore => null;

	public UM_Score(GK_Score gkScore, GPScore gpScore, GC_Score gcScore)
	{
	}
}
