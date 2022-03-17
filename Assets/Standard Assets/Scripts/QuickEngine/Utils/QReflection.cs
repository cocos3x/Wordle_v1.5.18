using System;
using System.Collections.Generic;
using System.Reflection;

namespace QuickEngine.Utils
{
	public static class QReflection
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Assembly, bool> _003C_003E9__18_0;

			public static Func<Type, string> _003C_003E9__21_0;

			internal bool _003CGetTypeByQualifiedName_003Eb__18_0(Assembly assembly)
			{
				return false;
			}

			internal string _003CGetNameSpaces_003Eb__21_0(Type t)
			{
				return "";
			}
		}

		private sealed class _003C_003Ec__DisplayClass20_0
		{
			public string name;

			public string @namespace;

			internal bool _003CGetType_003Eb__0(Type type)
			{
				return false;
			}
		}

		private static List<string> _003CAssemblyNames_003Ek__BackingField;

		private static Dictionary<string, Type> _003CTypeCache_003Ek__BackingField;

		private static Dictionary<Assembly, List<string>> _003CNameSpaceCache_003Ek__BackingField;

		private static Assembly[] _003CAssemblies_003Ek__BackingField;

		public static List<string> AssemblyNames
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Dictionary<string, Type> TypeCache
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Dictionary<Assembly, List<string>> NameSpaceCache
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Assembly[] Assemblies
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		static QReflection()
		{
		}

		public static void PrintManifestResources()
		{
		}

		public static Type GetTypeByQualifiedName(string name)
		{
			return null;
		}

		public static string GetQualifiedName(string name, string @namespace = "")
		{
			return "";
		}

		public static Type GetType(string name, string @namespace = "")
		{
			return null;
		}

		public static List<string> GetNameSpaces(Assembly assembly)
		{
			return null;
		}

		public static Assembly[] GetAllAssemblies()
		{
			return null;
		}

		public static object GetSingletonInstance(Type type, string singletonName, bool singletonIsProperty, BindingFlags flags = BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		public static object GetSingletonProperty(Type type, string singletonName, string propertyName, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		public static object GetSingletonField(Type type, string singletonName, string fieldName, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		public static bool SetSingletonProperty(Type type, string singletonName, string propertyName, object value, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return false;
		}

		public static bool SetSingletonField(Type type, string singletonName, string fieldName, object value, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return false;
		}
	}
}
