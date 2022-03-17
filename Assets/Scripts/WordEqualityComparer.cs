using System.Collections.Generic;

internal class WordEqualityComparer : IEqualityComparer<PossibleWords>
{
	public static readonly WordEqualityComparer Default;

	public bool Equals(PossibleWords x, PossibleWords y)
	{
		return false;
	}

	public int GetHashCode(PossibleWords obj)
	{
		return 0;
	}
}
