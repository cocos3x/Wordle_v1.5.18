using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector2
	{
		[Serializable]
		public struct RawEncryptedVector2
		{
			public int x;

			public int y;
		}

		private static int cryptoKey;

		private static readonly Vector2 zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector2 fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public float x
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float this[int index]
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private ObscuredVector2(Vector2 value)
		{
		}

		public ObscuredVector2(float x, float y)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return (RawEncryptedVector2)null;
		}

		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return (RawEncryptedVector2)null;
		}

		public static RawEncryptedVector2 Encrypt(float x, float y, int key)
		{
			return (RawEncryptedVector2)null;
		}

		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return (Vector2)null;
		}

		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return (Vector2)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public RawEncryptedVector2 GetEncrypted()
		{
			return (RawEncryptedVector2)null;
		}

		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		public Vector2 GetDecrypted()
		{
			return (Vector2)null;
		}

		private Vector2 InternalDecrypt()
		{
			return (Vector2)null;
		}

		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return false;
		}

		private float InternalDecryptField(int encrypted)
		{
			return 0f;
		}

		private int InternalEncryptField(float encrypted)
		{
			return 0;
		}

		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return (ObscuredVector2)null;
		}

		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return (Vector2)null;
		}

		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return (Vector3)null;
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
