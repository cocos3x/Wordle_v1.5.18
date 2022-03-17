using System;
using UnityEngine;

[Serializable]
public class GPAchievement
{
	public bool IsOpen;

	[SerializeField]
	private string _id;

	[SerializeField]
	private string _name;

	[SerializeField]
	private string _description;

	[SerializeField]
	private Texture2D _Texture;

	private int _currentSteps;

	private int _totalSteps;

	private GPAchievementType _type;

	private GPAchievementState _state;

	public string id => "";

	public string Id
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string name => "";

	public string Name
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string description => "";

	public string Description
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public int currentSteps => 0;

	public int CurrentSteps => 0;

	public int totalSteps => 0;

	public int TotalSteps => 0;

	public GPAchievementType type => (GPAchievementType)null;

	public GPAchievementType Type => (GPAchievementType)null;

	public GPAchievementState state => (GPAchievementState)null;

	public GPAchievementState State => (GPAchievementState)null;

	public Texture2D Texture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GPAchievement(string id, string name)
	{
	}

	public GPAchievement(string aId, string aName, string aDescr, string aCurentSteps, string aTotalSteps, string aState, string aType)
	{
	}
}
