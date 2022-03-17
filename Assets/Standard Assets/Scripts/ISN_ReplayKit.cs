using SA.Common.Models;
using SA.Common.Pattern;
using System;

public class ISN_ReplayKit : Singleton<ISN_ReplayKit>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__41_0(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_1(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_2(ReplayKitVideoShareResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_3(Error _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_4(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_5()
		{
		}
	}

	private bool _IsRecodingAvailableToShare;

	public bool IsRecording => false;

	public bool IsRecodingAvailableToShare => false;

	public bool IsAvailable => false;

	public bool IsMicEnabled => false;

	public static event Action<Result> ActionRecordStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> ActionRecordStoped
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<ReplayKitVideoShareResult> ActionShareDialogFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Error> ActionRecordInterrupted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> ActionRecorderDidChangeAvailability
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionRecordDiscard
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void StartRecording(bool microphoneEnabled = true)
	{
	}

	public void StopRecording()
	{
	}

	public void DiscardRecording()
	{
	}

	public void ShowVideoShareDialog()
	{
	}

	private void OnRecorStartSuccess(string data)
	{
	}

	private void OnRecorStartFailed(string errorData)
	{
	}

	private void OnRecorStopFailed(string errorData)
	{
	}

	private void OnRecorStopSuccess()
	{
	}

	private void OnRecordInterrupted(string errorData)
	{
	}

	private void OnRecorderDidChangeAvailability(string data)
	{
	}

	private void OnSaveResult(string sourcesData)
	{
	}

	public void OnRecordDiscard(string data)
	{
	}
}
