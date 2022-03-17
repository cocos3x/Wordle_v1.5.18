using UnityEngine;
using UnityEngine.UI;

public class ParticipantPresenter : MonoBehaviour
{
	public Image avatar;

	public Text id;

	public Text status;

	public Text playerId;

	public Text playerName;

	private string _id;

	private Sprite defaulttexture;

	private Sprite icon;

	private void Awake()
	{
	}

	public void SetParticipant(GP_Participant p)
	{
	}
}
