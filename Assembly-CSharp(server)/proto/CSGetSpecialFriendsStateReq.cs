using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200083B RID: 2107
	[Token(Token = "0x200083B")]
	[ProtoContract]
	public class CSGetSpecialFriendsStateReq
	{
		// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x21B5B44", Offset = "0x21B5B44", VA = "0x7BBC9B5B44")]
		public CSGetSpecialFriendsStateReq()
		{
		}

		// Token: 0x0400276B RID: 10091
		[Token(Token = "0x400276B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111156C", Offset = "0x111156C")]
		public bool is_first_login;
	}
}
