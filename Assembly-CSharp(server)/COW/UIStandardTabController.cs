using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001674 RID: 5748
	[Token(Token = "0x2001674")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0214", Offset = "0x10F0214")]
	public class UIStandardTabController : UIBaseController, IEasyList
	{
		// Token: 0x06006838 RID: 26680 RVA: 0x0001D928 File Offset: 0x0001BB28
		[Token(Token = "0x6006838")]
		[Address(RVA = "0x2131488", Offset = "0x2131488", VA = "0x7BBC931488")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006839")]
		[Address(RVA = "0x21314D8", Offset = "0x21314D8", VA = "0x7BBC9314D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683A")]
		public void RefreshEasyList<DataType>(List<DataType> dataList)
		{
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683B")]
		[Address(RVA = "0x2131598", Offset = "0x2131598", VA = "0x7BBC931598", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683C")]
		[Address(RVA = "0x21315C8", Offset = "0x21315C8", VA = "0x7BBC9315C8", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683D")]
		[Address(RVA = "0x213182C", Offset = "0x213182C", VA = "0x7BBC93182C")]
		public void UpdateBgState(bool value)
		{
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683E")]
		[Address(RVA = "0x213188C", Offset = "0x213188C", VA = "0x7BBC93188C")]
		public void OnItemClick(int index)
		{
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683F")]
		[Address(RVA = "0x2131900", Offset = "0x2131900", VA = "0x7BBC931900")]
		public void UpdatePanelDepth(int newDepth)
		{
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006840")]
		[Address(RVA = "0x21319C8", Offset = "0x21319C8", VA = "0x7BBC9319C8")]
		public UIStandardTabItemController GetTabItemControllerByIndex(int index, bool needScroll = true)
		{
			return null;
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006841")]
		[Address(RVA = "0x2131A54", Offset = "0x2131A54", VA = "0x7BBC931A54")]
		public void SelectTabItemByIndex(int index)
		{
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006842")]
		[Address(RVA = "0x2131AA0", Offset = "0x2131AA0", VA = "0x7BBC931AA0")]
		public UIStandardTabController()
		{
		}

		// Token: 0x04008521 RID: 34081
		[Token(Token = "0x4008521")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardTabView m_View;

		// Token: 0x04008522 RID: 34082
		[Token(Token = "0x4008522")]
		[FieldOffset(Offset = "0x60")]
		public Action<int> onItemClick;

		// Token: 0x04008523 RID: 34083
		[Token(Token = "0x4008523")]
		[FieldOffset(Offset = "0x68")]
		private int count;
	}
}
