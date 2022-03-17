using System.Collections.Generic;

public class PossibleWords
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public char charLetter;

		internal bool _003C_002Ector_003Eb__0(Letter myLetter)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public char charLetter;

		internal bool _003C_002Ector_003Eb__1(Letter myLetter)
		{
			return false;
		}
	}

	public string letterFocus;

	public string word;

	public string location;

	public List<Letter> letters;

	public List<LetterMatrix> letterMatrix;

	public int score;

	public PossibleWords()
	{
	}

	public PossibleWords(List<LetterMatrix> nLetterMatrix, string nWord, string nLocation, string nLetterFocus)
	{
	}
}
