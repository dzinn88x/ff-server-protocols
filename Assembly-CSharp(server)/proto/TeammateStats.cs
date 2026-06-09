using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	[ProtoContract]
	public class TeammateStats
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x24A104C", Offset = "0x24A104C", VA = "0x7BBCCA104C")]
		public TeammateStats()
		{
		}

		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B770", Offset = "0x110B770")]
		public ulong account_id;

		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B784", Offset = "0x110B784")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110B784", Offset = "0x110B784")]
		public string nickname;

		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B7D4", Offset = "0x110B7D4")]
		public uint kills;

		// Token: 0x040023E5 RID: 9189
		[Token(Token = "0x40023E5")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B7E8", Offset = "0x110B7E8")]
		public uint avatar_id;

		// Token: 0x040023E6 RID: 9190
		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B7FC", Offset = "0x110B7FC")]
		public uint banner_id;

		// Token: 0x040023E7 RID: 9191
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B810", Offset = "0x110B810")]
		public uint head_pic;

		// Token: 0x040023E8 RID: 9192
		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110B824", Offset = "0x110B824")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B824", Offset = "0x110B824")]
		public string clan_name;

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B874", Offset = "0x110B874")]
		public uint season_rank;

		// Token: 0x040023EA RID: 9194
		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B888", Offset = "0x110B888")]
		public uint level;

		// Token: 0x040023EB RID: 9195
		[Token(Token = "0x40023EB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B89C", Offset = "0x110B89C")]
		public bool has_elite_pass;

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B8B0", Offset = "0x110B8B0")]
		public uint badge_id;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B8C4", Offset = "0x110B8C4")]
		public uint badge_cnt;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B8D8", Offset = "0x110B8D8")]
		public bool is_friend;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x4D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B8EC", Offset = "0x110B8EC")]
		public bool show_rank;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B900", Offset = "0x110B900")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110B900", Offset = "0x110B900")]
		public string lock_region;

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B950", Offset = "0x110B950")]
		public uint pve_damage;

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B964", Offset = "0x110B964")]
		public uint pve_primary_weapon_skin;

		// Token: 0x040023F3 RID: 9203
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B978", Offset = "0x110B978")]
		public uint role;

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B98C", Offset = "0x110B98C")]
		public uint damage;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B9A0", Offset = "0x110B9A0")]
		public uint deads;

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B9B4", Offset = "0x110B9B4")]
		public uint score;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B9C8", Offset = "0x110B9C8")]
		public uint assists;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B9DC", Offset = "0x110B9DC")]
		public uint rank;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B9F0", Offset = "0x110B9F0")]
		public uint settle_bomb;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BA04", Offset = "0x110BA04")]
		public uint remove_bomb;

		// Token: 0x040023FB RID: 9211
		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BA18", Offset = "0x110BA18")]
		public uint[] big_head_level_and_count;

		// Token: 0x040023FC RID: 9212
		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BA54", Offset = "0x110BA54")]
		public uint token_pick_count;

		// Token: 0x040023FD RID: 9213
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BA68", Offset = "0x110BA68")]
		public uint escort_time;

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BA7C", Offset = "0x110BA7C")]
		public uint on_zone_time;

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BA90", Offset = "0x110BA90")]
		public uint buff_trigger_count;

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BAA4", Offset = "0x110BAA4")]
		public uint pin_id;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BAB8", Offset = "0x110BAB8")]
		public uint team_score;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BACC", Offset = "0x110BACC")]
		public uint headshot_kills;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BAE0", Offset = "0x110BAE0")]
		public uint hp_used_count;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BAF4", Offset = "0x110BAF4")]
		public uint survival_time;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BB08", Offset = "0x110BB08")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110BB08", Offset = "0x110BB08")]
		public string group_name;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BB58", Offset = "0x110BB58")]
		public uint group_icon;
	}
}
