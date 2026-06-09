using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000952 RID: 2386
	[Token(Token = "0x2000952")]
	[ProtoContract]
	public class CSClaimAnniversaryRewardsRes
	{
		// Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002660")]
		[Address(RVA = "0x21B0768", Offset = "0x21B0768", VA = "0x7BBC9B0768")]
		public CSClaimAnniversaryRewardsRes()
		{
		}

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11192BC", Offset = "0x11192BC")]
		public AwardData awards;
	}
}
