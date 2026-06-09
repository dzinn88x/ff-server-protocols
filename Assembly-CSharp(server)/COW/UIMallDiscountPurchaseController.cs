using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001594 RID: 5524
	[Token(Token = "0x2001594")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EECFC", Offset = "0x10EECFC")]
	public class UIMallDiscountPurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x060060DD RID: 24797 RVA: 0x0001BF00 File Offset: 0x0001A100
		[Token(Token = "0x60060DD")]
		[Address(RVA = "0x1C6C0E8", Offset = "0x1C6C0E8", VA = "0x7BBC46C0E8")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x1C6C138", Offset = "0x1C6C138", VA = "0x7BBC46C138", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x1C6C308", Offset = "0x1C6C308", VA = "0x7BBC46C308")]
		private void OnGemsPurchaseBtnClick()
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E0")]
		[Address(RVA = "0x1C6C444", Offset = "0x1C6C444", VA = "0x7BBC46C444")]
		private void OnGoldPurchaseBtnClick()
		{
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E1")]
		[Address(RVA = "0x1C6C310", Offset = "0x1C6C310", VA = "0x7BBC46C310")]
		private void PurchaseDiscountItem(EInventory.CurrencyType currencyType)
		{
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E2")]
		[Address(RVA = "0x1C6C44C", Offset = "0x1C6C44C", VA = "0x7BBC46C44C")]
		public void RefreshData(DiscountStoreDesc discountStoreDesc, bool showVoucherContainer = false)
		{
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E3")]
		[Address(RVA = "0x1C6C740", Offset = "0x1C6C740", VA = "0x7BBC46C740")]
		private void SetPriceData()
		{
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E4")]
		[Address(RVA = "0x1C6C8FC", Offset = "0x1C6C8FC", VA = "0x7BBC46C8FC")]
		public UIMallDiscountPurchaseController()
		{
		}

		// Token: 0x040080D2 RID: 32978
		[Token(Token = "0x40080D2")]
		[FieldOffset(Offset = "0xD8")]
		private DiscountStoreDesc m_DiscountStoreDesc;
	}
}
