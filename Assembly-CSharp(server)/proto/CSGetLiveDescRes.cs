using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009AF RID: 2479
	[Token(Token = "0x20009AF")]
	[ProtoContract]
	public class CSGetLiveDescRes
	{
		// Token: 0x060026BD RID: 9917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x21B4664", Offset = "0x21B4664", VA = "0x7BBC9B4664")]
		public CSGetLiveDescRes()
		{
		}

		// Token: 0x04002C9F RID: 11423
		[Token(Token = "0x4002C9F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A5B8", Offset = "0x111A5B8")]
		public List<LiveDesc> descs;
	}
}
