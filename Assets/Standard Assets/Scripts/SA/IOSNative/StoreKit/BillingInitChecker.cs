using SA.Common.Models;

namespace SA.IOSNative.StoreKit
{
	public class BillingInitChecker
	{
		public delegate void BillingInitListener();

		private BillingInitListener _listener;

		public BillingInitChecker(BillingInitListener listener)
		{
		}

		private void HandleOnStoreKitInitComplete(Result obj)
		{
		}
	}
}
