using UnityEngine;

public class DragController : MonoBehaviour
{
	private Vector3 _originalPosition;

	private Vector3 _dragOffset;

	private Camera _cam;

	[SerializeField]
	private float _speed;

	private void Awake()
	{
	}

	private void OnTouchBegin()
	{
	}

	private void OnTouchOver()
	{
	}

	private void OnTouchEnd()
	{
	}

	private Vector3 GetMousePos()
	{
		return (Vector3)null;
	}
}
