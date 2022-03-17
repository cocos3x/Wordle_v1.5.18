using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

namespace SIS
{
	[Serializable]
	public class IAPObject
	{
		public string id;

		public List<StoreID> storeIDs;

		public ProductType type;

		public string title;

		public string description;

		public string realPrice;

		public bool fetch;

		public Sprite icon;

		public int usageCount;

		public List<IAPCurrency> virtualPrice;

		public IAPRequirement req;

		public IAPType editorType;

		public bool platformFoldout;

		public bool onSale;

		public IDs GetIDs()
		{
			return null;
		}
	}
}
