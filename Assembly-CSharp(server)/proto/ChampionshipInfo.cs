using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200090D RID: 2317
	[Token(Token = "0x200090D")]
	[ProtoContract]
	public class ChampionshipInfo
	{
		// Token: 0x0600261B RID: 9755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x21B7FD8", Offset = "0x21B7FD8", VA = "0x7BBC9B7FD8")]
		public ChampionshipInfo()
		{
		}

		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117EE4", Offset = "0x1117EE4")]
		public uint championship_type;

		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117EF8", Offset = "0x1117EF8")]
		public TeamChampionshipInfo team_info;

		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117F0C", Offset = "0x1117F0C")]
		public AccountChampionshipInfo account_info;

		// Token: 0x04002AF3 RID: 10995
		[Token(Token = "0x4002AF3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117F20", Offset = "0x1117F20")]
		public List<ChampionshipWinnerInfo> winnner_infos;
	}
}
