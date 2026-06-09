using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AD3 RID: 6867
	[Token(Token = "0x2001AD3")]
	public class UIPaymentShopController : UIPaymentController.PaymentTabContentController
	{
		// Token: 0x06009111 RID: 37137 RVA: 0x00026AD8 File Offset: 0x00024CD8
		[Token(Token = "0x6009111")]
		[Address(RVA = "0x1F2DD1C", Offset = "0x1F2DD1C", VA = "0x7BBC72DD1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009112")]
		[Address(RVA = "0x1F2DD84", Offset = "0x1F2DD84", VA = "0x7BBC72DD84")]
		public UIPaymentShopController()
		{
		}

		// Token: 0x04009C7B RID: 40059
		[Token(Token = "0x4009C7B")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentShopView m_View;
	}
}
