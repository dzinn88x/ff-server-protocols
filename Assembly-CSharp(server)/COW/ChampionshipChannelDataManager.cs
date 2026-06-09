using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CB8 RID: 7352
	[Token(Token = "0x2001CB8")]
	public class ChampionshipChannelDataManager : SingletonModule<ChampionshipChannelDataManager>
	{
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600A060 RID: 41056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A94")]
		public ChampionshipChannelData DefaultChannel
		{
			[Token(Token = "0x600A060")]
			[Address(RVA = "0x14F45AC", Offset = "0x14F45AC", VA = "0x7BBBCF45AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A061")]
		[Address(RVA = "0x14F45B4", Offset = "0x14F45B4", VA = "0x7BBBCF45B4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A062")]
		[Address(RVA = "0x14F45BC", Offset = "0x14F45BC", VA = "0x7BBBCF45BC", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A063")]
		[Address(RVA = "0x14F473C", Offset = "0x14F473C", VA = "0x7BBBCF473C")]
		public ChampionshipChannelData GetChannelDataByID(int channelID)
		{
			return null;
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A064")]
		[Address(RVA = "0x14F4814", Offset = "0x14F4814", VA = "0x7BBBCF4814")]
		public List<ChampionshipChannelData> GetChannelList()
		{
			return null;
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A065")]
		[Address(RVA = "0x14F481C", Offset = "0x14F481C", VA = "0x7BBBCF481C")]
		public ChampionshipChannelDataManager()
		{
		}

		// Token: 0x0400A73A RID: 42810
		[Token(Token = "0x400A73A")]
		[FieldOffset(Offset = "0x18")]
		private ChampionshipChannelData m_DefaultChannel;

		// Token: 0x0400A73B RID: 42811
		[Token(Token = "0x400A73B")]
		[FieldOffset(Offset = "0x20")]
		private List<ChampionshipChannelData> m_ChannelList;

		// Token: 0x02001CB9 RID: 7353
		[Token(Token = "0x2001CB9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB954", Offset = "0x10FB954")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A067 RID: 41063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A067")]
			[Address(RVA = "0x14F48F0", Offset = "0x14F48F0", VA = "0x7BBBCF48F0")]
			public <>c()
			{
			}

			// Token: 0x0600A068 RID: 41064 RVA: 0x00029F28 File Offset: 0x00028128
			[Token(Token = "0x600A068")]
			[Address(RVA = "0x14F48F8", Offset = "0x14F48F8", VA = "0x7BBBCF48F8")]
			internal bool <OnInit>b__5_0(ChampionshipChannelData e)
			{
				return default(bool);
			}

			// Token: 0x0400A73C RID: 42812
			[Token(Token = "0x400A73C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ChampionshipChannelDataManager.<>c <>9;

			// Token: 0x0400A73D RID: 42813
			[Token(Token = "0x400A73D")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<ChampionshipChannelData> <>9__5_0;
		}

		// Token: 0x02001CBA RID: 7354
		[Token(Token = "0x2001CBA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB964", Offset = "0x10FB964")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600A069 RID: 41065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A069")]
			[Address(RVA = "0x14F480C", Offset = "0x14F480C", VA = "0x7BBBCF480C")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600A06A RID: 41066 RVA: 0x00029F40 File Offset: 0x00028140
			[Token(Token = "0x600A06A")]
			[Address(RVA = "0x14F4994", Offset = "0x14F4994", VA = "0x7BBBCF4994")]
			internal bool <GetChannelDataByID>b__0(ChampionshipChannelData e)
			{
				return default(bool);
			}

			// Token: 0x0400A73E RID: 42814
			[Token(Token = "0x400A73E")]
			[FieldOffset(Offset = "0x10")]
			public int channelID;
		}
	}
}
