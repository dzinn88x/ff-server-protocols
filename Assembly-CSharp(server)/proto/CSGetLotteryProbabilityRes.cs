using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000861 RID: 2145
	[Token(Token = "0x2000861")]
	[ProtoContract]
	public class CSGetLotteryProbabilityRes
	{
		// Token: 0x0600256F RID: 9583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x21B480C", Offset = "0x21B480C", VA = "0x7BBC9B480C")]
		public CSGetLotteryProbabilityRes()
		{
		}

		// Token: 0x0400281C RID: 10268
		[Token(Token = "0x400281C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112728", Offset = "0x1112728")]
		public List<RareProbability> rare_pr;
	}
}
