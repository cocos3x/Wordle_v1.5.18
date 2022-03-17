using System;
using UnityEngine;

public class FB_LikesRetrieveTask : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<FB_Result, FB_LikesRetrieveTask> _003C_003E9__10_0;

		internal void _003C_002Ector_003Eb__10_0(FB_Result _003Cp0_003E, FB_LikesRetrieveTask _003Cp1_003E)
		{
		}
	}

	private string _userId;

	public string userId => "";

	public event Action<FB_Result, FB_LikesRetrieveTask> ActionComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static FB_LikesRetrieveTask Create()
	{
		return null;
	}

	public void LoadLikes(string userId)
	{
	}

	public void LoadLikes(string userId, string pageId)
	{
	}

	private void OnUserLikesResult(FB_Result result)
	{
	}
}
