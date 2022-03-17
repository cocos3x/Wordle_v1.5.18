using System;
using System.Collections.Generic;

namespace SA.IOSDeploy
{
	[Serializable]
	public class Variable
	{
		public bool IsOpen;

		public bool IsListOpen;

		public string Name;

		public PlistValueTypes Type;

		public string StringValue;

		public int IntegerValue;

		public float FloatValue;

		public bool BooleanValue;

		public List<string> ChildrensIds;

		public void AddChild(Variable v)
		{
		}
	}
}
