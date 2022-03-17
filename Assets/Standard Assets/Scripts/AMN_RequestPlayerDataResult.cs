public class AMN_RequestPlayerDataResult : AMN_Result
{
	private string error;

	private GC_Player player;

	public string Error => "";

	public GC_Player Player => null;

	public AMN_RequestPlayerDataResult(bool success)
	{
	}

	public AMN_RequestPlayerDataResult(string err)
	{
	}

	public AMN_RequestPlayerDataResult(GC_Player pl)
	{
	}
}
