using SA.Common.Models;
using System.Collections.Generic;

public class MP_MediaPickerResult : Result
{
	private List<MP_MediaItem> _SelectedmediaItems;

	public List<MP_MediaItem> SelectedmediaItems => null;

	public List<MP_MediaItem> Items => null;

	public MP_MediaPickerResult(List<MP_MediaItem> selectedItems)
	{
	}

	public MP_MediaPickerResult(string errorData)
	{
	}
}
