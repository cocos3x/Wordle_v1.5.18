using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredQuaternion
	{
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			public int x;

			public int y;

			public int z;

			public int w;
		}

		private static int cryptoKey;

		private static readonly Quaternion identity;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Quaternion fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredQuaternion(Quaternion value)
		{
		}

		public ObscuredQuaternion(float x, float y, float z, float w)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return (RawEncryptedQuaternion)null;
		}

		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return (RawEncryptedQuaternion)null;
		}

		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			return (RawEncryptedQuaternion)null;
		}

		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return (Quaternion)null;
		}

		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return (Quaternion)null;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public RawEncryptedQuaternion GetEncrypted()
		{
			return (RawEncryptedQuaternion)null;
		}

		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		public Quaternion GetDecrypted()
		{
			return (Quaternion)null;
		}

		private Quaternion InternalDecrypt()
		{
			return (Quaternion)null;
		}

		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return false;
		}

		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return (ObscuredQuaternion)null;
		}

		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return (Quaternion)null;
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
