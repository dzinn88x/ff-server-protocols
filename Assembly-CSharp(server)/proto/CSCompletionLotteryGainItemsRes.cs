using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000876 RID: 2166
	[Token(Token = "0x2000876")]
	[ProtoContract]
	public class CSCompletionLotteryGainItemsRes
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x21B0C14", Offset = "0x21B0C14", VA = "0x7BBC9B0C14")]
		public CSCompletionLotteryGainItemsRes()
		{
		}

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113434", Offset = "0x1113434")]
		public List<ExchangedAward> exchanged_awards;
	}
}
