using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class ReorderableListElement : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		private readonly List<RaycastResult> _raycastResults;

		private ReorderableList _currentReorderableListRaycasted;

		private RectTransform _draggingObject;

		private LayoutElement _draggingObjectLE;

		private Vector2 _draggingObjectOriginalSize;

		private RectTransform _fakeElement;

		private LayoutElement _fakeElementLE;

		private int _fromIndex;

		private bool _isDragging;

		private RectTransform _rect;

		private ReorderableList _reorderableList;

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void RefreshSizes()
		{
		}

		public void Init(ReorderableList reorderableList)
		{
		}
	}
}
