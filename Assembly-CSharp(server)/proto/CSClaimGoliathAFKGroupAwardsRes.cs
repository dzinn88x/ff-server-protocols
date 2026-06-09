using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200098B RID: 2443
	[Token(Token = "0x200098B")]
	[ProtoContract]
	public class CSClaimGoliathAFKGroupAwardsRes
	{
		// Token: 0x06002699 RID: 9881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x21B0890", Offset = "0x21B0890", VA = "0x7BBC9B0890")]
		public CSClaimGoliathAFKGroupAwardsRes()
		{
		}

		// Token: 0x04002C3C RID: 11324
		[Token(Token = "0x4002C3C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119D48", Offset = "0x1119D48")]
		public AwardData awards;
	}
}
