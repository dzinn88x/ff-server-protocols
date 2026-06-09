using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D1 RID: 2001
	[Token(Token = "0x20007D1")]
	[ProtoContract]
	public class CSReadMailReq
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x21B71E8", Offset = "0x21B71E8", VA = "0x7BBC9B71E8")]
		public CSReadMailReq()
		{
		}

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F9D8", Offset = "0x110F9D8")]
		public ulong[] mail_ids;

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FA14", Offset = "0x110FA14")]
		public uint status;
	}
}
