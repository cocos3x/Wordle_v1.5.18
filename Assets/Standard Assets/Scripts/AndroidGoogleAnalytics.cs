using SA.Common.Pattern;

public class AndroidGoogleAnalytics : Singleton<AndroidGoogleAnalytics>
{
	private bool IsStarted;

	private void Awake()
	{
	}

	public void StartTracking()
	{
	}

	public void SetTrackerID(string trackingID)
	{
	}

	public void SendView(string appScreen)
	{
	}

	public void SendView()
	{
	}

	public void SendEvent(string category, string action, string label)
	{
	}

	public void SendEvent(string category, string action, string label, long value)
	{
	}

	public void SendEvent(string category, string action, string label, string key, string val)
	{
	}

	public void SendEvent(string category, string action, string label, long value, string key, string val)
	{
	}

	public void SendTiming(string category, long intervalInMilliseconds)
	{
	}

	public void SendTiming(string category, long intervalInMilliseconds, string name)
	{
	}

	public void SendTiming(string category, long intervalInMilliseconds, string name, string label)
	{
	}

	public void CreateTransaction(string transactionId, string affiliation, float revenue, float tax, float shipping, string currencyCode)
	{
	}

	public void CreateItem(string transactionId, string name, string sku, string category, float price, int quantity, string currencyCode)
	{
	}

	public void SetKey(string key, string value)
	{
	}

	public void ClearKey(string key)
	{
	}

	public void SetLogLevel(GPLogLevel logLevel)
	{
	}

	public void SetDryRun(bool mode)
	{
	}

	public void EnableAdvertisingIdCollection(bool mode)
	{
	}
}
