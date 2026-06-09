using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E2 RID: 2018
	[Token(Token = "0x20007E2")]
	[ProtoContract]
	public class CSChangeMemberTypeReq
	{
		// Token: 0x060024F1 RID: 9457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x21B0648", Offset = "0x21B0648", VA = "0x7BBC9B0648")]
		public CSChangeMemberTypeReq()
		{
		}

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD98", Offset = "0x110FD98")]
		public ulong changee_id;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FDAC", Offset = "0x110FDAC")]
		public uint target_type;
	}
}
