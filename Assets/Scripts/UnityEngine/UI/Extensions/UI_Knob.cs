using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class UI_Knob : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler
	{
		public enum Direction
		{
			CW,
			CCW
		}

		public Direction direction;

		public float knobValue;

		public float maxValue;

		public int loops;

		public bool clampOutput01;

		public bool snapToPosition;

		public int snapStepsPerLoop;

		public KnobFloatValueEvent OnValueChanged;

		private float _currentLoops;

		private float _previousValue;

		private float _initAngle;

		private float _currentAngle;

		private Vector2 _currentVector;

		private Quaternion _initRotation;

		private bool _canDrag;

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		private void SetInitPointerData(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void SnapToPosition(ref float knobValue)
		{
		}

		private void InvokeEvents(float value)
		{
		}
	}
}
