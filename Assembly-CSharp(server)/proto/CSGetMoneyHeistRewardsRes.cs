using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	[ProtoContract]
	public class CSGetMoneyHeistRewardsRes
	{
		// Token: 0x06002674 RID: 9844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x21B4CB4", Offset = "0x21B4CB4", VA = "0x7BBC9B4CB4")]
		public CSGetMoneyHeistRewardsRes()
		{
		}

		// Token: 0x04002BEE RID: 11246
		[Token(Token = "0x4002BEE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11195A0", Offset = "0x11195A0")]
		public List<AwardDesc> award_goods;
	}
}
