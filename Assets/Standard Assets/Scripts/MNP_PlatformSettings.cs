using UnityEngine;

public class MNP_PlatformSettings : ScriptableObject
{
	private const string ISNSettingsAssetName = "MNPSettings";

	private const string ISNSettingsPath = "Plugins/StansAssets/Support/Settings/Resources/";

	private const string ISNSettingsAssetExtension = ".asset";

	public MNAndroidDialogTheme AndroidDialogTheme;

	public const string VERSION_NUMBER = "5.1/24";

	private static MNP_PlatformSettings instance;

	public static MNP_PlatformSettings Instance => null;
}
