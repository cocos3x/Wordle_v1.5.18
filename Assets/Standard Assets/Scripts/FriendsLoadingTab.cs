using UnityEngine;
using UnityEngine.UI;

public class FriendsLoadingTab : FeatureTab
{
	public Image avatar;

	private Sprite logo;

	public Text playerLabel;

	public Button connectButton;

	public Text connectButtonLabel;

	private Sprite defaulttexture;

	public Button[] ConnectionDependedntButtons;

	public FriendInfoPresenter[] rows;

	private void Awake()
	{
	}

	public void ConncetButtonPress()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void LoadFriendsList()
	{
	}

	private void OnFriendListLoaded(GooglePlayResult result)
	{
	}

	private void OnPlayerDisconnected()
	{
	}

	private void OnPlayerConnected()
	{
	}

	private void OnConnectionResult(GooglePlayConnectionResult result)
	{
	}
}
