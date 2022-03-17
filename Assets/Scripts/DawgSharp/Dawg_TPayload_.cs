using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace DawgSharp
{
	public class Dawg<TPayload> : IEnumerable<KeyValuePair<string, TPayload>>, IEnumerable
	{
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Action<BinaryWriter, TPayload> writePayload;

			internal void _003CSaveAsYaleDawg_003Eb__0(OldDawg<TPayload> d, BinaryWriter w)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public Action<BinaryWriter, TPayload> writePayload;

			internal void _003CSaveAsMatrixDawg_003Eb__0(OldDawg<TPayload> d, BinaryWriter w)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			internal void _003C_002Ecctor_003Eb__20_0(BinaryWriter r, bool payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_1(BinaryWriter r, int payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_2(BinaryWriter r, uint payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_3(BinaryWriter r, long payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_4(BinaryWriter r, ulong payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_5(BinaryWriter r, byte payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_6(BinaryWriter r, sbyte payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_7(BinaryWriter r, short payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_8(BinaryWriter r, ushort payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_9(BinaryWriter r, string payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_10(BinaryWriter r, char payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_11(BinaryWriter r, double payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_12(BinaryWriter r, float payload)
			{
			}

			internal void _003C_002Ecctor_003Eb__20_13(BinaryWriter r, decimal payload)
			{
			}

			internal bool _003C_002Ecctor_003Eb__20_14(BinaryReader r)
			{
				return false;
			}

			internal int _003C_002Ecctor_003Eb__20_15(BinaryReader r)
			{
				return 0;
			}

			internal uint _003C_002Ecctor_003Eb__20_16(BinaryReader r)
			{
				return 0u;
			}

			internal long _003C_002Ecctor_003Eb__20_17(BinaryReader r)
			{
				return 0L;
			}

			internal ulong _003C_002Ecctor_003Eb__20_18(BinaryReader r)
			{
				return 0uL;
			}

			internal byte _003C_002Ecctor_003Eb__20_19(BinaryReader r)
			{
				return 0;
			}

			internal sbyte _003C_002Ecctor_003Eb__20_20(BinaryReader r)
			{
				return 0;
			}

			internal short _003C_002Ecctor_003Eb__20_21(BinaryReader r)
			{
				//IL_0003: Expected I4, but got O
				return (short)(int)null;
			}

			internal ushort _003C_002Ecctor_003Eb__20_22(BinaryReader r)
			{
				//IL_0003: Expected I4, but got O
				return (ushort)(int)null;
			}

			internal string _003C_002Ecctor_003Eb__20_23(BinaryReader r)
			{
				return "";
			}

			internal char _003C_002Ecctor_003Eb__20_24(BinaryReader r)
			{
				return '\0';
			}

			internal double _003C_002Ecctor_003Eb__20_25(BinaryReader r)
			{
				return 0.0;
			}

			internal float _003C_002Ecctor_003Eb__20_26(BinaryReader r)
			{
				return 0f;
			}

			internal decimal _003C_002Ecctor_003Eb__20_27(BinaryReader r)
			{
				return (decimal)null;
			}
		}

		private readonly IDawg<TPayload> dawg;

		private static readonly Dictionary<Type, object> Writers;

		private static readonly Dictionary<Type, object> Readers;

		public TPayload this[IEnumerable<char> word] => (TPayload)null;

		internal Dawg(IDawg<TPayload> dawg)
		{
		}

		public int GetLongestCommonPrefixLength(IEnumerable<char> word)
		{
			return 0;
		}

		public IEnumerable<KeyValuePair<string, TPayload>> MatchPrefix(IEnumerable<char> prefix)
		{
			return null;
		}

		public int GetNodeCount()
		{
			return 0;
		}

		public IEnumerator<KeyValuePair<string, TPayload>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void SaveTo(Stream stream, [Optional] Action<BinaryWriter, TPayload> writePayload)
		{
		}

		public void SaveAsYaleDawg(Stream stream, [Optional] Action<BinaryWriter, TPayload> writePayload)
		{
		}

		public void SaveAsMatrixDawg(Stream stream, [Optional] Action<BinaryWriter, TPayload> writePayload)
		{
		}

		private void Save(Stream stream, Action<OldDawg<TPayload>, BinaryWriter> save)
		{
		}

		private static Action<BinaryWriter, TPayload> GetStandardWriter()
		{
			return null;
		}

		public static Dawg<TPayload> Load(Stream stream, [Optional] Func<BinaryReader, TPayload> readPayload)
		{
			return null;
		}

		private static IDawg<TPayload> LoadIDawg(Stream stream, Func<BinaryReader, TPayload> readPayload)
		{
			return null;
		}

		private static int GetSignature()
		{
			return 0;
		}

		private static OldDawg<TPayload> LoadOldDawg(BinaryReader reader, int nodeCount, Func<BinaryReader, TPayload> readPayload)
		{
			return null;
		}
	}
}
