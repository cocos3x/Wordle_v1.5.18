using UnityEngine;

public class MultiplayerManagerExample : MonoBehaviour
{
	private void Awake()
	{
	}

	private void HandleActionPlayerAcceptedInvitation(GK_MatchType math, GK_Invite invite)
	{
	}

	private void HandleActionPlayerRequestedMatchWithRecipients(GK_MatchType matchType, string[] recepientIds, GK_Player[] recepients)
	{
	}

	private void OnGUI()
	{
	}

	private void HandleActionPlayerStateChanged(GK_Player player, GK_PlayerConnectionState state, GK_RTM_Match match)
	{
	}

	private void HandleActionMatchStarted(GK_RTM_MatchStartedResult result)
	{
	}

	private void HandleActionDataReceived(GK_Player player, byte[] data)
	{
	}
}
