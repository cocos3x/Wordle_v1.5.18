using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector2Int
	{
		[Serializable]
		public struct RawEncryptedVector2Int
		{
			public int x;

			public int y;
		}

		private static int cryptoKey;

		private static readonly Vector2Int zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector2Int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector2Int fakeValue;

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

		private ObscuredVector2Int(Vector2Int value)
		{
		}

		public ObscuredVector2Int(int x, int y)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static RawEncryptedVector2Int Encrypt(Vector2Int value)
		{
			return (RawEncryptedVector2Int)null;
		}

		public static RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
		{
			return (RawEncryptedVector2Int)null;
		}

		public static RawEncryptedVector2Int Encrypt(int x, int y, int key)
		{
			return (RawEncryptedVector2Int)null;
		}

		public static Vector2Int Decrypt(RawEncryptedVector2Int value)
		{
			return (Vector2Int)null;
		}

		public static Vector2Int Decrypt(RawEncryptedVector2Int value, int key)
		{
			return (Vector2Int)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public RawEncryptedVector2Int GetEncrypted()
		{
			return (RawEncryptedVector2Int)null;
		}

		public void SetEncrypted(RawEncryptedVector2Int encrypted)
		{
		}

		public Vector2Int GetDecrypted()
		{
			return (Vector2Int)null;
		}

		private Vector2Int InternalDecrypt()
		{
			return (Vector2Int)null;
		}

		private int InternalDecryptField(int encrypted)
		{
			return 0;
		}

		private int InternalEncryptField(int encrypted)
		{
			return 0;
		}

		public static implicit operator ObscuredVector2Int(Vector2Int value)
		{
			return (ObscuredVector2Int)null;
		}

		public static implicit operator Vector2Int(ObscuredVector2Int value)
		{
			return (Vector2Int)null;
		}

		public static implicit operator Vector2(ObscuredVector2Int value)
		{
			return (Vector2)null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
