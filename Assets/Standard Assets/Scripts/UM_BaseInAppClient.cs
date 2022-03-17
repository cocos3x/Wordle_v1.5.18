using System;

public abstract class UM_BaseInAppClient
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UM_BillingConnectionResult> _003C_003E9__26_0;

		public static Action<UM_PurchaseResult> _003C_003E9__26_1;

		public static Action<UM_BaseResult> _003C_003E9__26_2;

		internal void _003C_002Ector_003Eb__26_0(UM_BillingConnectionResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_1(UM_PurchaseResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_2(UM_BaseResult _003Cp0_003E)
		{
		}
	}

	protected bool _IsConnected;

	public bool IsConnected => false;

	public event Action<UM_BillingConnectionResult> OnServiceConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_PurchaseResult> OnPurchaseFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_BaseResult> OnRestoreFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Purchase(string productId)
	{
	}

	public abstract void Purchase(UM_InAppProduct product);

	public void Subscribe(string productId)
	{
	}

	public abstract void Subscribe(UM_InAppProduct product);

	public void Consume(string productId)
	{
	}

	public abstract void Consume(UM_InAppProduct product);

	public void FinishTransaction(string productId)
	{
	}

	public abstract void FinishTransaction(UM_InAppProduct product);

	public bool IsProductPurchased(string productId)
	{
		return false;
	}

	public virtual bool IsProductPurchased(UM_InAppProduct product)
	{
		return false;
	}

	protected void SendNoTemplateEvent()
	{
	}

	protected void SendServiceConnectedEvent(UM_BillingConnectionResult e)
	{
	}

	protected void SendPurchaseFinishedEvent(UM_PurchaseResult e)
	{
	}

	protected void SendRestoreFinishedEvent(UM_BaseResult e)
	{
	}
}
