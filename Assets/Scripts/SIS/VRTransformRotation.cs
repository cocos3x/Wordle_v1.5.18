using UnityEngine;

namespace SIS
{
	public class VRTransformRotation : MonoBehaviour
	{
		[SerializeField]
		private float m_Damping;

		[SerializeField]
		private float m_MaxYRotation;

		[SerializeField]
		private float m_MinYRotation;

		private const float k_ExpDampCoef = -20f;

		private void Update()
		{
		}
	}
}
