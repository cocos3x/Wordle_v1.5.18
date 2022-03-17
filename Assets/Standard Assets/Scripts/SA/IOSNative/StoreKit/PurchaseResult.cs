using SA.Common.Models;

namespace SA.IOSNative.StoreKit
{
	public class PurchaseResult : Result
	{
		private string _ProductIdentifier;

		private PurchaseState _State;

		private string _Receipt;

		private string _TransactionIdentifier;

		private string _ApplicationUsername;

		public TransactionErrorCode TransactionErrorCode => (TransactionErrorCode)null;

		public PurchaseState State => (PurchaseState)null;

		public string ProductIdentifier => "";

		public string ApplicationUsername => "";

		public string Receipt => "";

		public string TransactionIdentifier => "";

		public PurchaseResult(string productIdentifier, Error e)
		{
		}

		public PurchaseResult(string productIdentifier, PurchaseState state, string applicationUsername = "", string receipt = "", string transactionIdentifier = "")
		{
		}
	}
}
