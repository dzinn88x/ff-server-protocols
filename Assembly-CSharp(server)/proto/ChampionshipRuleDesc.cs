using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE6 RID: 2790
	[Token(Token = "0x2000AE6")]
	[ProtoContract]
	public class ChampionshipRuleDesc
	{
		// Token: 0x060027EE RID: 10222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x21B8104", Offset = "0x21B8104", VA = "0x7BBC9B8104")]
		public ChampionshipRuleDesc()
		{
		}

		// Token: 0x04003493 RID: 13459
		[Token(Token = "0x4003493")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B90", Offset = "0x1128B90")]
		public uint limited_level;

		// Token: 0x04003494 RID: 13460
		[Token(Token = "0x4003494")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128BA4", Offset = "0x1128BA4")]
		public uint limited_rank;

		// Token: 0x04003495 RID: 13461
		[Token(Token = "0x4003495")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128BB8", Offset = "0x1128BB8")]
		public uint upper_limited_level;

		// Token: 0x04003496 RID: 13462
		[Token(Token = "0x4003496")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128BCC", Offset = "0x1128BCC")]
		public uint upper_limited_rank;
	}
}
