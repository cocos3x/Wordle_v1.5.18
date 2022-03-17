public class FB_Result
{
	private string _RawData;

	private string _Error;

	protected bool _IsSucceeded;

	public bool IsSucceeded => false;

	public bool IsFailed => false;

	public string RawData => "";

	public string Error => "";

	public FB_Result(string RawData, string Error)
	{
	}
}
