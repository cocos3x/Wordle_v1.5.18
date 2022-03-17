namespace SA.Fitness
{
	public sealed class LoginScope
	{
		public static LoginScope SCOPE_ACTIVITY_READ;

		public static LoginScope SCOPE_ACTIVITY_READ_WRITE;

		public static LoginScope SCOPE_LOCATION_READ;

		public static LoginScope SCOPE_LOCATION_READ_WRITE;

		public static LoginScope SCOPE_BODY_READ;

		public static LoginScope SCOPE_BODY_READ_WRITE;

		public static LoginScope SCOPE_NUTRITION_READ;

		public static LoginScope SCOPE_NUTRITION_READ_WRITE;

		private string value;

		public string Value => "";

		private LoginScope()
		{
		}

		private LoginScope(string scope)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
