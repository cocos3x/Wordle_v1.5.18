using System.Collections.Generic;
using UnityEngine;

public class GC_Leaderboard
{
	public bool IsOpen;

	[SerializeField]
	private string _name;

	[SerializeField]
	private string _id;

	[SerializeField]
	private string _displayText;

	[SerializeField]
	private string _scoreFormat;

	[SerializeField]
	private string _imageUrl;

	[SerializeField]
	private Texture2D _Texture;

	private bool _CurrentPlayerScoreLoaded;

	private List<GC_Score> _CurrentPlayerScores;

	private Dictionary<int, GC_Score> _AllTimeCollection;

	private Dictionary<int, GC_Score> _WeekCollection;

	private Dictionary<int, GC_Score> _TodayCollection;

	public string Identifier
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string Title
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

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

	public string ScoreFormat => "";

	public string ImageUrl => "";

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

	public bool CurrentPlayerScoreLoaded => false;

	public List<GC_Score> GetScoresList(GC_ScoreTimeSpan timeSpan)
	{
		return null;
	}

	public GC_Score GetScoreByPlayerId(string id, GC_ScoreTimeSpan timeSpan)
	{
		return null;
	}

	public GC_Score GetScore(int rank, GC_ScoreTimeSpan timeSpan)
	{
		return null;
	}

	public GC_Score GetCurrentPlayerScore(GC_ScoreTimeSpan timeSpan)
	{
		return null;
	}

	public void UpdateCurrentPlayerScore(GC_Score newScore)
	{
	}

	public void UpdateScore(GC_Score newScore)
	{
	}
}
