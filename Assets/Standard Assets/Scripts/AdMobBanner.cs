using System.Collections.Generic;
using UnityEngine;

public class AdMobBanner : MonoBehaviour
{
	public GADBannerSize size;

	public TextAnchor anchor;

	private static Dictionary<string, GoogleMobileAdBanner> _registerdBanners;

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
