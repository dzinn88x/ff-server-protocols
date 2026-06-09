using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A02 RID: 2562
	[Token(Token = "0x2000A02")]
	[ProtoContract]
	public class MatchmakingDesc
	{
		// Token: 0x0600270C RID: 9996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x21BC9B8", Offset = "0x21BC9B8", VA = "0x7BBC9BC9B8")]
		public MatchmakingDesc()
		{
		}

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DAB0", Offset = "0x111DAB0")]
		public uint matchmaking_time;

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DAC4", Offset = "0x111DAC4")]
		public uint wait_join_time;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DAD8", Offset = "0x111DAD8")]
		public uint wait_protect_time;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DAEC", Offset = "0x111DAEC")]
		public uint login_gameserver_timeout;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB00", Offset = "0x111DB00")]
		public uint room_destroy_time;

		// Token: 0x04002E9A RID: 11930
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB14", Offset = "0x111DB14")]
		public uint sleep_ms;

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB28", Offset = "0x111DB28")]
		public bool ingame_reconnection;

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB3C", Offset = "0x111DB3C")]
		public uint keep_reconnection_time_second;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB50", Offset = "0x111DB50")]
		public uint bot_mmr_type;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB64", Offset = "0x111DB64")]
		public uint ranking_bot_mmr_type;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB78", Offset = "0x111DB78")]
		public uint room_wait_start_timeout;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DB8C", Offset = "0x111DB8C")]
		public bool inroom_reconnection;

		// Token: 0x04002EA1 RID: 11937
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DBA0", Offset = "0x111DBA0")]
		public uint inroom_reconnection_time_second;

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DBB4", Offset = "0x111DBB4")]
		public uint idc_timeout;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DBC8", Offset = "0x111DBC8")]
		public uint[] hackers_pool_effect_mode;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC04", Offset = "0x111DC04")]
		public bool room_enable_emulator_check;

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC18", Offset = "0x111DC18")]
		public uint room_limit_score;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC2C", Offset = "0x111DC2C")]
		public bool disable_mm7;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x59")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DC40", Offset = "0x111DC40")]
		public bool loading_reconnection;
	}
}
