using System;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class MultiBarSliders : MonoBehaviour
	{
		[Serializable]
		public class Bar
		{
			public EnergyBar bar;

			public string label;
		}

		public Bar[] bars;

		public Rect area;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}
	}
}
