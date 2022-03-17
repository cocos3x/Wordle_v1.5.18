namespace SA.IOSNative.StoreKit
{
	public class VerificationResponse
	{
		private int _Status;

		private string _Receipt;

		private string _ProductIdentifier;

		private string _OriginalJSON;

		public int Status => 0;

		public string Receipt => "";

		public string ProductIdentifier => "";

		public string OriginalJSON => "";

		public VerificationResponse(string productIdentifier, string dataArray)
		{
		}
	}
}
