using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class HorizontalScrollSnap : ScrollSnapBase, IEndDragHandler, IEventSystemHandler
	{
		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool IsRectMovingSlowerThanThreshold(float startingSpeed)
		{
			return false;
		}

		private void DistributePages()
		{
		}

		public void AddChild(GameObject GO)
		{
		}

		public void AddChild(GameObject GO, bool WorldPositionStays)
		{
		}

		public void RemoveChild(int index, out GameObject ChildRemoved)
		{
		}

		public void RemoveAllChildren(out GameObject[] ChildrenRemoved)
		{
		}

		private void SetScrollContainerPosition()
		{
		}

		public void UpdateLayout()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
