using System;
using UnityEngine;
using UnityEngine.Events;

namespace SIS
{
	public class VRInteractiveItem : MonoBehaviour
	{
		[Serializable]
		public class Vector2Event : UnityEvent<Vector2>
		{
		}

		public UnityEvent OnOver;

		public UnityEvent OnOut;

		public UnityEvent OnClick;

		public UnityEvent OnDoubleClick;

		public UnityEvent OnSelectionComplete;

		public UnityEvent OnUp;

		public UnityEvent OnDown;

		public Vector2Event OnSwipe;

		protected bool m_IsOver;

		public bool IsOver => false;

		public void Over()
		{
		}

		public void Out()
		{
		}

		public void Click()
		{
		}

		public void DoubleClick()
		{
		}

		public void Up()
		{
		}

		public void Down()
		{
		}

		public void Swipe(Vector2 dir)
		{
		}

		public void InvokeSelectable()
		{
		}
	}
}
