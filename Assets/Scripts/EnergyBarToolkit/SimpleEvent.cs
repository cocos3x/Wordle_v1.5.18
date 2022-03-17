using System;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class SimpleEvent : MonoBehaviour
	{
		[Serializable]
		public class Action
		{
			public enum Type
			{
				IncreaseByValue,
				IncreaseByPercent,
				DecreaseByValue,
				DecreaseByPercent,
				SetToValue,
				SetToPercent
			}

			internal SimpleEvent simpleEvent;

			public bool changeBar;

			public Type changeBarType;

			public float changeBarValue;

			public bool intervaled;

			public float timeInterval;

			private float timeIntervalAccum;

			public bool sendMessage;

			public Signal[] signals;

			public void Invoke(GameObject collider)
			{
			}

			private void InvokeActual(GameObject collider)
			{
			}

			public void Reset()
			{
			}
		}

		[Serializable]
		public class Signal
		{
			public enum ReceiverType
			{
				Self,
				Collider,
				FixedGameObject
			}

			public enum MessageArgument
			{
				Caller,
				BarValue,
				BarValuePercent
			}

			public ReceiverType receiverType;

			public GameObject receiver;

			public string methodName;

			public MessageArgument argument;

			public void Invoke(SimpleEvent simpleEvent, GameObject collider)
			{
			}
		}

		public enum Target
		{
			GameObjects,
			Tags
		}

		private enum TriggerType
		{
			Enter,
			Stay,
			Leave
		}

		private sealed class _003C_003Ec__DisplayClass15_0
		{
			public GameObject other;

			internal bool _003CIsReactingTo_003Eb__0(GameObject go)
			{
				return false;
			}

			internal bool _003CIsReactingTo_003Eb__1(string tag)
			{
				return false;
			}
		}

		public EnergyBar energyBar;

		public Target targetType;

		public GameObject[] targetGameObjects;

		public string[] targetTags;

		public Action onTriggerEnterAction;

		public Action onTriggerStayAction;

		public Action onTriggerLeaveAction;

		private void OnEnable()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerLeave(Collider other)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerStay2D(Collider2D other)
		{
		}

		private void OnTriggerLeave2D(Collider2D other)
		{
		}

		private void OnTrigger(GameObject other, TriggerType type)
		{
		}

		private bool IsReactingTo(GameObject other)
		{
			return false;
		}
	}
}
