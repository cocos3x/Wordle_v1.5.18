using System.Collections.Generic;

public class AMN_PlayerData : AMN_Singleton<AMN_PlayerData>
{
	private const string ENTITLEMENTS = "ENTITLEMENTS";

	public const string DATA_SPLITTER = "|";

	private void Awake()
	{
	}

	public static void AddNewSKU(string SKU)
	{
	}

	public static List<string> GetAvailableSKUs()
	{
		return null;
	}
}
