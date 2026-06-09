using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001578 RID: 5496
	[Token(Token = "0x2001578")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEA1C", Offset = "0x10EEA1C")]
	public class UIInstallmentMallItemController : UIMallItemWidgetController
	{
		// Token: 0x06005FC3 RID: 24515 RVA: 0x0001BB10 File Offset: 0x00019D10
		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0x190D5A4", Offset = "0x190D5A4", VA = "0x7BBC10D5A4")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0x190D5F4", Offset = "0x190D5F4", VA = "0x7BBC10D5F4", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x190D988", Offset = "0x190D988", VA = "0x7BBC10D988", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x190DAA0", Offset = "0x190DAA0", VA = "0x7BBC10DAA0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x190D858", Offset = "0x190D858", VA = "0x7BBC10D858")]
		private void SetPriceLabel()
		{
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x190D948", Offset = "0x190D948", VA = "0x7BBC10D948")]
		private void SetOverDueTitle()
		{
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x190DB94", Offset = "0x190DB94", VA = "0x7BBC10DB94", Slot = "44")]
		protected override void RefreshItemBGState()
		{
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x190DC68", Offset = "0x190DC68", VA = "0x7BBC10DC68", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x190DE24", Offset = "0x190DE24", VA = "0x7BBC10DE24", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x190E048", Offset = "0x190E048", VA = "0x7BBC10E048")]
		public UIInstallmentMallItemController()
		{
		}

		// Token: 0x0400802A RID: 32810
		[Token(Token = "0x400802A")]
		[FieldOffset(Offset = "0x228")]
		private InstallmentStoreDesc m_StoreItem;

		// Token: 0x0400802B RID: 32811
		[Token(Token = "0x400802B")]
		[FieldOffset(Offset = "0x230")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400802C RID: 32812
		[Token(Token = "0x400802C")]
		[FieldOffset(Offset = "0x238")]
		private bool m_IsOverDueItem;

		// Token: 0x0400802D RID: 32813
		[Token(Token = "0x400802D")]
		[FieldOffset(Offset = "0x240")]
		private Item m_Item;
	}
}
