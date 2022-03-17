using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Analytics.Experimental
{
	public static class AnalyticsEvent
	{
		private static readonly string k_SdkVersion;

		private static readonly string k_ErrorFormat_RequiredParamNotSet;

		private static readonly Dictionary<string, object> m_EventData;

		private static bool _003CdebugMode_003Ek__BackingField;

		public static string sdkVersion => "";

		public static bool debugMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static void OnValidationFailed(string message)
		{
		}

		private static void AddCustomEventData(IDictionary<string, object> eventData)
		{
		}

		private static string SplitCamelCase(string input)
		{
			return "";
		}

		public static string EnumToString(object enumValue)
		{
			return "";
		}

		public static AnalyticsResult Custom(string eventName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AchievementStep(int stepIndex, string achievementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AchievementUnlocked(string achievementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdComplete(bool rewarded, [Optional] string advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdComplete(bool rewarded, AdvertisingNetwork advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdOffer(bool rewarded, [Optional] string advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdOffer(bool rewarded, AdvertisingNetwork advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdSkip(bool rewarded, [Optional] string advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdSkip(bool rewarded, AdvertisingNetwork advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdStart(bool rewarded, [Optional] string advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult AdStart(bool rewarded, AdvertisingNetwork advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ChatMessageSent([Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult CutsceneSkip(string cutsceneName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult CutsceneStart(string cutsceneName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult FirstInteraction([Optional] string actionId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult GameOver([Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult GameOver(int levelIndex, [Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult GameStart([Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult IAPTransaction(string transactionContext, float price, string itemId, [Optional] string itemType, [Optional] string level, [Optional] string transactionId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ItemAcquired(AcquisitionType currencyType, string transactionContext, float amount, string itemId, float balance, [Optional] string itemType, [Optional] string level, [Optional] string transactionId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ItemAcquired(AcquisitionType currencyType, string transactionContext, float amount, string itemId, [Optional] string itemType, [Optional] string level, [Optional] string transactionId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ItemSpent(AcquisitionType currencyType, string transactionContext, float amount, string itemId, float balance, [Optional] string itemType, [Optional] string level, [Optional] string transactionId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ItemSpent(AcquisitionType currencyType, string transactionContext, float amount, string itemId, [Optional] string itemType, [Optional] string level, [Optional] string transactionId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelComplete(string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelComplete(int levelIndex, [Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelFail(string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelFail(int levelIndex, [Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelQuit(string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelQuit(int levelIndex, [Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelSkip(string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelSkip(int levelIndex, [Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelStart(string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelStart(int levelIndex, [Optional] string levelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelUp(string newLevelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult LevelUp(int newLevelIndex, [Optional] string newLevelName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult PostAdAction(bool rewarded, [Optional] string advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult PostAdAction(bool rewarded, AdvertisingNetwork advertisingNetwork, [Optional] string placementId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult PushNotificationClick(string messageId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult PushNotificationEnable([Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ScreenVisit(ScreenName screenName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult ScreenVisit(string screenName, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShare(ShareType shareType, SocialNetwork socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShare(ShareType shareType, string socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShare(string shareType, SocialNetwork socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShare(string shareType, string socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShareAccept(ShareType shareType, SocialNetwork socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShareAccept(ShareType shareType, string socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShareAccept(string shareType, SocialNetwork socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult SocialShareAccept(string shareType, string socialNetwork, [Optional] string senderId, [Optional] string recipientId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult StoreItemClick(StoreType storeType, string itemId, [Optional] string itemName, [Optional] Dictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult StoreOpened(StoreType storeType, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult TutorialComplete([Optional] string tutorialId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult TutorialSkip([Optional] string tutorialId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult TutorialStart([Optional] string tutorialId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult TutorialStep(int stepIndex, [Optional] string tutorialId, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult UserSignup(string authorizationNetwork, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		public static AnalyticsResult UserSignup(AuthorizationNetwork authorizationNetwork, [Optional] IDictionary<string, object> eventData)
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}
	}
}
