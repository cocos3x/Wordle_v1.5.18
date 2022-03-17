using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace QuickEngine.Extensions
{
	public static class AudioExtensions
	{
		private sealed class _003CPlayOneShotDelayed_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float aDelay;

			public AudioSource anAudioSource;

			public AudioClip anAudioClip;

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
			public _003CPlayOneShotDelayed_003Ed__0(int _003C_003E1__state)
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

		public static IEnumerator PlayOneShotDelayed(this AudioSource anAudioSource, AudioClip anAudioClip, float aDelay)
		{
			return null;
		}

		public static AudioType PlatformAudioType()
		{
			//IL_0003: Expected I4, but got O
			return (AudioType)null;
		}

		public static string PlatformAudioExtension()
		{
			return "";
		}

		public static string PlatformFileProtocol()
		{
			return "";
		}

		public static float ToDecibel(this float linear)
		{
			return 0f;
		}

		public static float ToLinear(this float dB)
		{
			return 0f;
		}
	}
}
