using SA.Common.Models;

public class UM_Result
{
	protected UM_Error _Error;

	protected bool _IsSucceeded;

	public bool IsSucceeded => false;

	public bool IsFailed => false;

	public UM_Error Error => null;

	public UM_Result()
	{
	}

	public UM_Result(Result result)
	{
	}

	public UM_Result(GooglePlayResult result)
	{
	}

	public UM_Result(AMN_Result result)
	{
	}

	public void SetError(UM_Error e)
	{
	}
}
