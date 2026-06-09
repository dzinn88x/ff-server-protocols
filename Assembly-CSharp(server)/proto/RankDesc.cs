using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	[ProtoContract]
	public class RankDesc
	{
		// Token: 0x0600277F RID: 10111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x249F9AC", Offset = "0x249F9AC", VA = "0x7BBCC9F9AC")]
		public RankDesc()
		{
		}

		// Token: 0x04003107 RID: 12551
		[Token(Token = "0x4003107")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112222C", Offset = "0x112222C")]
		public uint rank;

		// Token: 0x04003108 RID: 12552
		[Token(Token = "0x4003108")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122240", Offset = "0x1122240")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1122240", Offset = "0x1122240")]
		public string rank_desc;

		// Token: 0x04003109 RID: 12553
		[Token(Token = "0x4003109")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122290", Offset = "0x1122290")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1122290", Offset = "0x1122290")]
		public string rank_name;

		// Token: 0x0400310A RID: 12554
		[Token(Token = "0x400310A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11222E0", Offset = "0x11222E0")]
		public uint lower_bound;

		// Token: 0x0400310B RID: 12555
		[Token(Token = "0x400310B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11222F4", Offset = "0x11222F4")]
		public uint upper_bound;

		// Token: 0x0400310C RID: 12556
		[Token(Token = "0x400310C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122308", Offset = "0x1122308")]
		public bool heroic_mark_switch;
	}
}
