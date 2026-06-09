using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	[ProtoContract]
	public class CSLeaderboardRes
	{
		// Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x21B6654", Offset = "0x21B6654", VA = "0x7BBC9B6654")]
		public CSLeaderboardRes()
		{
		}

		// Token: 0x04002476 RID: 9334
		[Token(Token = "0x4002476")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C5F8", Offset = "0x110C5F8")]
		public List<LeaderboardItem> items;

		// Token: 0x04002477 RID: 9335
		[Token(Token = "0x4002477")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C60C", Offset = "0x110C60C")]
		public LeaderboardItem self;

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C620", Offset = "0x110C620")]
		public uint leaderboard_size;
	}
}
