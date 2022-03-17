using System.Collections.Generic;
using UnityEngine;

public class SocialPlatfromSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "9.8/21";

	public const string FB_SDK_VERSION_NUMBER = "6.2.2";

	public bool ShowImageSharingSettings;

	public bool SaveImageToGallery;

	public bool showPermitions;

	public bool ShowActions;

	public bool ShowAPIS;

	public List<string> fb_scopes_list;

	public string TWITTER_CONSUMER_KEY;

	public string TWITTER_CONSUMER_SECRET;

	public string TWITTER_ACCESS_TOKEN;

	public string TWITTER_ACCESS_TOKEN_SECRET;

	public bool ShowEditorOauthTestingBlock;

	private const string ISNSettingsAssetName = "SocialSettings";

	private const string ISNSettingsAssetExtension = ".asset";

	public bool TwitterAPI;

	public bool NativeSharingAPI;

	public bool InstagramAPI;

	public bool EnableImageSharing;

	public bool KeepManifestClean;

	private static SocialPlatfromSettings instance;

	public static SocialPlatfromSettings Instance => null;

	public void AddDefaultScopes()
	{
	}
}
