using System.Collections.Generic;
using UnityEngine;

namespace SA.Analytics.Google
{
	public class GA_Settings : ScriptableObject
	{
		public static string VERSION_NUMBER;

		[SerializeField]
		public List<Profile> accounts;

		[SerializeField]
		public List<PlatfromBound> platfromBounds;

		public bool showAdditionalParams;

		public bool showAdvancedParams;

		public bool showCParams;

		public bool showAccounts;

		public bool showPlatfroms;

		public bool showTestingMode;

		public string AppName;

		public string AppVersion;

		public bool UseHTTPS;

		public bool StringEscaping;

		public bool EditorAnalytics;

		public bool IsDisabled;

		public bool IsTestingModeEnabled;

		public int TestingModeAccIndex;

		public bool IsRequetsCachingEnabled;

		public bool IsQueueTimeEnabled;

		public bool AutoLevelTracking;

		public string LevelPrefix;

		public string LevelPostfix;

		public bool AutoAppQuitTracking;

		public bool AutoCampaignTracking;

		public bool AutoExceptionTracking;

		public bool AutoAppResumeTracking;

		public bool SubmitSystemInfoOnFirstLaunch;

		public bool UsePlayerSettingsForAppInfo;

		public bool EnableFirebase;

		public string FirebaseAppId;

		private const string AnalyticsSettingsAssetName = "GA_Settings";

		private const string AnalyticsSettingsAssetExtension = ".asset";

		private static GA_Settings instance;

		public static GA_Settings Instance => null;

		public void UpdateVersionAndName()
		{
		}

		public void AddProfile(Profile p)
		{
		}

		public void RemoveProfile(Profile p)
		{
		}

		public void SetProfileIndexForPlatfrom(RuntimePlatform platfrom, int index, bool IsTesting)
		{
		}

		public int GetProfileIndexForPlatfrom(RuntimePlatform platfrom, bool IsTestMode)
		{
			return 0;
		}

		public string[] GetProfileNames()
		{
			return null;
		}

		public int GetProfileIndex(Profile p)
		{
			return 0;
		}

		public Profile GetCurentProfile()
		{
			return null;
		}

		public Profile GetPrfileForPlatfrom(RuntimePlatform platfrom, bool IsTestMode)
		{
			return null;
		}
	}
}
