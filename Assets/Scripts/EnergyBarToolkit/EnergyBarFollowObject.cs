using UnityEngine;

namespace EnergyBarToolkit
{
	public class EnergyBarFollowObject : MonoBehaviour
	{
		public GameObject followObject;

		public Vector3 offset;

		public Vector3 rotation;

		public ObjectFinder worldCamera;

		public bool lookAtCamera;

		public bool updateLookupReference;

		[SerializeField]
		private Camera renderCamera;

		private Camera cameraReference;

		private Canvas canvas;

		public bool IsPossiblyVisible()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateFollowObject()
		{
		}

		private void UpdateFollowObjectScreenSpaceOverlay()
		{
		}

		private void UpdateFollowObjectScreenSpaceCamera()
		{
		}

		private void UpdateScreenSpace()
		{
		}

		private void UpdateFollowObjectWorldSpace()
		{
		}
	}
}
