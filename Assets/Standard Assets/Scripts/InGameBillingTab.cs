using UnityEngine;
using UnityEngine.UI;

public class InGameBillingTab : FeatureTab
{
	[SerializeField]
	private GameObject[] objectToEnbaleOnInit;

	[SerializeField]
	private Button[] initBoundButtons;

	public Text coinsLabel;

	public Text boostLabel;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void AddCoins()
	{
	}

	public void Boost()
	{
	}
}
