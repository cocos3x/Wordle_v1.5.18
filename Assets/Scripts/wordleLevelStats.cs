using System;
using System.Collections.Generic;

public class wordleLevelStats
{
	public int level;

	public DateTime day;

	public int currentStage;

	public int stagesComplete;

	public List<StageStats> stageStats;

	public bool locked;

	public int highScore;

	public int longWordScore;

	public string longWord;

	public int highScoreWordScore;

	public string highScoreWord;

	public float fastestTime;

	public int bonusHints;

	public bool bonusCompleted;

	public wordleLevelStats()
	{
	}

	public wordleLevelStats(int nLevel, bool nlocked)
	{
	}
}
