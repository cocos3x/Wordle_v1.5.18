using SA.Common.Pattern;
using System;

public class PermissionsManager : Singleton<PermissionsManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__13_0(AN_GrantPermissionsResult _003Cp0_003E)
		{
		}
	}

	private const string PM_CLASS_NAME = "com.androidnative.features.permissions.PermissionsManager";

	public static event Action<AN_GrantPermissionsResult> ActionPermissionsRequestCompleted
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

	public static bool IsPermissionGranted(AN_Permission permission)
	{
		return false;
	}

	public static bool IsPermissionGranted(string permission)
	{
		return false;
	}

	public static bool ShouldShowRequestPermission(AN_Permission permission)
	{
		return false;
	}

	public void RequestPermissions(params AN_Permission[] permissions)
	{
	}

	public void RequestPermissions(params string[] permissions)
	{
	}

	private void OnPermissionsResult(string data)
	{
	}

	public static AN_Permission GetPermissionByName(string fullName)
	{
		//IL_0003: Expected I4, but got O
		return (AN_Permission)null;
	}
}
