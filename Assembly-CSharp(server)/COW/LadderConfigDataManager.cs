using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001CDF RID: 7391
	[Token(Token = "0x2001CDF")]
	public class LadderConfigDataManager : SingletonModule<LadderConfigDataManager>
	{
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x0600A138 RID: 41272 RVA: 0x0002A4C8 File Offset: 0x000286C8
		[Token(Token = "0x17000A99")]
		public int MaxLadderRank
		{
			[Token(Token = "0x600A138")]
			[Address(RVA = "0x13F7A74", Offset = "0x13F7A74", VA = "0x7BBBBF7A74")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A139")]
		[Address(RVA = "0x13F7A7C", Offset = "0x13F7A7C", VA = "0x7BBBBF7A7C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A13A")]
		[Address(RVA = "0x13F8B20", Offset = "0x13F8B20", VA = "0x7BBBBF8B20")]
		public void UpdateRewards(Dictionary<uint, RankAwardsDesc> seasonAwards)
		{
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A13B")]
		[Address(RVA = "0x13F8F00", Offset = "0x13F8F00", VA = "0x7BBBBF8F00", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A13C")]
		[Address(RVA = "0x13F8FE0", Offset = "0x13F8FE0", VA = "0x7BBBBF8FE0")]
		public LadderLevelData GetLevelDataByRank(int rank)
		{
			return null;
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A13D")]
		[Address(RVA = "0x13F9068", Offset = "0x13F9068", VA = "0x7BBBBF9068")]
		public LadderLevelData GetNextLevelDataByRank(int rank)
		{
			return null;
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A13E")]
		[Address(RVA = "0x13F88DC", Offset = "0x13F88DC", VA = "0x7BBBBF88DC")]
		private void UpdateHeroicLevelBound()
		{
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x0002A4E0 File Offset: 0x000286E0
		[Token(Token = "0x600A13F")]
		[Address(RVA = "0x13F90FC", Offset = "0x13F90FC", VA = "0x7BBBBF90FC")]
		public bool IsMaxRankLevel(int rank)
		{
			return default(bool);
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A140")]
		[Address(RVA = "0x13F910C", Offset = "0x13F910C", VA = "0x7BBBBF910C")]
		public List<LadderLevelData> GetAllLevelData()
		{
			return null;
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A141")]
		[Address(RVA = "0x13F9268", Offset = "0x13F9268", VA = "0x7BBBBF9268")]
		public List<LadderLevelData> GetAllCSLevelData()
		{
			return null;
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A142")]
		[Address(RVA = "0x13F97F4", Offset = "0x13F97F4", VA = "0x7BBBBF97F4")]
		public List<RankCardData> GetRankCardDataList()
		{
			return null;
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A143")]
		[Address(RVA = "0x13F986C", Offset = "0x13F986C", VA = "0x7BBBBF986C")]
		public PeakRankData GetPeakRankData(f rankType = f.EMATCHMODE_RANKING)
		{
			return null;
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x0002A4F8 File Offset: 0x000286F8
		[Token(Token = "0x600A144")]
		[Address(RVA = "0x13F997C", Offset = "0x13F997C", VA = "0x7BBBBF997C")]
		public ERankCardType GetRankCardTypeById(int id)
		{
			return ERankCardType.NONE;
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x0002A510 File Offset: 0x00028710
		[Token(Token = "0x600A145")]
		[Address(RVA = "0x13F9AB8", Offset = "0x13F9AB8", VA = "0x7BBBBF9AB8")]
		public uint GetRankingHeroicLevel(int rankPoint)
		{
			return 0U;
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A146")]
		[Address(RVA = "0x13F9C14", Offset = "0x13F9C14", VA = "0x7BBBBF9C14")]
		public void GetHeroicRankBound(int cPoint, out int lowerBound, out int upperBound)
		{
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A147")]
		[Address(RVA = "0x13F9590", Offset = "0x13F9590", VA = "0x7BBBBF9590")]
		public CSRankData GetCSRankDataByRank(int rankLevel)
		{
			return null;
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x0002A528 File Offset: 0x00028728
		[Token(Token = "0x600A148")]
		[Address(RVA = "0x13F9D5C", Offset = "0x13F9D5C", VA = "0x7BBBBF9D5C")]
		public int GetCSRankStarCount(int rankLevel, int rankPoint)
		{
			return 0;
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x0002A540 File Offset: 0x00028740
		[Token(Token = "0x600A149")]
		[Address(RVA = "0x13F9E28", Offset = "0x13F9E28", VA = "0x7BBBBF9E28")]
		public uint GetCSMaxRankLevel()
		{
			return 0U;
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A14A")]
		[Address(RVA = "0x13F9E30", Offset = "0x13F9E30", VA = "0x7BBBBF9E30")]
		public RankingSeasonInfoData GetRankingSeasonInfo(int index)
		{
			return null;
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x0002A558 File Offset: 0x00028758
		[Token(Token = "0x600A14B")]
		[Address(RVA = "0x13F9F08", Offset = "0x13F9F08", VA = "0x7BBBBF9F08")]
		public int GetStarNumByRankAndRankPoint(int rank, int rankpoint)
		{
			return 0;
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A14C")]
		[Address(RVA = "0x13F9F3C", Offset = "0x13F9F3C", VA = "0x7BBBBF9F3C")]
		public HeroicMarkData GetHeroicMarkData(EHeroicMarkType t, uint val)
		{
			return null;
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A14D")]
		[Address(RVA = "0x13F9FDC", Offset = "0x13F9FDC", VA = "0x7BBBBF9FDC")]
		public GameObject SetHeroicEffect(ResourceID resID, Transform trans, int depth)
		{
			return null;
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A14E")]
		[Address(RVA = "0x13FA360", Offset = "0x13FA360", VA = "0x7BBBBFA360")]
		public LadderConfigDataManager()
		{
		}

		// Token: 0x0400A7D1 RID: 42961
		[Token(Token = "0x400A7D1")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, LadderLevelData> m_LadderLevelDataDict;

		// Token: 0x0400A7D2 RID: 42962
		[Token(Token = "0x400A7D2")]
		[FieldOffset(Offset = "0x20")]
		private List<RankCardData> m_RankingCardList;

		// Token: 0x0400A7D3 RID: 42963
		[Token(Token = "0x400A7D3")]
		[FieldOffset(Offset = "0x28")]
		private List<PeakRankData> m_PeakRankList;

		// Token: 0x0400A7D4 RID: 42964
		[Token(Token = "0x400A7D4")]
		[FieldOffset(Offset = "0x30")]
		private List<RankingHeroicLevelData> m_RankingHeroicLevelList;

		// Token: 0x0400A7D5 RID: 42965
		[Token(Token = "0x400A7D5")]
		[FieldOffset(Offset = "0x38")]
		private List<HeroicLevelBound> m_HeroicLevelBound;

		// Token: 0x0400A7D6 RID: 42966
		[Token(Token = "0x400A7D6")]
		[FieldOffset(Offset = "0x40")]
		private List<RankingSeasonInfoData> m_RankingSeasonInfo;

		// Token: 0x0400A7D7 RID: 42967
		[Token(Token = "0x400A7D7")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, HeroicMarkData> m_HeroicMarkBRMap;

		// Token: 0x0400A7D8 RID: 42968
		[Token(Token = "0x400A7D8")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, HeroicMarkData> m_HeroicMarkCSMap;

		// Token: 0x0400A7D9 RID: 42969
		[Token(Token = "0x400A7D9")]
		[FieldOffset(Offset = "0x58")]
		private int m_MaxLadderRank;

		// Token: 0x0400A7DA RID: 42970
		[Token(Token = "0x400A7DA")]
		[FieldOffset(Offset = "0x60")]
		private List<LadderLevelData> m_CSLadderLevelDataList;

		// Token: 0x0400A7DB RID: 42971
		[Token(Token = "0x400A7DB")]
		private const uint RankMax = 19U;

		// Token: 0x02001CE0 RID: 7392
		[Token(Token = "0x2001CE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA44", Offset = "0x10FBA44")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A150 RID: 41296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A150")]
			[Address(RVA = "0x13FA594", Offset = "0x13FA594", VA = "0x7BBBBFA594")]
			public <>c()
			{
			}

			// Token: 0x0600A151 RID: 41297 RVA: 0x0002A570 File Offset: 0x00028770
			[Token(Token = "0x600A151")]
			[Address(RVA = "0x13FA59C", Offset = "0x13FA59C", VA = "0x7BBBBFA59C")]
			internal int <GetAllLevelData>b__19_0(LadderLevelData a, LadderLevelData b)
			{
				return 0;
			}

			// Token: 0x0600A152 RID: 41298 RVA: 0x0002A588 File Offset: 0x00028788
			[Token(Token = "0x600A152")]
			[Address(RVA = "0x13FA5E4", Offset = "0x13FA5E4", VA = "0x7BBBBFA5E4")]
			internal int <GetAllCSLevelData>b__20_0(LadderLevelData a, LadderLevelData b)
			{
				return 0;
			}

			// Token: 0x0400A7DC RID: 42972
			[Token(Token = "0x400A7DC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LadderConfigDataManager.<>c <>9;

			// Token: 0x0400A7DD RID: 42973
			[Token(Token = "0x400A7DD")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<LadderLevelData> <>9__19_0;

			// Token: 0x0400A7DE RID: 42974
			[Token(Token = "0x400A7DE")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<LadderLevelData> <>9__20_0;
		}

		// Token: 0x02001CE1 RID: 7393
		[Token(Token = "0x2001CE1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA54", Offset = "0x10FBA54")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x0600A153 RID: 41299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A153")]
			[Address(RVA = "0x13F9974", Offset = "0x13F9974", VA = "0x7BBBBF9974")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x0600A154 RID: 41300 RVA: 0x0002A5A0 File Offset: 0x000287A0
			[Token(Token = "0x600A154")]
			[Address(RVA = "0x13FA62C", Offset = "0x13FA62C", VA = "0x7BBBBFA62C")]
			internal bool <GetPeakRankData>b__0(PeakRankData x)
			{
				return default(bool);
			}

			// Token: 0x0400A7DF RID: 42975
			[Token(Token = "0x400A7DF")]
			[FieldOffset(Offset = "0x10")]
			public f rankType;
		}

		// Token: 0x02001CE2 RID: 7394
		[Token(Token = "0x2001CE2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA64", Offset = "0x10FBA64")]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x0600A155 RID: 41301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A155")]
			[Address(RVA = "0x13F9F00", Offset = "0x13F9F00", VA = "0x7BBBBF9F00")]
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x0600A156 RID: 41302 RVA: 0x0002A5B8 File Offset: 0x000287B8
			[Token(Token = "0x600A156")]
			[Address(RVA = "0x13FA668", Offset = "0x13FA668", VA = "0x7BBBBFA668")]
			internal bool <GetRankingSeasonInfo>b__0(RankingSeasonInfoData x)
			{
				return default(bool);
			}

			// Token: 0x0400A7E0 RID: 42976
			[Token(Token = "0x400A7E0")]
			[FieldOffset(Offset = "0x10")]
			public int index;
		}
	}
}
