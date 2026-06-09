using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	[ProtoContract]
	public class CSEliminateGoodsFromLimitPoolReq
	{
		// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x21B1168", Offset = "0x21B1168", VA = "0x7BBC9B1168")]
		public CSEliminateGoodsFromLimitPoolReq()
		{
		}

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112944", Offset = "0x1112944")]
		public uint lottery_id;

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112958", Offset = "0x1112958")]
		public uint lottery_sub_id;

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111296C", Offset = "0x111296C")]
		public uint[] eliminated_goods;
	}
}
