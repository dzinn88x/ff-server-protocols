using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200157C RID: 5500
	[Token(Token = "0x200157C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEAFC", Offset = "0x10EEAFC")]
	public class UIInstallmentMallPurchaseItemController : UIEasyListItemController
	{
		// Token: 0x06005FE4 RID: 24548 RVA: 0x0001BB70 File Offset: 0x00019D70
		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0x190EC24", Offset = "0x190EC24", VA = "0x7BBC10EC24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0x190EC74", Offset = "0x190EC74", VA = "0x7BBC10EC74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0x190ED30", Offset = "0x190ED30", VA = "0x7BBC10ED30")]
		private void InitTerm()
		{
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0x190EE00", Offset = "0x190EE00", VA = "0x7BBC10EE00", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0x190EEC4", Offset = "0x190EEC4", VA = "0x7BBC10EEC4")]
		private void RefreshView()
		{
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0x190F440", Offset = "0x190F440", VA = "0x7BBC10F440")]
		public UIInstallmentMallPurchaseItemController()
		{
		}

		// Token: 0x04008034 RID: 32820
		[Token(Token = "0x4008034")]
		[FieldOffset(Offset = "0x70")]
		private UIInstallmentMallPurchaseItemView m_View;

		// Token: 0x04008035 RID: 32821
		[Token(Token = "0x4008035")]
		[FieldOffset(Offset = "0x78")]
		private InstallmentStoreDesc m_StoreDesc;

		// Token: 0x04008036 RID: 32822
		[Token(Token = "0x4008036")]
		[FieldOffset(Offset = "0x80")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04008037 RID: 32823
		[Token(Token = "0x4008037")]
		[FieldOffset(Offset = "0x88")]
		private Item m_Item;

		// Token: 0x04008038 RID: 32824
		[Token(Token = "0x4008038")]
		[FieldOffset(Offset = "0x90")]
		private int m_Index;

		// Token: 0x04008039 RID: 32825
		[Token(Token = "0x4008039")]
		[FieldOffset(Offset = "0x98")]
		private UIInstallmentMallPurchaseItemController.Term m_Term;

		// Token: 0x0400803A RID: 32826
		[Token(Token = "0x400803A")]
		[FieldOffset(Offset = "0xA0")]
		private UIInstallmentMallPurchaseItemController.FirstTerm m_FirstTerm;

		// Token: 0x0400803B RID: 32827
		[Token(Token = "0x400803B")]
		[FieldOffset(Offset = "0xA8")]
		private UIInstallmentMallPurchaseItemController.NormalTerm m_NormalTerm;

		// Token: 0x0400803C RID: 32828
		[Token(Token = "0x400803C")]
		[FieldOffset(Offset = "0xB0")]
		private UIInstallmentMallPurchaseItemController.LastTerm m_LastTerm;

		// Token: 0x0200157D RID: 5501
		[Token(Token = "0x200157D")]
		private class Term
		{
			// Token: 0x06005FEA RID: 24554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FEA")]
			[Address(RVA = "0x190EF80", Offset = "0x190EF80", VA = "0x7BBC10EF80")]
			public void SetData(UIInstallmentMallPurchaseItemView view, InstallmentStoreDesc desc, Item item, int index)
			{
			}

			// Token: 0x06005FEB RID: 24555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FEB")]
			[Address(RVA = "0x190F07C", Offset = "0x190F07C", VA = "0x7BBC10F07C")]
			public void RefreshView()
			{
			}

			// Token: 0x06005FEC RID: 24556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FEC")]
			[Address(RVA = "0x190FD50", Offset = "0x190FD50", VA = "0x7BBC10FD50", Slot = "4")]
			protected virtual void OnRefreshView()
			{
			}

			// Token: 0x06005FED RID: 24557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FED")]
			[Address(RVA = "0x190FBAC", Offset = "0x190FBAC", VA = "0x7BBC10FBAC")]
			private void HideUI()
			{
			}

			// Token: 0x06005FEE RID: 24558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FEE")]
			[Address(RVA = "0x190F604", Offset = "0x190F604", VA = "0x7BBC10F604")]
			public Term()
			{
			}

			// Token: 0x0400803D RID: 32829
			[Token(Token = "0x400803D")]
			[FieldOffset(Offset = "0x10")]
			protected UIInstallmentMallPurchaseItemView m_View;

			// Token: 0x0400803E RID: 32830
			[Token(Token = "0x400803E")]
			[FieldOffset(Offset = "0x18")]
			protected InstallmentStoreDesc m_Desc;

			// Token: 0x0400803F RID: 32831
			[Token(Token = "0x400803F")]
			[FieldOffset(Offset = "0x20")]
			protected Item m_Item;

			// Token: 0x04008040 RID: 32832
			[Token(Token = "0x4008040")]
			[FieldOffset(Offset = "0x28")]
			protected UIModelMall m_ModelMall;

			// Token: 0x04008041 RID: 32833
			[Token(Token = "0x4008041")]
			[FieldOffset(Offset = "0x30")]
			protected int m_Index;

			// Token: 0x04008042 RID: 32834
			[Token(Token = "0x4008042")]
			[FieldOffset(Offset = "0x34")]
			protected bool m_IsCurrentTerm;

			// Token: 0x04008043 RID: 32835
			[Token(Token = "0x4008043")]
			[FieldOffset(Offset = "0x35")]
			protected bool m_IsPreviousTerm;

			// Token: 0x04008044 RID: 32836
			[Token(Token = "0x4008044")]
			[FieldOffset(Offset = "0x38")]
			protected uint m_CurrentTerm;

			// Token: 0x04008045 RID: 32837
			[Token(Token = "0x4008045")]
			private const uint TERMLOCKCOLOR = 3154116863U;

			// Token: 0x04008046 RID: 32838
			[Token(Token = "0x4008046")]
			private const uint TERMNORMALCOLOR = 4139391487U;
		}

		// Token: 0x0200157E RID: 5502
		[Token(Token = "0x200157E")]
		private class FirstTerm : UIInstallmentMallPurchaseItemController.Term
		{
			// Token: 0x06005FEF RID: 24559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FEF")]
			[Address(RVA = "0x190F448", Offset = "0x190F448", VA = "0x7BBC10F448", Slot = "4")]
			protected override void OnRefreshView()
			{
			}

			// Token: 0x06005FF0 RID: 24560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FF0")]
			[Address(RVA = "0x190EDE8", Offset = "0x190EDE8", VA = "0x7BBC10EDE8")]
			public FirstTerm()
			{
			}
		}

		// Token: 0x0200157F RID: 5503
		[Token(Token = "0x200157F")]
		private class NormalTerm : UIInstallmentMallPurchaseItemController.Term
		{
			// Token: 0x06005FF1 RID: 24561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FF1")]
			[Address(RVA = "0x190F900", Offset = "0x190F900", VA = "0x7BBC10F900", Slot = "4")]
			protected override void OnRefreshView()
			{
			}

			// Token: 0x06005FF2 RID: 24562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FF2")]
			[Address(RVA = "0x190EDF0", Offset = "0x190EDF0", VA = "0x7BBC10EDF0")]
			public NormalTerm()
			{
			}
		}

		// Token: 0x02001580 RID: 5504
		[Token(Token = "0x2001580")]
		private class LastTerm : UIInstallmentMallPurchaseItemController.Term
		{
			// Token: 0x06005FF3 RID: 24563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FF3")]
			[Address(RVA = "0x190F60C", Offset = "0x190F60C", VA = "0x7BBC10F60C", Slot = "4")]
			protected override void OnRefreshView()
			{
			}

			// Token: 0x06005FF4 RID: 24564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FF4")]
			[Address(RVA = "0x190EDF8", Offset = "0x190EDF8", VA = "0x7BBC10EDF8")]
			public LastTerm()
			{
			}
		}
	}
}
