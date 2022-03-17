using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		private static short cryptoKey;

		[SerializeField]
		private short currentCryptoKey;

		[SerializeField]
		private short hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private short fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredShort(short value)
		{
		}

		public static void SetNewCryptoKey(short newKey)
		{
		}

		public static short EncryptDecrypt(short value)
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		public static short EncryptDecrypt(short value, short key)
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public short GetEncrypted()
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		public void SetEncrypted(short encrypted)
		{
		}

		public short GetDecrypted()
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		private short InternalDecrypt()
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		public static implicit operator ObscuredShort(short value)
		{
			return (ObscuredShort)null;
		}

		public static implicit operator short(ObscuredShort value)
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return (ObscuredShort)null;
		}

		public static ObscuredShort operator --(ObscuredShort input)
		{
			return (ObscuredShort)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredShort obj)
		{
			return false;
		}

		public override string ToString()
		{
			return "";
		}

		public string ToString(string format)
		{
			return "";
		}

		public override int GetHashCode()
		{
			return 0;
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
