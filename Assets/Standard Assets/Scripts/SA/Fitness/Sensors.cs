using SA.Common.Pattern;
using System.Collections.Generic;

namespace SA.Fitness
{
	public sealed class Sensors : Singleton<Sensors>
	{
		private Dictionary<int, SensorRequest> requests;

		private Dictionary<int, SensorListener> listeners;

		private void Awake()
		{
		}

		public void RequestSensors(SensorRequest request)
		{
		}

		public void RegisterSensorListener(SensorListener listener)
		{
		}

		private void SensorsRequestResultHandler(string data)
		{
		}

		private void SensorListenerRegisterSuccessHandler(string data)
		{
		}

		private void SensorListenerRegisterFailHandler(string data)
		{
		}

		private void SensorListenerDataPointHandler(string data)
		{
		}
	}
}
