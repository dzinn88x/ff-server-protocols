using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E34 RID: 7732
	[Token(Token = "0x2001E34")]
	internal class UIModelCSLadderMatch : UIBaseModel
	{
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0F")]
		public CSLadderSeasonStatsInfo CSLadderSeasonStatsInfo
		{
			[Token(Token = "0x600A8F8")]
			[Address(RVA = "0x22E1BF8", Offset = "0x22E1BF8", VA = "0x7BBCAE1BF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B10")]
		public CSLadderRankInfo CurrentCsRankInfo
		{
			[Token(Token = "0x600A8F9")]
			[Address(RVA = "0x22E1C64", Offset = "0x22E1C64", VA = "0x7BBCAE1C64")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x0002DB58 File Offset: 0x0002BD58
		[Token(Token = "0x600A8FA")]
		[Address(RVA = "0x22E1CD0", Offset = "0x22E1CD0", VA = "0x7BBCAE1CD0")]
		public bool IsCurrentSeasonOpen()
		{
			return default(bool);
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A8FB")]
		[Address(RVA = "0x22E1DB4", Offset = "0x22E1DB4", VA = "0x7BBCAE1DB4")]
		public CSRankingSeasonInfoDesc GetCurrentSeasonInfo()
		{
			return null;
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A8FC")]
		[Address(RVA = "0x22E1DCC", Offset = "0x22E1DCC", VA = "0x7BBCAE1DCC")]
		public List<AwardDesc> GetCSRankAwardList(uint rank)
		{
			return null;
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x0002DB70 File Offset: 0x0002BD70
		[Token(Token = "0x600A8FD")]
		[Address(RVA = "0x22E1ED0", Offset = "0x22E1ED0", VA = "0x7BBCAE1ED0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8FE")]
		[Address(RVA = "0x22E1ED8", Offset = "0x22E1ED8", VA = "0x7BBCAE1ED8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8FF")]
		[Address(RVA = "0x22E1FF8", Offset = "0x22E1FF8", VA = "0x7BBCAE1FF8", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A900")]
		[Address(RVA = "0x22E2000", Offset = "0x22E2000", VA = "0x7BBCAE2000")]
		public void GetCurOrRecentCSRankingConfig()
		{
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A901")]
		[Address(RVA = "0x22E21B8", Offset = "0x22E21B8", VA = "0x7BBCAE21B8")]
		public void RequestCsRankingInfoById(ulong accoutid)
		{
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A902")]
		[Address(RVA = "0x22E244C", Offset = "0x22E244C", VA = "0x7BBCAE244C")]
		public CSLadderRankInfo GetCsRankingInfoById(ulong accoutid)
		{
			return null;
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A903")]
		[Address(RVA = "0x22E24CC", Offset = "0x22E24CC", VA = "0x7BBCAE24CC")]
		public CSGetCurrentOrRecentCSRankingSeasonConfigRes GetFromCurOrRecentCSRankingConfig()
		{
			return null;
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A904")]
		[Address(RVA = "0x22E24D4", Offset = "0x22E24D4", VA = "0x7BBCAE24D4")]
		public void SetCurOrRecentCSRankingConfig(CSGetCurrentOrRecentCSRankingSeasonConfigRes res)
		{
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A905")]
		[Address(RVA = "0x22E24E0", Offset = "0x22E24E0", VA = "0x7BBCAE24E0")]
		public void InitPlayerCSRankingInfo(bool silence = false)
		{
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A906")]
		[Address(RVA = "0x22E26B0", Offset = "0x22E26B0", VA = "0x7BBCAE26B0")]
		public void ReRequestCsRankingsInfo()
		{
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A907")]
		[Address(RVA = "0x22E2704", Offset = "0x22E2704", VA = "0x7BBCAE2704")]
		public void GetPlayerCSRankingInfo(bool inmiditely = false)
		{
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x0002DB88 File Offset: 0x0002BD88
		[Token(Token = "0x600A908")]
		[Address(RVA = "0x22E2894", Offset = "0x22E2894", VA = "0x7BBCAE2894")]
		public ResourceID GetCSRankIcon(int rank, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
		{
			return default(ResourceID);
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A909")]
		[Address(RVA = "0x22E298C", Offset = "0x22E298C", VA = "0x7BBCAE298C")]
		public CSLadderSeasonStatsInfo GetPlayerLadderSeasonStats()
		{
			return null;
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90A")]
		[Address(RVA = "0x22E2AF8", Offset = "0x22E2AF8", VA = "0x7BBCAE2AF8")]
		public void RequestPlayerCSRankingSeasonStats()
		{
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90B")]
		[Address(RVA = "0x22E2E28", Offset = "0x22E2E28", VA = "0x7BBCAE2E28")]
		public void RequestPlayerCSRankInfo()
		{
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A90C")]
		[Address(RVA = "0x22E2A40", Offset = "0x22E2A40", VA = "0x7BBCAE2A40")]
		public CSLadderSeasonStatsInfo GetCSLadderSeasonInfoData(ulong accoutid, uint matchmode)
		{
			return null;
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90D")]
		[Address(RVA = "0x22E2BA8", Offset = "0x22E2BA8", VA = "0x7BBCAE2BA8")]
		public void RequestCSRankingStatsById(ulong accoutid)
		{
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90E")]
		[Address(RVA = "0x22E2EE0", Offset = "0x22E2EE0", VA = "0x7BBCAE2EE0")]
		public void GetCSPlayerStats(ulong accoutid, uint matchmode, bool inmiditely = false)
		{
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A90F")]
		[Address(RVA = "0x22E32F0", Offset = "0x22E32F0", VA = "0x7BBCAE32F0")]
		public List<LeaderBoardInfo> GetFriendBoardScoreList()
		{
			return null;
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A910")]
		[Address(RVA = "0x22E32F8", Offset = "0x22E32F8", VA = "0x7BBCAE32F8")]
		public LeaderBoardInfo GetLocalPlayerBoardRegion()
		{
			return null;
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A911")]
		[Address(RVA = "0x22E3300", Offset = "0x22E3300", VA = "0x7BBCAE3300")]
		public List<LeaderBoardInfo> GetRegionBoardScoreList()
		{
			return null;
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A912")]
		[Address(RVA = "0x22E3308", Offset = "0x22E3308", VA = "0x7BBCAE3308")]
		public LeaderBoardInfo GetLocalPlayerBoardFriend()
		{
			return null;
		}

		// Token: 0x0600A913 RID: 43283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A913")]
		[Address(RVA = "0x22E3310", Offset = "0x22E3310", VA = "0x7BBCAE3310")]
		public void RequestCSLeaderBoardFriend()
		{
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A914")]
		[Address(RVA = "0x22E36F4", Offset = "0x22E36F4", VA = "0x7BBCAE36F4")]
		public void RequestCSLeaderBoardRegion()
		{
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		[Token(Token = "0x600A915")]
		[Address(RVA = "0x22E39B8", Offset = "0x22E39B8", VA = "0x7BBCAE39B8")]
		public float GetKDANum()
		{
			return 0f;
		}

		// Token: 0x0600A916 RID: 43286 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		[Token(Token = "0x600A916")]
		[Address(RVA = "0x22E39FC", Offset = "0x22E39FC", VA = "0x7BBCAE39FC")]
		public uint GetRealSeasonID()
		{
			return 0U;
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A917")]
		[Address(RVA = "0x22E3A20", Offset = "0x22E3A20", VA = "0x7BBCAE3A20")]
		public UIModelCSLadderMatch()
		{
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A918")]
		[Address(RVA = "0x22E3BCC", Offset = "0x22E3BCC", VA = "0x7BBCAE3BCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F0C", Offset = "0x1145F0C")]
		private void <GetCurOrRecentCSRankingConfig>b__38_0(HttpErrorCode errodCode, object res)
		{
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A919")]
		[Address(RVA = "0x22E3CD4", Offset = "0x22E3CD4", VA = "0x7BBCAE3CD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F1C", Offset = "0x1145F1C")]
		private void <InitPlayerCSRankingInfo>b__43_0(HttpErrorCode errodCode, object res)
		{
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A91A")]
		[Address(RVA = "0x22E3ED0", Offset = "0x22E3ED0", VA = "0x7BBCAE3ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F2C", Offset = "0x1145F2C")]
		private void <GetPlayerCSRankingInfo>b__45_0(HttpErrorCode errodCode, object res)
		{
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A91B")]
		[Address(RVA = "0x22E4110", Offset = "0x22E4110", VA = "0x7BBCAE4110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F3C", Offset = "0x1145F3C")]
		private void <RequestCSLeaderBoardFriend>b__57_1(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A91C")]
		[Address(RVA = "0x22E468C", Offset = "0x22E468C", VA = "0x7BBCAE468C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F4C", Offset = "0x1145F4C")]
		private void <RequestCSLeaderBoardRegion>b__58_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AE5B RID: 44635
		[Token(Token = "0x400AE5B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSLadderSeasonInfo;

		// Token: 0x0400AE5C RID: 44636
		[Token(Token = "0x400AE5C")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSLifeSeasonInfo;

		// Token: 0x0400AE5D RID: 44637
		[Token(Token = "0x400AE5D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSCommonSeasonInfo;

		// Token: 0x0400AE5E RID: 44638
		[Token(Token = "0x400AE5E")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ulong, CDTimeData> m_CSLadderInfoClickDic;

		// Token: 0x0400AE5F RID: 44639
		[Token(Token = "0x400AE5F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ulong, CDTimeData> m_CSLadderCommonInfoClickDic;

		// Token: 0x0400AE60 RID: 44640
		[Token(Token = "0x400AE60")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ulong, CDTimeData> m_CSLadderLifeInfoClickDic;

		// Token: 0x0400AE61 RID: 44641
		[Token(Token = "0x400AE61")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<ulong, CDTimeData> m_CSLadderRankingProfileClickDic;

		// Token: 0x0400AE62 RID: 44642
		[Token(Token = "0x400AE62")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<ulong, CSLadderRankInfo> m_CsLadderRankInfo;

		// Token: 0x0400AE63 RID: 44643
		[Token(Token = "0x400AE63")]
		[FieldOffset(Offset = "0x58")]
		private CDTimeData rankinfoclick;

		// Token: 0x0400AE64 RID: 44644
		[Token(Token = "0x400AE64")]
		[FieldOffset(Offset = "0x60")]
		private int m_CSPlayerRankingSeasonStatsDelta;

		// Token: 0x0400AE65 RID: 44645
		[Token(Token = "0x400AE65")]
		[FieldOffset(Offset = "0x64")]
		private int m_CSPlayerRankInfoDelat;

		// Token: 0x0400AE66 RID: 44646
		[Token(Token = "0x400AE66")]
		[FieldOffset(Offset = "0x68")]
		private CSLadderSeasonStatsInfo m_CSLadderSeasonInfo;

		// Token: 0x0400AE67 RID: 44647
		[Token(Token = "0x400AE67")]
		[FieldOffset(Offset = "0x70")]
		private CSLadderRankInfo m_CurrentCSRankInfo;

		// Token: 0x0400AE68 RID: 44648
		[Token(Token = "0x400AE68")]
		[FieldOffset(Offset = "0x78")]
		private CSGetCurrentOrRecentCSRankingSeasonConfigRes m_CurrentOrRecentCsRankingSeasonConfig;

		// Token: 0x0400AE69 RID: 44649
		[Token(Token = "0x400AE69")]
		[FieldOffset(Offset = "0x80")]
		private List<LeaderBoardInfo> m_LeaderBoardRegionList;

		// Token: 0x0400AE6A RID: 44650
		[Token(Token = "0x400AE6A")]
		[FieldOffset(Offset = "0x88")]
		private List<LeaderBoardInfo> m_LadderBoardFriendList;

		// Token: 0x0400AE6B RID: 44651
		[Token(Token = "0x400AE6B")]
		[FieldOffset(Offset = "0x90")]
		private LeaderBoardInfo m_PlayerLeaderBoardRegion;

		// Token: 0x0400AE6C RID: 44652
		[Token(Token = "0x400AE6C")]
		[FieldOffset(Offset = "0x98")]
		private LeaderBoardInfo m_PlayerLeaderBoardFriend;

		// Token: 0x0400AE6D RID: 44653
		[Token(Token = "0x400AE6D")]
		[FieldOffset(Offset = "0xA0")]
		private float m_NextReqLeadderBoardTime;

		// Token: 0x0400AE6E RID: 44654
		[Token(Token = "0x400AE6E")]
		[FieldOffset(Offset = "0xA4")]
		private float m_NextReqFriendBoardTime;

		// Token: 0x0400AE6F RID: 44655
		[Token(Token = "0x400AE6F")]
		public const uint PropID_CSSeasonStatsRefresh = 2U;

		// Token: 0x0400AE70 RID: 44656
		[Token(Token = "0x400AE70")]
		public const uint PropID_CSRankInfoRefreshed = 4U;

		// Token: 0x0400AE71 RID: 44657
		[Token(Token = "0x400AE71")]
		public const uint PropID_CSRankSeasonInfoRefreshed = 8U;

		// Token: 0x0400AE72 RID: 44658
		[Token(Token = "0x400AE72")]
		public const uint PropID_CSLifeSeasonStatsRefresh = 16U;

		// Token: 0x0400AE73 RID: 44659
		[Token(Token = "0x400AE73")]
		public const uint PropID_CSCommonSeasonStatsRefresh = 32U;

		// Token: 0x0400AE74 RID: 44660
		[Token(Token = "0x400AE74")]
		public const uint PropID_CSRankingStatsRefresh = 64U;

		// Token: 0x0400AE75 RID: 44661
		[Token(Token = "0x400AE75")]
		public const uint PropID_CSLeaderBoardFriend = 128U;

		// Token: 0x0400AE76 RID: 44662
		[Token(Token = "0x400AE76")]
		public const uint PropID_CSLeaderBoardScore = 256U;

		// Token: 0x02001E35 RID: 7733
		[Token(Token = "0x2001E35")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC4D4", Offset = "0x10FC4D4")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600A91D RID: 43293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A91D")]
			[Address(RVA = "0x22E2444", Offset = "0x22E2444", VA = "0x7BBCAE2444")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x0600A91E RID: 43294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A91E")]
			[Address(RVA = "0x22E4A40", Offset = "0x22E4A40", VA = "0x7BBCAE4A40")]
			internal void <RequestCsRankingInfoById>b__0(HttpErrorCode errodCode, object res)
			{
			}

			// Token: 0x0400AE77 RID: 44663
			[Token(Token = "0x400AE77")]
			[FieldOffset(Offset = "0x10")]
			public ulong accoutid;

			// Token: 0x0400AE78 RID: 44664
			[Token(Token = "0x400AE78")]
			[FieldOffset(Offset = "0x18")]
			public UIModelCSLadderMatch <>4__this;
		}

		// Token: 0x02001E36 RID: 7734
		[Token(Token = "0x2001E36")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC4E4", Offset = "0x10FC4E4")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x0600A91F RID: 43295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A91F")]
			[Address(RVA = "0x22E2ED8", Offset = "0x22E2ED8", VA = "0x7BBCAE2ED8")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x0600A920 RID: 43296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A920")]
			[Address(RVA = "0x22E4DE4", Offset = "0x22E4DE4", VA = "0x7BBCAE4DE4")]
			internal void <RequestCSRankingStatsById>b__0(HttpErrorCode errodCode, object res)
			{
			}

			// Token: 0x0400AE79 RID: 44665
			[Token(Token = "0x400AE79")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCSLadderMatch <>4__this;

			// Token: 0x0400AE7A RID: 44666
			[Token(Token = "0x400AE7A")]
			[FieldOffset(Offset = "0x18")]
			public ulong accoutid;
		}

		// Token: 0x02001E37 RID: 7735
		[Token(Token = "0x2001E37")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC4F4", Offset = "0x10FC4F4")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x0600A921 RID: 43297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A921")]
			[Address(RVA = "0x22E32E8", Offset = "0x22E32E8", VA = "0x7BBCAE32E8")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x0600A922 RID: 43298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A922")]
			[Address(RVA = "0x22E5208", Offset = "0x22E5208", VA = "0x7BBCAE5208")]
			internal void <GetCSPlayerStats>b__0(HttpErrorCode errodCode, object res)
			{
			}

			// Token: 0x0400AE7B RID: 44667
			[Token(Token = "0x400AE7B")]
			[FieldOffset(Offset = "0x10")]
			public uint matchmode;

			// Token: 0x0400AE7C RID: 44668
			[Token(Token = "0x400AE7C")]
			[FieldOffset(Offset = "0x18")]
			public UIModelCSLadderMatch <>4__this;

			// Token: 0x0400AE7D RID: 44669
			[Token(Token = "0x400AE7D")]
			[FieldOffset(Offset = "0x20")]
			public ulong accoutid;
		}

		// Token: 0x02001E38 RID: 7736
		[Token(Token = "0x2001E38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC504", Offset = "0x10FC504")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A924 RID: 43300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A924")]
			[Address(RVA = "0x22E48FC", Offset = "0x22E48FC", VA = "0x7BBCAE48FC")]
			public <>c()
			{
			}

			// Token: 0x0600A925 RID: 43301 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
			[Token(Token = "0x600A925")]
			[Address(RVA = "0x22E4904", Offset = "0x22E4904", VA = "0x7BBCAE4904")]
			internal int <RequestCSLeaderBoardFriend>b__57_2(FriendAccountInfo x, FriendAccountInfo y)
			{
				return 0;
			}

			// Token: 0x0600A926 RID: 43302 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
			[Token(Token = "0x600A926")]
			[Address(RVA = "0x22E49B0", Offset = "0x22E49B0", VA = "0x7BBCAE49B0")]
			internal int <RequestCSLeaderBoardFriend>b__57_0(LeaderBoardInfo x, LeaderBoardInfo y)
			{
				return 0;
			}

			// Token: 0x0400AE7E RID: 44670
			[Token(Token = "0x400AE7E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelCSLadderMatch.<>c <>9;

			// Token: 0x0400AE7F RID: 44671
			[Token(Token = "0x400AE7F")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<FriendAccountInfo> <>9__57_2;

			// Token: 0x0400AE80 RID: 44672
			[Token(Token = "0x400AE80")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<LeaderBoardInfo> <>9__57_0;
		}
	}
}
