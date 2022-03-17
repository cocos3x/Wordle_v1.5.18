using System.Collections.Generic;
using UnityEngine;

namespace DoozyUI
{
	public class Soundy : MonoBehaviour
	{
		public float masterVolume;

		public float masterPitch;

		public int numberOfChannels;

		private GameObject channelsHolder;

		public List<AudioSource> channels;

		private Dictionary<string, UISound> soundsDatabase;

		private AudioSource GetChannel => null;

		private void Awake()
		{
		}

		private void CreateSoundChannels(int channelCount = 20)
		{
		}

		public void StopAllAudio()
		{
		}

		private void InitSoundsDatabase()
		{
		}

		private bool AddSoundToDatabase(string soundName)
		{
			return false;
		}

		public void PlaySound(AudioClip aClip)
		{
		}

		public void PlaySound(AudioClip aClip, float volumePercentage)
		{
		}

		public void PlaySound(AudioClip aClip, float volumePercentage, float pitch)
		{
		}

		public void PlaySound(string soundName)
		{
		}

		public void PlaySound(string soundName, float volumePercentage)
		{
		}

		public void PlaySound(string soundName, float volumePercentage, float pitch)
		{
		}

		public void PlaySoundFromResources(string soundName)
		{
		}

		public void PlaySoundFromResources(string soundName, float volume)
		{
		}

		public void PlaySoundFromResources(string soundName, float volume, float pitch)
		{
		}
	}
}
