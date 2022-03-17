using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class MNT_Room
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MNT_RoomState> _003C_003E9__5_0;

		internal void _003C_002Ector_003Eb__5_0(MNT_RoomState _003Cp0_003E)
		{
		}
	}

	private int _size;

	private byte[] _info;

	private MNT_RoomState _State;

	private List<MNT_PlayerTemplate> _Players;

	public Action<MNT_RoomState> MNT_RoomStateChangedAction;

	public MNT_RoomState State
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (MNT_RoomState)null;
		}
		set
		{
		}
	}

	public List<MNT_PlayerTemplate> Players => null;

	public int size => 0;

	public byte[] info => null;

	public MNT_Room(int roomSize = 1, [Optional] byte[] roomInfo)
	{
	}

	public void AddPlayer(MNT_PlayerTemplate player)
	{
	}

	public void RemovePlayer(MNT_PlayerTemplate player)
	{
	}

	public void RemovePlayerById(string id)
	{
	}

	public MNT_PlayerTemplate GetPlayerById(string id)
	{
		return null;
	}

	public void UpdateRoom(int size, byte[] info, List<MNT_PlayerTemplate> updatedPlayers)
	{
	}

	private void UpdateState()
	{
	}
}
