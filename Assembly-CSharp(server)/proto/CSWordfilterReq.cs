using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200072B RID: 1835
	[Token(Token = "0x200072B")]
	[ProtoContract]
	public class CSWordfilterReq
	{
		// Token: 0x06002438 RID: 9272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x21B7DC0", Offset = "0x21B7DC0", VA = "0x7BBC9B7DC0")]
		public CSWordfilterReq()
		{
		}

		// Token: 0x04002469 RID: 9321
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C404", Offset = "0x110C404")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C404", Offset = "0x110C404")]
		public string text;
	}
}
