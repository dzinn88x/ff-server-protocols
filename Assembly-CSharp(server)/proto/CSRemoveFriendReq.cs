using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000827 RID: 2087
	[Token(Token = "0x2000827")]
	[ProtoContract]
	public class CSRemoveFriendReq
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x21B73C4", Offset = "0x21B73C4", VA = "0x7BBC9B73C4")]
		public CSRemoveFriendReq()
		{
		}

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111008", Offset = "0x1111008")]
		public ulong remover;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111101C", Offset = "0x111101C")]
		public ulong removee;
	}
}
