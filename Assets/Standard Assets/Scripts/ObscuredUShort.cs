using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		private static ushort cryptoKey;

		private ushort currentCryptoKey;

		private ushort hiddenValue;

		private bool inited;

		private ushort fakeValue;

		private bool fakeValueActive;

		private ObscuredUShort(ushort value)
		{
		}

		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		public static ushort EncryptDecrypt(ushort value)
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public ushort GetEncrypted()
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		public void SetEncrypted(ushort encrypted)
		{
		}

		public ushort GetDecrypted()
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		private ushort InternalDecrypt()
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		public static implicit operator ObscuredUShort(ushort value)
		{
			return (ObscuredUShort)null;
		}

		public static implicit operator ushort(ObscuredUShort value)
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return (ObscuredUShort)null;
		}

		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return (ObscuredUShort)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredUShort obj)
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
