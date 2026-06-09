using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E66 RID: 7782
	[Token(Token = "0x2001E66")]
	public class RecommendFriendInfo
	{
		// Token: 0x0600AAD3 RID: 43731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAD3")]
		[Address(RVA = "0x175242C", Offset = "0x175242C", VA = "0x7BBBF5242C")]
		public RecommendFriendInfo()
		{
		}

		// Token: 0x0400AFE3 RID: 45027
		[Token(Token = "0x400AFE3")]
		[FieldOffset(Offset = "0x10")]
		public ulong AccountID;

		// Token: 0x0400AFE4 RID: 45028
		[Token(Token = "0x400AFE4")]
		[FieldOffset(Offset = "0x18")]
		public string Nickname;

		// Token: 0x0400AFE5 RID: 45029
		[Token(Token = "0x400AFE5")]
		[FieldOffset(Offset = "0x20")]
		public int Rank;

		// Token: 0x0400AFE6 RID: 45030
		[Token(Token = "0x400AFE6")]
		[FieldOffset(Offset = "0x24")]
		public int RankPoint;

		// Token: 0x0400AFE7 RID: 45031
		[Token(Token = "0x400AFE7")]
		[FieldOffset(Offset = "0x28")]
		public ESocial.Gender Gender;

		// Token: 0x0400AFE8 RID: 45032
		[Token(Token = "0x400AFE8")]
		[FieldOffset(Offset = "0x2C")]
		public EFriendRecommendType Type;
	}
}
