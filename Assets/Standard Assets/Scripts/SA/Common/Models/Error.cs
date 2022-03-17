namespace SA.Common.Models
{
	public class Error
	{
		private int _Code;

		private string _Messgae;

		public int Code => 0;

		public string Message => "";

		public Error()
		{
		}

		public Error(int code, string message = "")
		{
		}

		public Error(string errorData)
		{
		}
	}
}
