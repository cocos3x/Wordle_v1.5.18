public class AndroidNative
{
	public const string DATA_SPLITTER = "|";

	public const string DATA_EOF = "endofline";

	public const string DATA_SPLITTER2 = "|%|";

	public const string DATA_SPLITTER3 = "`";

	private const string UTILITY_CLASSS = "com.androidnative.features.common.AndroidNativeUtility";

	private const string CLASS_NAME = "com.androidnative.AN_Bridge";

	public static string[] StringToArray(string val)
	{
		return null;
	}

	public static string ArrayToString(string[] array)
	{
		return "";
	}

	public static void TwitterInit(string consumer_key, string consumer_secret)
	{
	}

	public static void AuthificateUser()
	{
	}

	public static void LoadUserData()
	{
	}

	public static void TwitterPost(string status)
	{
	}

	public static void TwitterPostWithImage(string status, string data)
	{
	}

	public static void LogoutFromTwitter()
	{
	}

	public static void InitCameraAPI(string folderName, int maxSize, int mode, int format)
	{
	}

	public static void SaveToGalalry(string ImageData, string name)
	{
	}

	public static void GetVideoAndStartShareIntent(string message, string caption)
	{
	}

	public static void GetVideoFromGallery()
	{
	}

	public static void GetImageFromGallery()
	{
	}

	public static void GetImagesFromGallery()
	{
	}

	public static void GetImageFromCamera(bool bSaveToGallery = false)
	{
	}

	public static void isPackageInstalled(string packagename)
	{
	}

	public static void runPackage(string packagename)
	{
	}

	public static void LoadAndroidId()
	{
	}

	public static void LoadPackagesList()
	{
	}

	public static void InvitePlusFriends()
	{
	}

	public static void LoadNetworkInfo()
	{
	}

	public static void OpenSettingsPage(string action)
	{
	}

	public static void LaunchApplication(string bundle, string data)
	{
	}

	public static void LoadContacts()
	{
	}

	public static void LoadPackageInfo()
	{
	}

	public static void GetInternalStoragePath()
	{
	}

	public static void GetExternalStoragePath()
	{
	}

	public static string GetExternalStoragePublicDirectory(string type)
	{
		return "";
	}

	public static void LoadLocaleInfo()
	{
	}

	public static void StartLockTask()
	{
	}

	public static void StopLockTask()
	{
	}

	public static void OpenAppInStore(string appPackageName)
	{
	}

	public static void GenerateRefreshToken(string redirectUrl, string clientId)
	{
	}

	public static void SaveToCacheStorage(string key, string value)
	{
	}

	public static string GetFromCacheStorage(string key)
	{
		return "";
	}

	public static void RemoveData(string key)
	{
	}

	public static void CopyToClipboard(string text)
	{
	}

	private static void CallUtility(string methodName, params object[] args)
	{
	}

	private static ReturnType CallUtilityForResult<ReturnType>(string methodName, params object[] args)
	{
		return (ReturnType)null;
	}

	private static void CallAndroidNativeBridge(string methodName, params object[] args)
	{
	}

	private static void CallStatic(string className, string methodName, params object[] args)
	{
	}
}
