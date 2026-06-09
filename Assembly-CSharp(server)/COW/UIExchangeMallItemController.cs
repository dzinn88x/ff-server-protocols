using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001565 RID: 5477
	[Token(Token = "0x2001565")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE774", Offset = "0x10EE774")]
	public class UIExchangeMallItemController : UIMallItemWidgetController
	{
		// Token: 0x06005F1B RID: 24347 RVA: 0x0001B870 File Offset: 0x00019A70
		[Token(Token = "0x6005F1B")]
		[Address(RVA = "0x22701D0", Offset = "0x22701D0", VA = "0x7BBCA701D0")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0x2270220", Offset = "0x2270220", VA = "0x7BBCA70220", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0x22704A8", Offset = "0x22704A8", VA = "0x7BBCA704A8")]
		private void SetExchangeIcon()
		{
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1E")]
		[Address(RVA = "0x22705C0", Offset = "0x22705C0", VA = "0x7BBCA705C0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0x22706B4", Offset = "0x22706B4", VA = "0x7BBCA706B4", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F20")]
		[Address(RVA = "0x22706BC", Offset = "0x22706BC", VA = "0x7BBCA706BC", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F21")]
		[Address(RVA = "0x2270454", Offset = "0x2270454", VA = "0x7BBCA70454")]
		protected void SetExchangePriceLabel()
		{
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F22")]
		[Address(RVA = "0x22706D0", Offset = "0x22706D0", VA = "0x7BBCA706D0", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F23")]
		[Address(RVA = "0x227088C", Offset = "0x227088C", VA = "0x7BBCA7088C", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x2270A48", Offset = "0x2270A48", VA = "0x7BBCA70A48")]
		public UIExchangeMallItemController()
		{
		}

		// Token: 0x04007FE3 RID: 32739
		[Token(Token = "0x4007FE3")]
		[FieldOffset(Offset = "0x228")]
		protected ExchangeStoreItemDesc m_ExchangeItem;
	}
}
