using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006B3 RID: 1715
	[Token(Token = "0x20006B3")]
	[ProtoContract]
	public class PlayerDetailedStats
	{
		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x249F6C4", Offset = "0x249F6C4", VA = "0x7BBCC9F6C4")]
		public PlayerDetailedStats()
		{
		}

		// Token: 0x040021A0 RID: 8608
		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109010", Offset = "0x1109010")]
		public uint deaths;

		// Token: 0x040021A1 RID: 8609
		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109024", Offset = "0x1109024")]
		public uint top10_times;

		// Token: 0x040021A2 RID: 8610
		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109038", Offset = "0x1109038")]
		public uint top_n_times;

		// Token: 0x040021A3 RID: 8611
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110904C", Offset = "0x110904C")]
		public uint distance_travelled;

		// Token: 0x040021A4 RID: 8612
		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109060", Offset = "0x1109060")]
		public uint survival_time;

		// Token: 0x040021A5 RID: 8613
		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109074", Offset = "0x1109074")]
		public uint revives;

		// Token: 0x040021A6 RID: 8614
		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109088", Offset = "0x1109088")]
		public uint highest_kills;

		// Token: 0x040021A7 RID: 8615
		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110909C", Offset = "0x110909C")]
		public uint damage;

		// Token: 0x040021A8 RID: 8616
		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11090B0", Offset = "0x11090B0")]
		public uint road_kills;

		// Token: 0x040021A9 RID: 8617
		[Token(Token = "0x40021A9")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11090C4", Offset = "0x11090C4")]
		public uint headshots;

		// Token: 0x040021AA RID: 8618
		[Token(Token = "0x40021AA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11090D8", Offset = "0x11090D8")]
		public uint headshot_kills;

		// Token: 0x040021AB RID: 8619
		[Token(Token = "0x40021AB")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11090EC", Offset = "0x11090EC")]
		public uint knock_down;

		// Token: 0x040021AC RID: 8620
		[Token(Token = "0x40021AC")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109100", Offset = "0x1109100")]
		public uint pick_ups;
	}
}
