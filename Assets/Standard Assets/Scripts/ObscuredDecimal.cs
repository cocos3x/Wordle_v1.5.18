using CodeStage.AntiCheat.Common;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		[StructLayout(2)]
		private struct DecimalLongBytesUnion
		{
			public decimal d;

			public long l1;

			public long l2;

			public ACTkByte16 b16;
		}

		private static long cryptoKey;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte16 hiddenValue;

		[SerializeField]
		private bool inited;

		private decimal fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDecimal(decimal value)
		{
		}

		public static void SetNewCryptoKey(long newKey)
		{
		}

		public static decimal Encrypt(decimal value)
		{
			return (decimal)null;
		}

		public static decimal Encrypt(decimal value, long key)
		{
			return (decimal)null;
		}

		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return (ACTkByte16)null;
		}

		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return (ACTkByte16)null;
		}

		public static decimal Decrypt(decimal value)
		{
			return (decimal)null;
		}

		public static decimal Decrypt(decimal value, long key)
		{
			return (decimal)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public decimal GetEncrypted()
		{
			return (decimal)null;
		}

		public void SetEncrypted(decimal encrypted)
		{
		}

		public decimal GetDecrypted()
		{
			return (decimal)null;
		}

		private decimal InternalDecrypt()
		{
			return (decimal)null;
		}

		public static implicit operator ObscuredDecimal(decimal value)
		{
			return (ObscuredDecimal)null;
		}

		public static implicit operator decimal(ObscuredDecimal value)
		{
			return (decimal)null;
		}

		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return (ObscuredDecimal)null;
		}

		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return (ObscuredDecimal)null;
		}

		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return (ObscuredDecimal)null;
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

		public bool Equals(ObscuredDecimal obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
