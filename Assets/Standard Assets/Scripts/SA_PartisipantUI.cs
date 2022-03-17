using UnityEngine;

public class SA_PartisipantUI : MonoBehaviour
{
	public GameObject avatar;

	public SA_Label id;

	public SA_Label status;

	public SA_Label playerId;

	public SA_Label playerName;

	private Texture defaulttexture;

	private void Awake()
	{
	}

	public void SetParticipant(GP_Participant p)
	{
	}

	public void SetParticipant(UM_RTM_Participant participant)
	{
	}
}
