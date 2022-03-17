using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class ScrollSnap : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		public enum ScrollDirection
		{
			Horizontal,
			Vertical
		}

		public delegate void PageSnapChange(int page);

		public ScrollDirection direction;

		protected ScrollRect scrollRect;

		protected RectTransform scrollRectTransform;

		protected Transform listContainerTransform;

		protected RectTransform rectTransform;

		private int pages;

		protected int startingPage;

		protected Vector3[] pageAnchorPositions;

		protected Vector3 lerpTarget;

		protected bool lerp;

		protected float listContainerMinPosition;

		protected float listContainerMaxPosition;

		protected float listContainerSize;

		protected RectTransform listContainerRectTransform;

		protected Vector2 listContainerCachedSize;

		protected float itemSize;

		protected int itemsCount;

		public Button nextButton;

		public Button prevButton;

		public int itemsVisibleAtOnce;

		public bool autoLayoutItems;

		public bool linkScrolbarSteps;

		public bool linkScrolrectScrollSensitivity;

		public bool useFastSwipe;

		public int fastSwipeThreshold;

		protected bool startDrag;

		protected Vector3 positionOnDragStart;

		protected int pageOnDragStart;

		protected bool fastSwipeTimer;

		protected int fastSwipeCounter;

		protected int fastSwipeTarget;

		private bool fastSwipe;

		public event PageSnapChange onPageChange
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateListItemsSize()
		{
		}

		public void UpdateListItemPositions()
		{
		}

		public void ResetPage()
		{
		}

		protected void UpdateScrollbar(bool linkSteps)
		{
		}

		private void LateUpdate()
		{
		}

		public void NextScreen()
		{
		}

		public void PreviousScreen()
		{
		}

		private void NextScreenCommand()
		{
		}

		private void PrevScreenCommand()
		{
		}

		public int CurrentPage()
		{
			return 0;
		}

		public void ChangePage(int page)
		{
		}

		private void PageChanged(int currentPage)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void _003CAwake_003Eb__36_0()
		{
		}

		private void _003CAwake_003Eb__36_1()
		{
		}
	}
}
