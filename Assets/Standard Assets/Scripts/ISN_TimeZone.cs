public class ISN_TimeZone
{
	private long _SecondsFromGMT;

	private string _Name;

	private static ISN_TimeZone _LocalTimeZone;

	public string Name => "";

	public long SecondsFromGMT => 0L;

	public static ISN_TimeZone LocalTimeZone => null;

	public ISN_TimeZone()
	{
	}

	public ISN_TimeZone(string data)
	{
	}
}
