using UnityEngine;

namespace DoozyUI
{
	public class UICanvas : MonoBehaviour
	{
		public const string DEFAULT_CANVAS_NAME = "MasterCanvas";

		public string canvasName;

		public bool customCanvasName;

		public bool dontDestroyOnLoad;

		private RectTransform m_rectTransform;

		private Canvas m_canvas;

		private bool registeredToUIManager;

		public bool IsMasterCanvas => false;

		public RectTransform RectTransform => null;

		public Canvas Canvas => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void RegisterToUIManager()
		{
		}

		public void UnregisterFromUIManager()
		{
		}
	}
}
