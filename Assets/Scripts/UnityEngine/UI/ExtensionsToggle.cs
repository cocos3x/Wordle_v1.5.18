using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	public class ExtensionsToggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		public enum ToggleTransition
		{
			None,
			Fade
		}

		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}

		[Serializable]
		public class ToggleEventObject : UnityEvent<ExtensionsToggle>
		{
		}

		public string UniqueID;

		public ToggleTransition toggleTransition;

		public Graphic graphic;

		[SerializeField]
		private ExtensionsToggleGroup m_Group;

		public ToggleEvent onValueChanged;

		public ToggleEventObject onToggleChanged;

		[SerializeField]
		private bool m_IsOn;

		public ExtensionsToggleGroup Group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected ExtensionsToggle()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private void SetToggleGroup(ExtensionsToggleGroup newGroup, bool setMemberValue)
		{
		}

		private void Set(bool value)
		{
		}

		private void Set(bool value, bool sendCallback)
		{
		}

		private void PlayEffect(bool instant)
		{
		}

		protected override void Start()
		{
		}

		private void InternalToggle()
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
