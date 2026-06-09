using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F9 RID: 1785
	[Token(Token = "0x20006F9")]
	[ProtoContract]
	public class MatchStatsExtra
	{
		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x21BC734", Offset = "0x21BC734", VA = "0x7BBC9BC734")]
		public MatchStatsExtra()
		{
		}

		// Token: 0x04002376 RID: 9078
		[Token(Token = "0x4002376")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AE9C", Offset = "0x110AE9C")]
		public uint walk_distance;

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AEB0", Offset = "0x110AEB0")]
		public uint profile_avatar;

		// Token: 0x04002378 RID: 9080
		[Token(Token = "0x4002378")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AEC4", Offset = "0x110AEC4")]
		public List<ItemCollect> items;

		// Token: 0x04002379 RID: 9081
		[Token(Token = "0x4002379")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AED8", Offset = "0x110AED8")]
		public List<WeaponKill> wp_kills;

		// Token: 0x0400237A RID: 9082
		[Token(Token = "0x400237A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AEEC", Offset = "0x110AEEC")]
		public uint air_drop_count;

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AF00", Offset = "0x110AF00")]
		public uint vehicle_distance;

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AF14", Offset = "0x110AF14")]
		public uint hp_used_count;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AF28", Offset = "0x110AF28")]
		public uint drive_time_seconds;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AF3C", Offset = "0x110AF3C")]
		public uint[] loadouts;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AF78", Offset = "0x110AF78")]
		public uint carepackage_count;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AF8C", Offset = "0x110AF8C")]
		public uint treasure_count;

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AFA0", Offset = "0x110AFA0")]
		public uint kill_swimming_count;

		// Token: 0x04002382 RID: 9090
		[Token(Token = "0x4002382")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AFB4", Offset = "0x110AFB4")]
		public uint swim_distance;

		// Token: 0x04002383 RID: 9091
		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AFC8", Offset = "0x110AFC8")]
		public uint damage_on_strop;

		// Token: 0x04002384 RID: 9092
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AFDC", Offset = "0x110AFDC")]
		public List<WeaponSkinKill> wp_skin_kill;

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AFF0", Offset = "0x110AFF0")]
		public List<WeaponSkinDamage> wp_skin_damage;

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B004", Offset = "0x110B004")]
		public uint strop_moving_distance;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B018", Offset = "0x110B018")]
		public List<WeaponDamage> wp_damage;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B02C", Offset = "0x110B02C")]
		public uint oildrum_kill;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B040", Offset = "0x110B040")]
		public uint vehicle_explode_kill;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B054", Offset = "0x110B054")]
		public List<CamouflageKill> cm_kill;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B068", Offset = "0x110B068")]
		public uint use_ice_wall;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B07C", Offset = "0x110B07C")]
		public List<VehicleKill> ve_kill;

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B090", Offset = "0x110B090")]
		public List<PoseKill> po_kill;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B0A4", Offset = "0x110B0A4")]
		public uint smog_oil_drum_destroy_count;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B0B8", Offset = "0x110B0B8")]
		public uint UAV_kill_count;

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B0CC", Offset = "0x110B0CC")]
		public uint[] manual_event_ids;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B108", Offset = "0x110B108")]
		public uint dbox_count;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B11C", Offset = "0x110B11C")]
		public uint[] emote_times;

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B158", Offset = "0x110B158")]
		public List<locationKill> locations_kill;

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B16C", Offset = "0x110B16C")]
		public List<wpIdAndKill> wp_ids_and_kill;

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B180", Offset = "0x110B180")]
		public bool emote_used;

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0xD1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B194", Offset = "0x110B194")]
		public bool search_air_drop;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B1A8", Offset = "0x110B1A8")]
		public uint vehicle_destroyed_count;

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B1BC", Offset = "0x110B1BC")]
		public uint paint_used_count;

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B1D0", Offset = "0x110B1D0")]
		public uint wp_id_no_skin_count;

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B1E4", Offset = "0x110B1E4")]
		public List<locationInfo> location_info;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B1F8", Offset = "0x110B1F8")]
		public List<killInfo> kill_info;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B20C", Offset = "0x110B20C")]
		public uint oildrum_damage;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B220", Offset = "0x110B220")]
		public highKillInfo high_kill_info;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B234", Offset = "0x110B234")]
		public List<wpIdAndDistance> wp_id_distance;

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B248", Offset = "0x110B248")]
		public List<killAndDistances> kill_and_distances;

		// Token: 0x040023A0 RID: 9120
		[Token(Token = "0x40023A0")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B25C", Offset = "0x110B25C")]
		public uint limited_event_rampage;
	}
}
