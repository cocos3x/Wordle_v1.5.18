using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections.Generic;

namespace SA.IOSNative.StoreKit
{
	public class PaymentManager : Singleton<PaymentManager>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			internal void _003C_002Ecctor_003Eb__66_0(Result _003Cp0_003E)
			{
			}

			internal void _003C_002Ecctor_003Eb__66_1()
			{
			}

			internal void _003C_002Ecctor_003Eb__66_2(RestoreResult _003Cp0_003E)
			{
			}

			internal void _003C_002Ecctor_003Eb__66_3(string _003Cp0_003E)
			{
			}

			internal void _003C_002Ecctor_003Eb__66_4(PurchaseResult _003Cp0_003E)
			{
			}

			internal void _003C_002Ecctor_003Eb__66_5(string _003Cp0_003E)
			{
			}

			internal void _003C_002Ecctor_003Eb__66_6(VerificationResponse _003Cp0_003E)
			{
			}
		}

		public const string APPLE_VERIFICATION_SERVER = "https://buy.itunes.apple.com/verifyReceipt";

		public const string SANDBOX_VERIFICATION_SERVER = "https://sandbox.itunes.apple.com/verifyReceipt";

		private bool _IsStoreLoaded;

		private bool _IsWaitingLoadResult;

		private static int _nextId;

		private Dictionary<int, StoreProductView> _productsView;

		private static string lastPurchasedProduct;

		public List<Product> Products => null;

		public bool IsStoreLoaded => false;

		public bool IsInAppPurchasesEnabled => false;

		public bool IsWaitingLoadResult => false;

		private static int NextId => 0;

		public static event Action<Result> OnStoreKitInitComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnRestoreStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<RestoreResult> OnRestoreComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string> OnTransactionStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<PurchaseResult> OnTransactionComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string> OnProductPurchasedExternally
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<VerificationResponse> OnVerificationComplete
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

		public void LoadStore(bool forceLoad = false)
		{
		}

		public void BuyProduct(string productId)
		{
		}

		public void FinishTransaction(string productId)
		{
		}

		public void AddProductId(string productId)
		{
		}

		public void AddProduct(Product product)
		{
		}

		public Product GetProductById(string prodcutId)
		{
			return null;
		}

		public void RestorePurchases()
		{
		}

		public void VerifyLastPurchase(string url)
		{
		}

		public void RegisterProductView(StoreProductView view)
		{
		}

		private void OnStoreKitInitFailed(string data)
		{
		}

		private void onStoreDataReceived(string data)
		{
		}

		private void onProductBought(string array)
		{
		}

		private void onProductPurchasedExternally(string productIdentifier)
		{
		}

		private void onProductStateDeferred(string productIdentifier)
		{
		}

		private void onTransactionFailed(string data)
		{
		}

		private void onVerificationResult(string data)
		{
		}

		public void onRestoreTransactionFailed(string array)
		{
		}

		public void onRestoreTransactionComplete(string array)
		{
		}

		private void OnProductViewLoaded(string viewId)
		{
		}

		private void OnProductViewLoadedFailed(string viewId)
		{
		}

		private void OnProductViewDismissed(string viewId)
		{
		}

		private void FireSuccessInitEvent()
		{
		}

		private void FireRestoreCompleteEvent()
		{
		}

		private void FireProductBoughtEvent(string productIdentifier, string applicationUsername, string receipt, string transactionIdentifier, bool IsRestored)
		{
		}

		private void SendTransactionFailEvent(string productIdentifier, Error error)
		{
		}

		private void EditorFakeInitEvent()
		{
		}
	}
}
