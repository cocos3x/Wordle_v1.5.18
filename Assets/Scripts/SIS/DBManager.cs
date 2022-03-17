using SIS.SimpleJSON;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SIS
{
	public class DBManager : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<IAPCurrency, bool> _003C_003E9__20_0;

			internal bool _003CGetPurchase_003Eb__20_0(IAPCurrency x)
			{
				return false;
			}
		}

		public const string prefsKey = "data";

		public const string idPrefixKey = "SIS_";

		public bool memoryOnly;

		public bool encrypt;

		public string obfuscKey;

		public const string currencyKey = "Currency";

		public const string contentKey = "Content";

		public const string selectedKey = "Selected";

		public const string playerKey = "Player";

		private static DBManager instance;

		private bool keepLegacy;

		private JSONNode gameData;

		public static event Action<string> updatedDataEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Init()
		{
		}

		private void InitDB()
		{
		}

		public static DBManager GetInstance()
		{
			return null;
		}

		public static void SetPurchase(string id, int amount = 1)
		{
		}

		public static int IncreasePurchase(string id, int value)
		{
			return 0;
		}

		public static int GetPurchase(string id)
		{
			return 0;
		}

		public static void RemovePurchase(string id)
		{
		}

		public static bool isPurchased(string id)
		{
			return false;
		}

		public static bool isRequirementMet(IAPRequirement req)
		{
			return false;
		}

		public static void SaveReceipt(string id, string data)
		{
		}

		public static string GetReceipt(string id)
		{
			return "";
		}

		public static bool VerifyVirtualPurchase(IAPObject obj)
		{
			return false;
		}

		public static void SetPlayerData(string id, JSONData data)
		{
		}

		public static int IncreasePlayerData(string id, int value)
		{
			return 0;
		}

		public static JSONNode GetPlayerData(string id)
		{
			return null;
		}

		public static void RemovePlayerData(string id)
		{
		}

		public static void SetFunds(string currency, int value)
		{
		}

		public static int IncreaseFunds(string currency, int value)
		{
			return 0;
		}

		public static int GetFunds(string currency)
		{
			return 0;
		}

		public static List<string> GetAllPurchased(bool withUpgrades = false)
		{
			return null;
		}

		public static Dictionary<string, int> GetCurrencies()
		{
			return null;
		}

		public static Dictionary<string, List<string>> GetAllSelected()
		{
			return null;
		}

		public static bool SetSelected(string id, bool single)
		{
			return false;
		}

		public static void SetDeselected(string id)
		{
		}

		public static bool GetSelected(string id)
		{
			return false;
		}

		public static List<string> GetSelectedGroup(string groupName)
		{
			return null;
		}

		public static string Read()
		{
			return "";
		}

		public static void Save(string id = "")
		{
		}

		public static void Overwrite(string otherData)
		{
		}

		public static string GetJSON(string key)
		{
			return "";
		}

		public static void Clear(string data)
		{
		}

		public static void ClearAll()
		{
		}

		private string Encrypt(string toEncrypt)
		{
			return "";
		}

		private string Decrypt(string toDecrypt)
		{
			return "";
		}

		public static string GetDeviceId()
		{
			return "";
		}
	}
}
