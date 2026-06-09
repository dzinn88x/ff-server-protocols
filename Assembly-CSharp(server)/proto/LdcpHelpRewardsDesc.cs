using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	[ProtoContract]
	public class LdcpHelpRewardsDesc
	{
		// Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x21BB844", Offset = "0x21BB844", VA = "0x7BBC9BB844")]
		public LdcpHelpRewardsDesc()
		{
		}

		// Token: 0x040035E7 RID: 13799
		[Token(Token = "0x40035E7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC28", Offset = "0x112BC28")]
		public uint target;

		// Token: 0x040035E8 RID: 13800
		[Token(Token = "0x40035E8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC3C", Offset = "0x112BC3C")]
		public List<AwardDesc> award_items;
	}
}
