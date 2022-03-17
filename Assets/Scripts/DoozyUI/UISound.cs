using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class UISound : ScriptableObject
	{
		public string soundName;

		public AudioClip audioClip;

		public SoundType soundType;

		public UISound(string sName, AudioClip aClip, SoundType sType = SoundType.All)
		{
		}
	}
}
