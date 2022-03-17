using SA.Common.Models;
using System.Collections.Generic;

namespace SA.Fitness
{
	public class StopSessionResult : Result
	{
		private List<Session> sessions;

		private int id;

		public int Id => 0;

		public List<Session> Sessions => null;

		public StopSessionResult(int id)
		{
		}

		public StopSessionResult(int id, int resultCode, string message)
		{
		}

		public void AddSession(Session session)
		{
		}
	}
}
