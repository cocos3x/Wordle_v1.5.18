using SA.IOSNative.Gestures;
using SA.IOSNative.Models;
using SA.IOSNative.StoreKit;
using System.Collections.Generic;
using UnityEngine;

public class IOSNativeSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "9.11/24";

	public bool EnableGameCenterAPI;

	public bool EnableInAppsAPI;

	public bool EnableCameraAPI;

	public bool EnableSocialSharingAPI;

	public bool EnablePickerAPI;

	public bool EnableMediaPlayerAPI;

	public bool EnableReplayKit;

	public bool EnableCloudKit;

	public bool EnableSoomla;

	public bool EnableGestureAPI;

	public bool EnableForceTouchAPI;

	public bool EnablePushNotificationsAPI;

	public bool EnableContactsAPI;

	public bool EnableAppEventsAPI;

	public bool EnableUserNotificationsAPI;

	public bool EnablePermissionAPI;

	public string AppleId;

	public int ToolbarIndex;

	public bool ExpandMoreActionsMenu;

	public bool ExpandModulesSettings;

	public bool InAppsEditorTesting;

	public bool CheckInternetBeforeLoadRequest;

	public bool PromotedPurchaseSupport;

	public TransactionsHandlingMode TransactionsHandlingMode;

	public List<string> DefaultStoreProductsView;

	public List<Product> InAppProducts;

	public bool ShowStoreKitProducts;

	public List<GK_Leaderboard> Leaderboards;

	public List<GK_AchievementTemplate> Achievements;

	public bool UseGCRequestCaching;

	public bool UsePPForAchievements;

	public bool AutoLoadUsersSmallImages;

	public bool AutoLoadUsersBigImages;

	public bool ShowLeaderboards;

	public bool ShowAchievementsParams;

	public bool AdEditorTesting;

	public int EditorFillRateIndex;

	public int EditorFillRate;

	public int MaxImageLoadSize;

	public float JPegCompressionRate;

	public IOSGalleryLoadImageFormat GalleryImageFormat;

	public int RPK_iPadViewType;

	public string CameraUsageDescription;

	public string PhotoLibraryUsageDescription;

	public string AppleMusicUsageDescription;

	public string ContactsUsageDescription;

	public List<UrlType> UrlTypes;

	public List<UrlType> ApplicationQueriesSchemes;

	public List<ForceTouchMenuItem> ForceTouchMenu;

	public bool DisablePluginLogs;

	public string SoomlaDownloadLink;

	public string SoomlaDocsLink;

	public string SoomlaGameKey;

	public string SoomlaEnvKey;

	public bool OneSignalEnabled;

	public string OneSignalDocsLink;

	private const string ISNSettingsAssetName = "IOSNativeSettings";

	private const string ISNSettingsAssetExtension = ".asset";

	private static IOSNativeSettings instance;

	public static IOSNativeSettings Instance => null;
}
