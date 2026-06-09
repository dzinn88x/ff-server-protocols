using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000965 RID: 2405
	[Token(Token = "0x2000965")]
	[ProtoContract]
	public class CSGetMoneyHeistRewardsReq
	{
		// Token: 0x06002673 RID: 9843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x21B4CAC", Offset = "0x21B4CAC", VA = "0x7BBC9B4CAC")]
		public CSGetMoneyHeistRewardsReq()
		{
		}

		// Token: 0x04002BED RID: 11245
		[Token(Token = "0x4002BED")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111958C", Offset = "0x111958C")]
		public uint money_sum;
	}
}
