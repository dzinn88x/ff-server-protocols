using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015A5 RID: 5541
	[Token(Token = "0x20015A5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEF6C", Offset = "0x10EEF6C")]
	public class UIMallPurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x06006180 RID: 24960 RVA: 0x0001C158 File Offset: 0x0001A358
		[Token(Token = "0x6006180")]
		[Address(RVA = "0x1DEFC34", Offset = "0x1DEFC34", VA = "0x7BBC5EFC34")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006181")]
		[Address(RVA = "0x1DEFC84", Offset = "0x1DEFC84", VA = "0x7BBC5EFC84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006182")]
		[Address(RVA = "0x1DEFE50", Offset = "0x1DEFE50", VA = "0x7BBC5EFE50")]
		private void OnGemsPurchaseBtnClick()
		{
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006183")]
		[Address(RVA = "0x1DF0044", Offset = "0x1DF0044", VA = "0x7BBC5F0044")]
		private void OnGoldPurchaseBtnClick()
		{
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006184")]
		[Address(RVA = "0x1DEFE5C", Offset = "0x1DEFE5C", VA = "0x7BBC5EFE5C")]
		private void PurchaseItem()
		{
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006185")]
		[Address(RVA = "0x1DF0050", Offset = "0x1DF0050", VA = "0x7BBC5F0050")]
		private void Purchase()
		{
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006186")]
		[Address(RVA = "0x1DF0228", Offset = "0x1DF0228", VA = "0x7BBC5F0228")]
		public void RefreshData(StoreDesc storeDesc, bool showVoucherContainer = false, bool isOffer = false, bool enableInput = false, int maxCount = 0, int defaultValue = 1, [Optional] Action successCallback, bool inputExceedNotify = false)
		{
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006187")]
		[Address(RVA = "0x1DF0528", Offset = "0x1DF0528", VA = "0x7BBC5F0528")]
		public void SetUIData(BaseItemInfo baseItemInfo, uint coinsPrice, uint gemsprice, [Optional] EventDelegate onPurchase, bool showVoucherContainer = false, int defaultCount = 1)
		{
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006188")]
		[Address(RVA = "0x1DF0B68", Offset = "0x1DF0B68", VA = "0x7BBC5F0B68")]
		public void SetUIData(string itemName, ResourceID image, uint quality, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint price = 0U, [Optional] EventDelegate onPurchase, bool showVoucherContainer = false)
		{
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006189")]
		[Address(RVA = "0x1DF0C6C", Offset = "0x1DF0C6C", VA = "0x7BBC5F0C6C")]
		public void SetDebrisStylePurchase()
		{
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618A")]
		[Address(RVA = "0x1DF0588", Offset = "0x1DF0588", VA = "0x7BBC5F0588")]
		private void SetPriceData(EventDelegate onPurchase, int defaultCount = 1)
		{
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618B")]
		[Address(RVA = "0x1DF0D14", Offset = "0x1DF0D14", VA = "0x7BBC5F0D14")]
		public UIMallPurchaseController()
		{
		}

		// Token: 0x04008157 RID: 33111
		[Token(Token = "0x4008157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
		private bool m_IsOffer;

		// Token: 0x04008158 RID: 33112
		[Token(Token = "0x4008158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private StoreDesc m_StoreDesc;

		// Token: 0x04008159 RID: 33113
		[Token(Token = "0x4008159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Action m_SuccessCallback;

		// Token: 0x0400815A RID: 33114
		[Token(Token = "0x400815A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private EInventory.CurrencyType m_CurrencyType;
	}
}
