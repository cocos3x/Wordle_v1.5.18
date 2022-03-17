using UnityEngine;

public class UM_RTM_Participant
{
	private string _Id;

	private string _Name;

	private UM_RTM_ParticipantStatus _Status;

	private GP_Participant _gpParticipant;

	private GK_Player _gkPlayer;

	public string Id => "";

	public string Name => "";

	public UM_RTM_ParticipantStatus Status => (UM_RTM_ParticipantStatus)null;

	public Texture2D HighResImage => null;

	public Texture2D SmallIcon => null;

	public UM_RTM_Participant(GP_Participant participant)
	{
	}

	public UM_RTM_Participant(GK_Player participant)
	{
	}
}
