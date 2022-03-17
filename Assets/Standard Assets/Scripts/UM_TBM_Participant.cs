using System;
using UnityEngine;

public class UM_TBM_Participant
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__13_0;

		public static Action<Texture2D> _003C_003E9__13_1;

		public static Action<Texture2D> _003C_003E9__14_0;

		public static Action<Texture2D> _003C_003E9__14_1;

		internal void _003C_002Ector_003Eb__13_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__13_1(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__14_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__14_1(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _Id;

	private string _Playerid;

	private string _DisplayName;

	private UM_TBM_Outcome _Outcome;

	private UM_TBM_ParticipantStatus _Status;

	private GK_TBM_Participant _GK_Participan;

	private GP_Participant _GP_Participant;

	public string Id => "";

	public string Playerid => "";

	public string DisplayName => "";

	public UM_TBM_Outcome Outcome => (UM_TBM_Outcome)null;

	public UM_TBM_ParticipantStatus Status => (UM_TBM_ParticipantStatus)null;

	public bool IsPlayerDefined => false;

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

	public UM_TBM_Participant(GK_TBM_Participant participant)
	{
	}

	public UM_TBM_Participant(GP_Participant participant)
	{
	}

	public void LoadBigPhoto()
	{
	}

	public void LoadSmallPhoto()
	{
	}

	private void HandleOnPlayerPhotoLoaded(GK_UserPhotoLoadResult res)
	{
	}

	private void HandleSmallPhotoLoaded(Texture2D photo)
	{
	}

	private void HandleBigPhotoLoaded(Texture2D photo)
	{
	}
}
