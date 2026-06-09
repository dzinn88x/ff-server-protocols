using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A4D RID: 2637
	[Token(Token = "0x2000A4D")]
	[ProtoContract]
	public class BaseMMRDesc
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002757")]
		[Address(RVA = "0x21AF72C", Offset = "0x21AF72C", VA = "0x7BBC9AF72C")]
		public BaseMMRDesc()
		{
		}

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112083C", Offset = "0x112083C")]
		public uint player_max_mmr;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120850", Offset = "0x1120850")]
		public uint player_min_mmr;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120864", Offset = "0x1120864")]
		public uint new_player_default_mmr;

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120878", Offset = "0x1120878")]
		public int drop_match_punish_mmr;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112088C", Offset = "0x112088C")]
		public uint bot_point;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11208A0", Offset = "0x11208A0")]
		public uint none_bot_mmr_separate;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11208B4", Offset = "0x11208B4")]
		public uint game_mode;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11208C8", Offset = "0x11208C8")]
		public bool use_new_rule;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x2D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11208DC", Offset = "0x11208DC")]
		public bool use_new_bot_rule;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11208F0", Offset = "0x11208F0")]
		public uint fps_player_default_mmr;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120904", Offset = "0x1120904")]
		public uint veteran_default_mmr;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120918", Offset = "0x1120918")]
		public uint bot_point_max_mmr;
	}
}
