using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	public class ActTesterGui : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass63_0
		{
			public string types;

			internal void _003CGetAllSimpleObscuredTypes_003Eb__2(Type t)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Assembly, bool> _003C_003E9__63_0;

			public static Func<Type, bool> _003C_003E9__63_1;

			internal bool _003CGetAllSimpleObscuredTypes_003Eb__63_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetAllSimpleObscuredTypes_003Eb__63_1(Type t)
			{
				return false;
			}
		}

		private const string RED_COLOR = "#FF4040";

		private const string GREEN_COLOR = "#02C85F";

		private const string PREFS_STRING = "name";

		private const string PREFS_INT = "money";

		private const string PREFS_FLOAT = "lifeBar";

		private const string PREFS_BOOL = "gameComplete";

		private const string PREFS_UINT = "demoUint";

		private const string PREFS_LONG = "demoLong";

		private const string PREFS_DOUBLE = "demoDouble";

		private const string PREFS_VECTOR2 = "demoVector2";

		private const string PREFS_VECTOR3 = "demoVector3";

		private const string PREFS_QUATERNION = "demoQuaternion";

		private const string PREFS_RECT = "demoRect";

		private const string PREFS_COLOR = "demoColor";

		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		public string regularString;

		public int regularInt;

		public float regularFloat;

		public Vector3 regularVector3;

		public ObscuredString obscuredString;

		public ObscuredInt obscuredInt;

		public ObscuredFloat obscuredFloat;

		public ObscuredVector3 obscuredVector3;

		public ObscuredBool obscuredBool;

		public ObscuredLong obscuredLong;

		public ObscuredDouble obscuredDouble;

		public ObscuredVector2 obscuredVector2;

		public ObscuredDecimal obscuredDecimal;

		public ObscuredVector2Int obscuredVector2Int;

		public ObscuredVector3Int obscuredVector3Int;

		public string prefsEncryptionKey;

		private readonly string[] tabs;

		private int currentTab;

		private string allSimpleObscuredTypes;

		private string regularPrefs;

		private string obscuredPrefs;

		private int savesLock;

		private bool savesAlterationDetected;

		private bool foreignSavesDetected;

		private bool injectionDetected;

		private bool speedHackDetected;

		private bool timeCheatingDetected;

		private bool obscuredTypeCheatDetected;

		private bool wallHackCheatDetected;

		private readonly StringBuilder logBuilder;

		public void OnSpeedHackDetected()
		{
		}

		public void OnTimeCheatingDetected()
		{
		}

		private void OnTimeCheatingError()
		{
		}

		public void OnInjectionDetected()
		{
		}

		public void OnInjectionDetectedWithCause(string cause)
		{
		}

		public void OnObscuredTypeCheatingDetected()
		{
		}

		public void OnWallHackDetected()
		{
		}

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void RandomizeObscuredVars()
		{
		}

		private void ObscuredStringExample()
		{
		}

		private void ObscuredIntExample()
		{
		}

		private void ObscuredFloatExample()
		{
		}

		private void ObscuredVector3Example()
		{
		}

		private void SavesAlterationDetected()
		{
		}

		private void ForeignSavesDetected()
		{
		}

		private void OnGUI()
		{
		}

		private string GetAllSimpleObscuredTypes()
		{
			return "";
		}

		private string GetAllObscuredPrefsDataTypes()
		{
			return "";
		}

		private void LoadRegularPrefs()
		{
		}

		private void SaveRegularPrefs()
		{
		}

		private void DeleteRegularPrefs()
		{
		}

		private void LoadObscuredPrefs()
		{
		}

		private void SaveObscuredPrefs()
		{
		}

		private void DeleteObscuredPrefs()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
