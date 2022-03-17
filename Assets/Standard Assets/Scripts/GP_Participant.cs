using System;
using UnityEngine;

public class GP_Participant
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__15_0;

		public static Action<Texture2D> _003C_003E9__15_1;

		internal void _003C_002Ector_003Eb__15_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__15_1(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _id;

	private string _playerid;

	private string _HiResImageUrl;

	private string _IconImageUrl;

	private string _DisplayName;

	private GP_ParticipantResult _result;

	private GP_RTM_ParticipantStatus _status;

	private Texture2D _SmallPhoto;

	private Texture2D _BigPhoto;

	public Texture2D SmallPhoto => null;

	public Texture2D BigPhoto => null;

	public string id => "";

	public string playerId => "";

	public string HiResImageUrl => "";

	public string IconImageUrl => "";

	public string DisplayName => "";

	public GP_RTM_ParticipantStatus Status => (GP_RTM_ParticipantStatus)null;

	public GP_ParticipantResult Result => null;

	public event Action<Texture2D> BigPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<Texture2D> SmallPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public GP_Participant(string uid, string playerUid, string stat, string hiResImg, string IconImg, string Name)
	{
	}

	public void SetResult(GP_ParticipantResult r)
	{
	}

	public void LoadBigPhoto()
	{
	}

	public void LoadSmallPhoto()
	{
	}

	private void HandheBigPhotoLoaed(Texture2D tex)
	{
	}

	private void HandheSmallPhotoLoaed(Texture2D tex)
	{
	}
}
