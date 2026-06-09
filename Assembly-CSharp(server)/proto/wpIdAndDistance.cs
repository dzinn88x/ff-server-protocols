using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x20006FC")]
	[ProtoContract]
	public class wpIdAndDistance
	{
		// Token: 0x0600240A RID: 9226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x24A1C74", Offset = "0x24A1C74", VA = "0x7BBCCA1C74")]
		public wpIdAndDistance()
		{
		}

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B2D4", Offset = "0x110B2D4")]
		public uint wp_id;

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B2E8", Offset = "0x110B2E8")]
		public double distance;
	}
}
