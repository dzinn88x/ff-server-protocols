using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	[ProtoContract]
	public class PingAddrDesc
	{
		// Token: 0x060025AC RID: 9644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x249F2D0", Offset = "0x249F2D0", VA = "0x7BBCC9F2D0")]
		public PingAddrDesc()
		{
		}

		// Token: 0x0400294F RID: 10575
		[Token(Token = "0x400294F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115004", Offset = "0x1115004")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115004", Offset = "0x1115004")]
		public string ip;

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115054", Offset = "0x1115054")]
		public bool is_traceroute;
	}
}
