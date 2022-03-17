using System.Collections.Generic;

public class GP_RTM_Room
{
	public string id;

	public string creatorId;

	public GP_RTM_RoomStatus status;

	public long creationTimestamp;

	public List<GP_Participant> participants;

	public void AddParticipant(GP_Participant p)
	{
	}

	public GP_Participant GetParticipantById(string id)
	{
		return null;
	}
}
