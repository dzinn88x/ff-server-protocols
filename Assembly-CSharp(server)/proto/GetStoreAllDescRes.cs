using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	[ProtoContract]
	public class GetStoreAllDescRes
	{
		// Token: 0x0600251F RID: 9503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x21BABDC", Offset = "0x21BABDC", VA = "0x7BBC9BABDC")]
		public GetStoreAllDescRes()
		{
		}

		// Token: 0x04002704 RID: 9988
		[Token(Token = "0x4002704")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110BF8", Offset = "0x1110BF8")]
		public CSGetGiftStoreRes gift_store;

		// Token: 0x04002705 RID: 9989
		[Token(Token = "0x4002705")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C0C", Offset = "0x1110C0C")]
		public CSGetStoreTabRes store_tab;

		// Token: 0x04002706 RID: 9990
		[Token(Token = "0x4002706")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C20", Offset = "0x1110C20")]
		public CSGetExchangeWebsiteRes exchange_website;

		// Token: 0x04002707 RID: 9991
		[Token(Token = "0x4002707")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C34", Offset = "0x1110C34")]
		public CSGetIPTagConfigRes ip_tag_config;

		// Token: 0x04002708 RID: 9992
		[Token(Token = "0x4002708")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C48", Offset = "0x1110C48")]
		public CSGetExchangeCurrencyAllDescRes exchange_currency;

		// Token: 0x04002709 RID: 9993
		[Token(Token = "0x4002709")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C5C", Offset = "0x1110C5C")]
		public CSGetPayLevelConfigRes pay_level_config_res;

		// Token: 0x0400270A RID: 9994
		[Token(Token = "0x400270A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C70", Offset = "0x1110C70")]
		public CSGetPBWSpecialStoreRes pbw_special_store_res;
	}
}
