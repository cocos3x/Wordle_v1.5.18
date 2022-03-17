public class ISN_Device
{
	private static ISN_Device _CurrentDevice;

	private string _Name;

	private string _SystemName;

	private string _Model;

	private string _LocalizedModel;

	private string _SystemVersion;

	private int _MajorSystemVersion;

	private string _PreferredLanguage_ISO639_1;

	private ISN_InterfaceIdiom _InterfaceIdiom;

	private ISN_DeviceGUID _GUID;

	public string Name => "";

	public string SystemName => "";

	public string Model => "";

	public string LocalizedModel => "";

	public string SystemVersion => "";

	public int MajorSystemVersion => 0;

	public ISN_InterfaceIdiom InterfaceIdiom => (ISN_InterfaceIdiom)null;

	public ISN_DeviceGUID GUID => null;

	public string PreferredLanguageCode => "";

	public string PreferredLanguage_ISO639_1 => "";

	public string AdvertisingIdentifier => "";

	public bool AdvertisingTrackingEnabled => false;

	public static ISN_Device CurrentDevice => null;

	public ISN_Device()
	{
	}

	public ISN_Device(string deviceData)
	{
	}
}
