using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	private sealed class _003CDoFadeOut_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MusicManager _003C_003E4__this;

		public float FadeTime;

		private float _003CstartVolume_003E5__2;

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
		public _003CDoFadeOut_003Ed__8(int _003C_003E1__state)
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

	private sealed class _003CCheckMusicState_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MusicManager _003C_003E4__this;

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
		public _003CCheckMusicState_003Ed__12(int _003C_003E1__state)
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

	public static MusicManager musicManager;

	public string menuMusic;

	public float musicVolume;

	public AudioSource menuMusicAudioSource;

	private WaitForSeconds checkMusicInterval;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void fadeOut(float FadeTime)
	{
	}

	private IEnumerator DoFadeOut(float FadeTime)
	{
		return null;
	}

	public void OnButtonClick(string buttonName)
	{
	}

	private void InitMusic()
	{
	}

	private AudioSource SetupMusic(string soundName)
	{
		return null;
	}

	private IEnumerator CheckMusicState()
	{
		return null;
	}

	private void UpdateMusicState()
	{
	}
}
