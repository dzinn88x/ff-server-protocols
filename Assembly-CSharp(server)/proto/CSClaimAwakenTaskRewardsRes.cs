using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000817 RID: 2071
	[Token(Token = "0x2000817")]
	[ProtoContract]
	public class CSClaimAwakenTaskRewardsRes
	{
		// Token: 0x06002526 RID: 9510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002526")]
		[Address(RVA = "0x21B0778", Offset = "0x21B0778", VA = "0x7BBC9B0778")]
		public CSClaimAwakenTaskRewardsRes()
		{
		}

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D88", Offset = "0x1110D88")]
		public AwardData awards;
	}
}
