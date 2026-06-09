using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200157B RID: 5499
	[Token(Token = "0x200157B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEAC4", Offset = "0x10EEAC4")]
	public class UIInstallmentMallPurchaseController : UIPopupWindowController
	{
		// Token: 0x06005FDD RID: 24541 RVA: 0x0001BB58 File Offset: 0x00019D58
		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0x190CD90", Offset = "0x190CD90", VA = "0x7BBC10CD90")]
		public static ResourceID UIResource()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0x190CFD4", Offset = "0x190CFD4", VA = "0x7BBC10CFD4")]
		protected object GetView()
		{
			return null;
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0x190CF1C", Offset = "0x190CF1C", VA = "0x7BBC10CF1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0x190D220", Offset = "0x190D220", VA = "0x7BBC10D220")]
		protected void RefreshTermList()
		{
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0x190D21C", Offset = "0x190D21C", VA = "0x7BBC10D21C", Slot = "40")]
		protected virtual void RefreshView()
		{
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0x190EB48", Offset = "0x190EB48", VA = "0x7BBC10EB48")]
		private void RefreshCDNBG()
		{
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0x190D59C", Offset = "0x190D59C", VA = "0x7BBC10D59C")]
		public UIInstallmentMallPurchaseController()
		{
		}

		// Token: 0x04008030 RID: 32816
		[Token(Token = "0x4008030")]
		[FieldOffset(Offset = "0x98")]
		private UIInstallmentMallPurchaseView m_View;

		// Token: 0x04008031 RID: 32817
		[Token(Token = "0x4008031")]
		[FieldOffset(Offset = "0xA0")]
		protected UIModelMall m_ModelMall;

		// Token: 0x04008032 RID: 32818
		[Token(Token = "0x4008032")]
		[FieldOffset(Offset = "0xA8")]
		protected InstallmentStoreDesc m_ItemDesc;

		// Token: 0x04008033 RID: 32819
		[Token(Token = "0x4008033")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelCDNAd m_ModelCDNAd;
	}
}
