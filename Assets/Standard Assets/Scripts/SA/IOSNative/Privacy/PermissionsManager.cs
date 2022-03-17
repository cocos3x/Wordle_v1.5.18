using System;
using System.Collections.Generic;

namespace SA.IOSNative.Privacy
{
	public static class PermissionsManager
	{
		private static Dictionary<string, Action<PermissionStatus>> OnResponseDictionary;

		static PermissionsManager()
		{
		}

		public static PermissionStatus CheckPermissions(Permission permission)
		{
			//IL_0003: Expected I4, but got O
			return (PermissionStatus)null;
		}

		public static void RequestPermission(Permission permission, Action<PermissionStatus> callback)
		{
		}

		internal static void PermissionRequestResponse(string permissionData)
		{
		}
	}
}
