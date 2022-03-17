using UnityEngine;

public class GP_Quest
{
	public string Id;

	public string Name;

	public string Description;

	public string IconImageUrl;

	public string BannerImageUrl;

	public GP_QuestState state;

	public long LastUpdatedTimestamp;

	public long AcceptedTimestamp;

	public long EndTimestamp;

	public byte[] RewardData;

	public long CurrentProgress;

	public long TargetProgress;

	private Texture2D _icon;

	private Texture2D _banner;

	public Texture2D icon => null;

	public Texture2D banner => null;

	public void LoadIcon()
	{
	}

	public void LoadBanner()
	{
	}

	private void OnBannerLoaded(Texture2D tex)
	{
	}

	private void OnIconLoaded(Texture2D tex)
	{
	}
}
