using System;
using System.Collections.Generic;

[Serializable]
public class GPScoreCollection
{
	public Dictionary<int, GPScore> AllTimeScores;

	public Dictionary<int, GPScore> WeekScores;

	public Dictionary<int, GPScore> TodayScores;
}
