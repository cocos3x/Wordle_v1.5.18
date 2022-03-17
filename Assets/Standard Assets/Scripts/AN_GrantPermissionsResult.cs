using SA.Common.Models;
using System.Collections.Generic;

public class AN_GrantPermissionsResult : Result
{
	private Dictionary<AN_Permission, AN_PermissionState> _RequestedPermissionsState;

	public Dictionary<AN_Permission, AN_PermissionState> RequestedPermissionsState => null;

	public AN_GrantPermissionsResult(string[] permissionsList, string[] resultsList)
	{
	}
}
