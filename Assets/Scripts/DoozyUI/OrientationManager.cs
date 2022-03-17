using QuickEngine.Common;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace DoozyUI
{
	public class OrientationManager : Singleton<OrientationManager>
	{
		public enum Orientation
		{
			Landscape,
			Portrait,
			Unknown
		}

		[Serializable]
		public class OrientationChange : UnityEvent<Orientation>
		{
		}

		private RectTransform m_rectTransform;

		private Canvas m_canvas;

		public bool debug;

		public OrientationChange onOrientationChange;

		private Orientation currentOrientation;

		public RectTransform RectTransform => null;

		public Canvas Canvas => null;

		public Orientation CurrentOrientation => (Orientation)null;

		protected OrientationManager()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		public void CheckDeviceOrientation()
		{
		}

		public void ChangeOrientation(Orientation newOrientation)
		{
		}

		private void NotifyUIManager(Orientation newOrientation)
		{
		}

		public static OrientationManager AddOrientationManagerToScene()
		{
			return null;
		}
	}
}
