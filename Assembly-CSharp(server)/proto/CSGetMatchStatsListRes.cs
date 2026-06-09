using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F5 RID: 1781
	[Token(Token = "0x20006F5")]
	[ProtoContract]
	public class CSGetMatchStatsListRes
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x21B4ADC", Offset = "0x21B4ADC", VA = "0x7BBC9B4ADC")]
		public CSGetMatchStatsListRes()
		{
		}

		// Token: 0x040022C2 RID: 8898
		[Token(Token = "0x40022C2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109EE8", Offset = "0x1109EE8")]
		public List<MatchAccountStats> match_stats_list;
	}
}
