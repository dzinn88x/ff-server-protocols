using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x20005E8")]
	[ProtoContract]
	public class AccountInfoWithPresence
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x21AE514", Offset = "0x21AE514", VA = "0x7BBC9AE514")]
		public AccountInfoWithPresence()
		{
		}

		// Token: 0x04001E08 RID: 7688
		[Token(Token = "0x4001E08")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105E4C", Offset = "0x1105E4C")]
		public ulong account_id;

		// Token: 0x04001E09 RID: 7689
		[Token(Token = "0x4001E09")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105E60", Offset = "0x1105E60")]
		public uint account_type;

		// Token: 0x04001E0A RID: 7690
		[Token(Token = "0x4001E0A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105E74", Offset = "0x1105E74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105E74", Offset = "0x1105E74")]
		public string nickname;

		// Token: 0x04001E0B RID: 7691
		[Token(Token = "0x4001E0B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105EC4", Offset = "0x1105EC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105EC4", Offset = "0x1105EC4")]
		public string external_id;

		// Token: 0x04001E0C RID: 7692
		[Token(Token = "0x4001E0C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105F14", Offset = "0x1105F14")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105F14", Offset = "0x1105F14")]
		public string external_name;

		// Token: 0x04001E0D RID: 7693
		[Token(Token = "0x4001E0D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105F64", Offset = "0x1105F64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105F64", Offset = "0x1105F64")]
		public string region;

		// Token: 0x04001E0E RID: 7694
		[Token(Token = "0x4001E0E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105FB4", Offset = "0x1105FB4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105FB4", Offset = "0x1105FB4")]
		public string portrait;

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106004", Offset = "0x1106004")]
		public uint level;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106018", Offset = "0x1106018")]
		public uint exp;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110602C", Offset = "0x110602C")]
		public long update_time;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106040", Offset = "0x1106040")]
		public AccountInfoWithStats solo_stats;

		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106054", Offset = "0x1106054")]
		public AccountInfoWithStats duo_stats;

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106068", Offset = "0x1106068")]
		public AccountInfoWithStats quad_stats;

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110607C", Offset = "0x110607C")]
		public uint external_type;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106090", Offset = "0x1106090")]
		public AccountInfoWithStats solo_ranking_stats;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11060A4", Offset = "0x11060A4")]
		public AccountInfoWithStats duo_ranking_stats;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11060B8", Offset = "0x11060B8")]
		public AccountInfoWithStats quad_ranking_stats;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11060CC", Offset = "0x11060CC")]
		public uint rank;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11060E0", Offset = "0x11060E0")]
		public uint ranking_points;

		// Token: 0x04001E1B RID: 7707
		[Token(Token = "0x4001E1B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11060F4", Offset = "0x11060F4")]
		public AccountInfoWithStats solo_casual_stats;

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106108", Offset = "0x1106108")]
		public AccountInfoWithStats duo_casual_stats;

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110611C", Offset = "0x110611C")]
		public AccountInfoWithStats quad_casual_stats;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106130", Offset = "0x1106130")]
		public uint banner_id;

		// Token: 0x04001E1F RID: 7711
		[Token(Token = "0x4001E1F")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106144", Offset = "0x1106144")]
		public uint head_pic;

		// Token: 0x04001E20 RID: 7712
		[Token(Token = "0x4001E20")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106158", Offset = "0x1106158")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106158", Offset = "0x1106158")]
		public string clan_name;

		// Token: 0x04001E21 RID: 7713
		[Token(Token = "0x4001E21")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11061A8", Offset = "0x11061A8")]
		public bool has_elite_pass;

		// Token: 0x04001E22 RID: 7714
		[Token(Token = "0x4001E22")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11061BC", Offset = "0x11061BC")]
		public uint badge_cnt;

		// Token: 0x04001E23 RID: 7715
		[Token(Token = "0x4001E23")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11061D0", Offset = "0x11061D0")]
		public uint badge_id;

		// Token: 0x04001E24 RID: 7716
		[Token(Token = "0x4001E24")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11061E4", Offset = "0x11061E4")]
		public bool is_deleted;

		// Token: 0x04001E25 RID: 7717
		[Token(Token = "0x4001E25")]
		[FieldOffset(Offset = "0xCD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11061F8", Offset = "0x11061F8")]
		public bool show_rank;

		// Token: 0x04001E26 RID: 7718
		[Token(Token = "0x4001E26")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110620C", Offset = "0x110620C")]
		public long last_login_at;

		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106220", Offset = "0x1106220")]
		public ulong external_uid;

		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106234", Offset = "0x1106234")]
		public uint role;

		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106248", Offset = "0x1106248")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106248", Offset = "0x1106248")]
		public string championship_team_name;

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106298", Offset = "0x1106298")]
		public uint championship_team_member_num;

		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11062AC", Offset = "0x11062AC")]
		public uint friend_intimacy;

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11062C0", Offset = "0x11062C0")]
		public ulong championship_team_id;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11062D4", Offset = "0x11062D4")]
		public uint cs_rank;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11062E8", Offset = "0x11062E8")]
		public uint cs_ranking_points;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11062FC", Offset = "0x11062FC")]
		public uint pin_id;

		// Token: 0x04001E30 RID: 7728
		[Token(Token = "0x4001E30")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106310", Offset = "0x1106310")]
		public AccountInfoWithStats cs_ranking_stats;

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106324", Offset = "0x1106324")]
		public bool is_cs_ranking_ban;
	}
}
