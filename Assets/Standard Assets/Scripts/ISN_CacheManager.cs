using UnityEngine;

public class ISN_CacheManager : MonoBehaviour
{
	private const string DATA_SPLITTER = "|";

	private const string ACHIEVEMENT_SPLITTER = "&";

	private const string GA_DATA_CACHE_KEY = "ISN_Cache";

	public static string SavedData
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public static void SaveAchievementRequest(string achievementId, float percent)
	{
	}

	public static void SendAchievementCachedRequest()
	{
	}

	public static void Clear()
	{
	}
}
