using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000934 RID: 2356
	[Token(Token = "0x2000934")]
	[ProtoContract]
	public class CSGetFreshActivityRewardsRes
	{
		// Token: 0x06002642 RID: 9794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002642")]
		[Address(RVA = "0x21B38A0", Offset = "0x21B38A0", VA = "0x7BBC9B38A0")]
		public CSGetFreshActivityRewardsRes()
		{
		}

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118C40", Offset = "0x1118C40")]
		public AwardData awards;

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118C54", Offset = "0x1118C54")]
		public List<ExchangedAward> exchange_awards;
	}
}
