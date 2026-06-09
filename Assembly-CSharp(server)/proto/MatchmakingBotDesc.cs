using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A05 RID: 2565
	[Token(Token = "0x2000A05")]
	[ProtoContract]
	public class MatchmakingBotDesc
	{
		// Token: 0x0600270F RID: 9999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x21BC9B0", Offset = "0x21BC9B0", VA = "0x7BBC9BC9B0")]
		public MatchmakingBotDesc()
		{
		}

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DDF8", Offset = "0x111DDF8")]
		public uint mmr_start;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE0C", Offset = "0x111DE0C")]
		public uint mmr_end;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE20", Offset = "0x111DE20")]
		public uint bot_cnt;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE34", Offset = "0x111DE34")]
		public uint bot_wait_time;

		// Token: 0x04002EC1 RID: 11969
		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE48", Offset = "0x111DE48")]
		public uint bot_mmr_separate;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE5C", Offset = "0x111DE5C")]
		public uint none_bot_mmr_separate;

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE70", Offset = "0x111DE70")]
		public uint bot_point;

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE84", Offset = "0x111DE84")]
		public uint map_id;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DE98", Offset = "0x111DE98")]
		public uint game_mode;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DEAC", Offset = "0x111DEAC")]
		public uint group_mode;

		// Token: 0x04002EC7 RID: 11975
		[Token(Token = "0x4002EC7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DEC0", Offset = "0x111DEC0")]
		public uint bot_cnt_lv1;

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DED4", Offset = "0x111DED4")]
		public uint bot_cnt_lv2;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DEE8", Offset = "0x111DEE8")]
		public uint bot_cnt_lv3;

		// Token: 0x04002ECA RID: 11978
		[Token(Token = "0x4002ECA")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DEFC", Offset = "0x111DEFC")]
		public uint bot_cnt_lv4;

		// Token: 0x04002ECB RID: 11979
		[Token(Token = "0x4002ECB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF10", Offset = "0x111DF10")]
		public uint fill_bot_level;

		// Token: 0x04002ECC RID: 11980
		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF24", Offset = "0x111DF24")]
		public uint bot_cnt_lv5;

		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF38", Offset = "0x111DF38")]
		public uint bot_cnt_lv6;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF4C", Offset = "0x111DF4C")]
		public uint team_bot_cnt_lv1;

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF60", Offset = "0x111DF60")]
		public uint team_bot_cnt_lv2;

		// Token: 0x04002ED0 RID: 11984
		[Token(Token = "0x4002ED0")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF74", Offset = "0x111DF74")]
		public uint team_bot_cnt_lv3;

		// Token: 0x04002ED1 RID: 11985
		[Token(Token = "0x4002ED1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF88", Offset = "0x111DF88")]
		public uint team_bot_cnt_lv4;

		// Token: 0x04002ED2 RID: 11986
		[Token(Token = "0x4002ED2")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DF9C", Offset = "0x111DF9C")]
		public uint team_bot_cnt_lv5;

		// Token: 0x04002ED3 RID: 11987
		[Token(Token = "0x4002ED3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DFB0", Offset = "0x111DFB0")]
		public uint team_bot_cnt_lv6;

		// Token: 0x04002ED4 RID: 11988
		[Token(Token = "0x4002ED4")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DFC4", Offset = "0x111DFC4")]
		public uint team_bot_cnt;

		// Token: 0x04002ED5 RID: 11989
		[Token(Token = "0x4002ED5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DFD8", Offset = "0x111DFD8")]
		public uint casual_player_safe_zone_switch;
	}
}
