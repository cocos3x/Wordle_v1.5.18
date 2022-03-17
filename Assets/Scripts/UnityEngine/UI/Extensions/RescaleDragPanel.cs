using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class RescaleDragPanel : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		private Vector2 pointerOffset;

		private RectTransform canvasRectTransform;

		private RectTransform panelRectTransform;

		private Transform goTransform;

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}

		private Vector2 ClampToWindow(PointerEventData data)
		{
			return (Vector2)null;
		}
	}
}
