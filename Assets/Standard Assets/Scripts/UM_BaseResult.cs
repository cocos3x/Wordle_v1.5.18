public class UM_BaseResult
{
	protected bool _IsSucceeded;

	public bool IsSucceeded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFailed => false;
}
