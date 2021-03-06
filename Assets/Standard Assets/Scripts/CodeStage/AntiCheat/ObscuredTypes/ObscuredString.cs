using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public sealed class ObscuredString
	{
		private static string cryptoKey;

		[SerializeField]
		private string currentCryptoKey;

		[SerializeField]
		private byte[] hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private string fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public int Length => 0;

		private ObscuredString()
		{
		}

		private ObscuredString(string value)
		{
		}

		public static void SetNewCryptoKey(string newKey)
		{
		}

		public static string EncryptDecrypt(string value)
		{
			return "";
		}

		public static string EncryptDecrypt(string value, string key)
		{
			return "";
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public string GetEncrypted()
		{
			return "";
		}

		public void SetEncrypted(string encrypted)
		{
		}

		public string GetDecrypted()
		{
			return "";
		}

		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		private string InternalDecrypt()
		{
			return "";
		}

		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		public static implicit operator string(ObscuredString value)
		{
			return "";
		}

		public override string ToString()
		{
			return "";
		}

		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return false;
		}

		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredString value)
		{
			return false;
		}

		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static byte[] GetBytes(string str)
		{
			return null;
		}

		private static string GetString(byte[] bytes)
		{
			return "";
		}

		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return false;
		}
	}
}
