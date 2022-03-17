public class UM_LocaleInfo
{
	private ISN_Locale _IOSLocale;

	private AN_Locale _ANLocale;

	public string CountryCode => "";

	public string DisplayCountry => "";

	public string LanguageCode => "";

	public string DisplayLanguage => "";

	private UM_LocaleInfo()
	{
	}

	public UM_LocaleInfo(ISN_Locale locale)
	{
	}

	public UM_LocaleInfo(AN_Locale locale)
	{
	}
}
