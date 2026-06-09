using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200084A RID: 2122
	[Token(Token = "0x200084A")]
	[ProtoContract]
	public class CSScrollMarqueeRes
	{
		// Token: 0x0600255F RID: 9567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255F")]
		[Address(RVA = "0x21B7564", Offset = "0x21B7564", VA = "0x7BBC9B7564")]
		public CSScrollMarqueeRes()
		{
		}

		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111878", Offset = "0x1111878")]
		public List<ScrollMarqueeDesc> scrollMarquees;
	}
}
