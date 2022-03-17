using System;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class EnergyBarSpawnerUGUI : MonoBehaviour
	{
		public enum FindCanvasMethod
		{
			ByTag,
			ByPath,
			ByType
		}

		public EnergyBarUGUIBase barPrefab;

		public Transform attachPoint;

		public ObjectFinder canvas;

		public ObjectFinder worldCamera;

		public bool updateLookupReference;

		[NonSerialized]
		public EnergyBarUGUIBase instance;

		public static EnergyBarUGUIBase Instantiate(UnityEngine.Object parent, EnergyBarUGUIBase barPrefab, ObjectFinder canvasFinder, ObjectFinder cameraFinder, Transform attachPoint, bool updateLookupReference)
		{
			return null;
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
	}
}
