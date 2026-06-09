using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000878 RID: 2168
	[Token(Token = "0x2000878")]
	[ProtoContract]
	public class CSGetCardsRes
	{
		// Token: 0x06002586 RID: 9606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x21B2AA8", Offset = "0x21B2AA8", VA = "0x7BBC9B2AA8")]
		public CSGetCardsRes()
		{
		}

		// Token: 0x04002898 RID: 10392
		[Token(Token = "0x4002898")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113498", Offset = "0x1113498")]
		public PVPCardInfo pvp_cards;

		// Token: 0x04002899 RID: 10393
		[Token(Token = "0x4002899")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11134AC", Offset = "0x11134AC")]
		public PVECardInfo pve_cards;
	}
}
