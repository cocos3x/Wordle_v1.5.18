using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace SA.IOSDeploy
{
	public class ISD_FrameworkHandler : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public string[] dirrExtensions;

			internal bool _003CGetImportedFrameworks_003Eb__0(FileInfo f)
			{
				return false;
			}

			internal bool _003CGetImportedFrameworks_003Eb__1(DirectoryInfo f)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public string[] fileExtensions;

			internal bool _003CGetImportedLibraries_003Eb__0(FileInfo f)
			{
				return false;
			}
		}

		private static List<Framework> _DefaultFrameworks;

		public static List<Framework> AvailableFrameworks => null;

		public static List<Framework> DefaultFrameworks => null;

		public static List<string> GetImportedFrameworks()
		{
			return null;
		}

		public static List<string> GetImportedLibraries()
		{
			return null;
		}

		public static string[] BaseFrameworksArray()
		{
			return null;
		}
	}
}
