using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AD7 RID: 6871
	[Token(Token = "0x2001AD7")]
	public class UIPaymentSubscriptionHubController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
	{
		// Token: 0x06009152 RID: 37202 RVA: 0x00026BB0 File Offset: 0x00024DB0
		[Token(Token = "0x6009152")]
		[Address(RVA = "0x1F32A3C", Offset = "0x1F32A3C", VA = "0x7BBC732A3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009153 RID: 37203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009153")]
		[Address(RVA = "0x1F32A8C", Offset = "0x1F32A8C", VA = "0x7BBC732A8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009154 RID: 37204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009154")]
		[Address(RVA = "0x1F32C6C", Offset = "0x1F32C6C", VA = "0x7BBC732C6C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009155")]
		[Address(RVA = "0x1F32D60", Offset = "0x1F32D60", VA = "0x7BBC732D60")]
		private void ClearSubscriptionUIs()
		{
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009156")]
		[Address(RVA = "0x1F33060", Offset = "0x1F33060", VA = "0x7BBC733060", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[Token(Token = "0x6009157")]
		[Address(RVA = "0x1F330A4", Offset = "0x1F330A4", VA = "0x7BBC7330A4", Slot = "31")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009158")]
		[Address(RVA = "0x1F33128", Offset = "0x1F33128", VA = "0x7BBC733128", Slot = "30")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009159")]
		[Address(RVA = "0x1F336B0", Offset = "0x1F336B0", VA = "0x7BBC7336B0", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600915A")]
		[Address(RVA = "0x1F336B4", Offset = "0x1F336B4", VA = "0x7BBC7336B4", Slot = "28")]
		public override void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
		{
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600915B")]
		[Address(RVA = "0x1F331CC", Offset = "0x1F331CC", VA = "0x7BBC7331CC")]
		private void UpdateSubscriptionItems()
		{
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600915C")]
		[Address(RVA = "0x1F34040", Offset = "0x1F34040", VA = "0x7BBC734040")]
		private void OnSubscriptionGoto(params object[] parameters)
		{
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600915D")]
		[Address(RVA = "0x1F33848", Offset = "0x1F33848", VA = "0x7BBC733848")]
		private void Goto(UIPaymentSubscriptionHubController.DisplayInfo info)
		{
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600915E")]
		[Address(RVA = "0x1F34158", Offset = "0x1F34158", VA = "0x7BBC734158")]
		private UIPaymentSubscriptionBaseController ContentUI(UIPaymentSubscriptionHubController.DisplayType displayType)
		{
			return null;
		}

		// Token: 0x0600915F RID: 37215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600915F")]
		[Address(RVA = "0x1F342B4", Offset = "0x1F342B4", VA = "0x7BBC7342B4")]
		public UIPaymentSubscriptionHubController()
		{
		}

		// Token: 0x04009C83 RID: 40067
		[Token(Token = "0x4009C83")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentSubscriptionHubView m_View;

		// Token: 0x04009C84 RID: 40068
		[Token(Token = "0x4009C84")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPayment m_Payment;

		// Token: 0x04009C85 RID: 40069
		[Token(Token = "0x4009C85")]
		[FieldOffset(Offset = "0x68")]
		private UIModelRebateCard m_RebateCard;

		// Token: 0x04009C86 RID: 40070
		[Token(Token = "0x4009C86")]
		[FieldOffset(Offset = "0x70")]
		private UIModelElitePass m_ElitePass;

		// Token: 0x04009C87 RID: 40071
		[Token(Token = "0x4009C87")]
		[FieldOffset(Offset = "0x78")]
		private List<UIPaymentSubscriptionItemController> m_Items;

		// Token: 0x04009C88 RID: 40072
		[Token(Token = "0x4009C88")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<UIPaymentSubscriptionHubController.DisplayType, UIPaymentSubscriptionBaseController> m_Contents;

		// Token: 0x02001AD8 RID: 6872
		[Token(Token = "0x2001AD8")]
		public enum DisplayType
		{
			// Token: 0x04009C8A RID: 40074
			[Token(Token = "0x4009C8A")]
			None,
			// Token: 0x04009C8B RID: 40075
			[Token(Token = "0x4009C8B")]
			RebateCard,
			// Token: 0x04009C8C RID: 40076
			[Token(Token = "0x4009C8C")]
			ElitePass,
			// Token: 0x04009C8D RID: 40077
			[Token(Token = "0x4009C8D")]
			Bundle
		}

		// Token: 0x02001AD9 RID: 6873
		[Token(Token = "0x2001AD9")]
		public struct DisplayInfo
		{
			// Token: 0x04009C8E RID: 40078
			[Token(Token = "0x4009C8E")]
			[FieldOffset(Offset = "0x0")]
			public UIPaymentSubscriptionHubController.DisplayType Type;

			// Token: 0x04009C8F RID: 40079
			[Token(Token = "0x4009C8F")]
			[FieldOffset(Offset = "0x4")]
			public int BundleID;
		}
	}
}
