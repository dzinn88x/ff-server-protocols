using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000915 RID: 2325
	[Token(Token = "0x2000915")]
	[ProtoContract]
	public class CSTeamChampionshipSeasonStatsRes
	{
		// Token: 0x06002623 RID: 9763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x21B7820", Offset = "0x21B7820", VA = "0x7BBC9B7820")]
		public CSTeamChampionshipSeasonStatsRes()
		{
		}

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11182A4", Offset = "0x11182A4")]
		public ulong team_id;

		// Token: 0x04002B1B RID: 11035
		[Token(Token = "0x4002B1B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11182B8", Offset = "0x11182B8")]
		public uint championship_type;

		// Token: 0x04002B1C RID: 11036
		[Token(Token = "0x4002B1C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11182CC", Offset = "0x11182CC")]
		public uint championship_id;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11182E0", Offset = "0x11182E0")]
		public ulong[] members;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111831C", Offset = "0x111831C")]
		public uint games_played;

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118330", Offset = "0x1118330")]
		public int max_score;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118344", Offset = "0x1118344")]
		public uint wins;

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118358", Offset = "0x1118358")]
		public uint top_10_percent_times;

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111836C", Offset = "0x111836C")]
		public uint top_50_percent_times;

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118380", Offset = "0x1118380")]
		public uint survival_time;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118394", Offset = "0x1118394")]
		public uint moving_distance;

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11183A8", Offset = "0x11183A8")]
		public uint kills;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11183BC", Offset = "0x11183BC")]
		public uint damage;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11183D0", Offset = "0x11183D0")]
		public uint one_game_most_kills;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11183E4", Offset = "0x11183E4")]
		public uint one_game_most_damage;

		// Token: 0x04002B29 RID: 11049
		[Token(Token = "0x4002B29")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11183F8", Offset = "0x11183F8")]
		public uint headshot_kills;

		// Token: 0x04002B2A RID: 11050
		[Token(Token = "0x4002B2A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111840C", Offset = "0x111840C")]
		public AccountInfoBasicBundleRes members_info;
	}
}
