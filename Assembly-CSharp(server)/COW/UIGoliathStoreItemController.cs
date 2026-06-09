using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200138A RID: 5002
	[Token(Token = "0x200138A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB7F8", Offset = "0x10EB7F8")]
	public class UIGoliathStoreItemController : UIEasyListItemController
	{
		// Token: 0x0600509F RID: 20639 RVA: 0x00018768 File Offset: 0x00016968
		[Token(Token = "0x600509F")]
		[Address(RVA = "0x1A82874", Offset = "0x1A82874", VA = "0x7BBC282874")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x1A828C4", Offset = "0x1A828C4", VA = "0x7BBC2828C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x1A82A90", Offset = "0x1A82A90", VA = "0x7BBC282A90", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x1A82B40", Offset = "0x1A82B40", VA = "0x7BBC282B40")]
		private void SetAwardView()
		{
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A3")]
		[Address(RVA = "0x1A82CE4", Offset = "0x1A82CE4", VA = "0x7BBC282CE4")]
		private void SetTokenView()
		{
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x1A82E34", Offset = "0x1A82E34", VA = "0x7BBC282E34")]
		private void SetLimitView()
		{
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x1A83548", Offset = "0x1A83548", VA = "0x7BBC283548")]
		private void OnBtnCanBuyClick()
		{
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x1A83588", Offset = "0x1A83588", VA = "0x7BBC283588")]
		private void OnBtnSoldOutClick()
		{
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x1A83694", Offset = "0x1A83694", VA = "0x7BBC283694")]
		public UIGoliathStoreItemController()
		{
		}

		// Token: 0x04007715 RID: 30485
		[Token(Token = "0x4007715")]
		[FieldOffset(Offset = "0x70")]
		private UIGoliathStoreItemView m_View;

		// Token: 0x04007716 RID: 30486
		[Token(Token = "0x4007716")]
		[FieldOffset(Offset = "0x78")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04007717 RID: 30487
		[Token(Token = "0x4007717")]
		[FieldOffset(Offset = "0x80")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007718 RID: 30488
		[Token(Token = "0x4007718")]
		[FieldOffset(Offset = "0x88")]
		private BigEventStoreCommodityDesc m_Data;

		// Token: 0x04007719 RID: 30489
		[Token(Token = "0x4007719")]
		[FieldOffset(Offset = "0x90")]
		private UIStandardItemMiniController m_ItemCtrl;

		// Token: 0x0400771A RID: 30490
		[Token(Token = "0x400771A")]
		private const uint LABEL_COLOR_TOKEN_ENOUGH = 4294967295U;

		// Token: 0x0400771B RID: 30491
		[Token(Token = "0x400771B")]
		private const uint LABEL_COLOR_TOKEN_NOT_ENOUGH = 3048518911U;

		// Token: 0x0400771C RID: 30492
		[Token(Token = "0x400771C")]
		private const string BUY_BTN_SPRITE_ENABLED = "Goliath_bt_large_normal";

		// Token: 0x0400771D RID: 30493
		[Token(Token = "0x400771D")]
		private const string BUY_BTN_SPRITE_DISABLED = "Goliath_bt_large_disable";
	}
}
