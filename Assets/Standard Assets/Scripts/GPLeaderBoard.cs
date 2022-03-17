using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GPLeaderBoard
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

	private bool _CurrentPlayerScoreLoaded;

	public GPScoreCollection SocsialCollection;

	public GPScoreCollection GlobalCollection;

	public List<GPScore> CurrentPlayerScore;

	private Dictionary<int, GP_LocalPlayerScoreUpdateListener> _ScoreUpdateListners;

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

	private Dictionary<int, GP_LocalPlayerScoreUpdateListener> ScoreUpdateListners => null;

	public GPLeaderBoard(string lId, string lName)
	{
	}

	public void UpdateName(string lName)
	{
	}

	public List<GPScore> GetScoresList(GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		return null;
	}

	public GPScore GetScoreByPlayerId(string playerId, GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		return null;
	}

	public GPScore GetScore(int rank, GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		return null;
	}

	public GPScore GetCurrentPlayerScore(GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		return null;
	}

	public void CreateScoreListener(int requestId)
	{
	}

	public void ReportLocalPlayerScoreUpdate(GPScore score, int requestId)
	{
	}

	public void ReportLocalPlayerScoreUpdateFail(string errorData, int requestId)
	{
	}

	public void UpdateCurrentPlayerScore(List<GPScore> newScores)
	{
	}

	public void UpdateCurrentPlayerScore(GPScore score)
	{
	}

	public void UpdateScore(GPScore score)
	{
	}
}
