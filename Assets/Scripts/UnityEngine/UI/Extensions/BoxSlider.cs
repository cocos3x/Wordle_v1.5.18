using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class BoxSlider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		public enum Direction
		{
			LeftToRight,
			RightToLeft,
			BottomToTop,
			TopToBottom
		}

		[Serializable]
		public class BoxSliderEvent : UnityEvent<float, float>
		{
		}

		private enum Axis
		{
			Horizontal,
			Vertical
		}

		[SerializeField]
		private RectTransform m_HandleRect;

		[SerializeField]
		private float m_MinValue;

		[SerializeField]
		private float m_MaxValue;

		[SerializeField]
		private bool m_WholeNumbers;

		[SerializeField]
		private float m_ValueX;

		[SerializeField]
		private float m_ValueY;

		[SerializeField]
		private BoxSliderEvent m_OnValueChanged;

		private Transform m_HandleTransform;

		private RectTransform m_HandleContainerRect;

		private Vector2 m_Offset;

		private DrivenRectTransformTracker m_Tracker;

		public RectTransform HandleRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float MinValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool WholeNumbers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float ValueX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NormalizedValueX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ValueY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NormalizedValueY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public BoxSliderEvent OnValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float StepSize => 0f;

		protected BoxSlider()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public void LayoutComplete()
		{
		}

		public void GraphicUpdateComplete()
		{
		}

		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return false;
		}

		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void UpdateCachedReferences()
		{
		}

		private void SetX(float input)
		{
		}

		private void SetX(float input, bool sendCallback)
		{
		}

		private void SetY(float input)
		{
		}

		private void SetY(float input, bool sendCallback)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateVisuals()
		{
		}

		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		private bool CanDrag(PointerEventData eventData)
		{
			return false;
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
