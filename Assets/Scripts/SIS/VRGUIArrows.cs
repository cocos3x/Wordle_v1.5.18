using UnityEngine;

namespace SIS
{
	public class VRGUIArrows : MonoBehaviour
	{
		[SerializeField]
		private float m_FadeDuration;

		[SerializeField]
		private float m_ShowAngle;

		[SerializeField]
		private Transform m_DesiredDirection;

		[SerializeField]
		private Transform m_Camera;

		[SerializeField]
		private Renderer[] m_ArrowRenderers;

		private float m_CurrentAlpha;

		private float m_TargetAlpha;

		private float m_FadeSpeed;

		private const string k_MaterialPropertyName = "_Alpha";

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Hide()
		{
		}

		public void Show()
		{
		}
	}
}
