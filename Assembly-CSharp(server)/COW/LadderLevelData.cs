using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001116 RID: 4374
	[Token(Token = "0x2001116")]
	public class LadderLevelData
	{
		// Token: 0x06004478 RID: 17528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004478")]
		[Address(RVA = "0x13F870C", Offset = "0x13F870C", VA = "0x7BBBBF870C")]
		public LadderLevelData(RankData rank_data)
		{
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004479")]
		[Address(RVA = "0x13F9640", Offset = "0x13F9640", VA = "0x7BBBBF9640")]
		public LadderLevelData(CSRankData rank_data)
		{
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x13F8CF0", Offset = "0x13F8CF0", VA = "0x7BBBBF8CF0")]
		public void UpdateRewards(List<AwardDesc> levelRewards, List<AwardDesc> seasonRewards)
		{
		}

		// Token: 0x0400546E RID: 21614
		[Token(Token = "0x400546E")]
		[FieldOffset(Offset = "0x10")]
		public int Rank;

		// Token: 0x0400546F RID: 21615
		[Token(Token = "0x400546F")]
		[FieldOffset(Offset = "0x18")]
		public string RankName;

		// Token: 0x04005470 RID: 21616
		[Token(Token = "0x4005470")]
		[FieldOffset(Offset = "0x20")]
		public int LowerBound;

		// Token: 0x04005471 RID: 21617
		[Token(Token = "0x4005471")]
		[FieldOffset(Offset = "0x24")]
		public int UpperBound;

		// Token: 0x04005472 RID: 21618
		[Token(Token = "0x4005472")]
		[FieldOffset(Offset = "0x28")]
		public List<BaseItemInfo> AchieveAwardItemList;

		// Token: 0x04005473 RID: 21619
		[Token(Token = "0x4005473")]
		[FieldOffset(Offset = "0x30")]
		public List<BaseItemInfo> SeasonEndAwardItemList;

		// Token: 0x04005474 RID: 21620
		[Token(Token = "0x4005474")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID IconRes;

		// Token: 0x04005475 RID: 21621
		[Token(Token = "0x4005475")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID BigIconRes;

		// Token: 0x04005476 RID: 21622
		[Token(Token = "0x4005476")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID LobbyIconRes;

		// Token: 0x04005477 RID: 21623
		[Token(Token = "0x4005477")]
		[FieldOffset(Offset = "0x44")]
		public ResourceID LadderSeasonRes;

		// Token: 0x04005478 RID: 21624
		[Token(Token = "0x4005478")]
		[FieldOffset(Offset = "0x48")]
		public bool IsPlayerLevel;

		// Token: 0x04005479 RID: 21625
		[Token(Token = "0x4005479")]
		[FieldOffset(Offset = "0x4C")]
		public uint CachedMaxRank;
	}
}
