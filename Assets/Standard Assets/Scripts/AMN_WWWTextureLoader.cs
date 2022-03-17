using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AMN_WWWTextureLoader : MonoBehaviour
{
	private sealed class _003CLoadCoroutin_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AMN_WWWTextureLoader _003C_003E4__this;

		private WWW _003Cwww_003E5__2;

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
		public _003CLoadCoroutin_003Ed__6(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__7_0;

		internal void _003C_002Ector_003Eb__7_0(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _url;

	public event Action<Texture2D> OnLoad
	{
		add
		{
		}
		remove
		{
		}
	}

	public static AMN_WWWTextureLoader Create()
	{
		return null;
	}

	public void LoadTexture(string url)
	{
	}

	private IEnumerator LoadCoroutin()
	{
		return null;
	}
}
