using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000634 RID: 1588
	[Token(Token = "0x2000634")]
	[ProtoContract]
	public class AccountFriendRes
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x21AE3A8", Offset = "0x21AE3A8", VA = "0x7BBC9AE3A8")]
		public AccountFriendRes()
		{
		}

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107FD0", Offset = "0x1107FD0")]
		public List<AccountInfoWithPresence> friends;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107FE4", Offset = "0x1107FE4")]
		public ulong[] star_friends;
	}
}
