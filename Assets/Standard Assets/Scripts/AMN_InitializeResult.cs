public class AMN_InitializeResult : AMN_Result
{
	private string error;

	public string Error => "";

	public AMN_InitializeResult(bool success)
	{
	}

	public AMN_InitializeResult(string err)
	{
	}
}
