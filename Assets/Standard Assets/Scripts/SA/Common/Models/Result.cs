namespace SA.Common.Models
{
	public class Result
	{
		protected Error _Error;

		public Error Error => null;

		public bool HasError => false;

		public bool IsSucceeded => false;

		public bool IsFailed => false;

		public Result()
		{
		}

		public Result(Error error)
		{
		}
	}
}
