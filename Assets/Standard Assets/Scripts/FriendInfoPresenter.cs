using UnityEngine;
using UnityEngine.UI;

public class FriendInfoPresenter : MonoBehaviour
{
	[SerializeField]
	private Text Id;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Toggle HasIcon;

	[SerializeField]
	private Toggle HasImage;

	[SerializeField]
	private Image Avatar;

	private string playerId;

	private string playerName;

	private bool hasIcon;

	private bool hasImage;

	private Sprite avatar;

	private void Start()
	{
	}

	public void SetInfo(string id, string name, bool icon, bool image, Texture2D srcImage)
	{
	}

	private void UpdateUi()
	{
	}
}
