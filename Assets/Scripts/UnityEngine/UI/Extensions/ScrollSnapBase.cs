using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class ScrollSnapBase : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler
	{
		[Serializable]
		public class SelectionChangeStartEvent : UnityEvent
		{
		}

		[Serializable]
		public class SelectionPageChangedEvent : UnityEvent<int>
		{
		}

		[Serializable]
		public class SelectionChangeEndEvent : UnityEvent<int>
		{
		}

		internal RectTransform _screensContainer;

		internal bool _isVertical;

		internal int _screens;

		internal float _scrollStartPosition;

		internal float _childSize;

		private float _childPos;

		private float _maskSize;

		internal Vector2 _childAnchorPoint;

		internal ScrollRect _scroll_rect;

		internal Vector3 _lerp_target;

		internal bool _lerp;

		internal bool _pointerDown;

		internal bool _settled;

		internal Vector3 _startPosition;

		internal int _currentPage;

		internal int _previousPage;

		internal int _halfNoVisibleItems;

		private int _bottomItem;

		private int _topItem;

		[SerializeField]
		public int StartingScreen;

		[SerializeField]
		public float PageStep;

		public GameObject Pagination;

		public GameObject NextButton;

		public GameObject PrevButton;

		public float transitionSpeed;

		public bool UseFastSwipe;

		public int FastSwipeThreshold;

		public int SwipeVelocityThreshold;

		public RectTransform MaskArea;

		public float MaskBuffer;

		public bool GoToBeginningOnLastPage;

		public bool UseParentTransform;

		public GameObject[] ChildObjects;

		[SerializeField]
		private SelectionChangeStartEvent m_OnSelectionChangeStartEvent;

		[SerializeField]
		private SelectionPageChangedEvent m_OnSelectionPageChangedEvent;

		[SerializeField]
		private SelectionChangeEndEvent m_OnSelectionChangeEndEvent;

		public int CurrentPage
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public SelectionChangeStartEvent OnSelectionChangeStartEvent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectionPageChangedEvent OnSelectionPageChangedEvent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectionChangeEndEvent OnSelectionChangeEndEvent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		internal void InitialiseChildObjectsFromScene()
		{
		}

		internal void InitialiseChildObjectsFromArray()
		{
		}

		internal void UpdateVisible()
		{
		}

		public void NextScreen()
		{
		}

		public void PreviousScreen()
		{
		}

		public void GoToScreen(int screenIndex)
		{
		}

		public void GoToScreen(int screenIndex, bool noCallBack)
		{
		}

		internal int GetPageforPosition(Vector3 pos)
		{
			return 0;
		}

		internal bool IsRectSettledOnaPage(Vector3 pos)
		{
			return false;
		}

		internal void GetPositionforPage(int page, ref Vector3 target)
		{
		}

		internal void ScrollToClosestElement()
		{
		}

		internal void ChangeBulletsInfo(int targetScreen)
		{
		}

		private void OnValidate()
		{
		}

		internal void StartScreenChange()
		{
		}

		internal void ScreenChange()
		{
		}

		internal void EndScreenChange()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void _003CAwake_003Eb__51_0()
		{
		}

		private void _003CAwake_003Eb__51_1()
		{
		}
	}
}
