using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B9 RID: 1209
	[Token(Token = "0x20004B9")]
	[ProtoContract]
	public class EInventory
	{
		// Token: 0x06001E99 RID: 7833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x24A2D48", Offset = "0x24A2D48", VA = "0x7BBCCA2D48")]
		public EInventory()
		{
		}

		// Token: 0x020004BA RID: 1210
		[Token(Token = "0x20004BA")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001684 RID: 5764
			[Token(Token = "0x4001684")]
			Proto_NONE,
			// Token: 0x04001685 RID: 5765
			[Token(Token = "0x4001685")]
			Proto_TOPUP_NTF,
			// Token: 0x04001686 RID: 5766
			[Token(Token = "0x4001686")]
			Proto_MONEY_UPDATE_NTF,
			// Token: 0x04001687 RID: 5767
			[Token(Token = "0x4001687")]
			Proto_NEW_ITEMS_NTF,
			// Token: 0x04001688 RID: 5768
			[Token(Token = "0x4001688")]
			proto_REBATECARD_NTF,
			// Token: 0x04001689 RID: 5769
			[Token(Token = "0x4001689")]
			proto_REBATECARD_REDEEM_NTF,
			// Token: 0x0400168A RID: 5770
			[Token(Token = "0x400168A")]
			proto_ITEM_CHANGE,
			// Token: 0x0400168B RID: 5771
			[Token(Token = "0x400168B")]
			proto_SELECTED_ITEMS_CHANGE,
			// Token: 0x0400168C RID: 5772
			[Token(Token = "0x400168C")]
			proto_EP_CARD_NTF,
			// Token: 0x0400168D RID: 5773
			[Token(Token = "0x400168D")]
			Proto_INSTALLMENT_ITEMS_NEW_NTF,
			// Token: 0x0400168E RID: 5774
			[Token(Token = "0x400168E")]
			Proto_INSTALLMENT_ITEMS_CHANGE_NTF,
			// Token: 0x0400168F RID: 5775
			[Token(Token = "0x400168F")]
			Proto_INSTALLMENT_ITEMS_DELETE_NTF,
			// Token: 0x04001690 RID: 5776
			[Token(Token = "0x4001690")]
			Proto_INSTALLMENT_PAY_NTF,
			// Token: 0x04001691 RID: 5777
			[Token(Token = "0x4001691")]
			Proto_LIMITED_AVATAR_OUT_EXPIRE_NTF
		}

		// Token: 0x020004BB RID: 1211
		[Token(Token = "0x20004BB")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001693 RID: 5779
			[Token(Token = "0x4001693")]
			ErrCode_SUSS
		}
	}
}
