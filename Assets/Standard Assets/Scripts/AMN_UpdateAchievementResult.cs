public class AMN_UpdateAchievementResult : AMN_Result
{
	private string error;

	private string achievementID;

	public string Error => "";

	public string AchievementID => "";

	public AMN_UpdateAchievementResult(bool success)
	{
	}

	public AMN_UpdateAchievementResult(string id, string err)
	{
	}

	public AMN_UpdateAchievementResult(string id)
	{
	}
}
