using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	[ProtoContract]
	public class CSClaimCupRewardRes
	{
		// Token: 0x06002471 RID: 9329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002471")]
		[Address(RVA = "0x21B07A8", Offset = "0x21B07A8", VA = "0x7BBC9B07A8")]
		public CSClaimCupRewardRes()
		{
		}

		// Token: 0x0400251A RID: 9498
		[Token(Token = "0x400251A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D64C", Offset = "0x110D64C")]
		public AwardData awards;
	}
}
