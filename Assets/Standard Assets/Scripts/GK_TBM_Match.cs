using System;
using System.Collections.Generic;

public class GK_TBM_Match
{
	public string Id;

	public string Message;

	public GK_TBM_Participant CurrentParticipant;

	public DateTime CreationTimestamp;

	public byte[] Data;

	public GK_TurnBasedMatchStatus Status;

	public List<GK_TBM_Participant> Participants;

	public string UTF8StringData => "";

	public GK_TBM_Participant LocalParticipant => null;

	public void SetData(string val)
	{
	}

	public GK_TBM_Participant GetParticipantByPlayerId(string playerId)
	{
		return null;
	}
}
