using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200091E RID: 2334
	[Token(Token = "0x200091E")]
	[ProtoContract]
	public class TeamLeaderboardRes
	{
		// Token: 0x0600262C RID: 9772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x24A0E20", Offset = "0x24A0E20", VA = "0x7BBCCA0E20")]
		public TeamLeaderboardRes()
		{
		}

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118740", Offset = "0x1118740")]
		public List<TeamLeaderboardItem> items;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118754", Offset = "0x1118754")]
		public TeamLeaderboardItem self;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x4002B53")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118768", Offset = "0x1118768")]
		public uint leaderboard_size;
	}
}
