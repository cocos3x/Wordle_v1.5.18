using System.Collections.Generic;
using UnityEngine;

public class LetterMatrix
{
	public string letter;

	public string value;

	public string special;

	public List<int> neighbours;

	public Transform tile;

	public bool selected;

	public LetterMatrix()
	{
	}

	public LetterMatrix(string newLetter)
	{
	}

	public LetterMatrix(string newLetter, List<int> newNeighbours)
	{
	}

	public LetterMatrix(string newLetter, List<int> newNeighbours, Transform newTile)
	{
	}

	public LetterMatrix(string newLetter, List<int> newNeighbours, Transform newTile, string newValue, string newSpecial)
	{
	}
}
