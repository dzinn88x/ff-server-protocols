using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001713 RID: 5907
	[Token(Token = "0x2001713")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F168C", Offset = "0x10F168C")]
	public class UIClanApplyListController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006E23 RID: 28195 RVA: 0x0001F050 File Offset: 0x0001D250
		[Token(Token = "0x6006E23")]
		[Address(RVA = "0x1BF8AFC", Offset = "0x1BF8AFC", VA = "0x7BBC3F8AFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E24")]
		[Address(RVA = "0x1BF8B4C", Offset = "0x1BF8B4C", VA = "0x7BBC3F8B4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x1BF8D08", Offset = "0x1BF8D08", VA = "0x7BBC3F8D08", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0x1BF8DE8", Offset = "0x1BF8DE8", VA = "0x7BBC3F8DE8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E27")]
		private void RefreshViewData<DataType>(List<DataType> memberList)
		{
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x0001F068 File Offset: 0x0001D268
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0x1BF8EF0", Offset = "0x1BF8EF0", VA = "0x7BBC3F8EF0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E29")]
		[Address(RVA = "0x1BF8F34", Offset = "0x1BF8F34", VA = "0x7BBC3F8F34", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2A")]
		[Address(RVA = "0x1BF8FC8", Offset = "0x1BF8FC8", VA = "0x7BBC3F8FC8", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2B")]
		[Address(RVA = "0x1BF8FF8", Offset = "0x1BF8FF8", VA = "0x7BBC3F8FF8")]
		public UIClanApplyListController()
		{
		}

		// Token: 0x040088E4 RID: 35044
		[Token(Token = "0x40088E4")]
		[FieldOffset(Offset = "0x98")]
		private UIClanApplyListView m_View;
	}
}
