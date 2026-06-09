using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A03 RID: 2563
	[Token(Token = "0x2000A03")]
	[ProtoContract]
	public class MatchmakingRuleDesc
	{
		// Token: 0x0600270D RID: 9997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x21BC9C0", Offset = "0x21BC9C0", VA = "0x7BBC9BC9C0")]
		public MatchmakingRuleDesc()
		{
		}

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC54", Offset = "0x111DC54")]
		public uint map_id;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC68", Offset = "0x111DC68")]
		public uint group_mode;

		// Token: 0x04002EAA RID: 11946
		[Token(Token = "0x4002EAA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC7C", Offset = "0x111DC7C")]
		public uint min_player_cnt;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC90", Offset = "0x111DC90")]
		public uint max_player_cnt;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DCA4", Offset = "0x111DCA4")]
		public bool mmr_open;

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DCB8", Offset = "0x111DCB8")]
		public bool bot_open;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DCCC", Offset = "0x111DCCC")]
		public uint min_room_mmr_delta;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DCE0", Offset = "0x111DCE0")]
		public uint base_mmr_delta;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DCF4", Offset = "0x111DCF4")]
		public List<MatchmakingTimeMMRRangeItem> ranges;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD08", Offset = "0x111DD08")]
		public uint mm_timeout;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD1C", Offset = "0x111DD1C")]
		public uint game_mode;

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD30", Offset = "0x111DD30")]
		public uint language_timeout;

		// Token: 0x04002EB4 RID: 11956
		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD44", Offset = "0x111DD44")]
		public uint difficulty;

		// Token: 0x04002EB5 RID: 11957
		[Token(Token = "0x4002EB5")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD58", Offset = "0x111DD58")]
		public uint halfway_join_time;

		// Token: 0x04002EB6 RID: 11958
		[Token(Token = "0x4002EB6")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD6C", Offset = "0x111DD6C")]
		public uint min_group_cnt;

		// Token: 0x04002EB7 RID: 11959
		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD80", Offset = "0x111DD80")]
		public uint max_group_cnt;

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DD94", Offset = "0x111DD94")]
		public uint begin_add_player_time;

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DDA8", Offset = "0x111DDA8")]
		public uint stop_add_player_time;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DDBC", Offset = "0x111DDBC")]
		public uint squad_prefer_protection_time;
	}
}
