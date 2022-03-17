using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		private static int instancesInScene;

		public float floatEpsilon;

		public float vector2Epsilon;

		public float vector3Epsilon;

		public float quaternionEpsilon;

		private static ObscuredCheatingDetector _003CInstance_003Ek__BackingField;

		public static ObscuredCheatingDetector Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private static ObscuredCheatingDetector GetOrCreateInstance => null;

		internal static bool ExistsAndIsRunning => false;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction callback)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private ObscuredCheatingDetector()
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

		private void StartDetectionInternal(UnityAction callback)
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
	}
}
