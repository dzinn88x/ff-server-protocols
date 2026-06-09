using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001EF7 RID: 7927
	[Token(Token = "0x2001EF7")]
	public class UIModelLeaderBoard : UIBaseModel
	{
		// Token: 0x0600AE3C RID: 44604 RVA: 0x000305D0 File Offset: 0x0002E7D0
		[Token(Token = "0x600AE3C")]
		[Address(RVA = "0x237F030", Offset = "0x237F030", VA = "0x7BBCB7F030", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE3D")]
		[Address(RVA = "0x237F038", Offset = "0x237F038", VA = "0x7BBCB7F038")]
		public LeaderBoardInfo GetLocalPlayerInfo(int propID)
		{
			return null;
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE3E")]
		[Address(RVA = "0x237F0C0", Offset = "0x237F0C0", VA = "0x7BBCB7F0C0")]
		private void SetLocalPlayerInfo(int propID, LeaderBoardInfo info)
		{
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE3F")]
		[Address(RVA = "0x237AA28", Offset = "0x237AA28", VA = "0x7BBCB7AA28")]
		public List<LeaderBoardInfo> GetLeaderBoardList(int propID)
		{
			return null;
		}

		// Token: 0x0600AE40 RID: 44608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE40")]
		[Address(RVA = "0x237F138", Offset = "0x237F138", VA = "0x7BBCB7F138", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AE41 RID: 44609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE41")]
		[Address(RVA = "0x237F254", Offset = "0x237F254", VA = "0x7BBCB7F254")]
		public void ClearFriendRequestWhenFail()
		{
		}

		// Token: 0x0600AE42 RID: 44610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE42")]
		[Address(RVA = "0x237F390", Offset = "0x237F390", VA = "0x7BBCB7F390")]
		public void UpdateFriendBoard(List<FriendAccountInfo> friend_list, EAccountAdscription type, bool isLadder = false)
		{
		}

		// Token: 0x0600AE43 RID: 44611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE43")]
		[Address(RVA = "0x23803C0", Offset = "0x23803C0", VA = "0x7BBCB803C0")]
		public void CacheUpdateSelfEPBadge()
		{
		}

		// Token: 0x0600AE44 RID: 44612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE44")]
		[Address(RVA = "0x2380638", Offset = "0x2380638", VA = "0x7BBCB80638")]
		private void CacheUpdateEPBadgeCount(int propID, ulong accountId, uint count)
		{
		}

		// Token: 0x0600AE45 RID: 44613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE45")]
		[Address(RVA = "0x2380240", Offset = "0x2380240", VA = "0x7BBCB80240")]
		public void SortFriendBoardWithPropID(int propID, List<LeaderBoardInfo> board_list)
		{
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x000305E8 File Offset: 0x0002E7E8
		[Token(Token = "0x600AE46")]
		[Address(RVA = "0x23808AC", Offset = "0x23808AC", VA = "0x7BBCB808AC")]
		public int SortFriendBoardItemWithScore(LeaderBoardInfo a, LeaderBoardInfo b)
		{
			return 0;
		}

		// Token: 0x0600AE47 RID: 44615 RVA: 0x00030600 File Offset: 0x0002E800
		[Token(Token = "0x600AE47")]
		[Address(RVA = "0x238094C", Offset = "0x238094C", VA = "0x7BBCB8094C")]
		public int SortFriendBoardItemWithWins(LeaderBoardInfo a, LeaderBoardInfo b)
		{
			return 0;
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x00030618 File Offset: 0x0002E818
		[Token(Token = "0x600AE48")]
		[Address(RVA = "0x23809EC", Offset = "0x23809EC", VA = "0x7BBCB809EC")]
		public int SortFriendBoardItemWithKills(LeaderBoardInfo a, LeaderBoardInfo b)
		{
			return 0;
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x00030630 File Offset: 0x0002E830
		[Token(Token = "0x600AE49")]
		[Address(RVA = "0x2380A8C", Offset = "0x2380A8C", VA = "0x7BBCB80A8C")]
		public int SortFriendBoardItemWithCSKills(LeaderBoardInfo a, LeaderBoardInfo b)
		{
			return 0;
		}

		// Token: 0x0600AE4A RID: 44618 RVA: 0x00030648 File Offset: 0x0002E848
		[Token(Token = "0x600AE4A")]
		[Address(RVA = "0x2380B2C", Offset = "0x2380B2C", VA = "0x7BBCB80B2C")]
		public int SortBoardItemWithEPBadges(LeaderBoardInfo a, LeaderBoardInfo b)
		{
			return 0;
		}

		// Token: 0x0600AE4B RID: 44619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4B")]
		[Address(RVA = "0x237F160", Offset = "0x237F160", VA = "0x7BBCB7F160")]
		public void ClearLeaderBoardData()
		{
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4C")]
		[Address(RVA = "0x2380BCC", Offset = "0x2380BCC", VA = "0x7BBCB80BCC")]
		public void RequestFriendLeaderBoard(uint propID, bool force = false, bool silence = false)
		{
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4D")]
		[Address(RVA = "0x2381014", Offset = "0x2381014", VA = "0x7BBCB81014")]
		public void RequestBigEventLeaderBoard(uint propID, int mainType = 0, int subType = 0, ulong mainKey = 0UL, ulong subKey = 0UL, string region = "", uint httpOp = 0U, bool force = false, uint pageIndex = 0U, uint pageSize = 100U, bool getSelf = true)
		{
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4E")]
		[Address(RVA = "0x23815CC", Offset = "0x23815CC", VA = "0x7BBCB815CC")]
		public void RequestLeaderBoard(uint propID, int mainType = 0, int subType = 0, ulong mainKey = 0UL, ulong subKey = 0UL, string region = "", uint httpOp = 0U, bool force = false, uint pageIndex = 0U, uint pageSize = 100U, bool getSelf = true)
		{
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4F")]
		[Address(RVA = "0x23819E4", Offset = "0x23819E4", VA = "0x7BBCB819E4")]
		private void RequestGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE50")]
		[Address(RVA = "0x2381B54", Offset = "0x2381B54", VA = "0x7BBCB81B54")]
		private void HandleAccountGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE51")]
		[Address(RVA = "0x2381D10", Offset = "0x2381D10", VA = "0x7BBCB81D10")]
		private void HandleClanGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE52")]
		[Address(RVA = "0x2381A80", Offset = "0x2381A80", VA = "0x7BBCB81A80")]
		private void RequestRegionLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE53 RID: 44627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE53")]
		[Address(RVA = "0x2381EDC", Offset = "0x2381EDC", VA = "0x7BBCB81EDC")]
		private void HandleAccountRegionLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE54")]
		[Address(RVA = "0x2382080", Offset = "0x2382080", VA = "0x7BBCB82080")]
		private void HandleClanRegionLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE55")]
		[Address(RVA = "0x2382224", Offset = "0x2382224", VA = "0x7BBCB82224")]
		private void HandleChampionshipRegionLeaderBoard(uint propID, CSLeaderboardReq req)
		{
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x00030660 File Offset: 0x0002E860
		[Token(Token = "0x600AE56")]
		[Address(RVA = "0x2381B28", Offset = "0x2381B28", VA = "0x7BBCB81B28")]
		private UIModelLeaderBoard.LeaderBoardProfileType GetLeaderBoardProfileType(int mainType)
		{
			return UIModelLeaderBoard.LeaderBoardProfileType.None;
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x00030678 File Offset: 0x0002E878
		[Token(Token = "0x600AE57")]
		[Address(RVA = "0x238144C", Offset = "0x238144C", VA = "0x7BBCB8144C")]
		private bool IsInRequestCD(uint propID)
		{
			return default(bool);
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE58")]
		[Address(RVA = "0x23823E0", Offset = "0x23823E0", VA = "0x7BBCB823E0")]
		public void RequestClanWeekLeaderBoardInfo([Optional] Action next)
		{
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE59")]
		[Address(RVA = "0x2380F68", Offset = "0x2380F68", VA = "0x7BBCB80F68")]
		private void RefreshAllFriendRankingStats(bool isLadder, bool silence = false)
		{
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5A")]
		[Address(RVA = "0x23825BC", Offset = "0x23825BC", VA = "0x7BBCB825BC")]
		private void RefreshGameFriendStats(bool isLadder, bool silence = false)
		{
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5B")]
		[Address(RVA = "0x2382704", Offset = "0x2382704", VA = "0x7BBCB82704")]
		public void RefreshPlatformFriendList(bool isLadder)
		{
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5C")]
		[Address(RVA = "0x238292C", Offset = "0x238292C", VA = "0x7BBCB8292C")]
		private void RequestFriendInfo(object req, bool isPlatform, bool isLadder, bool silence = false)
		{
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5D")]
		[Address(RVA = "0x2382BC0", Offset = "0x2382BC0", VA = "0x7BBCB82BC0")]
		public void RemoveFriendByAccountId(ulong friendID)
		{
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5E")]
		[Address(RVA = "0x2382C58", Offset = "0x2382C58", VA = "0x7BBCB82C58")]
		private void RemoveFriendByPropID(ulong accountid, int propid)
		{
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5F")]
		[Address(RVA = "0x2382DEC", Offset = "0x2382DEC", VA = "0x7BBCB82DEC")]
		public void AddFriendByAccountWithPresense(AccountInfoWithPresence account)
		{
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE60")]
		[Address(RVA = "0x2382E70", Offset = "0x2382E70", VA = "0x7BBCB82E70")]
		private void AddFriendByPropID(AccountInfoWithPresence account, int propid)
		{
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE61")]
		[Address(RVA = "0x237A1D4", Offset = "0x237A1D4", VA = "0x7BBCB7A1D4")]
		public void UpdateMyLadderInfo(LadderRankInfo rankInfo)
		{
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE62")]
		[Address(RVA = "0x2382FE0", Offset = "0x2382FE0", VA = "0x7BBCB82FE0")]
		public string GetClanRegionData()
		{
			return null;
		}

		// Token: 0x0600AE63 RID: 44643 RVA: 0x00030690 File Offset: 0x0002E890
		[Token(Token = "0x600AE63")]
		[Address(RVA = "0x2383198", Offset = "0x2383198", VA = "0x7BBCB83198")]
		public uint GetLeaderBoardSize(uint propID)
		{
			return 0U;
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE64")]
		[Address(RVA = "0x2383218", Offset = "0x2383218", VA = "0x7BBCB83218")]
		public UIModelLeaderBoard()
		{
		}

		// Token: 0x0400B246 RID: 45638
		[Token(Token = "0x400B246")]
		public const int PropID_GetSOLOLeaderBoard = 1;

		// Token: 0x0400B247 RID: 45639
		[Token(Token = "0x400B247")]
		public const int PropID_GetDUOLeaderBoard = 2;

		// Token: 0x0400B248 RID: 45640
		[Token(Token = "0x400B248")]
		public const int PropID_GetSQUADLeaderBoard = 4;

		// Token: 0x0400B249 RID: 45641
		[Token(Token = "0x400B249")]
		public const int PropID_FriendLeaderBoard = 8;

		// Token: 0x0400B24A RID: 45642
		[Token(Token = "0x400B24A")]
		public const int PropID_GlobleLeaderBoard = 16;

		// Token: 0x0400B24B RID: 45643
		[Token(Token = "0x400B24B")]
		public const int PropID_GetRegionData = 32;

		// Token: 0x0400B24C RID: 45644
		[Token(Token = "0x400B24C")]
		public const int PropID_WinsLeaderBoard = 64;

		// Token: 0x0400B24D RID: 45645
		[Token(Token = "0x400B24D")]
		public const int PropID_KillsLeaderBoard = 128;

		// Token: 0x0400B24E RID: 45646
		[Token(Token = "0x400B24E")]
		public const int PropID_CasualWinsLeaderBoard = 256;

		// Token: 0x0400B24F RID: 45647
		[Token(Token = "0x400B24F")]
		public const int PropID_CasualKillsLeaderBoard = 512;

		// Token: 0x0400B250 RID: 45648
		[Token(Token = "0x400B250")]
		public const int PropID_ScoreLeaderBoard = 1024;

		// Token: 0x0400B251 RID: 45649
		[Token(Token = "0x400B251")]
		public const int PropID_GetEmptyData = 2048;

		// Token: 0x0400B252 RID: 45650
		[Token(Token = "0x400B252")]
		public const int PropID_EPBadgeLeaderBoard = 4096;

		// Token: 0x0400B253 RID: 45651
		[Token(Token = "0x400B253")]
		public const int PropID_GetWeekData = 8192;

		// Token: 0x0400B254 RID: 45652
		[Token(Token = "0x400B254")]
		public const int PropID_GetTotalData = 16384;

		// Token: 0x0400B255 RID: 45653
		[Token(Token = "0x400B255")]
		public const int PropID_GetHonor = 32768;

		// Token: 0x0400B256 RID: 45654
		[Token(Token = "0x400B256")]
		public const int PropID_GuildWeekInfoUpdate = 65536;

		// Token: 0x0400B257 RID: 45655
		[Token(Token = "0x400B257")]
		public const int PropID_ClanRaceRank = 131072;

		// Token: 0x0400B258 RID: 45656
		[Token(Token = "0x400B258")]
		public const int PropID_TeamFFC = 262144;

		// Token: 0x0400B259 RID: 45657
		[Token(Token = "0x400B259")]
		public const int PropID_TeamThirdParty = 524288;

		// Token: 0x0400B25A RID: 45658
		[Token(Token = "0x400B25A")]
		public const int PropID_GetSendGiftLeaderBoard = 1048576;

		// Token: 0x0400B25B RID: 45659
		[Token(Token = "0x400B25B")]
		public const int PropID_GetReceiveGiftLeaderBoard = 2097152;

		// Token: 0x0400B25C RID: 45660
		[Token(Token = "0x400B25C")]
		public const int PropID_CSWinsLeaderBoard = 4194304;

		// Token: 0x0400B25D RID: 45661
		[Token(Token = "0x400B25D")]
		public const int PropID_CSKillSLeaderBoard = 8388608;

		// Token: 0x0400B25E RID: 45662
		[Token(Token = "0x400B25E")]
		public const int LEADERBOARD_SIZE = 100;

		// Token: 0x0400B25F RID: 45663
		[Token(Token = "0x400B25F")]
		public const int TEAM_LEADERBOARD_SIZE = 3000;

		// Token: 0x0400B260 RID: 45664
		[Token(Token = "0x400B260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<int, List<LeaderBoardInfo>> m_DicLeaderBoardList;

		// Token: 0x0400B261 RID: 45665
		[Token(Token = "0x400B261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, LeaderBoardInfo> m_LocalPlayerInfos;

		// Token: 0x0400B262 RID: 45666
		[Token(Token = "0x400B262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<uint, float> m_DicLeaderBoardCD;

		// Token: 0x0400B263 RID: 45667
		[Token(Token = "0x400B263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<uint, uint> m_DicLeaderBoardSize;

		// Token: 0x0400B264 RID: 45668
		[Token(Token = "0x400B264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<uint> m_RunningRequestPropIDCache;

		// Token: 0x0400B265 RID: 45669
		[Token(Token = "0x400B265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CSGetClanWeekLeaderboardInfoRes m_GuildWeekInfo;

		// Token: 0x0400B266 RID: 45670
		[Token(Token = "0x400B266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_LastUpdateFriendLadderTime;

		// Token: 0x0400B267 RID: 45671
		[Token(Token = "0x400B267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_LastUpdateFriendRankingTime;

		// Token: 0x0400B268 RID: 45672
		[Token(Token = "0x400B268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_FriendLadderInfoCooldown;

		// Token: 0x0400B269 RID: 45673
		[Token(Token = "0x400B269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_FriendStatsInfoCooldown;

		// Token: 0x0400B26A RID: 45674
		[Token(Token = "0x400B26A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_GameFriendLadderDataHasCome;

		// Token: 0x0400B26B RID: 45675
		[Token(Token = "0x400B26B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_FBFriendLadderDataHasCome;

		// Token: 0x0400B26C RID: 45676
		[Token(Token = "0x400B26C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_GameFriendStatsDataHasCome;

		// Token: 0x0400B26D RID: 45677
		[Token(Token = "0x400B26D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_FBFriendStatsDataHasCome;

		// Token: 0x02001EF8 RID: 7928
		[Token(Token = "0x2001EF8")]
		public class TeamLBIndex
		{
			// Token: 0x0600AE65 RID: 44645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE65")]
			[Address(RVA = "0x2385588", Offset = "0x2385588", VA = "0x7BBCB85588")]
			public TeamLBIndex()
			{
			}

			// Token: 0x0400B26E RID: 45678
			[Token(Token = "0x400B26E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int PropID;

			// Token: 0x0400B26F RID: 45679
			[Token(Token = "0x400B26F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint ChampionshipType;
		}

		// Token: 0x02001EF9 RID: 7929
		[Token(Token = "0x2001EF9")]
		public class DetailedTCStats
		{
			// Token: 0x0600AE66 RID: 44646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE66")]
			[Address(RVA = "0x2385580", Offset = "0x2385580", VA = "0x7BBCB85580")]
			public DetailedTCStats()
			{
			}

			// Token: 0x0400B270 RID: 45680
			[Token(Token = "0x400B270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint mvp_count;

			// Token: 0x0400B271 RID: 45681
			[Token(Token = "0x400B271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint double_kills;

			// Token: 0x0400B272 RID: 45682
			[Token(Token = "0x400B272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint triple_kills;

			// Token: 0x0400B273 RID: 45683
			[Token(Token = "0x400B273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint four_kills;

			// Token: 0x0400B274 RID: 45684
			[Token(Token = "0x400B274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint damage;

			// Token: 0x0400B275 RID: 45685
			[Token(Token = "0x400B275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public uint head_shot_kills;

			// Token: 0x0400B276 RID: 45686
			[Token(Token = "0x400B276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public uint knock_downs;

			// Token: 0x0400B277 RID: 45687
			[Token(Token = "0x400B277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public uint revivals;

			// Token: 0x0400B278 RID: 45688
			[Token(Token = "0x400B278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public uint assists;

			// Token: 0x0400B279 RID: 45689
			[Token(Token = "0x400B279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public uint deaths;
		}

		// Token: 0x02001EFA RID: 7930
		[Token(Token = "0x2001EFA")]
		private enum LeaderBoardProfileType
		{
			// Token: 0x0400B27B RID: 45691
			[Token(Token = "0x400B27B")]
			None,
			// Token: 0x0400B27C RID: 45692
			[Token(Token = "0x400B27C")]
			Account,
			// Token: 0x0400B27D RID: 45693
			[Token(Token = "0x400B27D")]
			Clan,
			// Token: 0x0400B27E RID: 45694
			[Token(Token = "0x400B27E")]
			Championship
		}

		// Token: 0x02001EFB RID: 7931
		[Token(Token = "0x2001EFB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCCF4", Offset = "0x10FCCF4")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x0600AE67 RID: 44647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE67")]
			[Address(RVA = "0x2380238", Offset = "0x2380238", VA = "0x7BBCB80238")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x0600AE68 RID: 44648 RVA: 0x000306A8 File Offset: 0x0002E8A8
			[Token(Token = "0x600AE68")]
			[Address(RVA = "0x2383354", Offset = "0x2383354", VA = "0x7BBCB83354")]
			internal bool <UpdateFriendBoard>b__0(LeaderBoardInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400B27F RID: 45695
			[Token(Token = "0x400B27F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LeaderBoardInfo leaderboard_info;
		}

		// Token: 0x02001EFC RID: 7932
		[Token(Token = "0x2001EFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD04", Offset = "0x10FCD04")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x0600AE69 RID: 44649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE69")]
			[Address(RVA = "0x23808A4", Offset = "0x23808A4", VA = "0x7BBCB808A4")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600AE6A RID: 44650 RVA: 0x000306C0 File Offset: 0x0002E8C0
			[Token(Token = "0x600AE6A")]
			[Address(RVA = "0x23833A0", Offset = "0x23833A0", VA = "0x7BBCB833A0")]
			internal bool <CacheUpdateEPBadgeCount>b__0(LeaderBoardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400B280 RID: 45696
			[Token(Token = "0x400B280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong accountId;
		}

		// Token: 0x02001EFD RID: 7933
		[Token(Token = "0x2001EFD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD14", Offset = "0x10FCD14")]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x0600AE6B RID: 44651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE6B")]
			[Address(RVA = "0x2381444", Offset = "0x2381444", VA = "0x7BBCB81444")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x0600AE6C RID: 44652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE6C")]
			[Address(RVA = "0x23833DC", Offset = "0x23833DC", VA = "0x7BBCB833DC")]
			internal void <RequestBigEventLeaderBoard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B281 RID: 45697
			[Token(Token = "0x400B281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B282 RID: 45698
			[Token(Token = "0x400B282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint propID;
		}

		// Token: 0x02001EFE RID: 7934
		[Token(Token = "0x2001EFE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD24", Offset = "0x10FCD24")]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x0600AE6D RID: 44653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE6D")]
			[Address(RVA = "0x2381ECC", Offset = "0x2381ECC", VA = "0x7BBCB81ECC")]
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x0600AE6E RID: 44654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE6E")]
			[Address(RVA = "0x23835D0", Offset = "0x23835D0", VA = "0x7BBCB835D0")]
			internal void <HandleAccountGlobalLeaderBoard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B283 RID: 45699
			[Token(Token = "0x400B283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B284 RID: 45700
			[Token(Token = "0x400B284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint propID;

			// Token: 0x0400B285 RID: 45701
			[Token(Token = "0x400B285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CSLeaderboardReq req;
		}

		// Token: 0x02001EFF RID: 7935
		[Token(Token = "0x2001EFF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD34", Offset = "0x10FCD34")]
		private sealed class <>c__DisplayClass62_1
		{
			// Token: 0x0600AE6F RID: 44655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE6F")]
			[Address(RVA = "0x2383ADC", Offset = "0x2383ADC", VA = "0x7BBCB83ADC")]
			public <>c__DisplayClass62_1()
			{
			}

			// Token: 0x0600AE70 RID: 44656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE70")]
			[Address(RVA = "0x2383AE4", Offset = "0x2383AE4", VA = "0x7BBCB83AE4")]
			internal void <HandleAccountGlobalLeaderBoard>b__1(HttpErrorCode errorCode1, object res1)
			{
			}

			// Token: 0x0400B286 RID: 45702
			[Token(Token = "0x400B286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AccountLeaderboardItem localPlayerInfo;

			// Token: 0x0400B287 RID: 45703
			[Token(Token = "0x400B287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLeaderBoard.<>c__DisplayClass62_0 CS$<>8__locals1;
		}

		// Token: 0x02001F00 RID: 7936
		[Token(Token = "0x2001F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD44", Offset = "0x10FCD44")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x0600AE71 RID: 44657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE71")]
			[Address(RVA = "0x2381ED4", Offset = "0x2381ED4", VA = "0x7BBCB81ED4")]
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x0600AE72 RID: 44658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE72")]
			[Address(RVA = "0x2383D00", Offset = "0x2383D00", VA = "0x7BBCB83D00")]
			internal void <HandleClanGlobalLeaderBoard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B288 RID: 45704
			[Token(Token = "0x400B288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B289 RID: 45705
			[Token(Token = "0x400B289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint propID;

			// Token: 0x0400B28A RID: 45706
			[Token(Token = "0x400B28A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CSLeaderboardReq req;
		}

		// Token: 0x02001F01 RID: 7937
		[Token(Token = "0x2001F01")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD54", Offset = "0x10FCD54")]
		private sealed class <>c__DisplayClass63_1
		{
			// Token: 0x0600AE73 RID: 44659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE73")]
			[Address(RVA = "0x23841FC", Offset = "0x23841FC", VA = "0x7BBCB841FC")]
			public <>c__DisplayClass63_1()
			{
			}

			// Token: 0x0600AE74 RID: 44660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE74")]
			[Address(RVA = "0x2384204", Offset = "0x2384204", VA = "0x7BBCB84204")]
			internal void <HandleClanGlobalLeaderBoard>b__1(HttpErrorCode errorCode1, object res1)
			{
			}

			// Token: 0x0400B28B RID: 45707
			[Token(Token = "0x400B28B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ClanLeaderboardItem localPlayerInfo;

			// Token: 0x0400B28C RID: 45708
			[Token(Token = "0x400B28C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLeaderBoard.<>c__DisplayClass63_0 CS$<>8__locals1;
		}

		// Token: 0x02001F02 RID: 7938
		[Token(Token = "0x2001F02")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD64", Offset = "0x10FCD64")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600AE75 RID: 44661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE75")]
			[Address(RVA = "0x23823C8", Offset = "0x23823C8", VA = "0x7BBCB823C8")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600AE76 RID: 44662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE76")]
			[Address(RVA = "0x2384420", Offset = "0x2384420", VA = "0x7BBCB84420")]
			internal void <HandleAccountRegionLeaderBoard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B28D RID: 45709
			[Token(Token = "0x400B28D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B28E RID: 45710
			[Token(Token = "0x400B28E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint propID;
		}

		// Token: 0x02001F03 RID: 7939
		[Token(Token = "0x2001F03")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD74", Offset = "0x10FCD74")]
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x0600AE77 RID: 44663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE77")]
			[Address(RVA = "0x23823D0", Offset = "0x23823D0", VA = "0x7BBCB823D0")]
			public <>c__DisplayClass66_0()
			{
			}

			// Token: 0x0600AE78 RID: 44664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE78")]
			[Address(RVA = "0x2384738", Offset = "0x2384738", VA = "0x7BBCB84738")]
			internal void <HandleClanRegionLeaderBoard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B28F RID: 45711
			[Token(Token = "0x400B28F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B290 RID: 45712
			[Token(Token = "0x400B290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint propID;
		}

		// Token: 0x02001F04 RID: 7940
		[Token(Token = "0x2001F04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD84", Offset = "0x10FCD84")]
		private sealed class <>c__DisplayClass67_0
		{
			// Token: 0x0600AE79 RID: 44665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE79")]
			[Address(RVA = "0x23823D8", Offset = "0x23823D8", VA = "0x7BBCB823D8")]
			public <>c__DisplayClass67_0()
			{
			}

			// Token: 0x0600AE7A RID: 44666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE7A")]
			[Address(RVA = "0x2384A50", Offset = "0x2384A50", VA = "0x7BBCB84A50")]
			internal void <HandleChampionshipRegionLeaderBoard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B291 RID: 45713
			[Token(Token = "0x400B291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B292 RID: 45714
			[Token(Token = "0x400B292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint propID;
		}

		// Token: 0x02001F05 RID: 7941
		[Token(Token = "0x2001F05")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCD94", Offset = "0x10FCD94")]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x0600AE7B RID: 44667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE7B")]
			[Address(RVA = "0x23825B4", Offset = "0x23825B4", VA = "0x7BBCB825B4")]
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x0600AE7C RID: 44668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE7C")]
			[Address(RVA = "0x2384D68", Offset = "0x2384D68", VA = "0x7BBCB84D68")]
			internal void <RequestClanWeekLeaderBoardInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B293 RID: 45715
			[Token(Token = "0x400B293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B294 RID: 45716
			[Token(Token = "0x400B294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeakReference nextWeakRef;
		}

		// Token: 0x02001F06 RID: 7942
		[Token(Token = "0x2001F06")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCDA4", Offset = "0x10FCDA4")]
		private sealed class <>c__DisplayClass75_0
		{
			// Token: 0x0600AE7D RID: 44669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE7D")]
			[Address(RVA = "0x2382BB8", Offset = "0x2382BB8", VA = "0x7BBCB82BB8")]
			public <>c__DisplayClass75_0()
			{
			}

			// Token: 0x0600AE7E RID: 44670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE7E")]
			[Address(RVA = "0x2384EEC", Offset = "0x2384EEC", VA = "0x7BBCB84EEC")]
			internal void <RequestFriendInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B295 RID: 45717
			[Token(Token = "0x400B295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isPlatform;

			// Token: 0x0400B296 RID: 45718
			[Token(Token = "0x400B296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelLeaderBoard <>4__this;

			// Token: 0x0400B297 RID: 45719
			[Token(Token = "0x400B297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isLadder;
		}

		// Token: 0x02001F07 RID: 7943
		[Token(Token = "0x2001F07")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCDB4", Offset = "0x10FCDB4")]
		private sealed class <>c__DisplayClass77_0
		{
			// Token: 0x0600AE7F RID: 44671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE7F")]
			[Address(RVA = "0x2382DE4", Offset = "0x2382DE4", VA = "0x7BBCB82DE4")]
			public <>c__DisplayClass77_0()
			{
			}

			// Token: 0x0600AE80 RID: 44672 RVA: 0x000306D8 File Offset: 0x0002E8D8
			[Token(Token = "0x600AE80")]
			[Address(RVA = "0x2385508", Offset = "0x2385508", VA = "0x7BBCB85508")]
			internal bool <RemoveFriendByPropID>b__0(LeaderBoardInfo item)
			{
				return default(bool);
			}

			// Token: 0x0400B298 RID: 45720
			[Token(Token = "0x400B298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong accountid;
		}

		// Token: 0x02001F08 RID: 7944
		[Token(Token = "0x2001F08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCDC4", Offset = "0x10FCDC4")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600AE81 RID: 44673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE81")]
			[Address(RVA = "0x2382FD8", Offset = "0x2382FD8", VA = "0x7BBCB82FD8")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600AE82 RID: 44674 RVA: 0x000306F0 File Offset: 0x0002E8F0
			[Token(Token = "0x600AE82")]
			[Address(RVA = "0x2385544", Offset = "0x2385544", VA = "0x7BBCB85544")]
			internal bool <UpdateMyLadderInfo>b__0(LeaderBoardInfo item)
			{
				return default(bool);
			}

			// Token: 0x0400B299 RID: 45721
			[Token(Token = "0x400B299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong myAccountID;
		}
	}
}
