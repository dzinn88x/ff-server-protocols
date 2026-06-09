using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A37 RID: 2615
	[Token(Token = "0x2000A37")]
	[ProtoContract]
	public class ClanScaleDesc
	{
		// Token: 0x06002741 RID: 10049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x21B8B0C", Offset = "0x21B8B0C", VA = "0x7BBC9B8B0C")]
		public ClanScaleDesc()
		{
		}

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FE78", Offset = "0x111FE78")]
		public uint clan_scale;

		// Token: 0x04002FB0 RID: 12208
		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FE8C", Offset = "0x111FE8C")]
		public uint max_member_count;

		// Token: 0x04002FB1 RID: 12209
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FEA0", Offset = "0x111FEA0")]
		public uint create_gold_cost;

		// Token: 0x04002FB2 RID: 12210
		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FEB4", Offset = "0x111FEB4")]
		public uint create_diamond_cost;
	}
}
