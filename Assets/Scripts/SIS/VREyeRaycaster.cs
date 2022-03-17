using System;
using UnityEngine;

namespace SIS
{
	public class VREyeRaycaster : MonoBehaviour
	{
		[SerializeField]
		private Canvas m_Canvas;

		[SerializeField]
		private Transform m_Camera;

		[SerializeField]
		private LayerMask m_ExclusionLayers;

		[SerializeField]
		private VRReticle m_Reticle;

		[SerializeField]
		private VRInput m_VrInput;

		[SerializeField]
		private VRSelectionRadial m_SelectionRadial;

		[SerializeField]
		private bool m_ShowDebugRay;

		[SerializeField]
		private float m_DebugRayLength;

		[SerializeField]
		private float m_DebugRayDuration;

		[SerializeField]
		private float m_RayLength;

		private VRInteractiveItem m_CurrentInteractible;

		private VRInteractiveItem m_LastInteractible;

		public VRInteractiveItem CurrentInteractible => null;

		public event Action<RaycastHit> OnRaycasthit
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void EyeRaycast()
		{
		}

		private void DeactiveLastInteractible()
		{
		}

		private void HandleUp()
		{
		}

		private void HandleDown()
		{
		}

		private void HandleClick()
		{
		}

		private void HandleDoubleClick()
		{
		}

		private void HandleSwipe(VRInput.SwipeDirection swipe)
		{
		}
	}
}
