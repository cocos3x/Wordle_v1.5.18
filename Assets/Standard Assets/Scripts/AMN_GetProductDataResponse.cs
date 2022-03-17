using System.Collections.Generic;

public class AMN_GetProductDataResponse : AMN_Result
{
	private string _requestId;

	private List<string> _unavailableSkus;

	private string _status;

	public string RequestId => "";

	public List<string> UnavailableSkus => null;

	public string Status => "";
}
