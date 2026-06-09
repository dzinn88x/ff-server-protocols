using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	[ProtoContract]
	public class MMRTCParam
	{
		// Token: 0x06002756 RID: 10070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x21BC0D8", Offset = "0x21BC0D8", VA = "0x7BBC9BC0D8")]
		public MMRTCParam()
		{
		}

		// Token: 0x04003009 RID: 12297
		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120774", Offset = "0x1120774")]
		public uint map_id;

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120788", Offset = "0x1120788")]
		public float max_point;

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112079C", Offset = "0x112079C")]
		public float except_game_round;

		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11207B0", Offset = "0x11207B0")]
		public float except_damage;

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11207C4", Offset = "0x11207C4")]
		public float result_ratio;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11207D8", Offset = "0x11207D8")]
		public float game_round_ratio;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11207EC", Offset = "0x11207EC")]
		public float damage_ratio;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120800", Offset = "0x1120800")]
		public uint game_mode;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120814", Offset = "0x1120814")]
		public float except_game_point;

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120828", Offset = "0x1120828")]
		public float game_point_ratio;
	}
}
