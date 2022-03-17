using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class ISN_MediaController : Singleton<ISN_MediaController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__42_0(MP_MediaPickerResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__42_1(MP_MediaPickerResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__42_2(MP_MediaItem _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__42_3(MP_MusicPlaybackState _003Cp0_003E)
		{
		}
	}

	private MP_MediaItem _NowPlayingItem;

	private MP_MusicPlaybackState _State;

	private List<MP_MediaItem> _CurrentQueue;

	public MP_MediaItem NowPlayingItem => null;

	public List<MP_MediaItem> CurrentQueue => null;

	public MP_MusicPlaybackState State => (MP_MusicPlaybackState)null;

	public static event Action<MP_MediaPickerResult> ActionMediaPickerResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<MP_MediaPickerResult> ActionQueueUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<MP_MediaItem> ActionNowPlayingItemChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<MP_MusicPlaybackState> ActionPlaybackStateChanged
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

	public void SetRepeatMode(MP_MusicRepeatMode mode)
	{
	}

	public void SetShuffleMode(MP_MusicShuffleMode mode)
	{
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void SkipToNextItem()
	{
	}

	public void SkipToBeginning()
	{
	}

	public void SkipToPreviousItem()
	{
	}

	public void ShowMediaPicker()
	{
	}

	public void SetCollection(params MP_MediaItem[] items)
	{
	}

	public void AddItemWithProductID(string productID)
	{
	}

	public void SetCollection(params string[] itemIds)
	{
	}

	private List<MP_MediaItem> ParseMediaItemsList(string[] data, int index = 0)
	{
		return null;
	}

	private MP_MediaItem ParseMediaItemData(string[] data, int index)
	{
		return null;
	}

	private void OnQueueUpdate(string data)
	{
	}

	private void OnQueueUpdateFailed(string errorData)
	{
	}

	private void OnMediaPickerResult(string data)
	{
	}

	private void OnMediaPickerFailed(string errorData)
	{
	}

	private void OnNowPlayingItemchanged(string data)
	{
	}

	private void OnPlaybackStateChanged(string state)
	{
	}
}
