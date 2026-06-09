using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200090C RID: 2316
	[Token(Token = "0x200090C")]
	[ProtoContract]
	public class CSTeamChampionshipInfoRes
	{
		// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x21B77A4", Offset = "0x21B77A4", VA = "0x7BBC9B77A4")]
		public CSTeamChampionshipInfoRes()
		{
		}

		// Token: 0x04002AEE RID: 10990
		[Token(Token = "0x4002AEE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117EBC", Offset = "0x1117EBC")]
		public ulong team_id;

		// Token: 0x04002AEF RID: 10991
		[Token(Token = "0x4002AEF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117ED0", Offset = "0x1117ED0")]
		public List<ChampionshipInfo> championship_infos;
	}
}
