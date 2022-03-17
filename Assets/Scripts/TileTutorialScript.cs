using DoozyUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TileTutorialScript : MonoBehaviour
{
	private sealed class _003CAnimation_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileTutorialScript _003C_003E4__this;

		private int _003CfirstTile_003E5__2;

		private bool _003CobjectReached_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CAnimation_003Ed__15(int _003C_003E1__state)
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

	private sealed class _003CAnimation2_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileTutorialScript _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CAnimation2_003Ed__16(int _003C_003E1__state)
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

	public float speed;

	private Vector3 originalPosition;

	private bool animating;

	public GameObject pointer;

	public GameObject pointer2;

	public UIButton button;

	public UIButton button2;

	public GameObject hintText;

	public GameObject dotDotDot;

	public List<GameObject> tiles;

	public List<GameObject> miniTiles;

	public UIElement thisPage;

	public bool animation2;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator Animation()
	{
		return null;
	}

	private IEnumerator Animation2()
	{
		return null;
	}

	private bool MoveToObject(GameObject target)
	{
		return false;
	}
}
