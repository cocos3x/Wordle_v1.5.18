using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	public class ReturnKeyTriggersButton : MonoBehaviour, ISubmitHandler, IEventSystemHandler
	{
		private EventSystem _system;

		public Button button;

		private bool highlight;

		public float highlightDuration;

		private void Start()
		{
		}

		private void RemoveHighlight()
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}
	}
}
