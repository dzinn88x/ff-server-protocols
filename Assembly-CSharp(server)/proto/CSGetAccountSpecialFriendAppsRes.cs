using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200083D RID: 2109
	[Token(Token = "0x200083D")]
	[ProtoContract]
	public class CSGetAccountSpecialFriendAppsRes
	{
		// Token: 0x06002552 RID: 9554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x21B1778", Offset = "0x21B1778", VA = "0x7BBC9B1778")]
		public CSGetAccountSpecialFriendAppsRes()
		{
		}

		// Token: 0x0400276D RID: 10093
		[Token(Token = "0x400276D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111594", Offset = "0x1111594")]
		public List<SepcialFriendsAppsRes> special_friend_request;
	}
}
