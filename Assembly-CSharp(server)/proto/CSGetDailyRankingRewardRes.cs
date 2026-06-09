using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000716 RID: 1814
	[Token(Token = "0x2000716")]
	[ProtoContract]
	public class CSGetDailyRankingRewardRes
	{
		// Token: 0x06002423 RID: 9251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x21B304C", Offset = "0x21B304C", VA = "0x7BBC9B304C")]
		public CSGetDailyRankingRewardRes()
		{
		}

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BEA0", Offset = "0x110BEA0")]
		public bool has_first_win;
	}
}
