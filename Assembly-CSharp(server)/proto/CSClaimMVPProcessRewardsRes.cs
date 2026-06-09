using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B5 RID: 2485
	[Token(Token = "0x20009B5")]
	[ProtoContract]
	public class CSClaimMVPProcessRewardsRes
	{
		// Token: 0x060026C3 RID: 9923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x21B091C", Offset = "0x21B091C", VA = "0x7BBC9B091C")]
		public CSClaimMVPProcessRewardsRes()
		{
		}

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A798", Offset = "0x111A798")]
		public AwardData awards;
	}
}
