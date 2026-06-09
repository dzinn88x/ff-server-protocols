using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A38 RID: 2616
	[Token(Token = "0x2000A38")]
	[ProtoContract]
	public class ClanConfigDesc
	{
		// Token: 0x06002742 RID: 10050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x21B85AC", Offset = "0x21B85AC", VA = "0x7BBC9B85AC")]
		public ClanConfigDesc()
		{
		}

		// Token: 0x04002FB3 RID: 12211
		[Token(Token = "0x4002FB3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FEC8", Offset = "0x111FEC8")]
		public uint clan_max_pending_applications;

		// Token: 0x04002FB4 RID: 12212
		[Token(Token = "0x4002FB4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FEDC", Offset = "0x111FEDC")]
		public uint player_max_requests_per_day;

		// Token: 0x04002FB5 RID: 12213
		[Token(Token = "0x4002FB5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FEF0", Offset = "0x111FEF0")]
		public uint max_invite_num;

		// Token: 0x04002FB6 RID: 12214
		[Token(Token = "0x4002FB6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FF04", Offset = "0x111FF04")]
		public uint join_days_before_sign_in;

		// Token: 0x04002FB7 RID: 12215
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FF18", Offset = "0x111FF18")]
		public uint clan_log_time_max;

		// Token: 0x04002FB8 RID: 12216
		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FF2C", Offset = "0x111FF2C")]
		public uint clan_log_cnt_max;

		// Token: 0x04002FB9 RID: 12217
		[Token(Token = "0x4002FB9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FF40", Offset = "0x111FF40")]
		public uint[] clan_preset_level;

		// Token: 0x04002FBA RID: 12218
		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FF7C", Offset = "0x111FF7C")]
		public uint[] clan_preset_rank;

		// Token: 0x04002FBB RID: 12219
		[Token(Token = "0x4002FBB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FFB8", Offset = "0x111FFB8")]
		public uint join_days_before_apply_for_deputy;

		// Token: 0x04002FBC RID: 12220
		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FFCC", Offset = "0x111FFCC")]
		public uint captain_offline_days;

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FFE0", Offset = "0x111FFE0")]
		public uint deputy_offline_days;
	}
}
