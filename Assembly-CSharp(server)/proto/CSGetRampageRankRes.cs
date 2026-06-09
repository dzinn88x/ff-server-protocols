using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200095F RID: 2399
	[Token(Token = "0x200095F")]
	[ProtoContract]
	public class CSGetRampageRankRes
	{
		// Token: 0x0600266D RID: 9837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x21B5734", Offset = "0x21B5734", VA = "0x7BBC9B5734")]
		public CSGetRampageRankRes()
		{
		}

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11194B0", Offset = "0x11194B0")]
		public List<RampageRankDesc> rampage_ranks;
	}
}
