using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000999 RID: 2457
	[Token(Token = "0x2000999")]
	[ProtoContract]
	public class Circle
	{
		// Token: 0x060026A7 RID: 9895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x21B8594", Offset = "0x21B8594", VA = "0x7BBC9B8594")]
		public Circle()
		{
		}

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A068", Offset = "0x111A068")]
		public Point center;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A07C", Offset = "0x111A07C")]
		public double radius;
	}
}
