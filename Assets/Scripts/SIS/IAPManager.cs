using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;

namespace SIS
{
	public class IAPManager : MonoBehaviour, IStoreListener
	{
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			public string storeId;

			public Func<StoreID, bool> _003C_003E9__0;

			internal bool _003CGetIAPIdentifier_003Eb__0(StoreID x)
			{
				return false;
			}
		}

		public static bool isDebug;

		public StoreKeys storeKeys;

		public List<IAPGroup> IAPs;

		public List<IAPCurrency> currencies;

		public Dictionary<string, IAPObject> IAPObjects;

		public static IStoreController controller;

		public static IExtensionProvider extensions;

		private static ConfigurationBuilder builder;

		private float initializeTime;

		private bool isRestoringTransactions;

		public bool IsInitialized;

		private static IAPManager instance;

		private WWW request;

		private string[] realIDs;

		private ReceiptValidator validator;

		private PlayfabManager playfabManager;

		public static event Action<string> purchaseSucceededEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string> purchaseFailedEvent
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

		public void Initialize()
		{
		}

		public void OnSceneWasLoaded(Scene scene, LoadSceneMode m)
		{
		}

		public static IAPManager GetInstance()
		{
			return null;
		}

		private void InitIds()
		{
		}

		private void RequestProductData(ConfigurationBuilder builder)
		{
		}

		public void OnInitialized(IStoreController ctrl, IExtensionProvider ext)
		{
		}

		public static void PurchaseProduct(string productId)
		{
		}

		public static void PurchaseProduct(IAPObject obj)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			//IL_0003: Expected I4, but got O
			return (PurchaseProcessingResult)null;
		}

		public void PurchaseVerified(string id)
		{
		}

		public static void RestoreTransactions()
		{
		}

		public static void OnTransactionsRestored(bool success)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		public void OnPurchaseFailed(Product item, PurchaseFailureReason reason)
		{
		}

		public static void OnPurchaseFailed(string error)
		{
		}

		public static List<string> GetIAPUpgrades(string productId)
		{
			return null;
		}

		public static string GetCurrentUpgrade(string productId)
		{
			return "";
		}

		public static string GetNextUpgrade(string productId)
		{
			return "";
		}

		public static string GetIAPIdentifier(string storeId)
		{
			return "";
		}

		public static List<IAPCurrency> GetCurrencies()
		{
			return null;
		}

		public static ProductDefinition[] GetProductDefinitions()
		{
			return null;
		}

		public static string[] GetIAPKeys()
		{
			return null;
		}

		public static string[] GetRealKeys()
		{
			return null;
		}

		public static IAPObject GetIAPObject(string id)
		{
			return null;
		}

		public static string GetIAPObjectGroupName(string id)
		{
			return "";
		}
	}
}
