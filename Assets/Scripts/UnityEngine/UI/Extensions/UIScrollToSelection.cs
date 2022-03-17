using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class UIScrollToSelection : MonoBehaviour
	{
		public enum ScrollType
		{
			VERTICAL,
			HORIZONTAL,
			BOTH
		}

		[SerializeField]
		private ScrollType scrollDirection;

		[SerializeField]
		private float scrollSpeed;

		[SerializeField]
		private bool cancelScrollOnInput;

		[SerializeField]
		private List<KeyCode> cancelScrollKeycodes;

		private RectTransform _003CScrollWindow_003Ek__BackingField;

		private ScrollRect _003CTargetScrollRect_003Ek__BackingField;

		private GameObject _003CLastCheckedGameObject_003Ek__BackingField;

		private RectTransform _003CCurrentTargetRectTransform_003Ek__BackingField;

		private bool _003CIsManualScrollingAvailable_003Ek__BackingField;

		protected RectTransform LayoutListGroup => null;

		protected ScrollType ScrollDirection => (ScrollType)null;

		protected float ScrollSpeed => 0f;

		protected bool CancelScrollOnInput => false;

		protected List<KeyCode> CancelScrollKeycodes => null;

		protected RectTransform ScrollWindow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected ScrollRect TargetScrollRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected EventSystem CurrentEventSystem => null;

		protected GameObject LastCheckedGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected GameObject CurrentSelectedGameObject => null;

		protected RectTransform CurrentTargetRectTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected bool IsManualScrollingAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateReferences()
		{
		}

		private void CheckIfScrollingShouldBeLocked()
		{
		}

		private void ScrollRectToLevelSelection()
		{
		}

		private void UpdateVerticalScrollPosition(RectTransform selection)
		{
		}

		private void UpdateHorizontalScrollPosition(RectTransform selection)
		{
		}

		private float GetScrollOffset(float position, float listAnchorPosition, float targetLength, float maskLength)
		{
			return 0f;
		}
	}
}
