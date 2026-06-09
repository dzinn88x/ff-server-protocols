using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200089A")]
	[ProtoContract]
	public class CSGetGoogleRewardsDescRes
	{
		// Token: 0x060025A8 RID: 9640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x21B4154", Offset = "0x21B4154", VA = "0x7BBC9B4154")]
		public CSGetGoogleRewardsDescRes()
		{
		}

		// Token: 0x040028F9 RID: 10489
		[Token(Token = "0x40028F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113E0C", Offset = "0x1113E0C")]
		public List<GoogleRewardsDesc> reward_desc;
	}
}
