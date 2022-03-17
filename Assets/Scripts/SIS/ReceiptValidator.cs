using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Purchasing;

namespace SIS
{
	public class ReceiptValidator : MonoBehaviour
	{
		public VerificationType verificationType;

		public virtual bool shouldValidate(VerificationType verificationType)
		{
			return false;
		}

		public virtual void Validate([Optional] Product p)
		{
		}

		public virtual void Validate(string receipt)
		{
		}
	}
}
