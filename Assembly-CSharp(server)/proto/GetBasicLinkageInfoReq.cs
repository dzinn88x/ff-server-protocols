using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000695 RID: 1685
	[Token(Token = "0x2000695")]
	[ProtoContract]
	public class GetBasicLinkageInfoReq
	{
		// Token: 0x060023D2 RID: 9170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x21BA9F4", Offset = "0x21BA9F4", VA = "0x7BBC9BA9F4")]
		public GetBasicLinkageInfoReq()
		{
		}

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108F34", Offset = "0x1108F34")]
		public ulong account_id;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108F48", Offset = "0x1108F48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108F48", Offset = "0x1108F48")]
		public string lock_region;
	}
}
