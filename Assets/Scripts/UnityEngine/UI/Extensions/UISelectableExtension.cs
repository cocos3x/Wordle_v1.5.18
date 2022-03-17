using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class UISelectableExtension : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Serializable]
		public class UIButtonEvent : UnityEvent<PointerEventData.InputButton>
		{
		}

		public UIButtonEvent OnButtonPress;

		public UIButtonEvent OnButtonRelease;

		public UIButtonEvent OnButtonHeld;

		private bool _pressed;

		private PointerEventData _heldEventData;

		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		private void Update()
		{
		}

		public void TestClicked()
		{
		}

		public void TestPressed()
		{
		}

		public void TestReleased()
		{
		}

		public void TestHold()
		{
		}

		private void OnDisable()
		{
		}
	}
}
