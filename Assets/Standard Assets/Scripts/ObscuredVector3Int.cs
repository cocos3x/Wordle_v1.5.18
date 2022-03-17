using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector3Int
	{
		[Serializable]
		public struct RawEncryptedVector3Int
		{
			public int x;

			public int y;

			public int z;
		}

		private static int cryptoKey;

		private static readonly Vector3Int zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector3Int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector3Int fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public int x
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int y
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int z
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int this[int index]
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private ObscuredVector3Int(Vector3Int value)
		{
		}

		public ObscuredVector3Int(int x, int y, int z)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static RawEncryptedVector3Int Encrypt(Vector3Int value)
		{
			return (RawEncryptedVector3Int)null;
		}

		public static RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
		{
			return (RawEncryptedVector3Int)null;
		}

		public static RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
		{
			return (RawEncryptedVector3Int)null;
		}

		public static Vector3Int Decrypt(RawEncryptedVector3Int value)
		{
			return (Vector3Int)null;
		}

		public static Vector3Int Decrypt(RawEncryptedVector3Int value, int key)
		{
			return (Vector3Int)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public RawEncryptedVector3Int GetEncrypted()
		{
			return (RawEncryptedVector3Int)null;
		}

		public void SetEncrypted(RawEncryptedVector3Int encrypted)
		{
		}

		public Vector3Int GetDecrypted()
		{
			return (Vector3Int)null;
		}

		private Vector3Int InternalDecrypt()
		{
			return (Vector3Int)null;
		}

		private int InternalDecryptField(int encrypted)
		{
			return 0;
		}

		private int InternalEncryptField(int encrypted)
		{
			return 0;
		}

		public static implicit operator ObscuredVector3Int(Vector3Int value)
		{
			return (ObscuredVector3Int)null;
		}

		public static implicit operator Vector3Int(ObscuredVector3Int value)
		{
			return (Vector3Int)null;
		}

		public static implicit operator Vector3(ObscuredVector3Int value)
		{
			return (Vector3)null;
		}

		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return (ObscuredVector3Int)null;
		}

		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
		{
			return (ObscuredVector3Int)null;
		}

		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
		{
			return (ObscuredVector3Int)null;
		}

		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return (ObscuredVector3Int)null;
		}

		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
		{
			return (ObscuredVector3Int)null;
		}

		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
		{
			return (ObscuredVector3Int)null;
		}

		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
		{
			return (ObscuredVector3Int)null;
		}

		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return false;
		}

		public override bool Equals(object other)
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
	}
}
