using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000914 RID: 2324
	[Token(Token = "0x2000914")]
	[ProtoContract]
	public class CSGetChampionshipConfigRes
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x21B2B0C", Offset = "0x21B2B0C", VA = "0x7BBC9B2B0C")]
		public CSGetChampionshipConfigRes()
		{
		}

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118268", Offset = "0x1118268")]
		public ChampionshipOpenInfoDesc open_info;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111827C", Offset = "0x111827C")]
		public List<ChampionshipScoreRewardDesc> reward_infos;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118290", Offset = "0x1118290")]
		public ChampionshipSettingDesc setting_info;
	}
}
