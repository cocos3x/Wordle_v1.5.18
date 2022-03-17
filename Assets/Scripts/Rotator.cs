using UnityEngine;

public class Rotator : MonoBehaviour
{
	public enum Axis
	{
		X,
		Y,
		Z
	}

	public float speed;

	public Axis axis;

	public bool clockwise;

	private Vector3 direction;

	private void Start()
	{
	}
}
