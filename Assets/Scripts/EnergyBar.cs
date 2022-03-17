using UnityEngine;

public class EnergyBar : MonoBehaviour
{
	[SerializeField]
	private int _valueCurrent;

	public int valueMin;

	public int valueMax;

	public bool animationEnabled;

	public float animValueF;

	public int valueCurrent
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float ValueF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected void Update()
	{
	}

	public void SetValueCurrent(int valueCurrent)
	{
	}

	public void SetValueMin(int valueMin)
	{
	}

	public void SetValueMax(int valueMax)
	{
	}

	public void SetValueF(float valueF)
	{
	}

	public void ChangeValueF(float valueF)
	{
	}

	public void ChangeValueCurrent(int value)
	{
	}
}
