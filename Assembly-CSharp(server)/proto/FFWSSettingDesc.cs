using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	[ProtoContract]
	public class FFWSSettingDesc
	{
		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x21BA198", Offset = "0x21BA198", VA = "0x7BBC9BA198")]
		public FFWSSettingDesc()
		{
		}

		// Token: 0x040036CA RID: 14026
		[Token(Token = "0x40036CA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D618", Offset = "0x112D618")]
		public bool is_guessing_available;

		// Token: 0x040036CB RID: 14027
		[Token(Token = "0x40036CB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D62C", Offset = "0x112D62C")]
		public uint guessing_activity_start_time;

		// Token: 0x040036CC RID: 14028
		[Token(Token = "0x40036CC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D640", Offset = "0x112D640")]
		public uint guessing_deadline;

		// Token: 0x040036CD RID: 14029
		[Token(Token = "0x40036CD")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D654", Offset = "0x112D654")]
		public bool is_live_available;

		// Token: 0x040036CE RID: 14030
		[Token(Token = "0x40036CE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D668", Offset = "0x112D668")]
		public uint live_start_time;

		// Token: 0x040036CF RID: 14031
		[Token(Token = "0x40036CF")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D67C", Offset = "0x112D67C")]
		public uint live_end_time;

		// Token: 0x040036D0 RID: 14032
		[Token(Token = "0x40036D0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D690", Offset = "0x112D690")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D690", Offset = "0x112D690")]
		public string live_url;

		// Token: 0x040036D1 RID: 14033
		[Token(Token = "0x40036D1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D6E0", Offset = "0x112D6E0")]
		public bool is_web_event_available;

		// Token: 0x040036D2 RID: 14034
		[Token(Token = "0x40036D2")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D6F4", Offset = "0x112D6F4")]
		public uint web_event_start_time;

		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D708", Offset = "0x112D708")]
		public uint web_event_end_time;

		// Token: 0x040036D4 RID: 14036
		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D71C", Offset = "0x112D71C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D71C", Offset = "0x112D71C")]
		public string web_event_url;

		// Token: 0x040036D5 RID: 14037
		[Token(Token = "0x40036D5")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D76C", Offset = "0x112D76C")]
		public uint world_progress_start_time;

		// Token: 0x040036D6 RID: 14038
		[Token(Token = "0x40036D6")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D780", Offset = "0x112D780")]
		public bool is_checkin_available;

		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D794", Offset = "0x112D794")]
		public uint extra_reward_box;

		// Token: 0x040036D8 RID: 14040
		[Token(Token = "0x40036D8")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D7A8", Offset = "0x112D7A8")]
		public bool is_activity_task_available;

		// Token: 0x040036D9 RID: 14041
		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D7BC", Offset = "0x112D7BC")]
		public uint final_team_url_show_start_time;

		// Token: 0x040036DA RID: 14042
		[Token(Token = "0x40036DA")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D7D0", Offset = "0x112D7D0")]
		public uint final_team_url_show_end_time;

		// Token: 0x040036DB RID: 14043
		[Token(Token = "0x40036DB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D7E4", Offset = "0x112D7E4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D7E4", Offset = "0x112D7E4")]
		public string final_team_url;

		// Token: 0x040036DC RID: 14044
		[Token(Token = "0x40036DC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D834", Offset = "0x112D834")]
		public uint champion_url_show_switch_time;

		// Token: 0x040036DD RID: 14045
		[Token(Token = "0x40036DD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D848", Offset = "0x112D848")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D848", Offset = "0x112D848")]
		public string champion_url;

		// Token: 0x040036DE RID: 14046
		[Token(Token = "0x40036DE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D898", Offset = "0x112D898")]
		public uint guessing_activity_end_time;

		// Token: 0x040036DF RID: 14047
		[Token(Token = "0x40036DF")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D8AC", Offset = "0x112D8AC")]
		public uint token_id;

		// Token: 0x040036E0 RID: 14048
		[Token(Token = "0x40036E0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D8C0", Offset = "0x112D8C0")]
		public uint process_max_value;

		// Token: 0x040036E1 RID: 14049
		[Token(Token = "0x40036E1")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D8D4", Offset = "0x112D8D4")]
		public bool is_exchange_available;

		// Token: 0x040036E2 RID: 14050
		[Token(Token = "0x40036E2")]
		[FieldOffset(Offset = "0x85")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D8E8", Offset = "0x112D8E8")]
		public bool is_peakday_available;
	}
}
