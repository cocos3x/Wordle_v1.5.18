using CodeStage.AntiCheat.Common;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout(2)]
		private struct DoubleLongBytesUnion
		{
			public double d;

			public long l;

			public ACTkByte8 b8;
		}

		private static long cryptoKey;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte8 hiddenValue;

		[SerializeField]
		private byte[] hiddenValueOld;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private double fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDouble(double value)
		{
		}

		public static void SetNewCryptoKey(long newKey)
		{
		}

		public static long Encrypt(double value)
		{
			return 0L;
		}

		public static long Encrypt(double value, long key)
		{
			return 0L;
		}

		private static ACTkByte8 InternalEncrypt(double value)
		{
			return (ACTkByte8)null;
		}

		private static ACTkByte8 InternalEncrypt(double value, long key)
		{
			return (ACTkByte8)null;
		}

		public static double Decrypt(long value)
		{
			return 0.0;
		}

		public static double Decrypt(long value, long key)
		{
			return 0.0;
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

		public double GetDecrypted()
		{
			return 0.0;
		}

		private double InternalDecrypt()
		{
			return 0.0;
		}

		public static implicit operator ObscuredDouble(double value)
		{
			return (ObscuredDouble)null;
		}

		public static implicit operator double(ObscuredDouble value)
		{
			return 0.0;
		}

		public static explicit operator ObscuredDouble(ObscuredFloat f)
		{
			return (ObscuredDouble)null;
		}

		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return (ObscuredDouble)null;
		}

		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return (ObscuredDouble)null;
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

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredDouble obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
