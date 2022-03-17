namespace SA.Common.Pattern
{
	public abstract class NonMonoSingleton<T> where T : NonMonoSingleton<T>, new()
	{
		private static T _Instance;

		public static T Instance => null;
	}
}
