using System;
using UnityEngine;

[Serializable]
public class Letter
{
	public string letter;

	public int value;

	public float weight;

	public int maxAllowed;

	public GameObject tile;

	public GameObject miniTile;

	public TileScript tileScript;

	public string special;

	public Letter()
	{
	}

	public Letter(string newLetter)
	{
	}

	public Letter(string newLetter, int newValue, float newWeight, int newMaxAllowed)
	{
	}

	public Letter(string newLetter, int newValue, float newWeight, int newMaxAllowed, string newSpecial)
	{
	}
}
