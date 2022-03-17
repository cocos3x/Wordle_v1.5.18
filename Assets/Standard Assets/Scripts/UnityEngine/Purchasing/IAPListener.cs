using System;
using UnityEngine.Events;

namespace UnityEngine.Purchasing
{
	public class IAPListener : MonoBehaviour
	{
		[Serializable]
		public class OnPurchaseCompletedEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<Product, PurchaseFailureReason>
		{
		}

		public bool consumePurchase;

		public bool dontDestroyOnLoad;

		public OnPurchaseCompletedEvent onPurchaseComplete;

		public OnPurchaseFailedEvent onPurchaseFailed;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			//IL_0003: Expected I4, but got O
			return (PurchaseProcessingResult)null;
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
		}
	}
}
