using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001EEA RID: 7914
	[Token(Token = "0x2001EEA")]
	public class UIModelLadderMatch : UIBaseModel, IUIModelDataChangeObserver
	{
		// Token: 0x0600ADD2 RID: 44498 RVA: 0x00030330 File Offset: 0x0002E530
		[Token(Token = "0x600ADD2")]
		[Address(RVA = "0x237755C", Offset = "0x237755C", VA = "0x7BBCB7755C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600ADD3 RID: 44499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7A")]
		public LadderRankInfo CurrentLadderRankInfo
		{
			[Token(Token = "0x600ADD3")]
			[Address(RVA = "0x2377564", Offset = "0x2377564", VA = "0x7BBCB77564")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600ADD4 RID: 44500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7B")]
		public uint[] CurrentLadderUsedMapList
		{
			[Token(Token = "0x600ADD4")]
			[Address(RVA = "0x23775D0", Offset = "0x23775D0", VA = "0x7BBCB775D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600ADD5 RID: 44501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7C")]
		public uint[] CurrentLadderSelectedMapList
		{
			[Token(Token = "0x600ADD5")]
			[Address(RVA = "0x23775D8", Offset = "0x23775D8", VA = "0x7BBCB775D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600ADD6 RID: 44502 RVA: 0x00030348 File Offset: 0x0002E548
		[Token(Token = "0x17000B7D")]
		public int CurrentRank
		{
			[Token(Token = "0x600ADD6")]
			[Address(RVA = "0x23775E0", Offset = "0x23775E0", VA = "0x7BBCB775E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600ADD7 RID: 44503 RVA: 0x00030360 File Offset: 0x0002E560
		[Token(Token = "0x17000B7E")]
		public int CurrentLadderScore
		{
			[Token(Token = "0x600ADD7")]
			[Address(RVA = "0x237760C", Offset = "0x237760C", VA = "0x7BBCB7760C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x00030378 File Offset: 0x0002E578
		// (set) Token: 0x0600ADD9 RID: 44505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7F")]
		public int CurrentPeakRankPos
		{
			[Token(Token = "0x600ADD8")]
			[Address(RVA = "0x2377638", Offset = "0x2377638", VA = "0x7BBCB77638")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600ADD9")]
			[Address(RVA = "0x2377640", Offset = "0x2377640", VA = "0x7BBCB77640")]
			set
			{
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600ADDA RID: 44506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B80")]
		public RankingSeasonInfo CurrentSeasonInfo
		{
			[Token(Token = "0x600ADDA")]
			[Address(RVA = "0x2377648", Offset = "0x2377648", VA = "0x7BBCB77648")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600ADDB RID: 44507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ADDC RID: 44508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B81")]
		public RankingInfo LastSeasonRankInfo
		{
			[Token(Token = "0x600ADDB")]
			[Address(RVA = "0x23776B4", Offset = "0x23776B4", VA = "0x7BBCB776B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600ADDC")]
			[Address(RVA = "0x23776BC", Offset = "0x23776BC", VA = "0x7BBCB776BC")]
			set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ADDE RID: 44510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B82")]
		public RankingSeasonInfo LastSeasonInfo
		{
			[Token(Token = "0x600ADDD")]
			[Address(RVA = "0x23776C4", Offset = "0x23776C4", VA = "0x7BBCB776C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600ADDE")]
			[Address(RVA = "0x23776CC", Offset = "0x23776CC", VA = "0x7BBCB776CC")]
			set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600ADDF RID: 44511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B83")]
		public LadderSeasonStatsInfo LadderSeasonStatsInfo
		{
			[Token(Token = "0x600ADDF")]
			[Address(RVA = "0x23776D4", Offset = "0x23776D4", VA = "0x7BBCB776D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B84")]
		public LadderMatchDaily LadderDailyInfo
		{
			[Token(Token = "0x600ADE0")]
			[Address(RVA = "0x2377740", Offset = "0x2377740", VA = "0x7BBCB77740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600ADE1 RID: 44513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B85")]
		public RankCard SelectedRankCardInfo
		{
			[Token(Token = "0x600ADE1")]
			[Address(RVA = "0x23777AC", Offset = "0x23777AC", VA = "0x7BBCB777AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ADE2")]
		[Address(RVA = "0x2377818", Offset = "0x2377818", VA = "0x7BBCB77818")]
		public List<ERanking.ActivityType> GetAvalibleRankingActivityTypes()
		{
			return null;
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x00030390 File Offset: 0x0002E590
		[Token(Token = "0x600ADE3")]
		[Address(RVA = "0x2377820", Offset = "0x2377820", VA = "0x7BBCB77820")]
		public bool isCurrentSeasonOpen()
		{
			return default(bool);
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x000303A8 File Offset: 0x0002E5A8
		[Token(Token = "0x600ADE4")]
		[Address(RVA = "0x23778DC", Offset = "0x23778DC", VA = "0x7BBCB778DC")]
		public bool isBonusRewardMode(uint mode)
		{
			return default(bool);
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600ADE5 RID: 44517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B86")]
		public RankAwardsDesc RankTopAward
		{
			[Token(Token = "0x600ADE5")]
			[Address(RVA = "0x23778E8", Offset = "0x23778E8", VA = "0x7BBCB778E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B87")]
		public List<RankAwardsDesc> CurrentSeasonAwards
		{
			[Token(Token = "0x600ADE6")]
			[Address(RVA = "0x23778F0", Offset = "0x23778F0", VA = "0x7BBCB778F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600ADE7 RID: 44519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B88")]
		public LadderLevelData CurrentLadderLevelData
		{
			[Token(Token = "0x600ADE7")]
			[Address(RVA = "0x23778F8", Offset = "0x23778F8", VA = "0x7BBCB778F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B89")]
		public LadderLevelData NextLadderLevelData
		{
			[Token(Token = "0x600ADE8")]
			[Address(RVA = "0x23779C0", Offset = "0x23779C0", VA = "0x7BBCB779C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600ADE9 RID: 44521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B8A")]
		public LadderLevelData MaxLadderLevelData
		{
			[Token(Token = "0x600ADE9")]
			[Address(RVA = "0x2377A88", Offset = "0x2377A88", VA = "0x7BBCB77A88")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADEA")]
		[Address(RVA = "0x2377B5C", Offset = "0x2377B5C", VA = "0x7BBCB77B5C", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600ADEB RID: 44523 RVA: 0x000303C0 File Offset: 0x0002E5C0
		[Token(Token = "0x600ADEB")]
		[Address(RVA = "0x2377C10", Offset = "0x2377C10", VA = "0x7BBCB77C10")]
		public bool IsPeakRank(int rank, float rankPoint)
		{
			return default(bool);
		}

		// Token: 0x0600ADEC RID: 44524 RVA: 0x000303D8 File Offset: 0x0002E5D8
		[Token(Token = "0x600ADEC")]
		[Address(RVA = "0x2377CF0", Offset = "0x2377CF0", VA = "0x7BBCB77CF0")]
		public bool IsLastSeasonPeakRank(int rank, float rankPoint)
		{
			return default(bool);
		}

		// Token: 0x0600ADED RID: 44525 RVA: 0x000303F0 File Offset: 0x0002E5F0
		[Token(Token = "0x600ADED")]
		[Address(RVA = "0x2377DD0", Offset = "0x2377DD0", VA = "0x7BBCB77DD0")]
		public bool IsCurrentUserPeakRank()
		{
			return default(bool);
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x00030408 File Offset: 0x0002E608
		[Token(Token = "0x17000B8B")]
		public bool IsMaxLadderLevel
		{
			[Token(Token = "0x600ADEE")]
			[Address(RVA = "0x2377E08", Offset = "0x2377E08", VA = "0x7BBCB77E08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x00030420 File Offset: 0x0002E620
		// (set) Token: 0x0600ADF0 RID: 44528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B8C")]
		public bool ShowCallsignRank
		{
			[Token(Token = "0x600ADEF")]
			[Address(RVA = "0x2377EA0", Offset = "0x2377EA0", VA = "0x7BBCB77EA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ADF0")]
			[Address(RVA = "0x2377EA8", Offset = "0x2377EA8", VA = "0x7BBCB77EA8")]
			set
			{
			}
		}

		// Token: 0x0600ADF1 RID: 44529 RVA: 0x00030438 File Offset: 0x0002E638
		[Token(Token = "0x600ADF1")]
		[Address(RVA = "0x2377EB4", Offset = "0x2377EB4", VA = "0x7BBCB77EB4")]
		public ResourceID GetRankIcon(int rank, float rankScore, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
		{
			return default(ResourceID);
		}

		// Token: 0x0600ADF2 RID: 44530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF2")]
		[Address(RVA = "0x2378038", Offset = "0x2378038", VA = "0x7BBCB78038")]
		public void GetSeasonInfoConfigFromServer([Optional] UIModelLadderMatch.OnFinishedDelegate onFinished, uint httpOp = 0U)
		{
		}

		// Token: 0x0600ADF3 RID: 44531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF3")]
		[Address(RVA = "0x2378250", Offset = "0x2378250", VA = "0x7BBCB78250")]
		public void ProcessSeasonInfoConfig(CSGetCurrentOrRecentRankingSeasonConfigRes season_info_res)
		{
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF4")]
		[Address(RVA = "0x23786B0", Offset = "0x23786B0", VA = "0x7BBCB786B0")]
		public void ProcessRankFirstWin(RankingMatchParam _param)
		{
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF5")]
		[Address(RVA = "0x2378730", Offset = "0x2378730", VA = "0x7BBCB78730")]
		public void ProcessLadderActivityInfo(CSGetRankingActivityConfigRes _res)
		{
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF6")]
		[Address(RVA = "0x2378930", Offset = "0x2378930", VA = "0x7BBCB78930")]
		public void RefreshRankInfo(uint httpOp = 0U, bool forceRefresh = false)
		{
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF7")]
		[Address(RVA = "0x2378A98", Offset = "0x2378A98", VA = "0x7BBCB78A98")]
		public void GetRankInfoFromServer(uint httpOp = 0U)
		{
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF8")]
		[Address(RVA = "0x2378C58", Offset = "0x2378C58", VA = "0x7BBCB78C58")]
		public void SetShowRank(bool showRank)
		{
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADF9")]
		[Address(RVA = "0x2378E88", Offset = "0x2378E88", VA = "0x7BBCB78E88")]
		public void ChooseRankCard(uint cardId)
		{
		}

		// Token: 0x0600ADFA RID: 44538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADFA")]
		[Address(RVA = "0x237904C", Offset = "0x237904C", VA = "0x7BBCB7904C")]
		public void RequestPeakRankPos()
		{
		}

		// Token: 0x0600ADFB RID: 44539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADFB")]
		[Address(RVA = "0x2379408", Offset = "0x2379408", VA = "0x7BBCB79408")]
		public void GetPlayerRankingSeasonStats()
		{
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADFC")]
		[Address(RVA = "0x23795E0", Offset = "0x23795E0", VA = "0x7BBCB795E0")]
		private void OnGetLadderHasFirstWind()
		{
		}

		// Token: 0x0600ADFD RID: 44541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADFD")]
		[Address(RVA = "0x237964C", Offset = "0x237964C", VA = "0x7BBCB7964C")]
		public void GetLadderHasFirstWin(bool preload = false, bool silence = false)
		{
		}

		// Token: 0x0600ADFE RID: 44542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADFE")]
		[Address(RVA = "0x237624C", Offset = "0x237624C", VA = "0x7BBCB7624C")]
		public void UpdateRankCard(uint[] _cardInfo)
		{
		}

		// Token: 0x0600ADFF RID: 44543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADFF")]
		[Address(RVA = "0x2379884", Offset = "0x2379884", VA = "0x7BBCB79884")]
		public void RequestError()
		{
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE00")]
		[Address(RVA = "0x237998C", Offset = "0x237998C", VA = "0x7BBCB7998C", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE01")]
		[Address(RVA = "0x237A3E8", Offset = "0x237A3E8", VA = "0x7BBCB7A3E8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE02")]
		[Address(RVA = "0x237A4C8", Offset = "0x237A4C8", VA = "0x7BBCB7A4C8")]
		public void SetSeasonChangeInfo(uint season_id)
		{
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600AE03 RID: 44547 RVA: 0x00030450 File Offset: 0x0002E650
		[Token(Token = "0x17000B8D")]
		public LatestRankInfo RankInfo
		{
			[Token(Token = "0x600AE03")]
			[Address(RVA = "0x237A6E8", Offset = "0x237A6E8", VA = "0x7BBCB7A6E8")]
			get
			{
				return default(LatestRankInfo);
			}
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE04")]
		[Address(RVA = "0x237A6FC", Offset = "0x237A6FC", VA = "0x7BBCB7A6FC")]
		public void SetLatestRankInfo(bool isRank, uint rankBefore, uint rankAfter, int scoreBefore, int scoreAfter)
		{
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x00030468 File Offset: 0x0002E668
		[Token(Token = "0x600AE05")]
		[Address(RVA = "0x237A738", Offset = "0x237A738", VA = "0x7BBCB7A738")]
		private bool CheckIsNeedRankComparePop()
		{
			return default(bool);
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE06")]
		[Address(RVA = "0x237AB44", Offset = "0x237AB44", VA = "0x7BBCB7AB44")]
		public List<LeaderBoardInfo> ConstructRankCompareFriendRankList()
		{
			return null;
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE07")]
		[Address(RVA = "0x237AFE8", Offset = "0x237AFE8", VA = "0x7BBCB7AFE8")]
		public void DebugGenerateFakeLatestRankInfo()
		{
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE08")]
		[Address(RVA = "0x237B1EC", Offset = "0x237B1EC", VA = "0x7BBCB7B1EC", Slot = "14")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x00030480 File Offset: 0x0002E680
		[Token(Token = "0x600AE09")]
		[Address(RVA = "0x237B424", Offset = "0x237B424", VA = "0x7BBCB7B424", Slot = "15")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600AE0A RID: 44554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B8E")]
		public List<MapOpeningInfo> CurrentLadderMapOpeningInfo
		{
			[Token(Token = "0x600AE0A")]
			[Address(RVA = "0x237B468", Offset = "0x237B468", VA = "0x7BBCB7B468")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE0B")]
		[Address(RVA = "0x23785CC", Offset = "0x23785CC", VA = "0x7BBCB785CC")]
		public void SetSelectedLadderMap()
		{
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE0C")]
		[Address(RVA = "0x237B470", Offset = "0x237B470", VA = "0x7BBCB7B470")]
		public void UpdateCurrentLadderMapOpeningInfo()
		{
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE0D")]
		[Address(RVA = "0x237B35C", Offset = "0x237B35C", VA = "0x7BBCB7B35C")]
		private void RefreshCurrentLadderMapAfterDownload()
		{
		}

		// Token: 0x0600AE0E RID: 44558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE0E")]
		[Address(RVA = "0x237C2F0", Offset = "0x237C2F0", VA = "0x7BBCB7C2F0")]
		public void SaveSelectedRankMaps(Dictionary<uint, bool> mapSelectDictory)
		{
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x00030498 File Offset: 0x0002E698
		[Token(Token = "0x600AE0F")]
		[Address(RVA = "0x237C6AC", Offset = "0x237C6AC", VA = "0x7BBCB7C6AC")]
		public int GetSelectedMapCount()
		{
			return 0;
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x000304B0 File Offset: 0x0002E6B0
		[Token(Token = "0x600AE10")]
		[Address(RVA = "0x237C6D8", Offset = "0x237C6D8", VA = "0x7BBCB7C6D8")]
		public bool RankMapHasSelected(uint mapID)
		{
			return default(bool);
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE11")]
		[Address(RVA = "0x237B8A4", Offset = "0x237B8A4", VA = "0x7BBCB7B8A4")]
		private void RefreshSelectedRankMap()
		{
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE12")]
		[Address(RVA = "0x237C788", Offset = "0x237C788", VA = "0x7BBCB7C788")]
		public uint[] GetSelectedRankingMaps()
		{
			return null;
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x000304C8 File Offset: 0x0002E6C8
		[Token(Token = "0x600AE13")]
		[Address(RVA = "0x237D14C", Offset = "0x237D14C", VA = "0x7BBCB7D14C")]
		public int GetMapsAddRP()
		{
			return 0;
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE14")]
		[Address(RVA = "0x2379E14", Offset = "0x2379E14", VA = "0x7BBCB79E14")]
		private void GetSeasonData(uint season_id, uint rank_point)
		{
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE15")]
		[Address(RVA = "0x237A00C", Offset = "0x237A00C", VA = "0x7BBCB7A00C")]
		private void GetRankThresholdScore(uint season_id, string region)
		{
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE16")]
		[Address(RVA = "0x237D340", Offset = "0x237D340", VA = "0x7BBCB7D340")]
		public UIModelLadderMatch()
		{
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE17")]
		[Address(RVA = "0x237D594", Offset = "0x237D594", VA = "0x7BBCB7D594")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11465CC", Offset = "0x11465CC")]
		private void <GetRankInfoFromServer>b__98_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE18")]
		[Address(RVA = "0x237DA50", Offset = "0x237DA50", VA = "0x7BBCB7DA50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11465DC", Offset = "0x11465DC")]
		private void <ChooseRankCard>b__100_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AE19 RID: 44569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE19")]
		[Address(RVA = "0x237DC98", Offset = "0x237DC98", VA = "0x7BBCB7DC98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11465EC", Offset = "0x11465EC")]
		private void <RequestPeakRankPos>b__101_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AE1A RID: 44570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE1A")]
		[Address(RVA = "0x237DDB8", Offset = "0x237DDB8", VA = "0x7BBCB7DDB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11465FC", Offset = "0x11465FC")]
		private void <GetPlayerRankingSeasonStats>b__102_0(HttpErrorCode errodCode, object res)
		{
		}

		// Token: 0x0600AE1B RID: 44571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE1B")]
		[Address(RVA = "0x237E0B8", Offset = "0x237E0B8", VA = "0x7BBCB7E0B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114660C", Offset = "0x114660C")]
		private void <GetRankThresholdScore>b__137_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B1FC RID: 45564
		[Token(Token = "0x400B1FC")]
		public const string RANK_MAP_SELECT = "rank_map_select";

		// Token: 0x0400B1FD RID: 45565
		[Token(Token = "0x400B1FD")]
		public const uint PropID_RankInfoRefreshed = 2U;

		// Token: 0x0400B1FE RID: 45566
		[Token(Token = "0x400B1FE")]
		public const uint PropID_SeasonInfoRefreshed = 4U;

		// Token: 0x0400B1FF RID: 45567
		[Token(Token = "0x400B1FF")]
		public const uint PropID_SetShowRankSuccess = 8U;

		// Token: 0x0400B200 RID: 45568
		[Token(Token = "0x400B200")]
		public const uint PropID_FirstWinRefreshed = 16U;

		// Token: 0x0400B201 RID: 45569
		[Token(Token = "0x400B201")]
		public const uint PropID_SeasonStatsRefresh = 32U;

		// Token: 0x0400B202 RID: 45570
		[Token(Token = "0x400B202")]
		public const uint PropID_SetChooseRankCardSuccess = 64U;

		// Token: 0x0400B203 RID: 45571
		[Token(Token = "0x400B203")]
		public const uint PropID_RankActivityRefreshed = 128U;

		// Token: 0x0400B204 RID: 45572
		[Token(Token = "0x400B204")]
		public const uint PropID_PeakRankPosRefresh = 128U;

		// Token: 0x0400B205 RID: 45573
		[Token(Token = "0x400B205")]
		public const uint PropID_RankMapSelectConfirmed = 256U;

		// Token: 0x0400B206 RID: 45574
		[Token(Token = "0x400B206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<ERanking.ActivityType, string> ERankActivityTypeForLocKeyMap;

		// Token: 0x0400B207 RID: 45575
		[Token(Token = "0x400B207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LadderRankInfo m_CurrentLadderRankInfo;

		// Token: 0x0400B208 RID: 45576
		[Token(Token = "0x400B208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_HasGotLadderInfo;

		// Token: 0x0400B209 RID: 45577
		[Token(Token = "0x400B209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_NextReqRankInfoTime;

		// Token: 0x0400B20A RID: 45578
		[Token(Token = "0x400B20A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_NextReqRankStatTime;

		// Token: 0x0400B20B RID: 45579
		[Token(Token = "0x400B20B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint[] m_CurrentLadderUsedMapList;

		// Token: 0x0400B20C RID: 45580
		[Token(Token = "0x400B20C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint[] m_CurrentLadderSelectedMapList;

		// Token: 0x0400B20D RID: 45581
		[Token(Token = "0x400B20D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int cachedMaxRank;

		// Token: 0x0400B20E RID: 45582
		[Token(Token = "0x400B20E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool isMaxRankDirty;

		// Token: 0x0400B20F RID: 45583
		[Token(Token = "0x400B20F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int currentPeakRankPos;

		// Token: 0x0400B210 RID: 45584
		[Token(Token = "0x400B210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RankingSeasonInfo m_CurrentSeasonInfo;

		// Token: 0x0400B211 RID: 45585
		[Token(Token = "0x400B211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RankingInfo m_LastSeasonRankInfo;

		// Token: 0x0400B212 RID: 45586
		[Token(Token = "0x400B212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RankingSeasonInfo m_LastSeasonInfo;

		// Token: 0x0400B213 RID: 45587
		[Token(Token = "0x400B213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LadderSeasonStatsInfo m_LadderSeasonInfo;

		// Token: 0x0400B214 RID: 45588
		[Token(Token = "0x400B214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private LadderMatchDaily m_LadderDailyInfo;

		// Token: 0x0400B215 RID: 45589
		[Token(Token = "0x400B215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RankCard m_RankCard;

		// Token: 0x0400B216 RID: 45590
		[Token(Token = "0x400B216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<ERanking.ActivityType> ladderActivityTypes;

		// Token: 0x0400B217 RID: 45591
		[Token(Token = "0x400B217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<RankAwardsDesc> m_CurrentSeasonAwards;

		// Token: 0x0400B218 RID: 45592
		[Token(Token = "0x400B218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RankAwardsDesc m_RankTopAward;

		// Token: 0x0400B219 RID: 45593
		[Token(Token = "0x400B219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private LadderLevelData m_CurrentLadderLevelData;

		// Token: 0x0400B21A RID: 45594
		[Token(Token = "0x400B21A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LadderLevelData m_NextLadderLevelData;

		// Token: 0x0400B21B RID: 45595
		[Token(Token = "0x400B21B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LadderLevelData m_MaxLadderLevelData;

		// Token: 0x0400B21C RID: 45596
		[Token(Token = "0x400B21C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_LastRequestPeakRankTime;

		// Token: 0x0400B21D RID: 45597
		[Token(Token = "0x400B21D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool isLastReachPeakRank;

		// Token: 0x0400B21E RID: 45598
		[Token(Token = "0x400B21E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public double PeakRankThreshold;

		// Token: 0x0400B21F RID: 45599
		[Token(Token = "0x400B21F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public double LastPeakRankThreshold;

		// Token: 0x0400B220 RID: 45600
		[Token(Token = "0x400B220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private CSPlayerRankingInfoReq m_PendingInfoRequest;

		// Token: 0x0400B221 RID: 45601
		[Token(Token = "0x400B221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Empty m_PendingSeasonRequest;

		// Token: 0x0400B222 RID: 45602
		[Token(Token = "0x400B222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private CSSetShowRankReq m_PendingShowRankRequest;

		// Token: 0x0400B223 RID: 45603
		[Token(Token = "0x400B223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CSChooseRankingCardsReq m_PendingSetChooseRankingCardRequest;

		// Token: 0x0400B224 RID: 45604
		[Token(Token = "0x400B224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_ShowCallsignRank;

		// Token: 0x0400B225 RID: 45605
		[Token(Token = "0x400B225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool m_PreloadLadder;

		// Token: 0x0400B226 RID: 45606
		[Token(Token = "0x400B226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private LatestRankInfo m_LatestRankInfo;

		// Token: 0x0400B227 RID: 45607
		[Token(Token = "0x400B227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<LeaderBoardInfo> ExceededPlatformFriendList;

		// Token: 0x0400B228 RID: 45608
		[Token(Token = "0x400B228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public List<LeaderBoardInfo> ExceededFriendList;

		// Token: 0x0400B229 RID: 45609
		[Token(Token = "0x400B229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool NeedRankComparisonPop;

		// Token: 0x0400B22A RID: 45610
		[Token(Token = "0x400B22A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public int SelfIndex;

		// Token: 0x0400B22B RID: 45611
		[Token(Token = "0x400B22B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<MapOpeningInfo> m_CurrentLadderMapOpeningInfo;

		// Token: 0x02001EEB RID: 7915
		// (Invoke) Token: 0x0600AE1D RID: 44573
		[Token(Token = "0x2001EEB")]
		public delegate void OnFinishedDelegate();

		// Token: 0x02001EEC RID: 7916
		[Token(Token = "0x2001EEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC44", Offset = "0x10FCC44")]
		private sealed class <>c__DisplayClass93_0
		{
			// Token: 0x0600AE20 RID: 44576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE20")]
			[Address(RVA = "0x2378248", Offset = "0x2378248", VA = "0x7BBCB78248")]
			public <>c__DisplayClass93_0()
			{
			}

			// Token: 0x0600AE21 RID: 44577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE21")]
			[Address(RVA = "0x237E8F4", Offset = "0x237E8F4", VA = "0x7BBCB7E8F4")]
			internal void <GetSeasonInfoConfigFromServer>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B22C RID: 45612
			[Token(Token = "0x400B22C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch <>4__this;

			// Token: 0x0400B22D RID: 45613
			[Token(Token = "0x400B22D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLadderMatch.OnFinishedDelegate onFinished;
		}

		// Token: 0x02001EED RID: 7917
		[Token(Token = "0x2001EED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC54", Offset = "0x10FCC54")]
		private sealed class <>c__DisplayClass97_0
		{
			// Token: 0x0600AE22 RID: 44578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE22")]
			[Address(RVA = "0x2378A80", Offset = "0x2378A80", VA = "0x7BBCB78A80")]
			public <>c__DisplayClass97_0()
			{
			}

			// Token: 0x0600AE23 RID: 44579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE23")]
			[Address(RVA = "0x237EE0C", Offset = "0x237EE0C", VA = "0x7BBCB7EE0C")]
			internal void <RefreshRankInfo>b__0()
			{
			}

			// Token: 0x0400B22E RID: 45614
			[Token(Token = "0x400B22E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch <>4__this;

			// Token: 0x0400B22F RID: 45615
			[Token(Token = "0x400B22F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint httpOp;
		}

		// Token: 0x02001EEE RID: 7918
		[Token(Token = "0x2001EEE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC64", Offset = "0x10FCC64")]
		private sealed class <>c__DisplayClass99_0
		{
			// Token: 0x0600AE24 RID: 44580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE24")]
			[Address(RVA = "0x2378E80", Offset = "0x2378E80", VA = "0x7BBCB78E80")]
			public <>c__DisplayClass99_0()
			{
			}

			// Token: 0x0600AE25 RID: 44581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE25")]
			[Address(RVA = "0x237EE40", Offset = "0x237EE40", VA = "0x7BBCB7EE40")]
			internal void <SetShowRank>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B230 RID: 45616
			[Token(Token = "0x400B230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch <>4__this;

			// Token: 0x0400B231 RID: 45617
			[Token(Token = "0x400B231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool showRank;
		}

		// Token: 0x02001EEF RID: 7919
		[Token(Token = "0x2001EEF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC74", Offset = "0x10FCC74")]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x0600AE26 RID: 44582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE26")]
			[Address(RVA = "0x237987C", Offset = "0x237987C", VA = "0x7BBCB7987C")]
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x0600AE27 RID: 44583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE27")]
			[Address(RVA = "0x237E2E0", Offset = "0x237E2E0", VA = "0x7BBCB7E2E0")]
			internal void <GetLadderHasFirstWin>b__0(HttpErrorCode errodCode, object res)
			{
			}

			// Token: 0x0400B232 RID: 45618
			[Token(Token = "0x400B232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch <>4__this;

			// Token: 0x0400B233 RID: 45619
			[Token(Token = "0x400B233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001EF0 RID: 7920
		[Token(Token = "0x2001EF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC84", Offset = "0x10FCC84")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AE29 RID: 44585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE29")]
			[Address(RVA = "0x237E204", Offset = "0x237E204", VA = "0x7BBCB7E204")]
			public <>c()
			{
			}

			// Token: 0x0600AE2A RID: 44586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE2A")]
			[Address(RVA = "0x237E20C", Offset = "0x237E20C", VA = "0x7BBCB7E20C")]
			internal void <SetSeasonChangeInfo>b__110_0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AE2B RID: 44587 RVA: 0x000304E0 File Offset: 0x0002E6E0
			[Token(Token = "0x600AE2B")]
			[Address(RVA = "0x237E210", Offset = "0x237E210", VA = "0x7BBCB7E210")]
			internal bool <CheckIsNeedRankComparePop>b__119_1(LeaderBoardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0600AE2C RID: 44588 RVA: 0x000304F8 File Offset: 0x0002E6F8
			[Token(Token = "0x600AE2C")]
			[Address(RVA = "0x237E244", Offset = "0x237E244", VA = "0x7BBCB7E244")]
			internal bool <UpdateCurrentLadderMapOpeningInfo>b__128_0(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AE2D RID: 44589 RVA: 0x00030510 File Offset: 0x0002E710
			[Token(Token = "0x600AE2D")]
			[Address(RVA = "0x237E278", Offset = "0x237E278", VA = "0x7BBCB7E278")]
			internal bool <RefreshSelectedRankMap>b__133_0(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AE2E RID: 44590 RVA: 0x00030528 File Offset: 0x0002E728
			[Token(Token = "0x600AE2E")]
			[Address(RVA = "0x237E2AC", Offset = "0x237E2AC", VA = "0x7BBCB7E2AC")]
			internal bool <GetSelectedRankingMaps>b__134_0(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B234 RID: 45620
			[Token(Token = "0x400B234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelLadderMatch.<>c <>9;

			// Token: 0x0400B235 RID: 45621
			[Token(Token = "0x400B235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__110_0;

			// Token: 0x0400B236 RID: 45622
			[Token(Token = "0x400B236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<LeaderBoardInfo> <>9__119_1;

			// Token: 0x0400B237 RID: 45623
			[Token(Token = "0x400B237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<MapOpeningInfo> <>9__128_0;

			// Token: 0x0400B238 RID: 45624
			[Token(Token = "0x400B238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<MapOpeningInfo> <>9__133_0;

			// Token: 0x0400B239 RID: 45625
			[Token(Token = "0x400B239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<MapOpeningInfo> <>9__134_0;
		}

		// Token: 0x02001EF1 RID: 7921
		[Token(Token = "0x2001EF1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC94", Offset = "0x10FCC94")]
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x0600AE2F RID: 44591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE2F")]
			[Address(RVA = "0x237AA20", Offset = "0x237AA20", VA = "0x7BBCB7AA20")]
			public <>c__DisplayClass119_0()
			{
			}

			// Token: 0x0600AE30 RID: 44592 RVA: 0x00030540 File Offset: 0x0002E740
			[Token(Token = "0x600AE30")]
			[Address(RVA = "0x237E428", Offset = "0x237E428", VA = "0x7BBCB7E428")]
			internal bool <CheckIsNeedRankComparePop>b__0(LeaderBoardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400B23A RID: 45626
			[Token(Token = "0x400B23A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch <>4__this;

			// Token: 0x0400B23B RID: 45627
			[Token(Token = "0x400B23B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong account_id;
		}

		// Token: 0x02001EF2 RID: 7922
		[Token(Token = "0x2001EF2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCCA4", Offset = "0x10FCCA4")]
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x0600AE31 RID: 44593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE31")]
			[Address(RVA = "0x237AFE0", Offset = "0x237AFE0", VA = "0x7BBCB7AFE0")]
			public <>c__DisplayClass120_0()
			{
			}

			// Token: 0x0600AE32 RID: 44594 RVA: 0x00030558 File Offset: 0x0002E758
			[Token(Token = "0x600AE32")]
			[Address(RVA = "0x237E4C4", Offset = "0x237E4C4", VA = "0x7BBCB7E4C4")]
			internal bool <ConstructRankCompareFriendRankList>b__0(LeaderBoardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0600AE33 RID: 44595 RVA: 0x00030570 File Offset: 0x0002E770
			[Token(Token = "0x600AE33")]
			[Address(RVA = "0x237E500", Offset = "0x237E500", VA = "0x7BBCB7E500")]
			internal bool <ConstructRankCompareFriendRankList>b__1(LeaderBoardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400B23C RID: 45628
			[Token(Token = "0x400B23C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong account_id;
		}

		// Token: 0x02001EF3 RID: 7923
		[Token(Token = "0x2001EF3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCCB4", Offset = "0x10FCCB4")]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x0600AE34 RID: 44596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE34")]
			[Address(RVA = "0x237C2E8", Offset = "0x237C2E8", VA = "0x7BBCB7C2E8")]
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x0600AE35 RID: 44597 RVA: 0x00030588 File Offset: 0x0002E788
			[Token(Token = "0x600AE35")]
			[Address(RVA = "0x237E53C", Offset = "0x237E53C", VA = "0x7BBCB7E53C")]
			internal bool <UpdateCurrentLadderMapOpeningInfo>b__1(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B23D RID: 45629
			[Token(Token = "0x400B23D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B23E RID: 45630
			[Token(Token = "0x400B23E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLadderMatch <>4__this;
		}

		// Token: 0x02001EF4 RID: 7924
		[Token(Token = "0x2001EF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCCC4", Offset = "0x10FCCC4")]
		private sealed class <>c__DisplayClass133_0
		{
			// Token: 0x0600AE36 RID: 44598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE36")]
			[Address(RVA = "0x237C780", Offset = "0x237C780", VA = "0x7BBCB7C780")]
			public <>c__DisplayClass133_0()
			{
			}

			// Token: 0x0600AE37 RID: 44599 RVA: 0x000305A0 File Offset: 0x0002E7A0
			[Token(Token = "0x600AE37")]
			[Address(RVA = "0x237E5D4", Offset = "0x237E5D4", VA = "0x7BBCB7E5D4")]
			internal bool <RefreshSelectedRankMap>b__1(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B23F RID: 45631
			[Token(Token = "0x400B23F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B240 RID: 45632
			[Token(Token = "0x400B240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLadderMatch <>4__this;
		}

		// Token: 0x02001EF5 RID: 7925
		[Token(Token = "0x2001EF5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCCD4", Offset = "0x10FCCD4")]
		private sealed class <>c__DisplayClass134_0
		{
			// Token: 0x0600AE38 RID: 44600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE38")]
			[Address(RVA = "0x237D144", Offset = "0x237D144", VA = "0x7BBCB7D144")]
			public <>c__DisplayClass134_0()
			{
			}

			// Token: 0x0600AE39 RID: 44601 RVA: 0x000305B8 File Offset: 0x0002E7B8
			[Token(Token = "0x600AE39")]
			[Address(RVA = "0x237E66C", Offset = "0x237E66C", VA = "0x7BBCB7E66C")]
			internal bool <GetSelectedRankingMaps>b__1(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B241 RID: 45633
			[Token(Token = "0x400B241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B242 RID: 45634
			[Token(Token = "0x400B242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLadderMatch <>4__this;
		}

		// Token: 0x02001EF6 RID: 7926
		[Token(Token = "0x2001EF6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCCE4", Offset = "0x10FCCE4")]
		private sealed class <>c__DisplayClass136_0
		{
			// Token: 0x0600AE3A RID: 44602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE3A")]
			[Address(RVA = "0x237D338", Offset = "0x237D338", VA = "0x7BBCB7D338")]
			public <>c__DisplayClass136_0()
			{
			}

			// Token: 0x0600AE3B RID: 44603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE3B")]
			[Address(RVA = "0x237E704", Offset = "0x237E704", VA = "0x7BBCB7E704")]
			internal void <GetSeasonData>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B243 RID: 45635
			[Token(Token = "0x400B243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch <>4__this;

			// Token: 0x0400B244 RID: 45636
			[Token(Token = "0x400B244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint season_id;

			// Token: 0x0400B245 RID: 45637
			[Token(Token = "0x400B245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint rank_point;
		}
	}
}
