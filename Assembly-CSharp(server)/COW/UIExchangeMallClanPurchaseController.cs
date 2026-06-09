using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001561 RID: 5473
	[Token(Token = "0x2001561")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE6E4", Offset = "0x10EE6E4")]
	public class UIExchangeMallClanPurchaseController : UIExchangeMallPurchseController
	{
		// Token: 0x06005EE8 RID: 24296 RVA: 0x0001B750 File Offset: 0x00019950
		[Token(Token = "0x6005EE8")]
		[Address(RVA = "0x1E7E27C", Offset = "0x1E7E27C", VA = "0x7BBC67E27C")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x0001B768 File Offset: 0x00019968
		// (set) Token: 0x06005EEA RID: 24298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B5")]
		protected override int ItemCount
		{
			[Token(Token = "0x6005EE9")]
			[Address(RVA = "0x1E7E2CC", Offset = "0x1E7E2CC", VA = "0x7BBC67E2CC", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005EEA")]
			[Address(RVA = "0x1E7E2D4", Offset = "0x1E7E2D4", VA = "0x7BBC67E2D4", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEB")]
		[Address(RVA = "0x1E7E43C", Offset = "0x1E7E43C", VA = "0x7BBC67E43C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEC")]
		[Address(RVA = "0x1E7E564", Offset = "0x1E7E564", VA = "0x7BBC67E564", Slot = "45")]
		public override void RefreshData(ExchangeStoreItemDesc exchangeStoreItem, UIExchangeMallPurchseController.EFromType fromType = UIExchangeMallPurchseController.EFromType.NONE)
		{
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x1E7E6EC", Offset = "0x1E7E6EC", VA = "0x7BBC67E6EC")]
		public UIExchangeMallClanPurchaseController()
		{
		}
	}
}
