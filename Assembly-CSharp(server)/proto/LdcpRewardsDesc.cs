using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B19 RID: 2841
	[Token(Token = "0x2000B19")]
	[ProtoContract]
	public class LdcpRewardsDesc
	{
		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x21BB8B8", Offset = "0x21BB8B8", VA = "0x7BBC9BB8B8")]
		public LdcpRewardsDesc()
		{
		}

		// Token: 0x040035E9 RID: 13801
		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC50", Offset = "0x112BC50")]
		public uint money;

		// Token: 0x040035EA RID: 13802
		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC64", Offset = "0x112BC64")]
		public List<AwardDesc> award_items;

		// Token: 0x040035EB RID: 13803
		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC78", Offset = "0x112BC78")]
		public bool big_one;
	}
}
