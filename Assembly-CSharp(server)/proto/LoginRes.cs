using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200089F RID: 2207
	[Token(Token = "0x200089F")]
	[ProtoContract]
	public class LoginRes
	{
		// Token: 0x060025AD RID: 9645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x21BBF5C", Offset = "0x21BBF5C", VA = "0x7BBC9BBF5C")]
		public LoginRes()
		{
		}

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115068", Offset = "0x1115068")]
		public ulong account_id;

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111507C", Offset = "0x111507C")]
		public uint account_type;

		// Token: 0x04002953 RID: 10579
		[Token(Token = "0x4002953")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115090", Offset = "0x1115090")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115090", Offset = "0x1115090")]
		public string region;

		// Token: 0x04002954 RID: 10580
		[Token(Token = "0x4002954")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11150E0", Offset = "0x11150E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11150E0", Offset = "0x11150E0")]
		public string nickname;

		// Token: 0x04002955 RID: 10581
		[Token(Token = "0x4002955")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115130", Offset = "0x1115130")]
		public ulong create_at;

		// Token: 0x04002956 RID: 10582
		[Token(Token = "0x4002956")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115144", Offset = "0x1115144")]
		public uint level;

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115158", Offset = "0x1115158")]
		public uint exp;

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111516C", Offset = "0x111516C")]
		public uint chat_server;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115180", Offset = "0x1115180")]
		public uint coins;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115194", Offset = "0x1115194")]
		public int gems;

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11151A8", Offset = "0x11151A8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11151A8", Offset = "0x11151A8")]
		public string notification_channel;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11151F8", Offset = "0x11151F8")]
		public uint voice_server;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111520C", Offset = "0x111520C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111520C", Offset = "0x111520C")]
		public string event_log_url;

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111525C", Offset = "0x111525C")]
		public List<RegionIDMapping> region_id_mapping;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115270", Offset = "0x1115270")]
		public ulong clan_id;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115284", Offset = "0x1115284")]
		public ulong server_time;

		// Token: 0x04002961 RID: 10593
		[Token(Token = "0x4002961")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115298", Offset = "0x1115298")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115298", Offset = "0x1115298")]
		public string noti_region;

		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11152E8", Offset = "0x11152E8")]
		public uint role;

		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11152FC", Offset = "0x11152FC")]
		public bool is_emulator;

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115310", Offset = "0x1115310")]
		public uint queue_position;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115324", Offset = "0x1115324")]
		public uint need_waiting_secs;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115338", Offset = "0x1115338")]
		public bool has_elite_pass;

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111534C", Offset = "0x111534C")]
		public uint badge_id;

		// Token: 0x04002968 RID: 10600
		[Token(Token = "0x4002968")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115360", Offset = "0x1115360")]
		public uint badge_cnt;

		// Token: 0x04002969 RID: 10601
		[Token(Token = "0x4002969")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115374", Offset = "0x1115374")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115374", Offset = "0x1115374")]
		public string chat_addr;

		// Token: 0x0400296A RID: 10602
		[Token(Token = "0x400296A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11153C4", Offset = "0x11153C4")]
		public bool show_rank;

		// Token: 0x0400296B RID: 10603
		[Token(Token = "0x400296B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11153D8", Offset = "0x11153D8")]
		public GetBasicEPInfoRes elite_pass_basic_info;

		// Token: 0x0400296C RID: 10604
		[Token(Token = "0x400296C")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11153EC", Offset = "0x11153EC")]
		public CSPlayerRankingInfoRes rank_info;

		// Token: 0x0400296D RID: 10605
		[Token(Token = "0x400296D")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115400", Offset = "0x1115400")]
		public long return_at;

		// Token: 0x0400296E RID: 10606
		[Token(Token = "0x400296E")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115414", Offset = "0x1115414")]
		public uint voice_type;

		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115428", Offset = "0x1115428")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115428", Offset = "0x1115428")]
		public string network_log_url;

		// Token: 0x04002970 RID: 10608
		[Token(Token = "0x4002970")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115478", Offset = "0x1115478")]
		public List<PingAddrDesc> ping_addr_desc_list;

		// Token: 0x04002971 RID: 10609
		[Token(Token = "0x4002971")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111548C", Offset = "0x111548C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111548C", Offset = "0x111548C")]
		public string ip_region;

		// Token: 0x04002972 RID: 10610
		[Token(Token = "0x4002972")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11154DC", Offset = "0x11154DC")]
		public double ranking_peak_threshold;

		// Token: 0x04002973 RID: 10611
		[Token(Token = "0x4002973")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11154F0", Offset = "0x11154F0")]
		public List<GameServerNodeManagerDesc> game_server_node_manager;

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115504", Offset = "0x1115504")]
		public ulong last_login_at;

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115518", Offset = "0x1115518")]
		public bool is_anti_addiction_open;

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[FieldOffset(Offset = "0x10C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111552C", Offset = "0x111552C")]
		public EAntiAddiction.AgeState age_state;

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115540", Offset = "0x1115540")]
		public AbTestChoices ab_test_choices;

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115554", Offset = "0x1115554")]
		public BlacklistInfoRes blacklist;

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115568", Offset = "0x1115568")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115568", Offset = "0x1115568")]
		public string mem_value;

		// Token: 0x0400297A RID: 10618
		[Token(Token = "0x400297A")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11155B8", Offset = "0x11155B8")]
		public uint register_variant;

		// Token: 0x0400297B RID: 10619
		[Token(Token = "0x400297B")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11155CC", Offset = "0x11155CC")]
		public WeaponRackRes weapon_rack;

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11155E0", Offset = "0x11155E0")]
		public uint vehicle_display;
	}
}
