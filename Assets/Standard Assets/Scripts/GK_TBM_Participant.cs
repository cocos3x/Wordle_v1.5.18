using System;

public class GK_TBM_Participant
{
	private string _PlayerId;

	private string _MatchId;

	private DateTime _TimeoutDate;

	private DateTime _LastTurnDate;

	private GK_TurnBasedParticipantStatus _Status;

	private GK_TurnBasedMatchOutcome _MatchOutcome;

	public string PlayerId => "";

	public GK_Player Player => null;

	public string MatchId => "";

	public DateTime TimeoutDate => (DateTime)null;

	public DateTime LastTurnDate => (DateTime)null;

	public GK_TurnBasedParticipantStatus Status => (GK_TurnBasedParticipantStatus)null;

	public GK_TurnBasedMatchOutcome MatchOutcome => (GK_TurnBasedMatchOutcome)null;

	public GK_TBM_Participant(string playerId, string status, string outcome, string timeoutDate, string lastTurnDate)
	{
	}

	public void SetOutcome(GK_TurnBasedMatchOutcome outcome)
	{
	}

	public void SetMatchId(string matchId)
	{
	}
}
