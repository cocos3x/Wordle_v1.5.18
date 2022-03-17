using UnityEngine;
using UnityEngine.UI;

public class LeaderboardInfoPresenter : MonoBehaviour
{
	[SerializeField]
	private Text Rank;

	[SerializeField]
	private Text Score;

	[SerializeField]
	private Text PlayerId;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Image Avatar;

	private string id;

	private string playerName;

	private string rank;

	private string score;

	private Sprite avatar;

	private Sprite old;

	private void Start()
	{
	}

	public void SetInfo(string rank, string score, string id, string name, Texture2D icon)
	{
	}

	public void Disable()
	{
	}

	private void UpdateUi()
	{
	}
}
