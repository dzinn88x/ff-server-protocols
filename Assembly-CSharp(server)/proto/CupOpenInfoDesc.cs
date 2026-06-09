using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B50 RID: 2896
	[Token(Token = "0x2000B50")]
	[ProtoContract]
	public class CupOpenInfoDesc
	{
		// Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x21B9240", Offset = "0x21B9240", VA = "0x7BBC9B9240")]
		public CupOpenInfoDesc()
		{
		}

		// Token: 0x0400370F RID: 14095
		[Token(Token = "0x400370F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E018", Offset = "0x112E018")]
		public uint cup_type;

		// Token: 0x04003710 RID: 14096
		[Token(Token = "0x4003710")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E02C", Offset = "0x112E02C")]
		public uint cup_id;

		// Token: 0x04003711 RID: 14097
		[Token(Token = "0x4003711")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E040", Offset = "0x112E040")]
		public long entrance_open_time;

		// Token: 0x04003712 RID: 14098
		[Token(Token = "0x4003712")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E054", Offset = "0x112E054")]
		public long entrance_end_time;

		// Token: 0x04003713 RID: 14099
		[Token(Token = "0x4003713")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E068", Offset = "0x112E068")]
		public long season_start_time;

		// Token: 0x04003714 RID: 14100
		[Token(Token = "0x4003714")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E07C", Offset = "0x112E07C")]
		public long season_end_time;

		// Token: 0x04003715 RID: 14101
		[Token(Token = "0x4003715")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E090", Offset = "0x112E090")]
		public long match_start_time;

		// Token: 0x04003716 RID: 14102
		[Token(Token = "0x4003716")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E0A4", Offset = "0x112E0A4")]
		public long match_end_time;
	}
}
