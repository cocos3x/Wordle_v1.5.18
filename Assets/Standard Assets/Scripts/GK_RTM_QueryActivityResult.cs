using SA.Common.Models;

public class GK_RTM_QueryActivityResult : Result
{
	private int _Activity;

	public int Activity => 0;

	public GK_RTM_QueryActivityResult(int activity)
	{
	}

	public GK_RTM_QueryActivityResult(string errorData)
	{
	}
}
