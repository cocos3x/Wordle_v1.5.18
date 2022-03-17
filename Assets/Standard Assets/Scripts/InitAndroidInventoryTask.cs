using System;
using UnityEngine;

public class InitAndroidInventoryTask : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__11_0;

		public static Action _003C_003E9__11_1;

		internal void _003C_002Ector_003Eb__11_0()
		{
		}

		internal void _003C_002Ector_003Eb__11_1()
		{
		}
	}

	public event Action ActionComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action ActionFailed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static InitAndroidInventoryTask Create()
	{
		return null;
	}

	public void Run()
	{
	}

	private void OnBillingConnected(BillingResult result)
	{
	}

	private void OnBillingConnectFinished()
	{
	}

	private void OnRetrieveProductsFinised(BillingResult result)
	{
	}
}
