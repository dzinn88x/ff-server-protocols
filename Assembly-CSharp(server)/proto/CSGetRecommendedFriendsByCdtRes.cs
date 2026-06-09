using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000835 RID: 2101
	[Token(Token = "0x2000835")]
	[ProtoContract]
	public class CSGetRecommendedFriendsByCdtRes
	{
		// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x21B5944", Offset = "0x21B5944", VA = "0x7BBC9B5944")]
		public CSGetRecommendedFriendsByCdtRes()
		{
		}

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111440", Offset = "0x1111440")]
		public List<AccountInfoWithPresenceAndSocialInfo> recommend_player_list;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111454", Offset = "0x1111454")]
		public bool is_search_result;
	}
}
