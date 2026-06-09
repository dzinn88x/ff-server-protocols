using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	[ProtoContract]
	public class EPDailyRewardStatus
	{
		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x21B98A0", Offset = "0x21B98A0", VA = "0x7BBC9B98A0")]
		public EPDailyRewardStatus()
		{
		}

		// Token: 0x04003177 RID: 12663
		[Token(Token = "0x4003177")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D94", Offset = "0x1122D94")]
		public List<EPDailyProcessRewardStatus> daily_reward_status;
	}
}
