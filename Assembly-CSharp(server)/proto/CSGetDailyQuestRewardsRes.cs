using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	[ProtoContract]
	public class CSGetDailyQuestRewardsRes
	{
		// Token: 0x060025A3 RID: 9635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x21B3044", Offset = "0x21B3044", VA = "0x7BBC9B3044")]
		public CSGetDailyQuestRewardsRes()
		{
		}

		// Token: 0x040028F3 RID: 10483
		[Token(Token = "0x40028F3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D94", Offset = "0x1113D94")]
		public AwardData awards;
	}
}
