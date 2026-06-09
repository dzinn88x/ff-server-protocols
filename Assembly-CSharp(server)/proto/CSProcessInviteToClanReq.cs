using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E1 RID: 2017
	[Token(Token = "0x20007E1")]
	[ProtoContract]
	public class CSProcessInviteToClanReq
	{
		// Token: 0x060024F0 RID: 9456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x21B6FD0", Offset = "0x21B6FD0", VA = "0x7BBC9B6FD0")]
		public CSProcessInviteToClanReq()
		{
		}

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD70", Offset = "0x110FD70")]
		public ulong inviter_id;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD84", Offset = "0x110FD84")]
		public ulong clan_id;
	}
}
