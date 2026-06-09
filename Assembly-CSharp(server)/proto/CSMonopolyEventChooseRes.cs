using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A7 RID: 2471
	[Token(Token = "0x20009A7")]
	[ProtoContract]
	public class CSMonopolyEventChooseRes
	{
		// Token: 0x060026B5 RID: 9909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x21B6B84", Offset = "0x21B6B84", VA = "0x7BBC9B6B84")]
		public CSMonopolyEventChooseRes()
		{
		}

		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A4B4", Offset = "0x111A4B4")]
		public EMiniGame.MonopolyEventResultType type;

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A4C8", Offset = "0x111A4C8")]
		public uint value;
	}
}
