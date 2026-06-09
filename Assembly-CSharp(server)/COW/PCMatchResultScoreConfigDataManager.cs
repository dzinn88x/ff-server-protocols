using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF1 RID: 7409
	[Token(Token = "0x2001CF1")]
	internal class PCMatchResultScoreConfigDataManager : SingletonModule<PCMatchResultScoreConfigDataManager>
	{
		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9D")]
		public MatchResultScoreListConfig ScoreList
		{
			[Token(Token = "0x600A196")]
			[Address(RVA = "0x20395A0", Offset = "0x20395A0", VA = "0x7BBC8395A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A197")]
		[Address(RVA = "0x20395A8", Offset = "0x20395A8", VA = "0x7BBC8395A8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[Token(Token = "0x600A198")]
		[Address(RVA = "0x2039814", Offset = "0x2039814", VA = "0x7BBC839814")]
		public uint GetScorePerKillByGroup(uint group)
		{
			return 0U;
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x0002A6F0 File Offset: 0x000288F0
		[Token(Token = "0x600A199")]
		[Address(RVA = "0x20398B4", Offset = "0x20398B4", VA = "0x7BBC8398B4")]
		public uint GetScoreByRankAndGroup(uint group, uint rank)
		{
			return 0U;
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A19A")]
		[Address(RVA = "0x20399D0", Offset = "0x20399D0", VA = "0x7BBC8399D0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A19B")]
		[Address(RVA = "0x20399D4", Offset = "0x20399D4", VA = "0x7BBC8399D4")]
		public PCMatchResultScoreConfigDataManager()
		{
		}

		// Token: 0x0400A803 RID: 43011
		[Token(Token = "0x400A803")]
		private const string overrideFileName = "scorelist.json";

		// Token: 0x0400A804 RID: 43012
		[Token(Token = "0x400A804")]
		[FieldOffset(Offset = "0x18")]
		private MatchResultScoreListConfig m_ScoreListConfig;
	}
}
