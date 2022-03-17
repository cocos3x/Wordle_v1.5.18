using System;
using System.Collections.Generic;

[Serializable]
public class Level
{
	public int level;

	public string type;

	public string title;

	public bool locked;

	public float time;

	public int scoreRequired;

	public int minimumLetters;

	public bool duplicatesAllowed;

	public string letterFocus;

	public bool ending;

	public int stages;

	public bool bonus;

	public int bonusStage1;

	public int bonusStage2;

	public int bonusStage3;

	public List<Letter> letters;

	public List<Stage> StageOverRides;

	public Level()
	{
	}

	public Level(int nLevel, string ntitle, bool nlocked, int nscoreRequired, float ntime, string nletterFocus, bool nending)
	{
	}

	public Level(int nLevel, List<Stage> nStageOverRides)
	{
	}

	public Level(int nLevel, string nType, List<Stage> nStageOverRides, bool nbonus, int nstages, bool nlocked)
	{
	}

	public Level Clone()
	{
		return null;
	}
}
