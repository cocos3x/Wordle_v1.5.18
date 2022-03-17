using SA.Common.Pattern;
using System.Collections.Generic;

namespace SA.Fitness
{
	public sealed class Recording : Singleton<Recording>
	{
		private Dictionary<int, SubscribeRequest> subscriptions;

		private Dictionary<int, UnsubscribeRequest> unsubs;

		private Dictionary<int, SubscriptionsRequest> subsRequests;

		private void Awake()
		{
		}

		public void Subscribe(SubscribeRequest request)
		{
		}

		public void ListSubscriptions(SubscriptionsRequest request)
		{
		}

		public void Unsubscribe(UnsubscribeRequest request)
		{
		}

		private void SubscribeResultListener(string data)
		{
		}

		private void ListSubsResultListener(string data)
		{
		}

		private void UnsubResultListener(string data)
		{
		}
	}
}
