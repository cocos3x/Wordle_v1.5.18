using SA.Common.Models;
using System.Collections.Generic;
using UnityEngine;

public class PTPGameController : MonoBehaviour
{
	public GameObject pref;

	private DisconnectButton d;

	private ConnectionButton b;

	private ClickManagerExample m;

	public static PTPGameController instance;

	private List<GameObject> spheres;

	private void Awake()
	{
	}

	public void createRedSphere(Vector3 pos)
	{
	}

	public void createGreenSphere(Vector3 pos)
	{
	}

	private void OnAuthFinished(Result res)
	{
	}

	private void HandleActionPlayerStateChanged(GK_Player player, GK_PlayerConnectionState state, GK_RTM_Match macth)
	{
	}

	private void HandleActionMatchStarted(GK_RTM_MatchStartedResult result)
	{
	}

	private void CheckMatchState(GK_RTM_Match macth)
	{
	}

	private void cleanUpScene()
	{
	}
}
