using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		private static long cryptoKey;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private long hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private long fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredLong(long value)
		{
		}

		public static void SetNewCryptoKey(long newKey)
		{
		}

		public static long Encrypt(long value)
		{
			return 0L;
		}

		public static long Decrypt(long value)
		{
			return 0L;
		}

		public static long Encrypt(long value, long key)
		{
			return 0L;
		}

		public static long Decrypt(long value, long key)
		{
			return 0L;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public long GetEncrypted()
		{
			return 0L;
		}

		public void SetEncrypted(long encrypted)
		{
		}

		public long GetDecrypted()
		{
			return 0L;
		}

		private long InternalDecrypt()
		{
			return 0L;
		}

		public static implicit operator ObscuredLong(long value)
		{
			return (ObscuredLong)null;
		}

		public static implicit operator long(ObscuredLong value)
		{
			return 0L;
		}

		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return (ObscuredLong)null;
		}

		public static ObscuredLong operator --(ObscuredLong input)
		{
			return (ObscuredLong)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredLong obj)
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
