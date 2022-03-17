using System.Collections.Generic;
using UnityEngine;

public class GoogleMobileAdSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "9.10/24";

	public const string PLAY_SERVICE_VERSION = "11.4.2";

	public const string PLAY_SERVICE_VERSION_NUMBER = "11020000";

	public string IOS_InterstisialsUnitId;

	public string IOS_BannersUnitId;

	public string IOS_RewardedVideoAdUnitId;

	public string Android_InterstisialsUnitId;

	public string Android_BannersUnitId;

	public string Android_RewardedVideoAdUnitId;

	public string WP8_InterstisialsUnitId;

	public string WP8_BannersUnitId;

	public string WP8_RewardedVideoAdUnitId;

	public bool IsIOSSettinsOpened;

	public bool IsAndroidSettinsOpened;

	public bool IsWP8SettinsOpened;

	public int EditorFillRate;

	public int EditorFillRateIndex;

	public bool IsEditorTestingEnabled;

	public bool IsTestSettinsOpened;

	public bool ShowActions;

	public bool KeepManifestClean;

	public bool TagForChildDirectedTreatment;

	[SerializeField]
	public List<GADTestDevice> testDevices;

	public bool IsKeywordsOpened;

	public List<string> DefaultKeywords;

	private const string ISNSettingsAssetName = "GoogleMobileAdSettings";

	private const string ISNSettingsAssetExtension = ".asset";

	private static GoogleMobileAdSettings instance;

	public static GoogleMobileAdSettings Instance => null;

	public void AddDevice(GADTestDevice p)
	{
	}

	public void RemoveDevice(GADTestDevice p)
	{
	}
}
