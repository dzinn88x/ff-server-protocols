using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001D8E RID: 7566
	[Token(Token = "0x2001D8E")]
	public class UIModelBingo : UIBaseModel
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600A568 RID: 42344 RVA: 0x0002C130 File Offset: 0x0002A330
		[Token(Token = "0x17000AE5")]
		private int OpeningDifficultyLevelCount
		{
			[Token(Token = "0x600A568")]
			[Address(RVA = "0x22D70F4", Offset = "0x22D70F4", VA = "0x7BBCAD70F4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x0002C148 File Offset: 0x0002A348
		[Token(Token = "0x600A569")]
		[Address(RVA = "0x22D7290", Offset = "0x22D7290", VA = "0x7BBCAD7290", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A56A")]
		[Address(RVA = "0x22D7298", Offset = "0x22D7298", VA = "0x7BBCAD7298", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x0002C160 File Offset: 0x0002A360
		[Token(Token = "0x600A56B")]
		[Address(RVA = "0x22D7434", Offset = "0x22D7434", VA = "0x7BBCAD7434")]
		public bool HasDescCacheData()
		{
			return default(bool);
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x0002C178 File Offset: 0x0002A378
		[Token(Token = "0x600A56C")]
		[Address(RVA = "0x22D74A0", Offset = "0x22D74A0", VA = "0x7BBCAD74A0")]
		public bool IsBingoInfoDataInited()
		{
			return default(bool);
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x0002C190 File Offset: 0x0002A390
		[Token(Token = "0x600A56D")]
		[Address(RVA = "0x22D74A8", Offset = "0x22D74A8", VA = "0x7BBCAD74A8")]
		public bool IsInOpenPeriod()
		{
			return default(bool);
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A56E")]
		[Address(RVA = "0x22D75C8", Offset = "0x22D75C8", VA = "0x7BBCAD75C8")]
		public CSSharedItemData Bingokey(UIModelBingo.BingoDifficulty difficulty)
		{
			return null;
		}

		// Token: 0x0600A56F RID: 42351 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		[Token(Token = "0x600A56F")]
		[Address(RVA = "0x22D76D4", Offset = "0x22D76D4", VA = "0x7BBCAD76D4")]
		public int BingoKeyCount(UIModelBingo.BingoDifficulty difficulty)
		{
			return 0;
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A570")]
		[Address(RVA = "0x22D7804", Offset = "0x22D7804", VA = "0x7BBCAD7804")]
		public void OnActivityBingoDesc(List<ClientActivityBingoInfoDesc> bingoDifficulyLevelDesc, List<ActivityBingoRewardsDesc> bingoDesc)
		{
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A571")]
		[Address(RVA = "0x22D7AE0", Offset = "0x22D7AE0", VA = "0x7BBCAD7AE0")]
		public void RequestBingoInfo(uint httpOption = 0U, bool force = false)
		{
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A572")]
		[Address(RVA = "0x22D7CD8", Offset = "0x22D7CD8", VA = "0x7BBCAD7CD8")]
		private void BingoInfoDataProcess(CSGetBingoRewardsInfoRes bingoInfoRes)
		{
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A573")]
		[Address(RVA = "0x22D891C", Offset = "0x22D891C", VA = "0x7BBCAD891C")]
		public void RequestFlipCard(UIModelBingo.BingoCard card)
		{
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A574")]
		[Address(RVA = "0x22D8B74", Offset = "0x22D8B74", VA = "0x7BBCAD8B74")]
		public void RequestBingoReward(uint bingoID)
		{
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A575")]
		[Address(RVA = "0x22D8D58", Offset = "0x22D8D58", VA = "0x7BBCAD8D58")]
		public void RequestQuickFinishTask(UIModelBingo.BingoCard card, bool useDiamond = false)
		{
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A576")]
		[Address(RVA = "0x22D905C", Offset = "0x22D905C", VA = "0x7BBCAD905C")]
		public void UpdateRedTips()
		{
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
		[Token(Token = "0x600A577")]
		[Address(RVA = "0x22D8558", Offset = "0x22D8558", VA = "0x7BBCAD8558")]
		private uint GetBingoTask(uint bingoID, int index)
		{
			return 0U;
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A578")]
		[Address(RVA = "0x22D91E8", Offset = "0x22D91E8", VA = "0x7BBCAD91E8")]
		public ActivityBingoRewardsDesc BingoDescOfLine(int line)
		{
			return null;
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A579")]
		[Address(RVA = "0x22D9268", Offset = "0x22D9268", VA = "0x7BBCAD9268")]
		public ActivityBingoRewardsDesc BingoDescOfDifficultyLevel(UIModelBingo.BingoDifficulty difficulty)
		{
			return null;
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		[Token(Token = "0x600A57A")]
		[Address(RVA = "0x22D9328", Offset = "0x22D9328", VA = "0x7BBCAD9328")]
		public bool IsBingoRewardTaskFinished(ActivityBingoRewardsDesc bingoReward)
		{
			return default(bool);
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
		[Token(Token = "0x600A57B")]
		[Address(RVA = "0x22D944C", Offset = "0x22D944C", VA = "0x7BBCAD944C")]
		public UIModelBingo.BingoDifficulty DifficultyOfBingoReward(uint bingoRewardId)
		{
			return UIModelBingo.BingoDifficulty.None;
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x0002C208 File Offset: 0x0002A408
		[Token(Token = "0x600A57C")]
		[Address(RVA = "0x22D9474", Offset = "0x22D9474", VA = "0x7BBCAD9474")]
		public static int RowColumID(int row, int colum)
		{
			return 0;
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A57D")]
		[Address(RVA = "0x22D9480", Offset = "0x22D9480", VA = "0x7BBCAD9480")]
		public UIModelBingo.BingoCard GetDefaultCard(int row, int colum)
		{
			return null;
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A57E")]
		[Address(RVA = "0x22D9514", Offset = "0x22D9514", VA = "0x7BBCAD9514")]
		public UIModelBingo.BingoCard FirstUnFinishCard()
		{
			return null;
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x0002C220 File Offset: 0x0002A420
		[Token(Token = "0x600A57F")]
		[Address(RVA = "0x22D9700", Offset = "0x22D9700", VA = "0x7BBCAD9700")]
		public bool AllCardCanFlip()
		{
			return default(bool);
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A580")]
		[Address(RVA = "0x22D7548", Offset = "0x22D7548", VA = "0x7BBCAD7548")]
		public ClientActivityBingoInfoDesc BingoDifficultyLevelInfo(UIModelBingo.BingoDifficulty difficulty)
		{
			return null;
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A581")]
		[Address(RVA = "0x22D889C", Offset = "0x22D889C", VA = "0x7BBCAD889C")]
		public ActivityBingoRewardsInfo BingoRewardInfo(uint bingoID)
		{
			return null;
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A582")]
		[Address(RVA = "0x22D9878", Offset = "0x22D9878", VA = "0x7BBCAD9878")]
		public ActivityBingoRewardsDesc NextDifficultyBingoRewardDesc(uint bingoID)
		{
			return null;
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A583")]
		[Address(RVA = "0x22D98F8", Offset = "0x22D98F8", VA = "0x7BBCAD98F8")]
		public void UpdateLineReward(int line, ActivityBingoRewardsDesc rewardDesc)
		{
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x0002C238 File Offset: 0x0002A438
		[Token(Token = "0x600A584")]
		[Address(RVA = "0x22D87EC", Offset = "0x22D87EC", VA = "0x7BBCAD87EC")]
		public int LineIDOfBingoReward(uint bingoId)
		{
			return 0;
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x0002C250 File Offset: 0x0002A450
		[Token(Token = "0x600A585")]
		[Address(RVA = "0x22D9970", Offset = "0x22D9970", VA = "0x7BBCAD9970")]
		public bool IsQuickCompleteKeyEnough(UIModelBingo.BingoCard card)
		{
			return default(bool);
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x0002C268 File Offset: 0x0002A468
		[Token(Token = "0x600A586")]
		[Address(RVA = "0x22D99D0", Offset = "0x22D99D0", VA = "0x7BBCAD99D0")]
		public bool IsTaskQuickCompleted(uint taskID)
		{
			return default(bool);
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x0002C280 File Offset: 0x0002A480
		[Token(Token = "0x600A587")]
		[Address(RVA = "0x22D9A40", Offset = "0x22D9A40", VA = "0x7BBCAD9A40")]
		public bool IsAllDifficultyFliped()
		{
			return default(bool);
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A588")]
		[Address(RVA = "0x22D9BA8", Offset = "0x22D9BA8", VA = "0x7BBCAD9BA8")]
		public AwardData GetInitReceivedKeyData()
		{
			return null;
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A589")]
		[Address(RVA = "0x22D9BC0", Offset = "0x22D9BC0", VA = "0x7BBCAD9BC0")]
		public void RemoveInitReceivedkeyData()
		{
		}

		// Token: 0x0600A58A RID: 42378 RVA: 0x0002C298 File Offset: 0x0002A498
		[Token(Token = "0x600A58A")]
		[Address(RVA = "0x22D9BD0", Offset = "0x22D9BD0", VA = "0x7BBCAD9BD0")]
		public bool IsNeedRequestInfoForce()
		{
			return default(bool);
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A58B")]
		[Address(RVA = "0x22D9BFC", Offset = "0x22D9BFC", VA = "0x7BBCAD9BFC")]
		public UIModelBingo()
		{
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A58C")]
		[Address(RVA = "0x22DA150", Offset = "0x22DA150", VA = "0x7BBCADA150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145BCC", Offset = "0x1145BCC")]
		private void <RequestBingoInfo>b__31_0(HttpErrorCode err, object res)
		{
		}

		// Token: 0x0400AB17 RID: 43799
		[Token(Token = "0x400AB17")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ActivityBingoRewardsDesc> m_BingoDesc;

		// Token: 0x0400AB18 RID: 43800
		[Token(Token = "0x400AB18")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, ActivityBingoRewardsInfo> m_BingoInfo;

		// Token: 0x0400AB19 RID: 43801
		[Token(Token = "0x400AB19")]
		[FieldOffset(Offset = "0x28")]
		private CSGetBingoRewardsInfoRes m_BingoInfoRes;

		// Token: 0x0400AB1A RID: 43802
		[Token(Token = "0x400AB1A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_BingoInfoDataInited;

		// Token: 0x0400AB1B RID: 43803
		[Token(Token = "0x400AB1B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, UIModelBingo.BingoCard> m_BingoCards;

		// Token: 0x0400AB1C RID: 43804
		[Token(Token = "0x400AB1C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, UIModelBingo.BingoCard> m_ActiveBingoCards;

		// Token: 0x0400AB1D RID: 43805
		[Token(Token = "0x400AB1D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, ActivityBingoRewardsDesc> m_ActiveBingoDesc;

		// Token: 0x0400AB1E RID: 43806
		[Token(Token = "0x400AB1E")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<UIModelBingo.BingoDifficulty, ClientActivityBingoInfoDesc> m_BingoDifficultyLevelInfo;

		// Token: 0x0400AB1F RID: 43807
		[Token(Token = "0x400AB1F")]
		[FieldOffset(Offset = "0x58")]
		private List<uint> m_Tasks;

		// Token: 0x0400AB20 RID: 43808
		[Token(Token = "0x400AB20")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<uint, int> m_RewardIDLineIDMap;

		// Token: 0x0400AB21 RID: 43809
		[Token(Token = "0x400AB21")]
		[FieldOffset(Offset = "0x68")]
		private List<uint> m_QuickCompletedTasks;

		// Token: 0x0400AB22 RID: 43810
		[Token(Token = "0x400AB22")]
		public const int PropID_GetActivityBingoInfo = 2;

		// Token: 0x0400AB23 RID: 43811
		[Token(Token = "0x400AB23")]
		public const int PropID_FlipBingoCard = 4;

		// Token: 0x0400AB24 RID: 43812
		[Token(Token = "0x400AB24")]
		public const int PropID_BingoRewardGot = 8;

		// Token: 0x0400AB25 RID: 43813
		[Token(Token = "0x400AB25")]
		public const int PropID_QuickFinishTask = 16;

		// Token: 0x0400AB26 RID: 43814
		[Token(Token = "0x400AB26")]
		[FieldOffset(Offset = "0x70")]
		private List<ServiceMessageTypeHTTP> m_RequestQueue;

		// Token: 0x0400AB27 RID: 43815
		[Token(Token = "0x400AB27")]
		[FieldOffset(Offset = "0x78")]
		private int m_OpeningDifficultyLevelCountWhenRequestInfo;

		// Token: 0x02001D8F RID: 7567
		[Token(Token = "0x2001D8F")]
		public enum BingoDifficulty
		{
			// Token: 0x0400AB29 RID: 43817
			[Token(Token = "0x400AB29")]
			None,
			// Token: 0x0400AB2A RID: 43818
			[Token(Token = "0x400AB2A")]
			Low,
			// Token: 0x0400AB2B RID: 43819
			[Token(Token = "0x400AB2B")]
			Middle,
			// Token: 0x0400AB2C RID: 43820
			[Token(Token = "0x400AB2C")]
			High
		}

		// Token: 0x02001D90 RID: 7568
		[Token(Token = "0x2001D90")]
		public enum BingoCardState
		{
			// Token: 0x0400AB2E RID: 43822
			[Token(Token = "0x400AB2E")]
			Lock,
			// Token: 0x0400AB2F RID: 43823
			[Token(Token = "0x400AB2F")]
			UnDone,
			// Token: 0x0400AB30 RID: 43824
			[Token(Token = "0x400AB30")]
			DoneNoFlip,
			// Token: 0x0400AB31 RID: 43825
			[Token(Token = "0x400AB31")]
			Fliped
		}

		// Token: 0x02001D91 RID: 7569
		[Token(Token = "0x2001D91")]
		public enum RewardState
		{
			// Token: 0x0400AB33 RID: 43827
			[Token(Token = "0x400AB33")]
			UnReceive,
			// Token: 0x0400AB34 RID: 43828
			[Token(Token = "0x400AB34")]
			Receive
		}

		// Token: 0x02001D92 RID: 7570
		[Token(Token = "0x2001D92")]
		public class BingoCard
		{
			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x0600A58D RID: 42381 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
			// (set) Token: 0x0600A58E RID: 42382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AE6")]
			public UIModelBingo.BingoCardState State
			{
				[Token(Token = "0x600A58D")]
				[Address(RVA = "0x22D8660", Offset = "0x22D8660", VA = "0x7BBCAD8660")]
				get
				{
					return UIModelBingo.BingoCardState.Lock;
				}
				[Token(Token = "0x600A58E")]
				[Address(RVA = "0x22DAD78", Offset = "0x22DAD78", VA = "0x7BBCADAD78")]
				set
				{
				}
			}

			// Token: 0x0600A58F RID: 42383 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
			[Token(Token = "0x600A58F")]
			[Address(RVA = "0x22DB2C8", Offset = "0x22DB2C8", VA = "0x7BBCADB2C8")]
			public bool IsCurrentTaskDone()
			{
				return default(bool);
			}

			// Token: 0x0600A590 RID: 42384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A590")]
			[Address(RVA = "0x22D865C", Offset = "0x22D865C", VA = "0x7BBCAD865C")]
			public void Init()
			{
			}

			// Token: 0x0600A591 RID: 42385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A591")]
			[Address(RVA = "0x22D8548", Offset = "0x22D8548", VA = "0x7BBCAD8548")]
			public BingoCard()
			{
			}

			// Token: 0x0400AB35 RID: 43829
			[Token(Token = "0x400AB35")]
			[FieldOffset(Offset = "0x10")]
			public int uniqueID;

			// Token: 0x0400AB36 RID: 43830
			[Token(Token = "0x400AB36")]
			[FieldOffset(Offset = "0x14")]
			public int row;

			// Token: 0x0400AB37 RID: 43831
			[Token(Token = "0x400AB37")]
			[FieldOffset(Offset = "0x18")]
			public int colum;

			// Token: 0x0400AB38 RID: 43832
			[Token(Token = "0x400AB38")]
			[FieldOffset(Offset = "0x1C")]
			public UIModelBingo.BingoDifficulty difficulty;

			// Token: 0x0400AB39 RID: 43833
			[Token(Token = "0x400AB39")]
			[FieldOffset(Offset = "0x20")]
			public UIModelBingo.BingoCard NextCard;

			// Token: 0x0400AB3A RID: 43834
			[Token(Token = "0x400AB3A")]
			[FieldOffset(Offset = "0x28")]
			private UIModelBingo.BingoCardState state;

			// Token: 0x0400AB3B RID: 43835
			[Token(Token = "0x400AB3B")]
			[FieldOffset(Offset = "0x2C")]
			public uint taskID;
		}

		// Token: 0x02001D93 RID: 7571
		[Token(Token = "0x2001D93")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF04", Offset = "0x10FBF04")]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x0600A592 RID: 42386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A592")]
			[Address(RVA = "0x22D8B6C", Offset = "0x22D8B6C", VA = "0x7BBCAD8B6C")]
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x0600A593 RID: 42387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A593")]
			[Address(RVA = "0x22DA454", Offset = "0x22DA454", VA = "0x7BBCADA454")]
			internal void <RequestFlipCard>b__0(HttpErrorCode err, object res)
			{
			}

			// Token: 0x0400AB3C RID: 43836
			[Token(Token = "0x400AB3C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBingo.BingoCard card;

			// Token: 0x0400AB3D RID: 43837
			[Token(Token = "0x400AB3D")]
			[FieldOffset(Offset = "0x18")]
			public UIModelBingo <>4__this;
		}

		// Token: 0x02001D94 RID: 7572
		[Token(Token = "0x2001D94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF14", Offset = "0x10FBF14")]
		private sealed class <>c__DisplayClass33_1
		{
			// Token: 0x0600A594 RID: 42388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A594")]
			[Address(RVA = "0x22DAD70", Offset = "0x22DAD70", VA = "0x7BBCADAD70")]
			public <>c__DisplayClass33_1()
			{
			}

			// Token: 0x0600A595 RID: 42389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A595")]
			[Address(RVA = "0x22DAD80", Offset = "0x22DAD80", VA = "0x7BBCADAD80")]
			internal void <RequestFlipCard>b__2(AwardDesc e)
			{
			}

			// Token: 0x0400AB3E RID: 43838
			[Token(Token = "0x400AB3E")]
			[FieldOffset(Offset = "0x10")]
			public List<BaseItemInfo> awardList;

			// Token: 0x0400AB3F RID: 43839
			[Token(Token = "0x400AB3F")]
			[FieldOffset(Offset = "0x18")]
			public Action<AwardDesc> <>9__2;
		}

		// Token: 0x02001D95 RID: 7573
		[Token(Token = "0x2001D95")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF24", Offset = "0x10FBF24")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A597 RID: 42391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A597")]
			[Address(RVA = "0x22DA330", Offset = "0x22DA330", VA = "0x7BBCADA330")]
			public <>c()
			{
			}

			// Token: 0x0600A598 RID: 42392 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
			[Token(Token = "0x600A598")]
			[Address(RVA = "0x22DA338", Offset = "0x22DA338", VA = "0x7BBCADA338")]
			internal int <RequestFlipCard>b__33_1(ActivityBingoRewardsInfo x, ActivityBingoRewardsInfo y)
			{
				return 0;
			}

			// Token: 0x0600A599 RID: 42393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A599")]
			[Address(RVA = "0x22DA380", Offset = "0x22DA380", VA = "0x7BBCADA380")]
			internal CommonRewardItemInfo <RequestFlipCard>b__33_3(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A59A RID: 42394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A59A")]
			[Address(RVA = "0x22DA38C", Offset = "0x22DA38C", VA = "0x7BBCADA38C")]
			internal CommonRewardItemInfo <RequestBingoReward>b__34_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A59B RID: 42395 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
			[Token(Token = "0x600A59B")]
			[Address(RVA = "0x22DA398", Offset = "0x22DA398", VA = "0x7BBCADA398")]
			internal bool <UpdateRedTips>b__36_0(uint e)
			{
				return default(bool);
			}

			// Token: 0x0400AB40 RID: 43840
			[Token(Token = "0x400AB40")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelBingo.<>c <>9;

			// Token: 0x0400AB41 RID: 43841
			[Token(Token = "0x400AB41")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ActivityBingoRewardsInfo> <>9__33_1;

			// Token: 0x0400AB42 RID: 43842
			[Token(Token = "0x400AB42")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__33_3;

			// Token: 0x0400AB43 RID: 43843
			[Token(Token = "0x400AB43")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__34_1;

			// Token: 0x0400AB44 RID: 43844
			[Token(Token = "0x400AB44")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<uint> <>9__36_0;
		}

		// Token: 0x02001D96 RID: 7574
		[Token(Token = "0x2001D96")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF34", Offset = "0x10FBF34")]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0600A59C RID: 42396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A59C")]
			[Address(RVA = "0x22D8D50", Offset = "0x22D8D50", VA = "0x7BBCAD8D50")]
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x0600A59D RID: 42397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A59D")]
			[Address(RVA = "0x22DAE20", Offset = "0x22DAE20", VA = "0x7BBCADAE20")]
			internal void <RequestBingoReward>b__0(HttpErrorCode err, object res)
			{
			}

			// Token: 0x0400AB45 RID: 43845
			[Token(Token = "0x400AB45")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBingo <>4__this;

			// Token: 0x0400AB46 RID: 43846
			[Token(Token = "0x400AB46")]
			[FieldOffset(Offset = "0x18")]
			public uint bingoID;
		}

		// Token: 0x02001D97 RID: 7575
		[Token(Token = "0x2001D97")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF44", Offset = "0x10FBF44")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x0600A59E RID: 42398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A59E")]
			[Address(RVA = "0x22D9054", Offset = "0x22D9054", VA = "0x7BBCAD9054")]
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x0600A59F RID: 42399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A59F")]
			[Address(RVA = "0x22DB190", Offset = "0x22DB190", VA = "0x7BBCADB190")]
			internal void <RequestQuickFinishTask>b__0(HttpErrorCode err, object res)
			{
			}

			// Token: 0x0400AB47 RID: 43847
			[Token(Token = "0x400AB47")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBingo <>4__this;

			// Token: 0x0400AB48 RID: 43848
			[Token(Token = "0x400AB48")]
			[FieldOffset(Offset = "0x18")]
			public CSFinishBingoActivityReq req;

			// Token: 0x0400AB49 RID: 43849
			[Token(Token = "0x400AB49")]
			[FieldOffset(Offset = "0x20")]
			public UIModelBingo.BingoCard card;
		}
	}
}
