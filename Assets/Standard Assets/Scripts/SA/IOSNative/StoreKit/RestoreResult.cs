using SA.Common.Models;

namespace SA.IOSNative.StoreKit
{
	public class RestoreResult : Result
	{
		public TransactionErrorCode TransactionErrorCode => (TransactionErrorCode)null;

		public RestoreResult(Error e)
		{
		}

		public RestoreResult()
		{
		}
	}
}
