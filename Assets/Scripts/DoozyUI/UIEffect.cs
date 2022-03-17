using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DoozyUI
{
	public class UIEffect : MonoBehaviour
	{
		public enum EffectPosition
		{
			InFrontOfTarget,
			BehindTarget
		}

		private sealed class _003CiReset_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIEffect _003C_003E4__this;

			public float resetDelay;

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
			public _003CiReset_003Ed__40(int _003C_003E1__state)
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

		private sealed class _003CiPlay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float startDelay;

			public UIEffect _003C_003E4__this;

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
			public _003CiPlay_003Ed__41(int _003C_003E1__state)
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

		public const string DEFAULT_CUSTOM_SORTING_LAYER_NAME = "Default";

		public const int DEFAULT_CUSTOM_ORDER_IN_LAYER = 0;

		public const int DEFAULT_DEFAULT_SORTING_ORDER_STEP = 1;

		public ParticleSystem targetParticleSystem;

		private ParticleSystem.MainModule targetParticleSystemMainModule;

		public UIElement targetUIElement;

		public float startDelay;

		public bool playOnAwake;

		public bool stopInstantly;

		public bool useCustomSortingLayerName;

		public string customSortingLayerName;

		public bool useCustomOrderInLayer;

		public int customOrderInLayer;

		public EffectPosition effectPosition;

		public int sortingOrderStep;

		public bool autoRegister;

		public bool isVisible;

		private float lifetime;

		private Coroutine cReset;

		private Coroutine cPlay;

		private ParticleSystem[] allThePS;

		private Canvas m_targetCanvas;

		private int targetPhysicsLayerID;

		private string targetSortingLayerName;

		private int targetOrderInLayer;

		private Canvas TargetCanvas => null;

		private void Reset()
		{
		}

		private void Awake()
		{
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

		private void Start()
		{
		}

		public void RegisterToUIManager()
		{
		}

		public void UnregisterFromUIManager()
		{
		}

		public void UpdateSorting()
		{
		}

		public void Show(bool forced = false)
		{
		}

		public void Hide(bool forced = false)
		{
		}

		private void ResetParticleSystem()
		{
		}

		private IEnumerator iReset(float resetDelay)
		{
			return null;
		}

		private IEnumerator iPlay(float startDelay = 0f)
		{
			return null;
		}
	}
}
