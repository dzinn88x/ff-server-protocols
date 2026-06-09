using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000973 RID: 2419
	[Token(Token = "0x2000973")]
	[ProtoContract]
	public class CSClaimBooyahDayProcessRewardsRes
	{
		// Token: 0x06002681 RID: 9857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x21B0798", Offset = "0x21B0798", VA = "0x7BBC9B0798")]
		public CSClaimBooyahDayProcessRewardsRes()
		{
		}

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119910", Offset = "0x1119910")]
		public AwardData awards;
	}
}
