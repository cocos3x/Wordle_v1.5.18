using System.Collections.Generic;
using UnityEngine;

public class AndroidAdMobBanner : MonoBehaviour
{
	public string BannersUnityId;

	public GADBannerSize size;

	public TextAnchor anchor;

	private static Dictionary<string, GoogleMobileAdBanner> _refisterdBanners;

	public static Dictionary<string, GoogleMobileAdBanner> registerdBanners => null;

	public string sceneBannerId => "";

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowBanner()
	{
	}

	public void HideBanner()
	{
	}
}
