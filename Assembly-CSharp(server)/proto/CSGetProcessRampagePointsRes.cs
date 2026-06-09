using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x200095A")]
	[ProtoContract]
	public class CSGetProcessRampagePointsRes
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x21B563C", Offset = "0x21B563C", VA = "0x7BBC9B563C")]
		public CSGetProcessRampagePointsRes()
		{
		}

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11193E8", Offset = "0x11193E8")]
		public List<RampagePoints> rampage_points;
	}
}
