using SA.Common.Pattern;
using System;

public class GP_AppInvitesController : Singleton<GP_AppInvitesController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__14_0(GP_SendAppInvitesResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__14_1(GP_RetrieveAppInviteResult _003Cp0_003E)
		{
		}
	}

	public static event Action<GP_SendAppInvitesResult> ActionAppInvitesSent
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_RetrieveAppInviteResult> ActionAppInviteRetrieved
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void StartInvitationDialog(GP_AppInviteBuilder builder)
	{
	}

	public void GetInvitation(bool autoLaunchDeepLink = false)
	{
	}

	private void OnInvitationDialogComplete(string InvitationIds)
	{
	}

	private void OnInvitationDialogFailed(string erroCode)
	{
	}

	private void OnInvitationLoadFailed(string erroCode)
	{
	}

	private void OnInvitationLoaded(string data)
	{
	}
}
