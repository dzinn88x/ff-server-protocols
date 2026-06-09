using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200091A RID: 2330
	[Token(Token = "0x200091A")]
	[ProtoContract]
	public class CSAccountLifeSeasonStats
	{
		// Token: 0x06002628 RID: 9768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x21B011C", Offset = "0x21B011C", VA = "0x7BBC9B011C")]
		public CSAccountLifeSeasonStats()
		{
		}

		// Token: 0x04002B41 RID: 11073
		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118600", Offset = "0x1118600")]
		public ulong account_id;

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118614", Offset = "0x1118614")]
		public uint championship_type;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118628", Offset = "0x1118628")]
		public List<AccountSeasonStats> stats;
	}
}
