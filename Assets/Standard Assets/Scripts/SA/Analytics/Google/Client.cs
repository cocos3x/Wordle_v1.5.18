using System.Text;
using UnityEngine;

namespace SA.Analytics.Google
{
	public class Client
	{
		private const string PROTOCOL_VERSION = "v=1";

		private const string HTTP_URL = "http://www.google-analytics.com/collect";

		private const string HTTPS_URL = "https://ssl.google-analytics.com/collect";

		public string TrackingID;

		public string ClientID;

		public string AppName;

		public string AppVersion;

		private string DefaultHitData;

		private StringBuilder builder;

		private HitType currentHitType;

		private string DataSendUrl;

		private string lastScreenName;

		private string userId;

		public string AnalyticsHost => "";

		public string LastScreenName => "";

		public string UserId => "";

		public Client(string anonymousClientID)
		{
		}

		public void GenerateHeaders(string trackingId)
		{
		}

		public void SetAnonymizeIP()
		{
		}

		public void SetQueueTime(int time)
		{
		}

		public void StartSession()
		{
		}

		public void EndSession()
		{
		}

		public void IPOverride(string ip)
		{
		}

		public void UserAgentOverride(string userAgent)
		{
		}

		public void SetDocumentReferrer(string url)
		{
		}

		public void SetCampaignName(string name)
		{
		}

		public void SetCampaignSource(string source)
		{
		}

		public void SetCampaignMedium(string medium)
		{
		}

		public void AddCampaignKeyword(string keyword)
		{
		}

		public void SetCampaignContent(string content)
		{
		}

		public void SetCampaignID(string id)
		{
		}

		public void SetGoogleAdWordsID(string id)
		{
		}

		public void SetGoogleDisplayAdsID(string id)
		{
		}

		public void SetUserId(string id)
		{
		}

		public void SetScreenResolution(int width, int height)
		{
		}

		public void SetViewportSize(int width, int height)
		{
		}

		public void SetDocumentEncoding(string encoding)
		{
		}

		public void SetScreenColors(string colorsBuffer)
		{
		}

		public void SetUserLanguage(string lang)
		{
		}

		public void SetJavaEnablede(bool isEnabled)
		{
		}

		public void SetFlashVersion(string version)
		{
		}

		public void SetHitType(HitType hit)
		{
		}

		public void SetNoInteractionHit()
		{
		}

		public void SetDocumentlocationURL(string url)
		{
		}

		public void SetDocumentHostName(string host)
		{
		}

		public void SetDocumentPath(string path)
		{
		}

		public void SetDocumentTitle(string title)
		{
		}

		public void SetScreenName(string name)
		{
		}

		public void SetLinkID(string id)
		{
		}

		public void SetApplicationName(string name)
		{
		}

		public void SetApplicationVersion(string version)
		{
		}

		public void SetApplicationInstallerID(string identifier)
		{
		}

		public void SetEventCategory(string ec)
		{
		}

		public void SetEventAction(string ea)
		{
		}

		public void SetEventLabel(string el)
		{
		}

		public void SetEventValue(int val)
		{
		}

		public void SetTransactionID(string ti)
		{
		}

		public void SetTransactionAffiliation(string ta)
		{
		}

		public void SetTransactionRevenue(float tr)
		{
		}

		public void SetTransactionShipping(float ts)
		{
		}

		public void SetTransactionTax(float tt)
		{
		}

		public void SetTransactionCouponCode(string tcc)
		{
		}

		public void SetItemName(string name)
		{
		}

		public void SetItemPrice(float ip)
		{
		}

		public void SetItemQuantity(int iq)
		{
		}

		public void SetItemCode(string ic)
		{
		}

		public void SetItemCategory(string iv)
		{
		}

		public void SetCurrencyCode(string cu)
		{
		}

		public void SetProductSKU(int productIndex, string sku)
		{
		}

		public void SetSetProductName(int productIndex, string name)
		{
		}

