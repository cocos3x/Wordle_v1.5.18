using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	public class UIVerticalScroller : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public UIVerticalScroller _003C_003E4__this;

			public int index;

			internal void _003CAddListener_003Eb__0()
			{
			}
		}

		public RectTransform _scrollingPanel;

		public GameObject[] _arrayOfElements;

		public RectTransform _center;

		public int StartingIndex;

		public GameObject ScrollUpButton;

		public GameObject ScrollDownButton;

		public UnityEvent<int> ButtonClicked;

		private float[] distReposition;

		private float[] distance;

		private int minElementsNum;

		private int elementLength;

		private float deltaY;

		private string result;

		public UIVerticalScroller()
		{
		}

		public UIVerticalScroller(RectTransform scrollingPanel, GameObject[] arrayOfElements, RectTransform center)
		{
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void AddListener(GameObject button, int index)
		{
		}

		private void DoSomething(int index)
		{
		}

		public void Update()
		{
		}

		private void ScrollingElements(float position)
		{
		}

		public string GetResults()
		{
			return "";
		}

		public void SnapToElement(int element)
		{
		}

		public void ScrollUp()
		{
		}

		public void ScrollDown()
		{
		}

		private void _003CStart_003Eb__16_0()
		{
		}

		private void _003CStart_003Eb__16_1()
		{
		}
	}
}
