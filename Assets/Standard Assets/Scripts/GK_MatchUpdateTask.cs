using UnityEngine;

public class GK_MatchUpdateTask : MonoBehaviour
{
	private GK_TBM_Controller _controller;

	private string _matchId;

	public static void Create(string matchId, GK_TBM_Controller controller)
	{
	}

	private void Awake()
	{
	}

	public void LoadMatchInfo(string matchId, GK_TBM_Controller controller)
	{
	}

	private void GameCenter_TBM_ActionMatchInfoLoaded(GK_TBM_LoadMatchResult res)
	{
	}
}
