using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000845 RID: 2117
	[Token(Token = "0x2000845")]
	[ProtoContract]
	public class CSClaimIntimacyAwardRes
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x21B08A0", Offset = "0x21B08A0", VA = "0x7BBC9B08A0")]
		public CSClaimIntimacyAwardRes()
		{
		}

		// Token: 0x0400277E RID: 10110
		[Token(Token = "0x400277E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11116E8", Offset = "0x11116E8")]
		public List<ExchangedAward> exchange_awards;
	}
}
