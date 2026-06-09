using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000898 RID: 2200
	[Token(Token = "0x2000898")]
	[ProtoContract]
	public class CSGetWeeklyProcessRewardsRes
	{
		// Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x21B63EC", Offset = "0x21B63EC", VA = "0x7BBC9B63EC")]
		public CSGetWeeklyProcessRewardsRes()
		{
		}

		// Token: 0x040028F7 RID: 10487
		[Token(Token = "0x40028F7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113DE4", Offset = "0x1113DE4")]
		public AwardData awards;
	}
}
