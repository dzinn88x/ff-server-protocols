using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E6 RID: 1510
	[Token(Token = "0x20005E6")]
	[ProtoContract]
	public class AccountInfoBasic
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002366")]
		[Address(RVA = "0x21AE434", Offset = "0x21AE434", VA = "0x7BBC9AE434")]
		public AccountInfoBasic()
		{
		}

		// Token: 0x04001DDD RID: 7645
		[Token(Token = "0x4001DDD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11058E8", Offset = "0x11058E8")]
		public ulong account_id;

		// Token: 0x04001DDE RID: 7646
		[Token(Token = "0x4001DDE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11058FC", Offset = "0x11058FC")]
		public uint account_type;

		// Token: 0x04001DDF RID: 7647
		[Token(Token = "0x4001DDF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105910", Offset = "0x1105910")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105910", Offset = "0x1105910")]
		public string nickname;

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105960", Offset = "0x1105960")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105960", Offset = "0x1105960")]
		public string external_id;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11059B0", Offset = "0x11059B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11059B0", Offset = "0x11059B0")]
		public string region;

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105A00", Offset = "0x1105A00")]
		public uint level;

		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105A14", Offset = "0x1105A14")]
		public uint exp;

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105A28", Offset = "0x1105A28")]
		public uint external_type;

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105A3C", Offset = "0x1105A3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105A3C", Offset = "0x1105A3C")]
		public string external_name;

		// Token: 0x04001DE6 RID: 7654
		[Token(Token = "0x4001DE6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105A8C", Offset = "0x1105A8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105A8C", Offset = "0x1105A8C")]
		public string external_icon;

		// Token: 0x04001DE7 RID: 7655
		[Token(Token = "0x4001DE7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105ADC", Offset = "0x1105ADC")]
		public uint banner_id;

		// Token: 0x04001DE8 RID: 7656
		[Token(Token = "0x4001DE8")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105AF0", Offset = "0x1105AF0")]
		public uint head_pic;

		// Token: 0x04001DE9 RID: 7657
		[Token(Token = "0x4001DE9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105B04", Offset = "0x1105B04")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105B04", Offset = "0x1105B04")]
		public string clan_name;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105B54", Offset = "0x1105B54")]
		public uint rank;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105B68", Offset = "0x1105B68")]
		public uint ranking_points;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105B7C", Offset = "0x1105B7C")]
		public uint role;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105B90", Offset = "0x1105B90")]
		public bool has_elite_pass;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105BA4", Offset = "0x1105BA4")]
		public uint badge_cnt;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105BB8", Offset = "0x1105BB8")]
		public uint badge_id;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105BCC", Offset = "0x1105BCC")]
		public uint season_id;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105BE0", Offset = "0x1105BE0")]
		public uint liked;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105BF4", Offset = "0x1105BF4")]
		public bool is_deleted;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		[FieldOffset(Offset = "0x89")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105C08", Offset = "0x1105C08")]
		public bool show_rank;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105C1C", Offset = "0x1105C1C")]
		public long last_login_at;

		// Token: 0x04001DF5 RID: 7669
		[Token(Token = "0x4001DF5")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105C30", Offset = "0x1105C30")]
		public ulong external_uid;

		// Token: 0x04001DF6 RID: 7670
		[Token(Token = "0x4001DF6")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105C44", Offset = "0x1105C44")]
		public long return_at;

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105C58", Offset = "0x1105C58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105C58", Offset = "0x1105C58")]
		public string championship_team_name;

		// Token: 0x04001DF8 RID: 7672
		[Token(Token = "0x4001DF8")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105CA8", Offset = "0x1105CA8")]
		public uint championship_team_member_num;

		// Token: 0x04001DF9 RID: 7673
		[Token(Token = "0x4001DF9")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105CBC", Offset = "0x1105CBC")]
		public ulong championship_team_id;

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105CD0", Offset = "0x1105CD0")]
		public uint cs_rank;

		// Token: 0x04001DFB RID: 7675
		[Token(Token = "0x4001DFB")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105CE4", Offset = "0x1105CE4")]
		public uint cs_ranking_points;

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105CF8", Offset = "0x1105CF8")]
		public uint[] weapon_skin_shows;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105D34", Offset = "0x1105D34")]
		public uint pin_id;

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105D48", Offset = "0x1105D48")]
		public bool is_cs_ranking_ban;

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105D5C", Offset = "0x1105D5C")]
		public uint max_rank;

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105D70", Offset = "0x1105D70")]
		public uint cs_max_rank;

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105D84", Offset = "0x1105D84")]
		public uint max_ranking_points;
	}
}
