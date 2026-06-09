using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	[ProtoContract]
	public class EPWeeklyProcessStatus
	{
		// Token: 0x0600278C RID: 10124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x21B9A24", Offset = "0x21B9A24", VA = "0x7BBC9B9A24")]
		public EPWeeklyProcessStatus()
		{
		}

		// Token: 0x0400317A RID: 12666
		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122DD0", Offset = "0x1122DD0")]
		public List<EPWeeklyProcessRewardStatus> weekly_process_status;
	}
}
