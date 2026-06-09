using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001941 RID: 6465
	[Token(Token = "0x2001941")]
	public class UIHudRangeShopCatagoryItemController : UIEasyListItemController
	{
		// Token: 0x0600831E RID: 33566 RVA: 0x000239D0 File Offset: 0x00021BD0
		[Token(Token = "0x600831E")]
		[Address(RVA = "0x17E7AA4", Offset = "0x17E7AA4", VA = "0x7BBBFE7AA4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600831F")]
		[Address(RVA = "0x17E7AF4", Offset = "0x17E7AF4", VA = "0x7BBBFE7AF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008320")]
		[Address(RVA = "0x17E7BD8", Offset = "0x17E7BD8", VA = "0x7BBBFE7BD8", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06008321 RID: 33569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008321")]
		[Address(RVA = "0x17E7DA0", Offset = "0x17E7DA0", VA = "0x7BBBFE7DA0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06008322 RID: 33570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008322")]
		[Address(RVA = "0x17E7E44", Offset = "0x17E7E44", VA = "0x7BBBFE7E44", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008323")]
		[Address(RVA = "0x17E8134", Offset = "0x17E8134", VA = "0x7BBBFE8134")]
		public UIHudRangeShopCatagoryItemController()
		{
		}

		// Token: 0x0400941C RID: 37916
		[Token(Token = "0x400941C")]
		[FieldOffset(Offset = "0x70")]
		private UIHudRangeShopCatagoryItemView m_View;

		// Token: 0x0400941D RID: 37917
		[Token(Token = "0x400941D")]
		[FieldOffset(Offset = "0x78")]
		private ^eCDCeY catagory;

		// Token: 0x0400941E RID: 37918
		[Token(Token = "0x400941E")]
		[FieldOffset(Offset = "0x80")]
		private Color normalIconCol;

		// Token: 0x0400941F RID: 37919
		[Token(Token = "0x400941F")]
		[FieldOffset(Offset = "0x90")]
		private Color hlIconCol;
	}
}
