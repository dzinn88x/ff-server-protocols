using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200087D RID: 2173
	[Token(Token = "0x200087D")]
	[ProtoContract]
	public class GetCardsAndIAPInfoRes
	{
		// Token: 0x0600258B RID: 9611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x21BAA58", Offset = "0x21BAA58", VA = "0x7BBC9BAA58")]
		public GetCardsAndIAPInfoRes()
		{
		}

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113600", Offset = "0x1113600")]
		public CSGetCardsRes cards_res;

		// Token: 0x040028A2 RID: 10402
		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113614", Offset = "0x1113614")]
		public CSGetAccountIAPInfoRes iap_info_res;
	}
}
