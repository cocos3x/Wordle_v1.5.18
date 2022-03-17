using System;
using UnityEngine;

public class AN_DeepLinkingManager : MonoBehaviour
{
	public static event Action<string> OnDeepLinkReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void GetLaunchDeepLinkId()
	{
	}

	private void DeepLinkReceived(string linkId)
	{
	}
}
