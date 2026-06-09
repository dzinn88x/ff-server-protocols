using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B0 RID: 2480
	[Token(Token = "0x20009B0")]
	[ProtoContract]
	public class CSSocialBasicInfoRes
	{
		// Token: 0x060026BE RID: 9918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x21B769C", Offset = "0x21B769C", VA = "0x7BBC9B769C")]
		public CSSocialBasicInfoRes()
		{
		}

		// Token: 0x04002CA0 RID: 11424
		[Token(Token = "0x4002CA0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A5CC", Offset = "0x111A5CC")]
		public SocialBasicInfo info;
	}
}
