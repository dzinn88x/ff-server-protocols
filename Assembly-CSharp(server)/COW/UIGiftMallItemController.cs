using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001576 RID: 5494
	[Token(Token = "0x2001576")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE9AC", Offset = "0x10EE9AC")]
	public class UIGiftMallItemController : UIMallItemWidgetController
	{
		// Token: 0x06005FAE RID: 24494 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x1A6D040", Offset = "0x1A6D040", VA = "0x7BBC26D040")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x1A6D090", Offset = "0x1A6D090", VA = "0x7BBC26D090", Slot = "36")]
		protected override void OnClothItemClick()
		{
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x1A6D154", Offset = "0x1A6D154", VA = "0x7BBC26D154", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x1A6D310", Offset = "0x1A6D310", VA = "0x7BBC26D310", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x1A6D4E4", Offset = "0x1A6D4E4", VA = "0x7BBC26D4E4")]
		private void SetPriceLabel(uint gemsPrice, uint coinsPrice)
		{
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x1A6D6BC", Offset = "0x1A6D6BC", VA = "0x7BBC26D6BC", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x1A6D714", Offset = "0x1A6D714", VA = "0x7BBC26D714", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0x1A6D808", Offset = "0x1A6D808", VA = "0x7BBC26D808", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x1A6D810", Offset = "0x1A6D810", VA = "0x7BBC26D810", Slot = "44")]
		protected override void RefreshItemBGState()
		{
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x1A6D8D4", Offset = "0x1A6D8D4", VA = "0x7BBC26D8D4", Slot = "47")]
		protected override void OnStartToggleMove()
		{
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x1A6D924", Offset = "0x1A6D924", VA = "0x7BBC26D924", Slot = "48")]
		protected override void OnFinishToggleMove()
		{
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x1A6D974", Offset = "0x1A6D974", VA = "0x7BBC26D974")]
		public void HideEffect()
		{
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x1A6D9B8", Offset = "0x1A6D9B8", VA = "0x7BBC26D9B8")]
		public UIGiftMallItemController()
		{
		}

		// Token: 0x04008028 RID: 32808
		[Token(Token = "0x4008028")]
		[FieldOffset(Offset = "0x228")]
		private GiftItem m_GiftItem;
	}
}
