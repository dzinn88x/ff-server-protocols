using System;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001F09 RID: 7945
	[Token(Token = "0x2001F09")]
	public class LeaderBoardInfo
	{
		// Token: 0x0600AE83 RID: 44675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE83")]
		[Address(RVA = "0x13FF3A0", Offset = "0x13FF3A0", VA = "0x7BBBBFF3A0")]
		private static void SetLeaderBoardInfo(LeaderBoardInfo info, AccountLeaderboardItem item)
		{
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE84")]
		[Address(RVA = "0x13FF72C", Offset = "0x13FF72C", VA = "0x7BBBBFF72C")]
		private static void SetLeaderBoardInfo(LeaderBoardInfo info, ClanLeaderboardItem item)
		{
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE85")]
		[Address(RVA = "0x13FF83C", Offset = "0x13FF83C", VA = "0x7BBBBFF83C")]
		private static void SetLeaderBoardInfo(LeaderBoardInfo info, TeamLeaderboardItem item)
		{
		}

		// Token: 0x0600AE86 RID: 44678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE86")]
		[Address(RVA = "0x13FF578", Offset = "0x13FF578", VA = "0x7BBBBFF578")]
		private static void SetLeaderBoardStatsData(LeaderBoardInfo info, AccountInfoWithStats stat)
		{
		}

		// Token: 0x0600AE87 RID: 44679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE87")]
		[Address(RVA = "0x13FF92C", Offset = "0x13FF92C", VA = "0x7BBBBFF92C")]
		public static DetailedTCStats parseDetailTcStats(string detailed_stats)
		{
			return null;
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE88")]
		[Address(RVA = "0x13FFAC8", Offset = "0x13FFAC8", VA = "0x7BBBBFFAC8")]
		private static DetailStats parseDetailStats(string detailed_stats)
		{
			return null;
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE89")]
		[Address(RVA = "0x13FFC64", Offset = "0x13FFC64", VA = "0x7BBBBFFC64")]
		public static implicit operator LeaderBoardInfo(AccountLeaderboardItem item)
		{
			return null;
		}

		// Token: 0x0600AE8A RID: 44682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE8A")]
		[Address(RVA = "0x13FFE4C", Offset = "0x13FFE4C", VA = "0x7BBBBFFE4C")]
		public static implicit operator LeaderBoardInfo(ClanLeaderboardItem item)
		{
			return null;
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE8B")]
		[Address(RVA = "0x13FFEB4", Offset = "0x13FFEB4", VA = "0x7BBBBFFEB4")]
		public static implicit operator LeaderBoardInfo(TeamLeaderboardItem item)
		{
			return null;
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE8C")]
		[Address(RVA = "0x13FFF1C", Offset = "0x13FFF1C", VA = "0x7BBBBFFF1C")]
		public LeaderBoardInfo(FriendAccountInfo info, uint type, bool is_ranking)
		{
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE8D")]
		[Address(RVA = "0x1400118", Offset = "0x1400118", VA = "0x7BBBC00118")]
		public LeaderBoardInfo(FriendAccountInfo info)
		{
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE8E")]
		[Address(RVA = "0x13FFCCC", Offset = "0x13FFCCC", VA = "0x7BBBBFFCCC")]
		public LeaderBoardInfo()
		{
		}

		// Token: 0x0600AE8F RID: 44687 RVA: 0x00030708 File Offset: 0x0002E908
		[Token(Token = "0x600AE8F")]
		[Address(RVA = "0x14002CC", Offset = "0x14002CC", VA = "0x7BBBC002CC")]
		public uint GetChampionshipTrailKills()
		{
			return 0U;
		}

		// Token: 0x0400B29A RID: 45722
		[Token(Token = "0x400B29A")]
		[FieldOffset(Offset = "0x10")]
		public ulong account_id;

		// Token: 0x0400B29B RID: 45723
		[Token(Token = "0x400B29B")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400B29C RID: 45724
		[Token(Token = "0x400B29C")]
		[FieldOffset(Offset = "0x20")]
		public uint current_rank;

		// Token: 0x0400B29D RID: 45725
		[Token(Token = "0x400B29D")]
		[FieldOffset(Offset = "0x24")]
		public uint last_rank;

		// Token: 0x0400B29E RID: 45726
		[Token(Token = "0x400B29E")]
		[FieldOffset(Offset = "0x28")]
		public float score;

		// Token: 0x0400B29F RID: 45727
		[Token(Token = "0x400B29F")]
		[FieldOffset(Offset = "0x30")]
		public long play_time;

		// Token: 0x0400B2A0 RID: 45728
		[Token(Token = "0x400B2A0")]
		[FieldOffset(Offset = "0x38")]
		public uint win_times;

		// Token: 0x0400B2A1 RID: 45729
		[Token(Token = "0x400B2A1")]
		[FieldOffset(Offset = "0x3C")]
		public uint kill_times;

		// Token: 0x0400B2A2 RID: 45730
		[Token(Token = "0x400B2A2")]
		[FieldOffset(Offset = "0x40")]
		public float win_rating;

		// Token: 0x0400B2A3 RID: 45731
		[Token(Token = "0x400B2A3")]
		[FieldOffset(Offset = "0x44")]
		public float kill_rating;

		// Token: 0x0400B2A4 RID: 45732
		[Token(Token = "0x400B2A4")]
		[FieldOffset(Offset = "0x48")]
		public float kda;

		// Token: 0x0400B2A5 RID: 45733
		[Token(Token = "0x400B2A5")]
		[FieldOffset(Offset = "0x50")]
		public string portrait;

		// Token: 0x0400B2A6 RID: 45734
		[Token(Token = "0x400B2A6")]
		[FieldOffset(Offset = "0x58")]
		public uint ladder_rank;

		// Token: 0x0400B2A7 RID: 45735
		[Token(Token = "0x400B2A7")]
		[FieldOffset(Offset = "0x5C")]
		public uint ep_Badge_cnt;

		// Token: 0x0400B2A8 RID: 45736
		[Token(Token = "0x400B2A8")]
		[FieldOffset(Offset = "0x60")]
		public int has_EP;

		// Token: 0x0400B2A9 RID: 45737
		[Token(Token = "0x400B2A9")]
		[FieldOffset(Offset = "0x68")]
		public string region;

		// Token: 0x0400B2AA RID: 45738
		[Token(Token = "0x400B2AA")]
		[FieldOffset(Offset = "0x70")]
		public uint honor;

		// Token: 0x0400B2AB RID: 45739
		[Token(Token = "0x400B2AB")]
		[FieldOffset(Offset = "0x74")]
		public uint clanlevel;

		// Token: 0x0400B2AC RID: 45740
		[Token(Token = "0x400B2AC")]
		[FieldOffset(Offset = "0x78")]
		public double leaderboard_score;

		// Token: 0x0400B2AD RID: 45741
		[Token(Token = "0x400B2AD")]
		[FieldOffset(Offset = "0x80")]
		public float kill_death_rating;

		// Token: 0x0400B2AE RID: 45742
		[Token(Token = "0x400B2AE")]
		[FieldOffset(Offset = "0x84")]
		public uint external_type;

		// Token: 0x0400B2AF RID: 45743
		[Token(Token = "0x400B2AF")]
		[FieldOffset(Offset = "0x88")]
		public uint cs_rank;

		// Token: 0x0400B2B0 RID: 45744
		[Token(Token = "0x400B2B0")]
		[FieldOffset(Offset = "0x8C")]
		public uint cs_rankpoint;

		// Token: 0x0400B2B1 RID: 45745
		[Token(Token = "0x400B2B1")]
		[FieldOffset(Offset = "0x90")]
		public BaseProfileInfo profile_info;

		// Token: 0x0400B2B2 RID: 45746
		[Token(Token = "0x400B2B2")]
		[FieldOffset(Offset = "0x98")]
		public TeamLeaderboardProfile team_profile_info;

		// Token: 0x0400B2B3 RID: 45747
		[Token(Token = "0x400B2B3")]
		[FieldOffset(Offset = "0xA0")]
		public ulong limited_event_score;
	}
}
