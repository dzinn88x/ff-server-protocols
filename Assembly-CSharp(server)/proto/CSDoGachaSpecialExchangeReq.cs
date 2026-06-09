using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200086A RID: 2154
	[Token(Token = "0x200086A")]
	[ProtoContract]
	public class CSDoGachaSpecialExchangeReq
	{
		// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x21B0F70", Offset = "0x21B0F70", VA = "0x7BBC9B0F70")]
		public CSDoGachaSpecialExchangeReq()
		{
		}

		// Token: 0x0400282B RID: 10283
		[Token(Token = "0x400282B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112908", Offset = "0x1112908")]
		public uint forge_tab_id;

		// Token: 0x0400282C RID: 10284
		[Token(Token = "0x400282C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111291C", Offset = "0x111291C")]
		public uint item_id;

		// Token: 0x0400282D RID: 10285
		[Token(Token = "0x400282D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112930", Offset = "0x1112930")]
		public uint exchange_cnt;
	}
}
