using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	public class WallHackDetector : ActDetectorBase
	{
		private sealed class _003CInitDetector_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WallHackDetector _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitDetector_003Ed__79(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CCaptureFrame_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WallHackDetector _003C_003E4__this;

			private RenderTexture _003CpreviousActive_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCaptureFrame_003Ed__84(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		internal const string COMPONENT_NAME = "WallHack Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		private const int SHADER_TEXTURE_SIZE = 4;

		private const int RENDER_TEXTURE_SIZE = 4;

		private readonly Vector3 rigidPlayerVelocity;

		private static int instancesInScene;

		private readonly WaitForEndOfFrame waitForEndOfFrame;

		[SerializeField]
		private bool checkRigidbody;

		[SerializeField]
		private bool checkController;

		[SerializeField]
		private bool checkWireframe;

		[SerializeField]
		private bool checkRaycast;

		public int wireframeDelay;

		public int raycastDelay;

		public Vector3 spawnPosition;

		public byte maxFalsePositives;

		private GameObject serviceContainer;

		private GameObject solidWall;

		private GameObject thinWall;

		private Camera wfCamera;

		private MeshRenderer foregroundRenderer;

		private MeshRenderer backgroundRenderer;

		private Color wfColor1;

		private Color wfColor2;

		private Shader wfShader;

		private Material wfMaterial;

		private Texture2D shaderTexture;

		private Texture2D targetTexture;

		private RenderTexture renderTexture;

		private int whLayer;

		private int raycastMask;

		private Rigidbody rigidPlayer;

		private CharacterController charControllerPlayer;

		private float charControllerVelocity;

		private byte rigidbodyDetections;

		private byte controllerDetections;

		private byte wireframeDetections;

		private byte raycastDetections;

		private bool wireframeDetected;

		private readonly RaycastHit[] rayHits;

		private static WallHackDetector _003CInstance_003Ek__BackingField;

		public bool CheckRigidbody
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckController
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckWireframe
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckRaycast
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static WallHackDetector Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private static WallHackDetector GetOrCreateInstance => null;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction callback)
		{
		}

		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private WallHackDetector()
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

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
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

		private void UpdateServiceContainer()
		{
		}

		private IEnumerator InitDetector()
		{
			return null;
		}

		private void StartRigidModule()
		{
		}

		private void StartControllerModule()
		{
		}

		private void StartWireframeModule()
		{
		}

		private void ShootWireframeModule()
		{
		}

		private IEnumerator CaptureFrame()
		{
			return null;
		}

		private void StartRaycastModule()
		{
		}

		private void ShootRaycastModule()
		{
		}

		private void StopRigidModule()
		{
		}

		private void StopControllerModule()
		{
		}

		private void StopWireframeModule()
		{
		}

		private void StopRaycastModule()
		{
		}

		private void InitRigidModule()
		{
		}

		private void InitControllerModule()
		{
		}

		private void UninitRigidModule()
		{
		}

		private void UninitControllerModule()
		{
		}

		private bool Detect()
		{
			return false;
		}

		private static Color32 GenerateColor()
		{
			return (Color32)null;
		}

		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return false;
		}
	}
}
