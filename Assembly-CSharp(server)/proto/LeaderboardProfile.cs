using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000732")]
	[ProtoContract]
	public class LeaderboardProfile
	{
		// Token: 0x0600243F RID: 9279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x21BB944", Offset = "0x21BB944", VA = "0x7BBC9BB944")]
		public LeaderboardProfile()
		{
		}

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C724", Offset = "0x110C724")]
		public bool has_data;

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C738", Offset = "0x110C738")]
		public AccountLeaderboardProfile account_profile;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C74C", Offset = "0x110C74C")]
		public ClanLeaderboardProfile clan_profile;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C760", Offset = "0x110C760")]
		public TeamLeaderboardProfile team_profile;
	}
}
