using UnityEngine;
using UnityEngine.UI;

namespace SIS
{
	public class VRReticle : MonoBehaviour
	{
		[SerializeField]
		private float m_DefaultDistance;

		[SerializeField]
		private bool m_UseNormal;

		[SerializeField]
		private Image m_Image;

		[SerializeField]
		private Transform m_ReticleTransform;

		[SerializeField]
		private Transform m_Camera;

		private Vector3 m_OriginalScale;

		private Quaternion m_OriginalRotation;

		public bool UseNormal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform ReticleTransform => null;

		private void Awake()
		{
		}

		public void Hide()
		{
		}

		public void Show()
		{
		}

		public void SetPosition()
		{
		}

		public void SetPosition(RaycastHit hit)
		{
		}
	}
}
