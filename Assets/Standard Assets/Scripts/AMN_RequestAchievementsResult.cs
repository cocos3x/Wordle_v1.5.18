using System.Collections.Generic;

public class AMN_RequestAchievementsResult : AMN_Result
{
	private string error;

	private List<GC_Achievement> achievementList;

	public string Error => "";

	public List<GC_Achievement> AchievementList => null;

	public AMN_RequestAchievementsResult(bool success)
	{
	}

	public AMN_RequestAchievementsResult(string err)
	{
	}

	public AMN_RequestAchievementsResult(List<GC_Achievement> list)
	{
	}
}
