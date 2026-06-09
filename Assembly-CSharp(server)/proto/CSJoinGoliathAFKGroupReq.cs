using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000986 RID: 2438
	[Token(Token = "0x2000986")]
	[ProtoContract]
	public class CSJoinGoliathAFKGroupReq
	{
		// Token: 0x06002694 RID: 9876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x21B65E0", Offset = "0x21B65E0", VA = "0x7BBC9B65E0")]
		public CSJoinGoliathAFKGroupReq()
		{
		}

		// Token: 0x04002C35 RID: 11317
		[Token(Token = "0x4002C35")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C44", Offset = "0x1119C44")]
		public ulong group_id;

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C58", Offset = "0x1119C58")]
		public ELimitedEvent.GoliathGroupJoinSource source;
	}
}
