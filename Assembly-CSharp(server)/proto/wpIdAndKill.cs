using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006FB RID: 1787
	[Token(Token = "0x20006FB")]
	[ProtoContract]
	public class wpIdAndKill
	{
		// Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x24A1C7C", Offset = "0x24A1C7C", VA = "0x7BBCCA1C7C")]
		public wpIdAndKill()
		{
		}

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B298", Offset = "0x110B298")]
		public uint wp_id;

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B2AC", Offset = "0x110B2AC")]
		public uint kills;

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B2C0", Offset = "0x110B2C0")]
		public bool pre_cdt_triggered;
	}
}
