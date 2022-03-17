using SA.Common.Models;
using System.Collections.Generic;

namespace SA.Fitness
{
	public class SubscriptionsRequestResult : Result
	{
		private List<Subscription> subscriptions;

		private int id;

		public int Id => 0;

		public List<Subscription> Subscriptions => null;

		public SubscriptionsRequestResult(int id)
		{
		}

		public SubscriptionsRequestResult(int id, int resultCode, string message)
		{
		}

		public void AddSubscription(Subscription subscription)
		{
		}
	}
}
