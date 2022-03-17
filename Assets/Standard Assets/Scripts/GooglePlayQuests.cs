using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class GooglePlayQuests : Singleton<GooglePlayQuests>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GP_QuestResult> _003C_003E9__20_0;

		public static Action<GP_QuestResult> _003C_003E9__20_1;

		public static Action<GP_QuestResult> _003C_003E9__20_2;

		internal void _003C_002Ector_003Eb__20_0(GP_QuestResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_1(GP_QuestResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_2(GP_QuestResult _003Cp0_003E)
		{
		}
	}

	public Action<GP_QuestResult> OnQuestsLoaded;

	public Action<GP_QuestResult> OnQuestsAccepted;

	public Action<GP_QuestResult> OnQuestsCompleted;

	public static GP_QuestsSelect[] SELECT_ALL_QUESTS;

	private Dictionary<string, GP_Quest> _Quests;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void LoadQuests(GP_QuestSortOrder sortOrder)
	{
	}

	public void LoadQuests(GP_QuestSortOrder sortOrder, params GP_QuestsSelect[] selectors)
	{
	}

	public void ShowQuests()
	{
	}

	public void ShowQuests(params GP_QuestsSelect[] selectors)
	{
	}

	public void AcceptQuest(string id)
	{
	}

	public GP_Quest GetQuestById(string id)
	{
		return null;
	}

	public List<GP_Quest> GetQuests()
	{
		return null;
	}

	public List<GP_Quest> GetQuestsByState(GP_QuestState state)
	{
		return null;
	}

	private void OnGPQuestAccepted(string data)
	{
	}

	private void OnGPQuestCompleted(string data)
	{
	}

	private void OnGPQuestUpdated(string data)
	{
	}

	private void OnGPQuestsLoaded(string data)
	{
	}

	private void UpdateQuestInfo(string id, string name, string descr, string icon, string banner, string state, string timeUpdated, string timeAccepted, string timeEnded, string rewardData, string currentProgress, string targetProgress)
	{
	}
}
