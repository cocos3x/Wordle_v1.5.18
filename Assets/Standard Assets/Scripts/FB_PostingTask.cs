public class FB_PostingTask : AsyncTask
{
	private string _toId;

	private string _link;

	private string _linkName;

	private string _linkCaption;

	private string _linkDescription;

	private string _picture;

	private string _actionName;

	private string _actionLink;

	private string _reference;

	public static FB_PostingTask Cretae()
	{
		return null;
	}

	public void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "")
	{
	}

	private void OnFBInited()
	{
	}

	private void OnFBAuth(FB_Result result)
	{
	}
}
