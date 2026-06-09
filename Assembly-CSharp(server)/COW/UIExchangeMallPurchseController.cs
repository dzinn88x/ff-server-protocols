using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001568 RID: 5480
	[Token(Token = "0x2001568")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE81C", Offset = "0x10EE81C")]
	public class UIExchangeMallPurchseController : UIMallPurchaseBaseController
	{
		// Token: 0x06005F41 RID: 24385 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		[Token(Token = "0x6005F41")]
		[Address(RVA = "0x2272D5C", Offset = "0x2272D5C", VA = "0x7BBCA72D5C")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F42")]
		[Address(RVA = "0x2272DAC", Offset = "0x2272DAC", VA = "0x7BBCA72DAC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x0001B900 File Offset: 0x00019B00
		// (set) Token: 0x06005F44 RID: 24388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B6")]
		protected override int ItemCount
		{
			[Token(Token = "0x6005F43")]
			[Address(RVA = "0x2272E7C", Offset = "0x2272E7C", VA = "0x7BBCA72E7C", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005F44")]
			[Address(RVA = "0x2272E84", Offset = "0x2272E84", VA = "0x7BBCA72E84", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F45")]
		[Address(RVA = "0x2272F54", Offset = "0x2272F54", VA = "0x7BBCA72F54")]
		protected void OnExchangeBtnClick()
		{
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F46")]
		[Address(RVA = "0x2273044", Offset = "0x2273044", VA = "0x7BBCA73044", Slot = "45")]
		public virtual void RefreshData(ExchangeStoreItemDesc exchangeStoreItem, UIExchangeMallPurchseController.EFromType entryFrom = UIExchangeMallPurchseController.EFromType.MALL)
		{
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F47")]
		[Address(RVA = "0x2273350", Offset = "0x2273350", VA = "0x7BBCA73350")]
		protected void SetExchangeIcon(UISprite sprite)
		{
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F48")]
		[Address(RVA = "0x2273450", Offset = "0x2273450", VA = "0x7BBCA73450")]
		public UIExchangeMallPurchseController()
		{
		}

		// Token: 0x04007FED RID: 32749
		[Token(Token = "0x4007FED")]
		[FieldOffset(Offset = "0xD8")]
		protected ExchangeStoreItemDesc m_ExchangeStoreItem;

		// Token: 0x04007FEE RID: 32750
		[Token(Token = "0x4007FEE")]
		[FieldOffset(Offset = "0xE0")]
		private UIExchangeMallPurchseController.EFromType m_EntryFrom;

		// Token: 0x02001569 RID: 5481
		[Token(Token = "0x2001569")]
		public enum EFromType
		{
			// Token: 0x04007FF0 RID: 32752
			[Token(Token = "0x4007FF0")]
			NONE,
			// Token: 0x04007FF1 RID: 32753
			[Token(Token = "0x4007FF1")]
			MALL,
			// Token: 0x04007FF2 RID: 32754
			[Token(Token = "0x4007FF2")]
			EXCHANGE_POP
		}
	}
}
