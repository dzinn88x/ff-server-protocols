using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200093A RID: 2362
	[Token(Token = "0x200093A")]
	[ProtoContract]
	public class CSGetLinkageActivityRewardsRes
	{
		// Token: 0x06002648 RID: 9800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x21B465C", Offset = "0x21B465C", VA = "0x7BBC9B465C")]
		public CSGetLinkageActivityRewardsRes()
		{
		}

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118E0C", Offset = "0x1118E0C")]
		public AwardData awards;
	}
}
