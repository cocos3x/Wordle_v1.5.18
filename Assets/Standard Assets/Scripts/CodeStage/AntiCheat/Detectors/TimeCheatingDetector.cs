using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	public class TimeCheatingDetector : ActDetectorBase
	{
		private struct AsyncCallbackData
		{
			public Action<double> callback;

			public double data;
		}

		internal const string COMPONENT_NAME = "Time Cheating Detector";

		private const string LOG_PREFIX = "[ACTk] Time Cheating Detector: ";

		private const string TIME_SERVER = "pool.ntp.org";

		private const int NTP_DATA_BUFFER_LENGTH = 48;

		private static int instancesInScene;

		private readonly DateTime date1900;

		private readonly Queue<AsyncCallbackData> asyncResultQueue;

		private readonly List<AsyncCallbackData> resultList;

		private readonly object lockObject;

		private float timeElapsed;

		protected UnityAction errorAction;

		public int interval;

		public int threshold;

		private Socket asyncSocket;

		private Action<double> getOnlineTimeCallback;

		private string targetHost;

		private byte[] targetIP;

		private IPEndPoint targetEndpoint;

		private byte[] ntpData;

		private SocketAsyncEventArgs connectArgs;

		private SocketAsyncEventArgs sendArgs;

		private SocketAsyncEventArgs receiveArgs;

		private bool checkingForCheat;

		private static TimeCheatingDetector _003CInstance_003Ek__BackingField;

		public bool IsCheckingForCheat => false;

		public static TimeCheatingDetector Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private static TimeCheatingDetector GetOrCreateInstance => null;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction detectionCallback, [Optional] UnityAction errorCallback)
		{
		}

		public static void StartDetection(UnityAction detectionCallback, int interval)
		{
		}

		public static void StartDetection(UnityAction detectionCallback, UnityAction errorCallback, int interval)
		{
		}

		public static void StopDetection()
		{
		}

		public static void SetErrorCallback(UnityAction errorCallback)
		{
		}

		public static void Dispose()
		{
		}

		private TimeCheatingDetector()
		{
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnLevelLoadedCallback()
		{
		}

		private void Update()
		{
		}

		public void ForceCheck()
		{
		}

		private void StartDetectionInternal(UnityAction detectionCallback, UnityAction errorCallback, int checkInterval)
		{
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override void PauseDetector()
		{
		}

		protected override void ResumeDetector()
		{
		}

		protected override void StopDetectionInternal()
		{
		}

		protected override void DisposeInternal()
		{
		}

		private void CheckForCheat()
		{
		}

		private void OnTimeGot(double onlineTime)
		{
		}

		public static double GetOnlineTime(string server)
		{
			return 0.0;
		}

		public void GetOnlineTimeAsync(string server, Action<double> callback)
		{
		}

		private void OnSocketConnected(object sender, SocketAsyncEventArgs e)
		{
		}

		private void OnSocketSend(object sender, SocketAsyncEventArgs e)
		{
		}

		private void OnSocketReceive(object sender, SocketAsyncEventArgs e)
		{
		}

		private void SocketAsyncResult(double time)
		{
		}

		private double GetLocalTime()
		{
			return 0.0;
		}
	}
}
