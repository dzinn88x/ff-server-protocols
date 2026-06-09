using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E3 RID: 2019
	[Token(Token = "0x20007E3")]
	[ProtoContract]
	public class CSReassignCaptainReq
	{
		// Token: 0x060024F2 RID: 9458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x21B7264", Offset = "0x21B7264", VA = "0x7BBC9B7264")]
		public CSReassignCaptainReq()
		{
		}

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FDC0", Offset = "0x110FDC0")]
		public ulong reassignee_id;
	}
}
