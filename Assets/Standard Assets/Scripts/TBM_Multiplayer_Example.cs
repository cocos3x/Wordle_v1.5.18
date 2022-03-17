using SA.Common.Models;

public class TBM_Multiplayer_Example : BaseIOSFeaturePreview
{
	private static bool IsInitialized;

	public GK_TBM_Match CurrentMatch => null;

	private void Awake()
	{
	}

	private void HandleActionNearbyPlayerStateUpdated(GK_Player player, bool IsAvaliable)
	{
	}

	private void HandleActionPlayerAcceptedInvitation(GK_MatchType matchType, GK_Invite invite)
	{
	}

	private void HandleActionPlayerRequestedMatchWithRecipients(GK_MatchType matchType, string[] recepientIds, GK_Player[] recepients)
	{
	}

	private void HandleActionMatchStarted(GK_RTM_MatchStartedResult result)
	{
	}

	private void HandleOnPlayerPhotoLoaded(GK_UserPhotoLoadResult result)
	{
	}

	private void OnGUI()
	{
	}

	private void OnAuthFinished(Result res)
	{
	}

	public void ActionMatchesResultLoaded(GK_TBM_LoadMatchesResult res)
	{
	}

	private void ActionMatchDataUpdated(GK_TBM_MatchDataUpdateResult res)
	{
	}

	private void ActionTrunEnded(GK_TBM_EndTrunResult result)
	{
	}

	private void ActionMacthEnded(GK_TBM_MatchEndResult result)
	{
	}

	private void ActionMacthRemoved(GK_TBM_MatchRemovedResult result)
	{
	}

	private void ActionMatchFound(GK_TBM_MatchInitResult result)
	{
	}
}
