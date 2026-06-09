using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	[ProtoContract]
	public class ChallengeStatus
	{
		// Token: 0x0600259D RID: 9629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x21B7F5C", Offset = "0x21B7F5C", VA = "0x7BBC9B7F5C")]
		public ChallengeStatus()
		{
		}

		// Token: 0x040028D0 RID: 10448
		[Token(Token = "0x40028D0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A88", Offset = "0x1113A88")]
		public uint challenge_id;

		// Token: 0x040028D1 RID: 10449
		[Token(Token = "0x40028D1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A9C", Offset = "0x1113A9C")]
		public EPTarget_Status status;

		// Token: 0x040028D2 RID: 10450
		[Token(Token = "0x40028D2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113AB0", Offset = "0x1113AB0")]
		public uint update_time;

		// Token: 0x040028D3 RID: 10451
		[Token(Token = "0x40028D3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113AC4", Offset = "0x1113AC4")]
		public uint[] role_condition;

		// Token: 0x040028D4 RID: 10452
		[Token(Token = "0x40028D4")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B00", Offset = "0x1113B00")]
		public uint count_type;

		// Token: 0x040028D5 RID: 10453
		[Token(Token = "0x40028D5")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B14", Offset = "0x1113B14")]
		public uint game_mode;

		// Token: 0x040028D6 RID: 10454
		[Token(Token = "0x40028D6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B28", Offset = "0x1113B28")]
		public uint player_count;

		// Token: 0x040028D7 RID: 10455
		[Token(Token = "0x40028D7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B3C", Offset = "0x1113B3C")]
		public List<ChallengeCdt> conditions;

		// Token: 0x040028D8 RID: 10456
		[Token(Token = "0x40028D8")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B50", Offset = "0x1113B50")]
		public uint match_mode;

		// Token: 0x040028D9 RID: 10457
		[Token(Token = "0x40028D9")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B64", Offset = "0x1113B64")]
		public uint date;

		// Token: 0x040028DA RID: 10458
		[Token(Token = "0x40028DA")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B78", Offset = "0x1113B78")]
		public uint challenge_type;

		// Token: 0x040028DB RID: 10459
		[Token(Token = "0x40028DB")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113B8C", Offset = "0x1113B8C")]
		public uint special_challenge;

		// Token: 0x040028DC RID: 10460
		[Token(Token = "0x40028DC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113BA0", Offset = "0x1113BA0")]
		public uint daily_count;

		// Token: 0x040028DD RID: 10461
		[Token(Token = "0x40028DD")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113BB4", Offset = "0x1113BB4")]
		public bool is_daily_quest;

		// Token: 0x040028DE RID: 10462
		[Token(Token = "0x40028DE")]
		[FieldOffset(Offset = "0x55")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113BC8", Offset = "0x1113BC8")]
		public bool is_unfinished_daily_quest;

		// Token: 0x040028DF RID: 10463
		[Token(Token = "0x40028DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113BDC", Offset = "0x1113BDC")]
		public uint max_daily_count;

		// Token: 0x040028E0 RID: 10464
		[Token(Token = "0x40028E0")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113BF0", Offset = "0x1113BF0")]
		public uint week_id;
	}
}
