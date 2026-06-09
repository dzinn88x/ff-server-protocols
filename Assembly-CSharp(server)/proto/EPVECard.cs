using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC8 RID: 2760
	[Token(Token = "0x2000AC8")]
	[ProtoContract]
	public class EPVECard
	{
		// Token: 0x060027D1 RID: 10193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x21B9A14", Offset = "0x21B9A14", VA = "0x7BBC9B9A14")]
		public EPVECard()
		{
		}

		// Token: 0x02000AC9 RID: 2761
		[Token(Token = "0x2000AC9")]
		[ProtoContract]
		public enum GeneralType
		{
			// Token: 0x040033D6 RID: 13270
			[Token(Token = "0x40033D6")]
			GeneralType_NONE,
			// Token: 0x040033D7 RID: 13271
			[Token(Token = "0x40033D7")]
			GeneralType_PROBABLITY,
			// Token: 0x040033D8 RID: 13272
			[Token(Token = "0x40033D8")]
			GeneralType_DAILY_LIMIT
		}
	}
}
