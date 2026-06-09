using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200099C RID: 2460
	[Token(Token = "0x200099C")]
	[ProtoContract]
	public class Point
	{
		// Token: 0x060026AA RID: 9898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x249F6D4", Offset = "0x249F6D4", VA = "0x7BBCC9F6D4")]
		public Point()
		{
		}

		// Token: 0x04002C75 RID: 11381
		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A1F8", Offset = "0x111A1F8")]
		public double x;

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A20C", Offset = "0x111A20C")]
		public double y;
	}
}
