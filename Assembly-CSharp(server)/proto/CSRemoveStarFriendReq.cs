using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000832 RID: 2098
	[Token(Token = "0x2000832")]
	[ProtoContract]
	public class CSRemoveStarFriendReq
	{
		// Token: 0x06002547 RID: 9543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x21B7428", Offset = "0x21B7428", VA = "0x7BBC9B7428")]
		public CSRemoveStarFriendReq()
		{
		}

		// Token: 0x04002755 RID: 10069
		[Token(Token = "0x4002755")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11113B4", Offset = "0x11113B4")]
		public ulong removee;
	}
}
