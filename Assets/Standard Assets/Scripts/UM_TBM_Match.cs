using System.Collections.Generic;
using System.Runtime.InteropServices;

public class UM_TBM_Match
{
	private string _Id;

	private byte[] _Data;

	private bool _IsCurrentPlayerTurn;

	private UM_TBM_MatchStatus _Status;

	private UM_TBM_Participant _CurrentParticipant;

	private List<UM_TBM_Participant> _Participants;

	public string Id => "";

	public byte[] Data => null;

	public bool IsLocalPlayerTurn => false;

	public bool IsEnded => false;

	public UM_TBM_MatchStatus Status => (UM_TBM_MatchStatus)null;

	public UM_TBM_Participant CurrentParticipant => null;

	public List<UM_TBM_Participant> Participants => null;

	public UM_TBM_Participant NextParticipant => null;

	public UM_TBM_Participant Competitor => null;

	public UM_TBM_Participant LocalParticipant => null;

	public UM_TBM_Match(GK_TBM_Match match)
	{
	}

	public UM_TBM_Match(GP_TBM_Match match)
	{
	}

	public void TakeTrun(byte[] matchData, [Optional] UM_TBM_Participant nextParticipant)
	{
	}

	public void QuitInTurn(UM_TBM_Participant nextParticipant)
	{
	}

	public void QuitOutOfTurn()
	{
	}

	public void Finish(byte[] matchData, params UM_TMB_ParticipantResult[] results)
	{
	}

	public void Rematch()
	{
	}

	public void Win(byte[] matchData)
	{
	}

	public void Lose(byte[] matchData)
	{
	}

	public void Tie(byte[] matchData)
	{
	}

	public void Remove()
	{
	}
}
