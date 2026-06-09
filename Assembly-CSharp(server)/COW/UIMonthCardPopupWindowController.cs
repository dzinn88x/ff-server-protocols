using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A7B RID: 6779
	[Token(Token = "0x2001A7B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8454", Offset = "0x10F8454")]
	public class UIMonthCardPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06008ECD RID: 36557 RVA: 0x00026130 File Offset: 0x00024330
		[Token(Token = "0x6008ECD")]
		[Address(RVA = "0x14C7EF8", Offset = "0x14C7EF8", VA = "0x7BBBCC7EF8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ECE")]
		[Address(RVA = "0x14C7F48", Offset = "0x14C7F48", VA = "0x7BBBCC7F48", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ECF")]
		[Address(RVA = "0x14C87A4", Offset = "0x14C87A4", VA = "0x7BBBCC87A4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED0")]
		[Address(RVA = "0x14C87E8", Offset = "0x14C87E8", VA = "0x7BBBCC87E8")]
		private void OnBtnRedeemClick()
		{
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED1")]
		[Address(RVA = "0x14C8B30", Offset = "0x14C8B30", VA = "0x7BBBCC8B30")]
		private void OnBtnPurchaseClick()
		{
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED2")]
		[Address(RVA = "0x14C8D70", Offset = "0x14C8D70", VA = "0x7BBBCC8D70")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED3")]
		[Address(RVA = "0x14C9878", Offset = "0x14C9878", VA = "0x7BBBCC9878")]
		private void OnTimeCountFinished()
		{
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x00026148 File Offset: 0x00024348
		[Token(Token = "0x6008ED4")]
		[Address(RVA = "0x14C9918", Offset = "0x14C9918", VA = "0x7BBBCC9918", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED5")]
		[Address(RVA = "0x14C995C", Offset = "0x14C995C", VA = "0x7BBBCC995C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008ED6 RID: 36566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED6")]
		[Address(RVA = "0x14C9CD8", Offset = "0x14C9CD8", VA = "0x7BBBCC9CD8")]
		public UIMonthCardPopupWindowController()
		{
		}

		// Token: 0x04009A5F RID: 39519
		[Token(Token = "0x4009A5F")]
		private const uint REDEEM_BTN_DEFAULT_COLOR = 4290380031U;

		// Token: 0x04009A60 RID: 39520
		[Token(Token = "0x4009A60")]
		private const uint REDEEM_BTN_GREY_COLOR = 2155905279U;

		// Token: 0x04009A61 RID: 39521
		[Token(Token = "0x4009A61")]
		private const uint REDEEM_BTN_TITLE_GREY_COLOR = 757935615U;

		// Token: 0x04009A62 RID: 39522
		[Token(Token = "0x4009A62")]
		private const uint REDEEM_BTN_TITLE_DEFAULT_COLOR = 2000686079U;

		// Token: 0x04009A63 RID: 39523
		[Token(Token = "0x4009A63")]
		[FieldOffset(Offset = "0x98")]
		private UIMonthCardPopupWindowView m_View;

		// Token: 0x04009A64 RID: 39524
		[Token(Token = "0x4009A64")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelRebateCard m_Model;
	}
}
