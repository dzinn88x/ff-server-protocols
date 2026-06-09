using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001567 RID: 5479
	[Token(Token = "0x2001567")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE7E4", Offset = "0x10EE7E4")]
	public class UIExchangeMallPopWndItemController : UIMallItemWidgetController
	{
		// Token: 0x06005F38 RID: 24376 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[Token(Token = "0x6005F38")]
		[Address(RVA = "0x22723E0", Offset = "0x22723E0", VA = "0x7BBCA723E0")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F39")]
		[Address(RVA = "0x2272430", Offset = "0x2272430", VA = "0x7BBCA72430", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0x22726B8", Offset = "0x22726B8", VA = "0x7BBCA726B8")]
		private void SetExchangeIcon()
		{
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0x22727D0", Offset = "0x22727D0", VA = "0x7BBCA727D0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0x22728C4", Offset = "0x22728C4", VA = "0x7BBCA728C4", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0x22728CC", Offset = "0x22728CC", VA = "0x7BBCA728CC", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0x2272664", Offset = "0x2272664", VA = "0x7BBCA72664")]
		protected void SetExchangePriceLabel()
		{
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0x22728E0", Offset = "0x22728E0", VA = "0x7BBCA728E0", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F40")]
		[Address(RVA = "0x2272AA8", Offset = "0x2272AA8", VA = "0x7BBCA72AA8")]
		public UIExchangeMallPopWndItemController()
		{
		}

		// Token: 0x04007FEC RID: 32748
		[Token(Token = "0x4007FEC")]
		[FieldOffset(Offset = "0x228")]
		protected ExchangeStoreItemDesc m_ExchangeItem;
	}
}
