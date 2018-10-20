namespace FiveMRcon
{
	public static class Util
	{
		public static bool _IsStringNull(this string text)
		{
			return text == null || text.Trim() == "";
		}
	}
}
