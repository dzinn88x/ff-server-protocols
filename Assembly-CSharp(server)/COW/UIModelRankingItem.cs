using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FCB RID: 8139
	[Token(Token = "0x2001FCB")]
	public class UIModelRankingItem : UIBaseModel
	{
		// Token: 0x0600B499 RID: 46233 RVA: 0x00033438 File Offset: 0x00031638
		[Token(Token = "0x600B499")]
		[Address(RVA = "0x2397098", Offset = "0x2397098", VA = "0x7BBCB97098", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B49A")]
		[Address(RVA = "0x23970A0", Offset = "0x23970A0", VA = "0x7BBCB970A0")]
		public void ProcessRankingItem(GetRankingItemRankConfigRes res)
		{
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B49B")]
		[Address(RVA = "0x23970B0", Offset = "0x23970B0", VA = "0x7BBCB970B0")]
		public RankingItemRank FindRankingItemDataByID(uint itemID)
		{
			return null;
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x00033450 File Offset: 0x00031650
		[Token(Token = "0x600B49C")]
		[Address(RVA = "0x2397188", Offset = "0x2397188", VA = "0x7BBCB97188")]
		public bool CheckIsReachRankItemUseLevel(uint itemId)
		{
			return default(bool);
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B49D")]
		[Address(RVA = "0x2397268", Offset = "0x2397268", VA = "0x7BBCB97268")]
		public UIModelRankingItem()
		{
		}

		// Token: 0x0400B6FB RID: 46843
		[Token(Token = "0x400B6FB")]
		[FieldOffset(Offset = "0x18")]
		private List<RankingItemRank> m_RankingItemList;

		// Token: 0x02001FCC RID: 8140
		[Token(Token = "0x2001FCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD5E4", Offset = "0x10FD5E4")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600B49E RID: 46238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B49E")]
			[Address(RVA = "0x2397180", Offset = "0x2397180", VA = "0x7BBCB97180")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0600B49F RID: 46239 RVA: 0x00033468 File Offset: 0x00031668
			[Token(Token = "0x600B49F")]
			[Address(RVA = "0x23972F8", Offset = "0x23972F8", VA = "0x7BBCB972F8")]
			internal bool <FindRankingItemDataByID>b__0(RankingItemRank data)
			{
				return default(bool);
			}

			// Token: 0x0400B6FC RID: 46844
			[Token(Token = "0x400B6FC")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}
	}
}
