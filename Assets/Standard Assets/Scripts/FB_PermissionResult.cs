using System.Collections.Generic;

public class FB_PermissionResult : FB_Result
{
	private Dictionary<string, FB_Permission> _Permissions;

	public Dictionary<string, FB_Permission> Permissions => null;

	public FB_PermissionResult(string RawData, string Error)
	{
	}

	public void SetPermissions(Dictionary<string, FB_Permission> permissions)
	{
	}
}
