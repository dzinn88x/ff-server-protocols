using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A6 RID: 2470
	[Token(Token = "0x20009A6")]
	[ProtoContract]
	public class CSMonopolyEventChooseReq
	{
		// Token: 0x060026B4 RID: 9908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x21B6B28", Offset = "0x21B6B28", VA = "0x7BBC9B6B28")]
		public CSMonopolyEventChooseReq()
		{
		}

		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A450", Offset = "0x111A450")]
		public uint choice;

		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111A464", Offset = "0x111A464")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A464", Offset = "0x111A464")]
		public string language;
	}
}
