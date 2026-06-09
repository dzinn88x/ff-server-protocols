using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B07 RID: 2823
	[Token(Token = "0x2000B07")]
	[ProtoContract]
	public class CSRankingWhitelistDesc
	{
		// Token: 0x0600280F RID: 10255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x21B7184", Offset = "0x21B7184", VA = "0x7BBC9B7184")]
		public CSRankingWhitelistDesc()
		{
		}

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A454", Offset = "0x112A454")]
		public ulong account_id;
	}
}
