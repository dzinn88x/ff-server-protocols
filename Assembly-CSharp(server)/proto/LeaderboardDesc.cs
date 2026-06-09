using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	[ProtoContract]
	public class LeaderboardDesc
	{
		// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x21BB934", Offset = "0x21BB934", VA = "0x7BBC9BB934")]
		public LeaderboardDesc()
		{
		}

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A70", Offset = "0x1121A70")]
		public uint main_type;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A84", Offset = "0x1121A84")]
		public uint order;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A98", Offset = "0x1121A98")]
		public uint size;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121AAC", Offset = "0x1121AAC")]
		public uint starting_value;
	}
}
