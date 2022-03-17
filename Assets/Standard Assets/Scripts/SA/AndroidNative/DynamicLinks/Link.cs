using System.Collections.Generic;

namespace SA.AndroidNative.DynamicLinks
{
	public class Link
	{
		public class SocialMetaTagParameters
		{
			public class Builder
			{
				private SocialMetaTagParameters param;

				public Builder SetTitle(string title)
				{
					return null;
				}

				public Builder SetDescription(string description)
				{
					return null;
				}

				public Builder SetImageUrl(string url)
				{
					return null;
				}

				public SocialMetaTagParameters Build()
				{
					return null;
				}
			}

			private string title;

			private string description;

			private string imageUrl;

			public string Title => "";

			public string Description => "";

			public string ImageUrl => "";

			private SocialMetaTagParameters()
			{
			}

			public Dictionary<string, object> Serialize()
			{
				return null;
			}
		}

		public class ItunesConnectAnalyticsParameters
		{
			public class Builder
			{
				private ItunesConnectAnalyticsParameters param;

				public Builder SetProviderToken(string token)
				{
					return null;
				}

				public Builder SetAffiliateToken(string token)
				{
					return null;
				}

				public Builder SetCampaignToken(string token)
				{
					return null;
				}

				public ItunesConnectAnalyticsParameters Build()
				{
					return null;
				}
			}

			private string providerToken;

			private string affiliateToken;

			private string campaignToken;

			public string CampaignToken => "";

			public string AffiliateToken => "";

			public string ProviderToken => "";

			private ItunesConnectAnalyticsParameters()
			{
			}

			public Dictionary<string, object> Serialize()
			{
				return null;
			}
		}

		public class GoogleAnalyticsParameters
		{
			public class Builder
			{
				private GoogleAnalyticsParameters param;

				public Builder SetSource(string source)
				{
					return null;
				}

				public Builder SetMedium(string medium)
				{
					return null;
				}

				public Builder SetCampaign(string campaign)
				{
					return null;
				}

				public Builder SetTerm(string term)
				{
					return null;
				}

				public Builder SetContent(string content)
				{
					return null;
				}

				public GoogleAnalyticsParameters Build()
				{
					return null;
				}
			}

			private string source;

			private string medium;

			private string campaign;

			private string term;

			private string content;

			public string Content => "";

			public string Term => "";

			public string Campaign => "";

			public string Medium => "";

			public string Source => "";

			private GoogleAnalyticsParameters()
			{
			}

			public Dictionary<string, object> Serialize()
			{
				return null;
			}
		}

		public class IosParameters
		{
			public class Builder
			{
				private IosParameters param;

				public Builder(string appBundle)
				{
				}

				public Builder SetFallbackUrl(string url)
				{
					return null;
				}

				public Builder SetCustomScheme(string scheme)
				{
					return null;
				}

				public Builder SetIpadFallbackUrl(string ipadFallbackUrl)
				{
					return null;
				}

				public Builder SetIpadBundleId(string ipadBundleId)
				{
					return null;
				}

				public Builder SetAppStoreId(string appStoreId)
				{
					return null;
				}

				public Builder SetMinimumVersion(string minVersion)
				{
					return null;
				}

				public IosParameters Build()
				{
					return null;
				}
			}

			private string appBundle;

			private string appStoreId;

			private string minimumVersion;

			private string ipadBundleId;

			private string ipadFallbackUrl;

			private string fallbackUrl;

			private string customScheme;

			public string AppStoreId => "";

			public string AppBundle => "";

			public string MinimumVersion => "";

			public string IpadBundleId => "";

			public string IpadFallbackUrl => "";

			public string FallbackUrl => "";

			public string CustomScheme => "";

			private IosParameters()
			{
			}

			public Dictionary<string, object> Serialize()
			{
				return null;
			}
		}

		public class AndroidParameters
		{
			public class Builder
			{
				private AndroidParameters param;

				public Builder(string appBundle)
				{
				}

				public Builder SetFallbackUrl(string url)
				{
					return null;
				}

				public Builder SetMinimumVersion(int minVersion)
				{
					return null;
				}

				public AndroidParameters Build()
				{
					return null;
				}
			}

			private string appBundle;

			private string fallbackUrl;

			private int minimumVersion;

			public string FallbackUrl => "";

			public int MinimumVersion => 0;

			public string AppBundle => "";

			private AndroidParameters()
			{
			}

			public Dictionary<string, object> Serialize()
			{
				return null;
			}
		}

		public class Builder
		{
			private Link link;

			public Builder SetLink(string url)
			{
				return null;
			}

			public Builder SetDynamicLinkDomain(string domain)
			{
				return null;
			}

			public Builder SetAndroidParameters(AndroidParameters param)
			{
				return null;
			}

			public Builder SetIosParameters(IosParameters param)
			{
				return null;
			}

			public Builder SetGoogleAnalyticsParameters(GoogleAnalyticsParameters param)
			{
				return null;
			}

			public Builder SetItunesConnectAnalyticsParameters(ItunesConnectAnalyticsParameters param)
			{
				return null;
			}

			public Builder SetSocialMetaTagParameters(SocialMetaTagParameters param)
			{
				return null;
			}

			public Link Build()
			{
				return null;
			}
		}

		private string url;

		private string domain;

		private AndroidParameters androidParams;

		private IosParameters iosParams;

		private GoogleAnalyticsParameters googleAnalyticsParams;

		private ItunesConnectAnalyticsParameters itunesAnalyticsParams;

		private SocialMetaTagParameters socialMetaTagParams;

		public string Url => "";

		public string Domain => "";

		public AndroidParameters AndroidParams => null;

		public IosParameters IosParams => null;

		public GoogleAnalyticsParameters GoogleAnalyticsParams => null;

		public ItunesConnectAnalyticsParameters ItunesAnalyticsParams => null;

		public SocialMetaTagParameters SocialMetaTagParams => null;

		private Link()
		{
		}

		public Dictionary<string, object> Serialize()
		{
			return null;
		}
	}
}
