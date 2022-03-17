using SA.Common.Models;
using System.Collections.Generic;

public class UM_TBM_MatchesLoadResult : UM_Result
{
	private List<UM_TBM_Match> _Matches;

	private List<UM_TBM_Invite> _Invitations;

	public List<UM_TBM_Match> Matches => null;

	public List<UM_TBM_Invite> Invitations => null;

	public UM_TBM_MatchesLoadResult(Result result)
	{
	}

	public UM_TBM_MatchesLoadResult(GooglePlayResult result)
	{
	}

	public void SetMatches(List<UM_TBM_Match> matches)
	{
	}

	public void SetInvitations(List<UM_TBM_Invite> invitations)
	{
	}
}
