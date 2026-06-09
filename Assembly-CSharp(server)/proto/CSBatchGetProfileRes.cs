using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B7 RID: 2487
	[Token(Token = "0x20009B7")]
	[ProtoContract]
	public class CSBatchGetProfileRes
	{
		// Token: 0x060026C5 RID: 9925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x21B0458", Offset = "0x21B0458", VA = "0x7BBC9B0458")]
		public CSBatchGetProfileRes()
		{
		}

		// Token: 0x04002CB0 RID: 11440
		[Token(Token = "0x4002CB0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A7E8", Offset = "0x111A7E8")]
		public List<AvatarProfileWithID> profiles;
	}
}
