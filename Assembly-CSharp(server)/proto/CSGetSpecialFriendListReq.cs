using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	[ProtoContract]
	public class CSGetSpecialFriendListReq
	{
		// Token: 0x06002551 RID: 9553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x21B5AC8", Offset = "0x21B5AC8", VA = "0x7BBC9B5AC8")]
		public CSGetSpecialFriendListReq()
		{
		}

		// Token: 0x0400276C RID: 10092
		[Token(Token = "0x400276C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111580", Offset = "0x1111580")]
		public ulong owner_id;
	}
}
