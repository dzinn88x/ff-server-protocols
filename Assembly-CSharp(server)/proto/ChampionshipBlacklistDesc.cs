using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE8 RID: 2792
	[Token(Token = "0x2000AE8")]
	[ProtoContract]
	public class ChampionshipBlacklistDesc
	{
		// Token: 0x060027F0 RID: 10224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x21B7FD0", Offset = "0x21B7FD0", VA = "0x7BBC9B7FD0")]
		public ChampionshipBlacklistDesc()
		{
		}

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128CBC", Offset = "0x1128CBC")]
		public uint championship_type;

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128CD0", Offset = "0x1128CD0")]
		public uint championship_id;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128CE4", Offset = "0x1128CE4")]
		public ulong account_id;
	}
}
