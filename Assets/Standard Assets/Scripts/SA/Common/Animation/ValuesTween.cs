using System;
using UnityEngine;

namespace SA.Common.Animation
{
	public class ValuesTween : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__20_0;

			public static Action<float> _003C_003E9__20_1;

			public static Action<Vector3> _003C_003E9__20_2;

			internal void _003C_002Ector_003Eb__20_0()
			{
			}

			internal void _003C_002Ector_003Eb__20_1(float _003Cp0_003E)
			{
			}

			internal void _003C_002Ector_003Eb__20_2(Vector3 _003Cp0_003E)
			{
			}
		}

		public bool DestoryGameObjectOnComplete;

		private float FinalFloatValue;

		private Vector3 FinalVectorValue;

		public event Action OnComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<float> OnValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Vector3> OnVectorValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public static ValuesTween Create()
		{
			return null;
		}

		private void Update()
		{
		}

		public void ValueTo(float from, float to, float time, EaseType easeType = EaseType.linear)
		{
		}

		public void VectorTo(Vector3 from, Vector3 to, float time, EaseType easeType = EaseType.linear)
		{
		}

		public void ScaleTo(Vector3 from, Vector3 to, float time, EaseType easeType = EaseType.linear)
		{
		}

		public void VectorToS(Vector3 from, Vector3 to, float speed, EaseType easeType = EaseType.linear)
		{
		}

		public void Stop()
		{
		}

		private void onTweenComplete()
		{
		}
	}
}
