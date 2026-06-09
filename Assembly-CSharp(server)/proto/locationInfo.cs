using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	[ProtoContract]
	public class locationInfo
	{
		// Token: 0x0600240E RID: 9230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x24A1BF0", Offset = "0x24A1BF0", VA = "0x7BBCCA1BF0")]
		public locationInfo()
		{
		}

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B374", Offset = "0x110B374")]
		public uint trigger_name;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B388", Offset = "0x110B388")]
		public uint damage;

		// Token: 0x040023B0 RID: 9136
		[Token(Token = "0x40023B0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B39C", Offset = "0x110B39C")]
		public List<wpIdAndKill> wp_ids_and_kill;

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B3B0", Offset = "0x110B3B0")]
		public bool emote_used;

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B3C4", Offset = "0x110B3C4")]
		public uint vehicle;

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B3D8", Offset = "0x110B3D8")]
		public uint revival_count;
	}
}
