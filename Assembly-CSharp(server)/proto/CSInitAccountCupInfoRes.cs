using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	[ProtoContract]
	public class CSInitAccountCupInfoRes
	{
		// Token: 0x0600244D RID: 9293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x21B652C", Offset = "0x21B652C", VA = "0x7BBC9B652C")]
		public CSInitAccountCupInfoRes()
		{
		}

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB5C", Offset = "0x110CB5C")]
		public List<CSAccountCupInfoRes> infos;
	}
}
