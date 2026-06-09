using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000923 RID: 2339
	[Token(Token = "0x2000923")]
	[ProtoContract]
	public class TeamChampionshipMatchStats
	{
		// Token: 0x06002631 RID: 9777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x24A0D8C", Offset = "0x24A0D8C", VA = "0x7BBCCA0D8C")]
		public TeamChampionshipMatchStats()
		{
		}

		// Token: 0x04002B58 RID: 11096
		[Token(Token = "0x4002B58")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11187CC", Offset = "0x11187CC")]
		public ulong team_id;

		// Token: 0x04002B59 RID: 11097
		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11187E0", Offset = "0x11187E0")]
		public uint championship_type;

		// Token: 0x04002B5A RID: 11098
		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11187F4", Offset = "0x11187F4")]
		public uint championship_id;

		// Token: 0x04002B5B RID: 11099
		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118808", Offset = "0x1118808")]
		public ulong match_id;

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111881C", Offset = "0x111881C")]
		public uint create_time;

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118830", Offset = "0x1118830")]
		public uint end_time;

		// Token: 0x04002B5E RID: 11102
		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118844", Offset = "0x1118844")]
		public int score;

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118858", Offset = "0x1118858")]
		public EChampionship.ChampionshipPhase phase;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111886C", Offset = "0x111886C")]
		public bool is_invalid;

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118880", Offset = "0x1118880")]
		public TeamMatchStats team_match_stats;
	}
}
