using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		private static int cryptoKey;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private int fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredInt(int value)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static int Encrypt(int value)
		{
			return 0;
		}

		public static int Encrypt(int value, int key)
		{
			return 0;
		}

		public static int Decrypt(int value)
		{
			return 0;
		}

		public static int Decrypt(int value, int key)
		{
			return 0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public int GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(int encrypted)
		{
		}

		public int GetDecrypted()
		{
			return 0;
		}

		private int InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredInt(int value)
		{
			return (ObscuredInt)null;
		}

		public static implicit operator int(ObscuredInt value)
		{
			return 0;
		}

		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return (ObscuredFloat)null;
		}

		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return (ObscuredDouble)null;
		}

		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return (ObscuredUInt)null;
		}

		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return (ObscuredInt)null;
		}

		public static ObscuredInt operator --(ObscuredInt input)
		{
			return (ObscuredInt)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredInt obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return "";
		}

		public string ToString(string format)
		{
			return "";
		}

		public string ToString(IFormatProvider provider)
		{
			return "";
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return "";
		}
	}
}
