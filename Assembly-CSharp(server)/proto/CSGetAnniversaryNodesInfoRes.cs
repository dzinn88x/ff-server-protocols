using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000951 RID: 2385
	[Token(Token = "0x2000951")]
	[ProtoContract]
	public class CSGetAnniversaryNodesInfoRes
	{
		// Token: 0x0600265F RID: 9823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265F")]
		[Address(RVA = "0x21B1FF8", Offset = "0x21B1FF8", VA = "0x7BBC9B1FF8")]
		public CSGetAnniversaryNodesInfoRes()
		{
		}

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11192A8", Offset = "0x11192A8")]
		public List<AnniversaryNodeShort> nodes;
	}
}
