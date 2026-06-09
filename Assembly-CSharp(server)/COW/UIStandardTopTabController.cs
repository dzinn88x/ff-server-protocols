using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001677 RID: 5751
	[Token(Token = "0x2001677")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0284", Offset = "0x10F0284")]
	public class UIStandardTopTabController : UIBaseController, IEasyList
	{
		// Token: 0x0600685C RID: 26716 RVA: 0x0001D988 File Offset: 0x0001BB88
		[Token(Token = "0x600685C")]
		[Address(RVA = "0x2133918", Offset = "0x2133918", VA = "0x7BBC933918")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685D")]
		[Address(RVA = "0x2133968", Offset = "0x2133968", VA = "0x7BBC933968", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685E")]
		public void RefreshEasyList<DataType>(List<DataType> dataList)
		{
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685F")]
		[Address(RVA = "0x2133D9C", Offset = "0x2133D9C", VA = "0x7BBC933D9C")]
		public void OnItemClick(int index)
		{
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006860")]
		[Address(RVA = "0x2133E10", Offset = "0x2133E10", VA = "0x7BBC933E10", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006861")]
		[Address(RVA = "0x2133E40", Offset = "0x2133E40", VA = "0x7BBC933E40", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006862")]
		[Address(RVA = "0x2133F58", Offset = "0x2133F58", VA = "0x7BBC933F58")]
		public UIButton GetBtnClose()
		{
			return null;
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006863")]
		[Address(RVA = "0x2133F84", Offset = "0x2133F84", VA = "0x7BBC933F84")]
		public void UpdatePanelDepth(int newDepth)
		{
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006864")]
		[Address(RVA = "0x21340F0", Offset = "0x21340F0", VA = "0x7BBC9340F0")]
		public UIStandardTopTabItemController GetTabItemControllerByIndex(int index)
		{
			return null;
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006865")]
		[Address(RVA = "0x2134178", Offset = "0x2134178", VA = "0x7BBC934178")]
		public void SelectTabItemByIndex(int index)
		{
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006866")]
		[Address(RVA = "0x21341C4", Offset = "0x21341C4", VA = "0x7BBC9341C4")]
		public UIStandardTopTabController()
		{
		}

		// Token: 0x04008533 RID: 34099
		[Token(Token = "0x4008533")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardTopTabView m_View;

		// Token: 0x04008534 RID: 34100
		[Token(Token = "0x4008534")]
		[FieldOffset(Offset = "0x60")]
		public Action<int> onItemClick;

		// Token: 0x04008535 RID: 34101
		[Token(Token = "0x4008535")]
		[FieldOffset(Offset = "0x68")]
		private int count;
	}
}
