using SA.AndroidNative.DynamicLinks;
using System.Collections.Generic;
using UnityEngine;

public class AndroidNativeSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "9.10/24";

	public const string GOOGLE_PLAY_SDK_VERSION_NUMBER = "11.4.2";

	public const string GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER = "11400000";

	public bool EnablePlusAPI;

	public bool EnableGamesAPI;

	public bool EnableAppInviteAPI;

	public bool EnableDriveAPI;

	public bool LoadProfileIcons;

	public bool LoadProfileImages;

	public bool LoadQuestsImages;

	public bool LoadQuestsIcons;

	public bool LoadEventsIcons;

	public bool ShowConnectingPopup;

	public bool AutoLoadLocalPlayerScore;

	public bool GoogleFitEnabled;

	public bool EnableATCSupport;

	public bool OneSignalEnabled;

	public string OneSignalAppID;

	public string OneSignalDownloadLink;

	public string OneSignalDocLink;

	public bool UseParsePushNotifications;

	public string ParseAppId;

	public string DotNetKey;

	public string ParseDocLink;

	public string ParseDownloadLink;

	public AndroidDialogTheme DialogTheme;

	public bool EnableSoomla;

	public string SoomlaDownloadLink;

	public string SoomlaDocsLink;

	public string SoomlaGameKey;

	public string SoomlaEnvKey;

	public int Ad_EditorFillRateIndex;

	public int Ad_EditorFillRate;

	public bool Is_Ad_EditorTestingEnabled;

	public int InApps_EditorFillRateIndex;

	public int InApps_EditorFillRate;

	public bool Is_InApps_EditorTestingEnabled;

	public bool Is_Leaderboards_Editor_Notifications_Enabled;

	public bool Is_Achievements_Editor_Notifications_Enabled;

	public string GCM_SenderId;

	public AN_PushNotificationService PushService;

	public bool SaveCameraImageToGallery;

	public bool UseProductNameAsFolderName;

	public string GalleryFolderName;

	public int MaxImageLoadSize;

	public AN_CameraCaptureType CameraCaptureMode;

	public AndroidCameraImageFormat ImageFormat;

	public bool ShowAppPermissions;

	public bool EnableBillingAPI;

	public bool EnablePSAPI;

	public bool EnableSocialAPI;

	public bool EnableCameraAPI;

	public bool ExpandNativeAPI;

	public bool ExpandPSAPI;

	public bool ExpandBillingAPI;

	public bool ExpandSocialAPI;

	public bool ExpandCameraAPI;

	public bool ThirdPartyParams;

	public bool ShowPSSettingsResources;

	public bool ShowActions;

	public bool GCMSettingsActinve;

	public bool LocalNotificationsAPI;

	public bool ImmersiveModeAPI;

	public bool ApplicationInformationAPI;

	public bool ExternalAppsAPI;

	public bool PoupsandPreloadersAPI;

	public bool CheckAppLicenseAPI;

	public bool NetworkStateAPI;

	public bool FirebaseAnalytics;

	public bool FirebaseDynamicLinks;

	public string FirebaseAppId;

	public string FirebaseApiKey;

	public List<LinkEditorTemplate> DynamicLinks;

	public bool InAppPurchasesAPI;

	public bool GooglePlayServicesAPI;

	public bool PlayServicesAdvancedSignInAPI;

	public bool GoogleButtonAPI;

	public bool AnalyticsAPI;

	public bool GoogleCloudSaveAPI;

	public bool PushNotificationsAPI;

	public bool GoogleMobileAdAPI;

	public bool GoogleOAuthAPI;

	public bool GalleryAPI;

	public bool CameraAPI;

	public bool KeepManifestClean;

	public string GooglePlayServiceAppID;

	public int ToolbarSelectedIndex;

	public string base64EncodedPublicKey;

	public bool ShowStoreProducts;

	public List<GoogleProductTemplate> InAppProducts;

	public bool ShowLeaderboards;

	public List<GPLeaderBoard> Leaderboards;

	public bool ShowAchievements;

	public List<GPAchievement> Achievements;

	public bool ShowWhenAppIsForeground;

	public bool EnableVibrationLocal;

	public Texture2D LocalNotificationSmallIcon;

	public Texture2D LocalNotificationLargeIcon;

	public AudioClip LocalNotificationSound;

	public int LocalNotificationWakeLockTimer;

	public bool ReplaceOldNotificationWithNew;

	public bool ShowPushWhenAppIsForeground;

	public bool EnableVibrationPush;

	public Color PushNotificationColor;

	public Texture2D PushNotificationSmallIcon;

	public Texture2D PushNotificationLargeIcon;

	public AudioClip PushNotificationSound;

	public const string ANSettingsAssetName = "AndroidNativeSettings";

	public const string ANSettingsAssetExtension = ".asset";

	private static AndroidNativeSettings instance;

	public static AndroidNativeSettings Instance => null;

	public bool IsBase64KeyWasReplaced => false;
}
