using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ABC RID: 6844
	[Token(Token = "0x2001ABC")]
	public class UIPaymentBundleTopItemController : UIBaseController
	{
		// Token: 0x0600906E RID: 36974 RVA: 0x000267C0 File Offset: 0x000249C0
		[Token(Token = "0x600906E")]
		[Address(RVA = "0x16FB088", Offset = "0x16FB088", VA = "0x7BBBEFB088")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600906F")]
		[Address(RVA = "0x16FB0D8", Offset = "0x16FB0D8", VA = "0x7BBBEFB0D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009070 RID: 36976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009070")]
		[Address(RVA = "0x16F26F4", Offset = "0x16F26F4", VA = "0x7BBBEF26F4")]
		public void SetViewData(UIPaymentSpecialStoreItemData data)
		{
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009071")]
		[Address(RVA = "0x16FB1BC", Offset = "0x16FB1BC", VA = "0x7BBBEFB1BC")]
		private void CheckTips()
		{
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009072")]
		[Address(RVA = "0x16FB288", Offset = "0x16FB288", VA = "0x7BBBEFB288")]
		public void OnButtonClick()
		{
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009073")]
		[Address(RVA = "0x16F2E08", Offset = "0x16F2E08", VA = "0x7BBBEF2E08")]
		public void OnItemBtnSelect()
		{
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009074")]
		[Address(RVA = "0x16F31F4", Offset = "0x16F31F4", VA = "0x7BBBEF31F4")]
		public void OnItemUnSelect()
		{
		}

		// Token: 0x06009075 RID: 36981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009075")]
		[Address(RVA = "0x16FB32C", Offset = "0x16FB32C", VA = "0x7BBBEFB32C")]
		public UIPaymentBundleTopItemController()
		{
		}

		// Token: 0x04009C1A RID: 39962
		[Token(Token = "0x4009C1A")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentBundleTopItemView m_View;

		// Token: 0x04009C1B RID: 39963
		[Token(Token = "0x4009C1B")]
		[FieldOffset(Offset = "0x60")]
		private UIPaymentSpecialStoreItemData m_Data;

		// Token: 0x04009C1C RID: 39964
		[Token(Token = "0x4009C1C")]
		[FieldOffset(Offset = "0x68")]
		private ETipsType m_type;

		// Token: 0x04009C1D RID: 39965
		[Token(Token = "0x4009C1D")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<EStore.PbwActivityType, string[]> m_Icons;
	}
}
