using UnityEngine;

public class AN_GoogleAnalyticsProxy : MonoBehaviour
{
	private const string CLASS_NAME = "com.androidnative.gms.analytics.AN_AnalyticsProxy";

	private static void CallActivityFunction(string methodName, params object[] args)
	{
	}

	public static void StartAnalyticsTracking()
	{
	}

	public static void SetTrackerID(string trackingID)
	{
	}

	public static void SendView()
	{
	}

	public static void SendView(string appScreen)
	{
	}

	public static void SendEvent(string category, string action, string label, string value)
	{
	}

	public static void SendEvent(string category, string action, string label, string value, string key, string val)
	{
	}

	public static void SendTiming(string category, string intervalInMilliseconds, string name, string label)
	{
	}

	public static void CreateTransaction(string transactionId, string affiliation, string revenue, string tax, string shipping, string currencyCode)
	{
	}

	public static void CreateItem(string transactionId, string name, string sku, string category, string price, string quantity, string currencyCode)
	{
	}

	public static void SetKey(string key, string value)
	{
	}

	public static void ClearKey(string key)
	{
	}

	public static void SetLogLevel(int lvl)
	{
	}

	public static void SetDryRun(string mode)
	{
	}

	public static void EnableAdvertisingIdCollection(string mode)
	{
	}
}
