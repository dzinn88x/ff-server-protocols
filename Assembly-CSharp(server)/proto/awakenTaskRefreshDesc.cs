using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A67 RID: 2663
	[Token(Token = "0x2000A67")]
	[ProtoContract]
	public class awakenTaskRefreshDesc
	{
		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x24A1BD0", Offset = "0x24A1BD0", VA = "0x7BBCCA1BD0")]
		public awakenTaskRefreshDesc()
		{
		}

		// Token: 0x040030AF RID: 12463
		[Token(Token = "0x40030AF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121868", Offset = "0x1121868")]
		public uint original_avatar_id;

		// Token: 0x040030B0 RID: 12464
		[Token(Token = "0x40030B0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112187C", Offset = "0x112187C")]
		public uint[] re_cost_type;

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11218B8", Offset = "0x11218B8")]
		public uint[] re_cost;

		// Token: 0x040030B2 RID: 12466
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11218F4", Offset = "0x11218F4")]
		public uint re_times_limit;
	}
}
