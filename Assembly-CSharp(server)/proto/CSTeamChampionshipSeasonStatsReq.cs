using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000916 RID: 2326
	[Token(Token = "0x2000916")]
	[ProtoContract]
	public class CSTeamChampionshipSeasonStatsReq
	{
		// Token: 0x06002624 RID: 9764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002624")]
		[Address(RVA = "0x21B7818", Offset = "0x21B7818", VA = "0x7BBC9B7818")]
		public CSTeamChampionshipSeasonStatsReq()
		{
		}

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118420", Offset = "0x1118420")]
		public ulong team_id;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118434", Offset = "0x1118434")]
		public uint championship_type;

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118448", Offset = "0x1118448")]
		public uint championship_id;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111845C", Offset = "0x111845C")]
		public bool need_members_info;
	}
}
