using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000830 RID: 2096
	[Token(Token = "0x2000830")]
	[ProtoContract]
	public class CSGetRecommendedFriendRes
	{
		// Token: 0x06002545 RID: 9541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x21B58B0", Offset = "0x21B58B0", VA = "0x7BBC9B58B0")]
		public CSGetRecommendedFriendRes()
		{
		}

		// Token: 0x04002752 RID: 10066
		[Token(Token = "0x4002752")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111350", Offset = "0x1111350")]
		public List<AccountInfoWithPresence> rand_friend_list;

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111364", Offset = "0x1111364")]
		public List<AccountInfoWithPresence> common_friend_list;
	}
}
