using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200070D RID: 1805
	[Token(Token = "0x200070D")]
	[ProtoContract]
	public class CSPlayerRankingInfoReq
	{
		// Token: 0x0600241A RID: 9242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x21B6EF8", Offset = "0x21B6EF8", VA = "0x7BBC9B6EF8")]
		public CSPlayerRankingInfoReq()
		{
		}

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BBE4", Offset = "0x110BBE4")]
		public uint season_id;
	}
}
