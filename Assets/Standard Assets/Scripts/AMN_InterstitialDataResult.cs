public class AMN_InterstitialDataResult : AMN_Result
{
	private AMN_AdProperties properties;

	private string _error_message;

	public AMN_AdProperties Properties
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Error_message
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public AMN_InterstitialDataResult(string error_message)
	{
	}

	public AMN_InterstitialDataResult(string[] data)
	{
	}
}