		public void SetProductBrand(int productIndex, string brand)
		{
		}

		public void SetProductCategory(int productIndex, string category)
		{
		}

		public void SetProductVariant(int productIndex, string variant)
		{
		}

		public void SetProductPrice(int productIndex, float prise)
		{
		}

		public void SetProductQuantity(int productIndex, int quantit)
		{
		}

		public void SetProductCouponCode(int productIndex, string couponCode)
		{
		}

		public void SetProductPosition(int productIndex, int pos)
		{
		}

		public void SetProductCustomDimension(int productIndex, int index, string val)
		{
		}

		public void SetProductCustomMetric(int productIndex, int index, int metric)
		{
		}

		public void SetProductAction(string pa)
		{
		}

		public void SetProductActionList(string val)
		{
		}

		public void SetCheckoutStep(int cos)
		{
		}

		public void SetCheckoutStepOption(string col)
		{
		}

		public void SetSocialNetwork(string sn)
		{
		}

		public void SetSocialAction(string action)
		{
		}

		public void SetSocialActionTarget(string target)
		{
		}

		public void SetUserTimingCategory(string category)
		{
		}

		public void SetUserTimingVariableName(string name)
		{
		}

		public void SetUserTimingTime(int time)
		{
		}

		public void SetUserTimingLabel(string label)
		{
		}

		public void SetPageLoadTime(int time)
		{
		}

		public void SetDNSTime(int time)
		{
		}

		public void SetPageDownloadTime(int time)
		{
		}

		public void SetRedirectResponseTime(int time)
		{
		}

		public void SetTCPConnectTime(int time)
		{
		}

		public void SetServerResponseTime(int time)
		{
		}

		public void SetPromotionID(int index, string id)
		{
		}

		public void SetPromotionName(int index, string nm)
		{
		}

		public void SetPromotionCreative(int index, string cr)
		{
		}

		public void SetPromotionPosition(int index, string ps)
		{
		}

		public void SetPromotionAction(string promoa)
		{
		}

		public void SetExceptionDescription(string description)
		{
		}

		public void SetIsFatalException(bool isFatal)
		{
		}

		public void SetNonInteractionFlag()
		{
		}

		public void SetCustomDimension(int index, string value)
		{
		}

		public void SetCustomMetric(int index, int value)
		{
		}

		public void SetExperimentID(string id)
		{
		}

		public void SetExperimentVariant(string variant)
		{
		}

		public void SendPageHit(string host, string page, string title, string description = "", string linkId = "")
		{
		}

		public void SendEventHit(string category, string action, string label = "", int val = -1, bool trackLevelName = false)
		{
		}

		public void SendTransactionHit(string id, string affiliation = "", string currencyCode = "", float revenue = 0f, float shipping = 0f, float tax = 0f)
		{
		}

		public void SendItemHit(string transactionId, string name, string SKU, float price, int quantity = 1, string category = "", string currencyCode = "")
		{
		}

		public void SendSocialHit(string action, string network, string target)
		{
		}

		public void SendExceptionHit(string description, bool IsFatal = false)
		{
		}

		public void SendUserTimingHit(string category, string variable, int time, string label)
		{
		}

		public void SendScreenHit(string screenName)
		{
		}

		public void CreateHit(HitType hit)
		{
		}

		public void Send()
		{
		}

		public WWW GenerateWWW(byte[] data)
		{
			return null;
		}

		public void AppendData(string protocolToken, string val)
		{
		}

		public void AppendData(string protocolToken, string val, string action, int maxSize, params HitType[] supportedHitTypes)
		{
		}

		private string FloatToCurrency(float val)
		{
			return "";
		}

		private void CheckDataLength(string action, string data, int maxLength)
		{
		}

		private string EscapeString(string original)
		{
			return "";
		}

		private string EscapeString(string original, bool forced)
		{
			return "";
		}
	}
}
