using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000969 RID: 2409
	[Token(Token = "0x2000969")]
	[ProtoContract]
	public class CSGetMoneyHeistDescRes
	{
		// Token: 0x06002677 RID: 9847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x21B4BC4", Offset = "0x21B4BC4", VA = "0x7BBC9B4BC4")]
		public CSGetMoneyHeistDescRes()
		{
		}

		// Token: 0x04002BFA RID: 11258
		[Token(Token = "0x4002BFA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111971C", Offset = "0x111971C")]
		public List<MoneyHeistAward> money_heist_award;
	}
}
