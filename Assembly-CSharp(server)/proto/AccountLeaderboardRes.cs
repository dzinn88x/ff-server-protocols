using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	[ProtoContract]
	public class AccountLeaderboardRes
	{
		// Token: 0x06002444 RID: 9284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x21AE60C", Offset = "0x21AE60C", VA = "0x7BBC9AE60C")]
		public AccountLeaderboardRes()
		{
		}

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C878", Offset = "0x110C878")]
		public List<AccountLeaderboardItem> items;

		// Token: 0x04002497 RID: 9367
		[Token(Token = "0x4002497")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C88C", Offset = "0x110C88C")]
		public AccountLeaderboardItem self;

		// Token: 0x04002498 RID: 9368
		[Token(Token = "0x4002498")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C8A0", Offset = "0x110C8A0")]
		public uint leaderboard_size;
	}
}
