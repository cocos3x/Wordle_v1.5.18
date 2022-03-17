using System;
using System.Collections.Generic;

[Serializable]
public class Stage
{
	public int stage;

	public float time;

	public int scoreRequired;

	public string letterFocus;

	public bool ending;

	public List<Letter> letters;

	public Stage()
	{
	}

	public Stage(int nstage, float ntime, int nscoreRequired, string nletterFocus, bool nending, List<Letter> nletters)
	{
	}
}
