using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000678 RID: 1656
	[Token(Token = "0x2000678")]
	[ProtoContract]
	public class GetTeamChampionshipInfoStatsReq
	{
		// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x21BABE4", Offset = "0x21BABE4", VA = "0x7BBC9BABE4")]
		public GetTeamChampionshipInfoStatsReq()
		{
		}

		// Token: 0x04002094 RID: 8340
		[Token(Token = "0x4002094")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11087A0", Offset = "0x11087A0")]
		public uint championship_type;

		// Token: 0x04002095 RID: 8341
		[Token(Token = "0x4002095")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11087B4", Offset = "0x11087B4")]
		public uint championship_id;

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11087C8", Offset = "0x11087C8")]
		public ulong[] team_ids;
	}
}
