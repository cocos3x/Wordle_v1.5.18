using UnityEngine;

public class WP8NativeSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "3.4/24";

	private const string WP8NativeSettingsAssetName = "WP8NativeSettings";

	private const string WP8NativeSettingsAssetExtension = ".asset";

	private static WP8NativeSettings instance;

	public static WP8NativeSettings Instance => null;
}
