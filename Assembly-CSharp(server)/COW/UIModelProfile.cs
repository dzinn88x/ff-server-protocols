using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001FB0 RID: 8112
	[Token(Token = "0x2001FB0")]
	public class UIModelProfile : UIBaseModel
	{
		// Token: 0x0600B40C RID: 46092 RVA: 0x00033168 File Offset: 0x00031368
		[Token(Token = "0x600B40C")]
		[Address(RVA = "0x238EEDC", Offset = "0x238EEDC", VA = "0x7BBCB8EEDC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40D")]
		[Address(RVA = "0x238EEE4", Offset = "0x238EEE4", VA = "0x7BBCB8EEE4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40E")]
		[Address(RVA = "0x238EEEC", Offset = "0x238EEEC", VA = "0x7BBCB8EEEC", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40F")]
		[Address(RVA = "0x238F214", Offset = "0x238F214", VA = "0x7BBCB8F214", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C34")]
		public List<MatchRecordPersonal> HistoryRecordList
		{
			[Token(Token = "0x600B410")]
			[Address(RVA = "0x238F428", Offset = "0x238F428", VA = "0x7BBCB8F428")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B411 RID: 46097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B411")]
		[Address(RVA = "0x238F430", Offset = "0x238F430", VA = "0x7BBCB8F430")]
		public void ProcessDiamondCost(DiamondCostRes res)
		{
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x00033180 File Offset: 0x00031380
		[Token(Token = "0x600B412")]
		[Address(RVA = "0x238F440", Offset = "0x238F440", VA = "0x7BBCB8F440")]
		public uint GetDiamondCost()
		{
			return 0U;
		}

		// Token: 0x0600B413 RID: 46099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B413")]
		[Address(RVA = "0x238F448", Offset = "0x238F448", VA = "0x7BBCB8F448")]
		public Dictionary<uint, PersonalRecordData> GetPersonalRecordDict(uint matchMode)
		{
			return null;
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B414")]
		[Address(RVA = "0x238F4C8", Offset = "0x238F4C8", VA = "0x7BBCB8F4C8")]
		public void ForeRefreshAvatar()
		{
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B415")]
		[Address(RVA = "0x238F52C", Offset = "0x238F52C", VA = "0x7BBCB8F52C")]
		public CSGetBattleTagRes GetBattleTag(ulong account_id)
		{
			return null;
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B416")]
		[Address(RVA = "0x238F5AC", Offset = "0x238F5AC", VA = "0x7BBCB8F5AC")]
		public void RequestBattleTag(ulong account_id, bool force = false)
		{
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B417")]
		[Address(RVA = "0x238F8D8", Offset = "0x238F8D8", VA = "0x7BBCB8F8D8")]
		public void RequestShowBoardOnly(ulong account_id = 0UL)
		{
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B418")]
		[Address(RVA = "0x238FBE0", Offset = "0x238FBE0", VA = "0x7BBCB8FBE0")]
		public void RequestShowBoardData(ulong account_id = 0UL, bool refreshavatar = false, bool silence = false)
		{
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B419")]
		[Address(RVA = "0x2390054", Offset = "0x2390054", VA = "0x7BBCB90054")]
		public void RequestPlayerBriefInfo(ulong account_id)
		{
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B41A")]
		[Address(RVA = "0x2390384", Offset = "0x2390384", VA = "0x7BBCB90384")]
		public AccountBriefInfo GetPlayerBriefInfo(ulong id)
		{
			return null;
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B41B")]
		[Address(RVA = "0x2390404", Offset = "0x2390404", VA = "0x7BBCB90404")]
		public void RequestPersonalInfo(ulong account_id = 0UL, [Optional] Action callback)
		{
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B41C")]
		[Address(RVA = "0x2390764", Offset = "0x2390764", VA = "0x7BBCB90764")]
		public void RequestPlayerHeroicMarkInfo(ulong account_id)
		{
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B41D")]
		[Address(RVA = "0x2390B74", Offset = "0x2390B74", VA = "0x7BBCB90B74")]
		public CSGetHeroicInfoRes GetPlayerHeroicMarkInfo(ulong account_id)
		{
			return null;
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B41E")]
		[Address(RVA = "0x2390BF4", Offset = "0x2390BF4", VA = "0x7BBCB90BF4")]
		public void RequestAllRelationshipStateInfo(ulong accid, bool force = false)
		{
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B41F")]
		[Address(RVA = "0x2390ED8", Offset = "0x2390ED8", VA = "0x7BBCB90ED8")]
		public List<IntimacyState> GetRelationShipInfo(ulong accid)
		{
			return null;
		}

		// Token: 0x0600B420 RID: 46112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B420")]
		[Address(RVA = "0x2390F58", Offset = "0x2390F58", VA = "0x7BBCB90F58")]
		public AccountPersonalShowInfo GetPersonalShowData(ulong id)
		{
			return null;
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B421")]
		[Address(RVA = "0x2390FD8", Offset = "0x2390FD8", VA = "0x7BBCB90FD8")]
		public PersonalLiveTvData GetPersonalLiveTvData(ulong id)
		{
			return null;
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B422")]
		[Address(RVA = "0x2391058", Offset = "0x2391058", VA = "0x7BBCB91058")]
		public void RequestPersonalData(uint type, ulong account_id = 0UL)
		{
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B423")]
		[Address(RVA = "0x23912FC", Offset = "0x23912FC", VA = "0x7BBCB912FC")]
		public void RequestSetPesonalSetting(CSUpdateSocialBasicInfoReq req, bool refreshbattle = false)
		{
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B424")]
		[Address(RVA = "0x23914B0", Offset = "0x23914B0", VA = "0x7BBCB914B0")]
		public void RequestHistoryRecord(ulong account_id = 0UL)
		{
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B425")]
		[Address(RVA = "0x2391774", Offset = "0x2391774", VA = "0x7BBCB91774")]
		public void ClearMatchModeCache()
		{
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B426")]
		[Address(RVA = "0x23917D4", Offset = "0x23917D4", VA = "0x7BBCB917D4")]
		private PersonalRecordData AccountInfo2PersonalRecord(AccountInfoWithStatsToClient acInfo, uint type)
		{
			return null;
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B427")]
		[Address(RVA = "0x2391C84", Offset = "0x2391C84", VA = "0x7BBCB91C84")]
		public UIModelProfile()
		{
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B428")]
		[Address(RVA = "0x2391F0C", Offset = "0x2391F0C", VA = "0x7BBCB91F0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146DAC", Offset = "0x1146DAC")]
		private void <RequestHistoryRecord>b__62_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0400B666 RID: 46694
		[Token(Token = "0x400B666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<MatchRecordPersonal> m_HistoryRecordList;

		// Token: 0x0400B667 RID: 46695
		[Token(Token = "0x400B667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<f, Dictionary<uint, PersonalRecordData>> m_MatchModeDict;

		// Token: 0x0400B668 RID: 46696
		[Token(Token = "0x400B668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<ulong, PersonalLiveTvData> m_ShowLiveTvInfoDic;

		// Token: 0x0400B669 RID: 46697
		[Token(Token = "0x400B669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<ulong, CDTimeData> m_RequestLiveInfoCDDict;

		// Token: 0x0400B66A RID: 46698
		[Token(Token = "0x400B66A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<ServiceMessageTypeHTTP, ulong> m_CDDic;

		// Token: 0x0400B66B RID: 46699
		[Token(Token = "0x400B66B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<ulong, ulong> m_PlayerBriefInfoCDDict;

		// Token: 0x0400B66C RID: 46700
		[Token(Token = "0x400B66C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<ulong, AccountBriefInfo> m_PlayerBriefInfoDict;

		// Token: 0x0400B66D RID: 46701
		[Token(Token = "0x400B66D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<ulong, ulong> m_AccoutDic;

		// Token: 0x0400B66E RID: 46702
		[Token(Token = "0x400B66E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<ulong, ulong> m_BattleTagDic;

		// Token: 0x0400B66F RID: 46703
		[Token(Token = "0x400B66F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<ulong, AccountPersonalShowInfo> m_PersonShowinfoDic;

		// Token: 0x0400B670 RID: 46704
		[Token(Token = "0x400B670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<ulong, CSGetBattleTagRes> m_PersonBattleTagRes;

		// Token: 0x0400B671 RID: 46705
		[Token(Token = "0x400B671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<ulong, List<IntimacyState>> m_PersonalIntimacyDic;

		// Token: 0x0400B672 RID: 46706
		[Token(Token = "0x400B672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<ulong, ulong> m_RequestIntimcyCDDict;

		// Token: 0x0400B673 RID: 46707
		[Token(Token = "0x400B673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<ulong, ulong> m_PlayerHeroicMarkInfoCDDict;

		// Token: 0x0400B674 RID: 46708
		[Token(Token = "0x400B674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<ulong, CSGetHeroicInfoRes> m_PlayerHeroicMarkInfoDict;

		// Token: 0x0400B675 RID: 46709
		[Token(Token = "0x400B675")]
		private const int m_CDSecond = 300;

		// Token: 0x0400B676 RID: 46710
		[Token(Token = "0x400B676")]
		private const int m_PersonSecond = 7;

		// Token: 0x0400B677 RID: 46711
		[Token(Token = "0x400B677")]
		private const int m_BriefInfoSecond = 1800;

		// Token: 0x0400B678 RID: 46712
		[Token(Token = "0x400B678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private uint m_diamond;

		// Token: 0x0400B679 RID: 46713
		[Token(Token = "0x400B679")]
		public const int PropID_GetProfileSuccess = 1;

		// Token: 0x0400B67A RID: 46714
		[Token(Token = "0x400B67A")]
		public const int PropID_GetProfileFail = 2;

		// Token: 0x0400B67B RID: 46715
		[Token(Token = "0x400B67B")]
		public const int PropID_GetHistorystats = 4;

		// Token: 0x0400B67C RID: 46716
		[Token(Token = "0x400B67C")]
		public const int PropID_GetShowBoardDataSuccess = 8;

		// Token: 0x0400B67D RID: 46717
		[Token(Token = "0x400B67D")]
		public const int PropID_GetLiveTvDataSuccess = 16;

		// Token: 0x0400B67E RID: 46718
		[Token(Token = "0x400B67E")]
		public const int PropID_GetShowBoardAvatarDataSuccess = 32;

		// Token: 0x0400B67F RID: 46719
		[Token(Token = "0x400B67F")]
		public const int PropID_GetPersonalSettingSuccess = 64;

		// Token: 0x0400B680 RID: 46720
		[Token(Token = "0x400B680")]
		public const int PropID_GetPersonalBattleTagSuccess = 128;

		// Token: 0x0400B681 RID: 46721
		[Token(Token = "0x400B681")]
		public const int PropID_GetPlayerBriefInfoSuccess = 256;

		// Token: 0x0400B682 RID: 46722
		[Token(Token = "0x400B682")]
		public const int PropID_GetPlayerRelationShipSuccess = 512;

		// Token: 0x0400B683 RID: 46723
		[Token(Token = "0x400B683")]
		public const int PropID_GetPlayerBattleTag = 1024;

		// Token: 0x0400B684 RID: 46724
		[Token(Token = "0x400B684")]
		public const int PropID_GetPlayerHeroicMarkInfoSuccess = 2048;

		// Token: 0x0400B685 RID: 46725
		[Token(Token = "0x400B685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string DefaultSex;

		// Token: 0x0400B686 RID: 46726
		[Token(Token = "0x400B686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string DefaultShow;

		// Token: 0x0400B687 RID: 46727
		[Token(Token = "0x400B687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string DefaultOnLineTime;

		// Token: 0x0400B688 RID: 46728
		[Token(Token = "0x400B688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string DefaultActiveTime;

		// Token: 0x0400B689 RID: 46729
		[Token(Token = "0x400B689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string DefaultModePrefer;

		// Token: 0x0400B68A RID: 46730
		[Token(Token = "0x400B68A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public string DefaultSignature;

		// Token: 0x02001FB1 RID: 8113
		[Token(Token = "0x2001FB1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD4C4", Offset = "0x10FD4C4")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x0600B429 RID: 46121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B429")]
			[Address(RVA = "0x238F8D0", Offset = "0x238F8D0", VA = "0x7BBCB8F8D0")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x0600B42A RID: 46122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B42A")]
			[Address(RVA = "0x23921B0", Offset = "0x23921B0", VA = "0x7BBCB921B0")]
			internal void <RequestBattleTag>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B68B RID: 46731
			[Token(Token = "0x400B68B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B68C RID: 46732
			[Token(Token = "0x400B68C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong account_id;
		}

		// Token: 0x02001FB2 RID: 8114
		[Token(Token = "0x2001FB2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD4D4", Offset = "0x10FD4D4")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x0600B42B RID: 46123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B42B")]
			[Address(RVA = "0x238FBD8", Offset = "0x238FBD8", VA = "0x7BBCB8FBD8")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0600B42C RID: 46124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B42C")]
			[Address(RVA = "0x23923EC", Offset = "0x23923EC", VA = "0x7BBCB923EC")]
			internal void <RequestShowBoardOnly>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B68D RID: 46733
			[Token(Token = "0x400B68D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B68E RID: 46734
			[Token(Token = "0x400B68E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong account_id;
		}

		// Token: 0x02001FB3 RID: 8115
		[Token(Token = "0x2001FB3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD4E4", Offset = "0x10FD4E4")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x0600B42D RID: 46125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B42D")]
			[Address(RVA = "0x239004C", Offset = "0x239004C", VA = "0x7BBCB9004C")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600B42E RID: 46126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B42E")]
			[Address(RVA = "0x23926A8", Offset = "0x23926A8", VA = "0x7BBCB926A8")]
			internal void <RequestShowBoardData>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B68F RID: 46735
			[Token(Token = "0x400B68F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B690 RID: 46736
			[Token(Token = "0x400B690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong account_id;

			// Token: 0x0400B691 RID: 46737
			[Token(Token = "0x400B691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool refreshavatar;
		}

		// Token: 0x02001FB4 RID: 8116
		[Token(Token = "0x2001FB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD4F4", Offset = "0x10FD4F4")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x0600B42F RID: 46127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B42F")]
			[Address(RVA = "0x239037C", Offset = "0x239037C", VA = "0x7BBCB9037C")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x0600B430 RID: 46128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B430")]
			[Address(RVA = "0x2392A4C", Offset = "0x2392A4C", VA = "0x7BBCB92A4C")]
			internal void <RequestPlayerBriefInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B692 RID: 46738
			[Token(Token = "0x400B692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B693 RID: 46739
			[Token(Token = "0x400B693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong account_id;
		}

		// Token: 0x02001FB5 RID: 8117
		[Token(Token = "0x2001FB5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD504", Offset = "0x10FD504")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x0600B431 RID: 46129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B431")]
			[Address(RVA = "0x239075C", Offset = "0x239075C", VA = "0x7BBCB9075C")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x0600B432 RID: 46130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B432")]
			[Address(RVA = "0x2392CC4", Offset = "0x2392CC4", VA = "0x7BBCB92CC4")]
			internal void <RequestPersonalInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B694 RID: 46740
			[Token(Token = "0x400B694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B695 RID: 46741
			[Token(Token = "0x400B695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong account_id;

			// Token: 0x0400B696 RID: 46742
			[Token(Token = "0x400B696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action callback;
		}

		// Token: 0x02001FB6 RID: 8118
		[Token(Token = "0x2001FB6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD514", Offset = "0x10FD514")]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x0600B433 RID: 46131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B433")]
			[Address(RVA = "0x2390B6C", Offset = "0x2390B6C", VA = "0x7BBCB90B6C")]
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x0600B434 RID: 46132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B434")]
			[Address(RVA = "0x2392F8C", Offset = "0x2392F8C", VA = "0x7BBCB92F8C")]
			internal void <RequestPlayerHeroicMarkInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B697 RID: 46743
			[Token(Token = "0x400B697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool IsLocalUser;

			// Token: 0x0400B698 RID: 46744
			[Token(Token = "0x400B698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B699 RID: 46745
			[Token(Token = "0x400B699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ulong account_id;
		}

		// Token: 0x02001FB7 RID: 8119
		[Token(Token = "0x2001FB7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD524", Offset = "0x10FD524")]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x0600B435 RID: 46133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B435")]
			[Address(RVA = "0x2390ED0", Offset = "0x2390ED0", VA = "0x7BBCB90ED0")]
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x0600B436 RID: 46134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B436")]
			[Address(RVA = "0x239318C", Offset = "0x239318C", VA = "0x7BBCB9318C")]
			internal void <RequestAllRelationshipStateInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B69A RID: 46746
			[Token(Token = "0x400B69A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B69B RID: 46747
			[Token(Token = "0x400B69B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong accid;
		}

		// Token: 0x02001FB8 RID: 8120
		[Token(Token = "0x2001FB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD534", Offset = "0x10FD534")]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x0600B437 RID: 46135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B437")]
			[Address(RVA = "0x23912F4", Offset = "0x23912F4", VA = "0x7BBCB912F4")]
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x0600B438 RID: 46136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B438")]
			[Address(RVA = "0x23933D8", Offset = "0x23933D8", VA = "0x7BBCB933D8")]
			internal void <RequestPersonalData>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B69C RID: 46748
			[Token(Token = "0x400B69C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelProfile <>4__this;

			// Token: 0x0400B69D RID: 46749
			[Token(Token = "0x400B69D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint matchMode;
		}

		// Token: 0x02001FB9 RID: 8121
		[Token(Token = "0x2001FB9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD544", Offset = "0x10FD544")]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x0600B439 RID: 46137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B439")]
			[Address(RVA = "0x23914A8", Offset = "0x23914A8", VA = "0x7BBCB914A8")]
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x0600B43A RID: 46138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B43A")]
			[Address(RVA = "0x23937FC", Offset = "0x23937FC", VA = "0x7BBCB937FC")]
			internal void <RequestSetPesonalSetting>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400B69E RID: 46750
			[Token(Token = "0x400B69E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool refreshbattle;

			// Token: 0x0400B69F RID: 46751
			[Token(Token = "0x400B69F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelProfile <>4__this;
		}
	}
}
