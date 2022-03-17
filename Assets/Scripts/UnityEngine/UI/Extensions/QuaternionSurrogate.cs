using System.Runtime.Serialization;

namespace UnityEngine.UI.Extensions
{
	public sealed class QuaternionSurrogate : ISerializationSurrogate
	{
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
		}

		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			return null;
		}
	}
}
