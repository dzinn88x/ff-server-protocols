using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AD2 RID: 6866
	[Token(Token = "0x2001AD2")]
	public class UIPaymentRebateCardController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
	{
		// Token: 0x06009105 RID: 37125 RVA: 0x00026AA8 File Offset: 0x00024CA8
		[Token(Token = "0x6009105")]
		[Address(RVA = "0x1F2C468", Offset = "0x1F2C468", VA = "0x7BBC72C468")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009106")]
		[Address(RVA = "0x1F2C4B8", Offset = "0x1F2C4B8", VA = "0x7BBC72C4B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009107")]
		[Address(RVA = "0x1F2C894", Offset = "0x1F2C894", VA = "0x7BBC72C894")]
		private void OnGetCDNAD(params object[] data)
		{
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009108")]
		[Address(RVA = "0x1F2CD60", Offset = "0x1F2CD60", VA = "0x7BBC72CD60")]
		private void UpdateRebateCards()
		{
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009109")]
		[Address(RVA = "0x1F2D4E8", Offset = "0x1F2D4E8", VA = "0x7BBC72D4E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600910A")]
		[Address(RVA = "0x1F2D5CC", Offset = "0x1F2D5CC", VA = "0x7BBC72D5CC")]
		private void OnNotifyCheckboxChange()
		{
		}

		// Token: 0x0600910B RID: 37131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600910B")]
		[Address(RVA = "0x1F2D62C", Offset = "0x1F2D62C", VA = "0x7BBC72D62C", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x00026AC0 File Offset: 0x00024CC0
		[Token(Token = "0x600910C")]
		[Address(RVA = "0x1F2D778", Offset = "0x1F2D778", VA = "0x7BBC72D778", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600910D")]
		[Address(RVA = "0x1F2D7BC", Offset = "0x1F2D7BC", VA = "0x7BBC72D7BC", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600910E RID: 37134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600910E")]
		[Address(RVA = "0x1F2D8E4", Offset = "0x1F2D8E4", VA = "0x7BBC72D8E4")]
		public UIPaymentRebateCardController()
		{
		}

		// Token: 0x0600910F RID: 37135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600910F")]
		[Address(RVA = "0x1F2D8EC", Offset = "0x1F2D8EC", VA = "0x7BBC72D8EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114495C", Offset = "0x114495C")]
		private void <OnGetCDNAD>b__10_0(Texture nt)
		{
		}

		// Token: 0x06009110 RID: 37136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009110")]
		[Address(RVA = "0x1F2D990", Offset = "0x1F2D990", VA = "0x7BBC72D990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114496C", Offset = "0x114496C")]
		private void <OnGetCDNAD>b__10_1(Texture nt)
		{
		}

		// Token: 0x04009C73 RID: 40051
		[Token(Token = "0x4009C73")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentRebateCardView m_View;

		// Token: 0x04009C74 RID: 40052
		[Token(Token = "0x4009C74")]
		private const uint REDEEM_BTN_DEFAULT_COLOR = 4290380031U;

		// Token: 0x04009C75 RID: 40053
		[Token(Token = "0x4009C75")]
		private const uint REDEEM_BTN_GREY_COLOR = 2155905279U;

		// Token: 0x04009C76 RID: 40054
		[Token(Token = "0x4009C76")]
		private const uint REDEEM_BTN_TITLE_GREY_COLOR = 757935615U;

		// Token: 0x04009C77 RID: 40055
		[Token(Token = "0x4009C77")]
		private const uint REDEEM_BTN_TITLE_DEFAULT_COLOR = 2000686079U;

		// Token: 0x04009C78 RID: 40056
		[Token(Token = "0x4009C78")]
		[FieldOffset(Offset = "0x60")]
		private UIModelRebateCard m_RebateCard;

		// Token: 0x04009C79 RID: 40057
		[Token(Token = "0x4009C79")]
		[FieldOffset(Offset = "0x68")]
		private UIRebateCardItemController m_MonthCardItemController;

		// Token: 0x04009C7A RID: 40058
		[Token(Token = "0x4009C7A")]
		[FieldOffset(Offset = "0x70")]
		private UIRebateCardItemController m_WeekCardItemController;
	}
}
