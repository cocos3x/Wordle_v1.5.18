using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector3
	{
		[Serializable]
		public struct RawEncryptedVector3
		{
			public int x;

			public int y;

			public int z;
		}

		private static int cryptoKey;

		private static readonly Vector3 zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector3 fakeValue;

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

		public float z
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

		private ObscuredVector3(Vector3 value)
		{
		}

		public ObscuredVector3(float x, float y, float z)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return (RawEncryptedVector3)null;
		}

		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return (RawEncryptedVector3)null;
		}

		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
		{
			return (RawEncryptedVector3)null;
		}

		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return (Vector3)null;
		}

		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return (Vector3)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public RawEncryptedVector3 GetEncrypted()
		{
			return (RawEncryptedVector3)null;
		}

		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		public Vector3 GetDecrypted()
		{
			return (Vector3)null;
		}

		private Vector3 InternalDecrypt()
		{
			return (Vector3)null;
		}

		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
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

		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return (ObscuredVector3)null;
		}

		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return (Vector3)null;
		}

		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return (ObscuredVector3)null;
		}

		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return (ObscuredVector3)null;
		}

		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
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
