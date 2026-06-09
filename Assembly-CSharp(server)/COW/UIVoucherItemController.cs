using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BFC RID: 7164
	[Token(Token = "0x2001BFC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB4D4", Offset = "0x10FB4D4")]
	public abstract class UIVoucherItemController : UIEasyListItemController
	{
		// Token: 0x06009BAB RID: 39851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAB")]
		[Address(RVA = "0x1684130", Offset = "0x1684130", VA = "0x7BBBE84130", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x06009BAC RID: 39852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAC")]
		[Address(RVA = "0x16843E0", Offset = "0x16843E0", VA = "0x7BBBE843E0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009BAD RID: 39853
		[Token(Token = "0x6009BAD")]
		public abstract void RefreshView();

		// Token: 0x06009BAE RID: 39854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAE")]
		[Address(RVA = "0x16844F0", Offset = "0x16844F0", VA = "0x7BBBE844F0")]
		public void SetVoucherData(uint itemGemsPrice, uint itemCoinsPrice, VoucherData selectedVoucher)
		{
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAF")]
		[Address(RVA = "0x16844FC", Offset = "0x16844FC", VA = "0x7BBBE844FC")]
		protected UIVoucherItemController()
		{
		}

		// Token: 0x0400A1E0 RID: 41440
		[Token(Token = "0x400A1E0")]
		[FieldOffset(Offset = "0x70")]
		protected EVoucherState m_State;

		// Token: 0x0400A1E1 RID: 41441
		[Token(Token = "0x400A1E1")]
		[FieldOffset(Offset = "0x78")]
		protected VoucherData m_Data;

		// Token: 0x0400A1E2 RID: 41442
		[Token(Token = "0x400A1E2")]
		[FieldOffset(Offset = "0x80")]
		protected uint m_ItemPrice;

		// Token: 0x0400A1E3 RID: 41443
		[Token(Token = "0x400A1E3")]
		[FieldOffset(Offset = "0x84")]
		protected uint m_ItemGemsPrice;

		// Token: 0x0400A1E4 RID: 41444
		[Token(Token = "0x400A1E4")]
		[FieldOffset(Offset = "0x88")]
		protected uint m_ItemCoinsPrice;

		// Token: 0x0400A1E5 RID: 41445
		[Token(Token = "0x400A1E5")]
		[FieldOffset(Offset = "0x90")]
		protected VoucherData m_SelectedVoucher;

		// Token: 0x0400A1E6 RID: 41446
		[Token(Token = "0x400A1E6")]
		protected const uint ITEM_GREY = 2139062271U;
	}
}
