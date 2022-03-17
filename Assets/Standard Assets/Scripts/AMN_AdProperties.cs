public class AMN_AdProperties
{
	private bool _canExpand;

	private bool _canPlayAudio;

	private bool _canPlayVideo;

	private string _adtype;

	public bool CanExpand
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanPlayAudio
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanPlayVideo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string Adtype
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public AMN_AdProperties(bool canExpand, bool canPlayAudio, bool canPlayVideo, string adtype)
	{
	}
}
