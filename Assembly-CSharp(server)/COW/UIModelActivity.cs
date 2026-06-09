using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001D3F RID: 7487
	[Token(Token = "0x2001D3F")]
	public class UIModelActivity : UIBaseModel
	{
		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x0002AAE0 File Offset: 0x00028CE0
		// (set) Token: 0x0600A2BD RID: 41661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB6")]
		public ulong EasterActivityTodayExpireTime
		{
			[Token(Token = "0x600A2BC")]
			[Address(RVA = "0x1484DD8", Offset = "0x1484DD8", VA = "0x7BBBC84DD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114586C", Offset = "0x114586C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600A2BD")]
			[Address(RVA = "0x1484DE0", Offset = "0x1484DE0", VA = "0x7BBBC84DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114587C", Offset = "0x114587C")]
			private set
			{
			}
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2BE")]
		[Address(RVA = "0x1484DE8", Offset = "0x1484DE8", VA = "0x7BBBC84DE8")]
		public TagConfig GetActivityTagConfigByEvent(EEventTag eEvent)
		{
			return null;
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		// (set) Token: 0x0600A2C0 RID: 41664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB7")]
		public bool HasFirstRecharge
		{
			[Token(Token = "0x600A2BF")]
			[Address(RVA = "0x1484E68", Offset = "0x1484E68", VA = "0x7BBBC84E68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2C0")]
			[Address(RVA = "0x1484E70", Offset = "0x1484E70", VA = "0x7BBBC84E70")]
			private set
			{
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600A2C1 RID: 41665 RVA: 0x0002AB10 File Offset: 0x00028D10
		// (set) Token: 0x0600A2C2 RID: 41666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB8")]
		public bool HasSecondRecharge
		{
			[Token(Token = "0x600A2C1")]
			[Address(RVA = "0x1484F18", Offset = "0x1484F18", VA = "0x7BBBC84F18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2C2")]
			[Address(RVA = "0x1484F20", Offset = "0x1484F20", VA = "0x7BBBC84F20")]
			private set
			{
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x0002AB28 File Offset: 0x00028D28
		// (set) Token: 0x0600A2C4 RID: 41668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB9")]
		public bool HasShareImage
		{
			[Token(Token = "0x600A2C3")]
			[Address(RVA = "0x1484F2C", Offset = "0x1484F2C", VA = "0x7BBBC84F2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2C4")]
			[Address(RVA = "0x1484F34", Offset = "0x1484F34", VA = "0x7BBBC84F34")]
			private set
			{
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x0002AB40 File Offset: 0x00028D40
		// (set) Token: 0x0600A2C6 RID: 41670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABA")]
		public bool ShowFriendReunionInviter
		{
			[Token(Token = "0x600A2C5")]
			[Address(RVA = "0x1484F40", Offset = "0x1484F40", VA = "0x7BBBC84F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114588C", Offset = "0x114588C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2C6")]
			[Address(RVA = "0x1484F48", Offset = "0x1484F48", VA = "0x7BBBC84F48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114589C", Offset = "0x114589C")]
			private set
			{
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600A2C7 RID: 41671 RVA: 0x0002AB58 File Offset: 0x00028D58
		// (set) Token: 0x0600A2C8 RID: 41672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABB")]
		public bool ShowFriendReunionInvitee
		{
			[Token(Token = "0x600A2C7")]
			[Address(RVA = "0x1484F54", Offset = "0x1484F54", VA = "0x7BBBC84F54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11458AC", Offset = "0x11458AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2C8")]
			[Address(RVA = "0x1484F5C", Offset = "0x1484F5C", VA = "0x7BBBC84F5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11458BC", Offset = "0x11458BC")]
			private set
			{
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600A2C9 RID: 41673 RVA: 0x0002AB70 File Offset: 0x00028D70
		[Token(Token = "0x17000ABC")]
		public bool ShowFriendReunion
		{
			[Token(Token = "0x600A2C9")]
			[Address(RVA = "0x1484F68", Offset = "0x1484F68", VA = "0x7BBBC84F68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A2CB RID: 41675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABD")]
		public CSGetFestivalAttendanceInfoRes MegaFestivalAttendanceInfo
		{
			[Token(Token = "0x600A2CA")]
			[Address(RVA = "0x1484F7C", Offset = "0x1484F7C", VA = "0x7BBBC84F7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11458CC", Offset = "0x11458CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A2CB")]
			[Address(RVA = "0x1484F84", Offset = "0x1484F84", VA = "0x7BBBC84F84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11458DC", Offset = "0x11458DC")]
			private set
			{
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600A2CC RID: 41676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A2CD RID: 41677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABE")]
		public List<FestivalAttendanceItem> MegaFestivalSigninAwards
		{
			[Token(Token = "0x600A2CC")]
			[Address(RVA = "0x1484F8C", Offset = "0x1484F8C", VA = "0x7BBBC84F8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11458EC", Offset = "0x11458EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A2CD")]
			[Address(RVA = "0x1484F94", Offset = "0x1484F94", VA = "0x7BBBC84F94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11458FC", Offset = "0x11458FC")]
			private set
			{
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x0002AB88 File Offset: 0x00028D88
		// (set) Token: 0x0600A2CF RID: 41679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABF")]
		public bool HasGetMegaFestivalInfoSinceLogin
		{
			[Token(Token = "0x600A2CE")]
			[Address(RVA = "0x1484F9C", Offset = "0x1484F9C", VA = "0x7BBBC84F9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114590C", Offset = "0x114590C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2CF")]
			[Address(RVA = "0x1484FA4", Offset = "0x1484FA4", VA = "0x7BBBC84FA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114591C", Offset = "0x114591C")]
			private set
			{
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600A2D0 RID: 41680 RVA: 0x0002ABA0 File Offset: 0x00028DA0
		// (set) Token: 0x0600A2D1 RID: 41681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC0")]
		public bool IsShowMegaFestivalRedDot
		{
			[Token(Token = "0x600A2D0")]
			[Address(RVA = "0x1484FB0", Offset = "0x1484FB0", VA = "0x7BBBC84FB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A2D1")]
			[Address(RVA = "0x1484FB8", Offset = "0x1484FB8", VA = "0x7BBBC84FB8")]
			set
			{
			}
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D2")]
		[Address(RVA = "0x14850A0", Offset = "0x14850A0", VA = "0x7BBBC850A0", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D3")]
		[Address(RVA = "0x1485394", Offset = "0x1485394", VA = "0x7BBBC85394")]
		public void UpdateEasterActivityTodayExpireTime()
		{
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x0002ABB8 File Offset: 0x00028DB8
		[Token(Token = "0x600A2D4")]
		[Address(RVA = "0x1485500", Offset = "0x1485500", VA = "0x7BBBC85500")]
		public bool ActivityDescDataFetched()
		{
			return default(bool);
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x0002ABD0 File Offset: 0x00028DD0
		[Token(Token = "0x600A2D5")]
		[Address(RVA = "0x1485510", Offset = "0x1485510", VA = "0x7BBBC85510")]
		public bool HasActivityInfoData()
		{
			return default(bool);
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		[Token(Token = "0x600A2D6")]
		[Address(RVA = "0x1485520", Offset = "0x1485520", VA = "0x7BBBC85520")]
		public bool HasMegaAttendanceInfoData()
		{
			return default(bool);
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2D7")]
		[Address(RVA = "0x1485530", Offset = "0x1485530", VA = "0x7BBBC85530")]
		public HttpRequest RequestActivityDesc(float timeout = 0f)
		{
			return null;
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D8")]
		[Address(RVA = "0x1485754", Offset = "0x1485754", VA = "0x7BBBC85754")]
		public void ProcessAllActivityDescs()
		{
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D9")]
		[Address(RVA = "0x1486628", Offset = "0x1486628", VA = "0x7BBBC86628")]
		public void OnActivityDescResponse(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x0002AC00 File Offset: 0x00028E00
		[Token(Token = "0x600A2DA")]
		[Address(RVA = "0x1486340", Offset = "0x1486340", VA = "0x7BBBC86340")]
		public bool IsInValidLevel(ClientActivityDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x0002AC18 File Offset: 0x00028E18
		[Token(Token = "0x600A2DB")]
		[Address(RVA = "0x14867E8", Offset = "0x14867E8", VA = "0x7BBBC867E8")]
		public bool IsValidGroup(uint groupId)
		{
			return default(bool);
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2DC")]
		[Address(RVA = "0x1486C38", Offset = "0x1486C38", VA = "0x7BBBC86C38")]
		public HttpRequest RequestActivityInfo(float timeout = 0f, bool forceUpdate = false)
		{
			return null;
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DD")]
		[Address(RVA = "0x1486CF0", Offset = "0x1486CF0", VA = "0x7BBBC86CF0")]
		private void OnGetActivenessInfo()
		{
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DE")]
		[Address(RVA = "0x1486D9C", Offset = "0x1486D9C", VA = "0x7BBBC86D9C")]
		public void RequestGetActivenessInfo(uint groupid, bool preload = false)
		{
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DF")]
		[Address(RVA = "0x1486FE0", Offset = "0x1486FE0", VA = "0x7BBBC86FE0")]
		public void RequestGetActivenessInfoCache()
		{
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E0")]
		[Address(RVA = "0x1487000", Offset = "0x1487000", VA = "0x7BBBC87000")]
		private void OnGetActivenessRewardInfo()
		{
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E1")]
		[Address(RVA = "0x1487044", Offset = "0x1487044", VA = "0x7BBBC87044")]
		public void RequestGetActivenessRewardInfo(bool preload = false)
		{
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E2")]
		[Address(RVA = "0x1487304", Offset = "0x1487304", VA = "0x7BBBC87304")]
		public void RequestActivenessReward(uint _group_id, uint _box_id)
		{
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E3")]
		[Address(RVA = "0x1487554", Offset = "0x1487554", VA = "0x7BBBC87554")]
		private void RefreshActivenessRewardState(List<BoxState> boxState)
		{
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E4")]
		[Address(RVA = "0x1487874", Offset = "0x1487874", VA = "0x7BBBC87874")]
		public void OnActivityInfoResponse(HttpErrorCode errorCode, CSGetActivityInfoRes obj)
		{
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E5")]
		[Address(RVA = "0x1487C64", Offset = "0x1487C64", VA = "0x7BBBC87C64")]
		public void RequestActivityAward(uint activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true)
		{
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E6")]
		[Address(RVA = "0x1487F90", Offset = "0x1487F90", VA = "0x7BBBC87F90")]
		public void RequestActivityAwardInGameScene(uint activityid)
		{
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E7")]
		[Address(RVA = "0x1487D0C", Offset = "0x1487D0C", VA = "0x7BBBC87D0C")]
		public void RequestActivityAward(uint[] activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true)
		{
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E8")]
		[Address(RVA = "0x14881B4", Offset = "0x14881B4", VA = "0x7BBBC881B4")]
		public void RequestBountyActivityAward(uint activityid)
		{
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x0002AC30 File Offset: 0x00028E30
		[Token(Token = "0x600A2E9")]
		[Address(RVA = "0x1488430", Offset = "0x1488430", VA = "0x7BBBC88430")]
		public bool NeedShowActivenessClaimAllBtn()
		{
			return default(bool);
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EA")]
		[Address(RVA = "0x1488768", Offset = "0x1488768", VA = "0x7BBBC88768")]
		public void NotifyActivityUpdate(List<ActivityUpdateInfo> updateInfos)
		{
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2EB")]
		[Address(RVA = "0x1488D38", Offset = "0x1488D38", VA = "0x7BBBC88D38")]
		public ClientActivityDesc GetBigEventDescByID(uint activityID)
		{
			return null;
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2EC")]
		[Address(RVA = "0x1486740", Offset = "0x1486740", VA = "0x7BBBC86740")]
		public ActivityClientInfo GetActicityInfo(uint activityid)
		{
			return null;
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2ED")]
		[Address(RVA = "0x1489068", Offset = "0x1489068", VA = "0x7BBBC89068")]
		public ActivenessInfo GetActivenessInfo()
		{
			return null;
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EE")]
		[Address(RVA = "0x14851D0", Offset = "0x14851D0", VA = "0x7BBBC851D0")]
		public void ResetActivenessTaskAndReward()
		{
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x0002AC48 File Offset: 0x00028E48
		[Token(Token = "0x600A2EF")]
		[Address(RVA = "0x1489070", Offset = "0x1489070", VA = "0x7BBBC89070")]
		public ulong GetActivenessResetTime(EActivenessRewardType type)
		{
			return 0UL;
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2F0")]
		[Address(RVA = "0x1489268", Offset = "0x1489268", VA = "0x7BBBC89268")]
		public List<ActivenessReward> GetActivenessRewardList(EActivenessRewardType type)
		{
			return null;
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x0002AC60 File Offset: 0x00028E60
		[Token(Token = "0x600A2F1")]
		[Address(RVA = "0x1489318", Offset = "0x1489318", VA = "0x7BBBC89318")]
		public bool HasExchangeActivity()
		{
			return default(bool);
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x0002AC78 File Offset: 0x00028E78
		[Token(Token = "0x600A2F2")]
		[Address(RVA = "0x1489450", Offset = "0x1489450", VA = "0x7BBBC89450")]
		public bool HasBindActivity()
		{
			return default(bool);
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x0002AC90 File Offset: 0x00028E90
		[Token(Token = "0x600A2F3")]
		[Address(RVA = "0x1489588", Offset = "0x1489588", VA = "0x7BBBC89588")]
		public bool HasBindActivityNow()
		{
			return default(bool);
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		[Token(Token = "0x600A2F4")]
		[Address(RVA = "0x1489790", Offset = "0x1489790", VA = "0x7BBBC89790")]
		public bool IsInActivePeriod(ActivityGroupDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		[Token(Token = "0x600A2F5")]
		[Address(RVA = "0x1489824", Offset = "0x1489824", VA = "0x7BBBC89824")]
		public bool IsInActivePeriod(ClientActivityDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2F6")]
		[Address(RVA = "0x14898AC", Offset = "0x14898AC", VA = "0x7BBBC898AC")]
		public List<ActivityGroupDesc> GetActivityGroupDescs_Unfinished(EEventType eventType)
		{
			return null;
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2F7")]
		[Address(RVA = "0x1489958", Offset = "0x1489958", VA = "0x7BBBC89958")]
		public List<ActivityGroupDesc> GetActivityGroupDescs_RewardClaimable(EEventType eventType)
		{
			return null;
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		[Token(Token = "0x600A2F8")]
		[Address(RVA = "0x1489A04", Offset = "0x1489A04", VA = "0x7BBBC89A04")]
		public bool HasClaimableReward(ActivityGroupDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x0002ACF0 File Offset: 0x00028EF0
		[Token(Token = "0x600A2F9")]
		[Address(RVA = "0x1489CBC", Offset = "0x1489CBC", VA = "0x7BBBC89CBC")]
		public bool IsUnfinished(ActivityGroupDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2FA")]
		[Address(RVA = "0x1489DC0", Offset = "0x1489DC0", VA = "0x7BBBC89DC0")]
		public List<ActivityClientInfo> FindActivityInfosByGroupIdAndState(uint groupId, proto.EActivity.State state)
		{
			return null;
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x0002AD08 File Offset: 0x00028F08
		[Token(Token = "0x600A2FB")]
		[Address(RVA = "0x1489B08", Offset = "0x1489B08", VA = "0x7BBBC89B08")]
		private bool MatchWithActivityInfo(ActivityGroupDesc activityGroupDesc, Predicate<ActivityClientInfo> predicate)
		{
			return default(bool);
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x0002AD20 File Offset: 0x00028F20
		[Token(Token = "0x600A2FC")]
		[Address(RVA = "0x14896D0", Offset = "0x14896D0", VA = "0x7BBBC896D0")]
		public bool IsInPreviewPeriod(ActivityGroupDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x0002AD38 File Offset: 0x00028F38
		[Token(Token = "0x600A2FD")]
		[Address(RVA = "0x148A074", Offset = "0x148A074", VA = "0x7BBBC8A074")]
		public bool IsInPreviewPeriod(ClientActivityDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x0002AD50 File Offset: 0x00028F50
		[Token(Token = "0x600A2FE")]
		[Address(RVA = "0x148A138", Offset = "0x148A138", VA = "0x7BBBC8A138")]
		public bool IsInPreLoginPeriod(uint groupid)
		{
			return default(bool);
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2FF")]
		[Address(RVA = "0x148A1EC", Offset = "0x148A1EC", VA = "0x7BBBC8A1EC")]
		public ActivityGroupDesc GetActivityGroupDesc(uint groupid)
		{
			return null;
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A300")]
		[Address(RVA = "0x14885E4", Offset = "0x14885E4", VA = "0x7BBBC885E4")]
		public List<ActivityGroupDesc> GetActivityGroupDescs(EEventType eventType)
		{
			return null;
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A301")]
		[Address(RVA = "0x148A2FC", Offset = "0x148A2FC", VA = "0x7BBBC8A2FC")]
		public List<ActivityGroupDesc> GetActivityGroupDescs(EventEntryType entry, EEventType eventType)
		{
			return null;
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A302")]
		[Address(RVA = "0x1489FE0", Offset = "0x1489FE0", VA = "0x7BBBC89FE0")]
		public List<ClientActivityDesc> GetActivityDescList(uint groupid)
		{
			return null;
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A303")]
		[Address(RVA = "0x1489E9C", Offset = "0x1489E9C", VA = "0x7BBBC89E9C")]
		public List<ActivityClientInfo> GetActivityInfoList(uint groupid)
		{
			return null;
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x0002AD68 File Offset: 0x00028F68
		[Token(Token = "0x600A304")]
		[Address(RVA = "0x148A5E4", Offset = "0x148A5E4", VA = "0x7BBBC8A5E4")]
		public int GetEasterRedDotNum()
		{
			return 0;
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0002AD80 File Offset: 0x00028F80
		[Token(Token = "0x600A305")]
		[Address(RVA = "0x148AC70", Offset = "0x148AC70", VA = "0x7BBBC8AC70")]
		public int GetOverviewRedDotNum()
		{
			return 0;
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x0002AD98 File Offset: 0x00028F98
		[Token(Token = "0x600A306")]
		[Address(RVA = "0x148AFB0", Offset = "0x148AFB0", VA = "0x7BBBC8AFB0")]
		public bool IsOverviewActivityRedDotValid(ClientActivityDesc activity)
		{
			return default(bool);
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x0002ADB0 File Offset: 0x00028FB0
		[Token(Token = "0x600A307")]
		[Address(RVA = "0x148B218", Offset = "0x148B218", VA = "0x7BBBC8B218")]
		public int GetExchangeActivityCanExchageNum(ActivityGroupDesc groupDesc)
		{
			return 0;
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		[Token(Token = "0x600A308")]
		[Address(RVA = "0x148AAF8", Offset = "0x148AAF8", VA = "0x7BBBC8AAF8")]
		public bool ExchangeActivityCanExchange(uint activityId)
		{
			return default(bool);
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		[Token(Token = "0x600A309")]
		[Address(RVA = "0x148B454", Offset = "0x148B454", VA = "0x7BBBC8B454")]
		public bool ExchangeActivityItemCountEnough(ClientActivityDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x0002ADF8 File Offset: 0x00028FF8
		[Token(Token = "0x600A30A")]
		[Address(RVA = "0x148B37C", Offset = "0x148B37C", VA = "0x7BBBC8B37C")]
		public bool IsActivityInForecastTime(uint activityId)
		{
			return default(bool);
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A30B")]
		[Address(RVA = "0x1487B30", Offset = "0x1487B30", VA = "0x7BBBC87B30")]
		private void UpdateExtraInfo()
		{
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A30C")]
		[Address(RVA = "0x148B570", Offset = "0x148B570", VA = "0x7BBBC8B570")]
		private void UpdateShowActivityDescGroup()
		{
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x0002AE10 File Offset: 0x00029010
		[Token(Token = "0x600A30D")]
		[Address(RVA = "0x148C4C0", Offset = "0x148C4C0", VA = "0x7BBBC8C4C0")]
		public bool GroupAwared(ActivityGroupDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A30E")]
		[Address(RVA = "0x1484FC4", Offset = "0x1484FC4", VA = "0x7BBBC84FC4")]
		private void UpdateActivityTipsNum()
		{
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A30F")]
		[Address(RVA = "0x148CC0C", Offset = "0x148CC0C", VA = "0x7BBBC8CC0C")]
		public void CloseExchangeRedTips(uint activity_id)
		{
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A310")]
		[Address(RVA = "0x148CCD0", Offset = "0x148CCD0", VA = "0x7BBBC8CCD0")]
		public void OpenExchangeRedTips(uint activity_id)
		{
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x0002AE28 File Offset: 0x00029028
		[Token(Token = "0x600A311")]
		[Address(RVA = "0x148AA38", Offset = "0x148AA38", VA = "0x7BBBC8AA38")]
		public bool IsExchangeRedTipsClosed(uint activity_id)
		{
			return default(bool);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x0002AE40 File Offset: 0x00029040
		[Token(Token = "0x600A312")]
		[Address(RVA = "0x148C634", Offset = "0x148C634", VA = "0x7BBBC8C634")]
		public int ActivityDailyTipsNum()
		{
			return 0;
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x0002AE58 File Offset: 0x00029058
		[Token(Token = "0x600A313")]
		[Address(RVA = "0x148C6DC", Offset = "0x148C6DC", VA = "0x7BBBC8C6DC")]
		public int ActivityFestival1TipsNum()
		{
			return 0;
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x0002AE70 File Offset: 0x00029070
		[Token(Token = "0x600A314")]
		[Address(RVA = "0x148C784", Offset = "0x148C784", VA = "0x7BBBC8C784")]
		public int ActivityFestival2TipsNum()
		{
			return 0;
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x0002AE88 File Offset: 0x00029088
		[Token(Token = "0x600A315")]
		[Address(RVA = "0x148C82C", Offset = "0x148C82C", VA = "0x7BBBC8C82C")]
		private int UpdateMegaFestivalTipsNum()
		{
			return 0;
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x0002AEA0 File Offset: 0x000290A0
		[Token(Token = "0x600A316")]
		[Address(RVA = "0x148CD94", Offset = "0x148CD94", VA = "0x7BBBC8CD94")]
		public int ActivityTopTabTipsNum(EventTabType tabType)
		{
			return 0;
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x0002AEB8 File Offset: 0x000290B8
		[Token(Token = "0x600A317")]
		[Address(RVA = "0x148C8D4", Offset = "0x148C8D4", VA = "0x7BBBC8C8D4")]
		public int ActivityGwTokenTipsNum()
		{
			return 0;
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x0002AED0 File Offset: 0x000290D0
		[Token(Token = "0x600A318")]
		[Address(RVA = "0x148C97C", Offset = "0x148C97C", VA = "0x7BBBC8C97C")]
		public int ActivityGwCommonTipsNum()
		{
			return 0;
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x0002AEE8 File Offset: 0x000290E8
		[Token(Token = "0x600A319")]
		[Address(RVA = "0x148CA24", Offset = "0x148CA24", VA = "0x7BBBC8CA24")]
		public int ActivityActivenessTipsNum()
		{
			return 0;
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x0002AF00 File Offset: 0x00029100
		[Token(Token = "0x600A31A")]
		[Address(RVA = "0x148CEC4", Offset = "0x148CEC4", VA = "0x7BBBC8CEC4")]
		public int MegaFestivalTabTipsNum(EventTabType tabType)
		{
			return 0;
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x0002AF18 File Offset: 0x00029118
		[Token(Token = "0x600A31B")]
		[Address(RVA = "0x148DFF0", Offset = "0x148DFF0", VA = "0x7BBBC8DFF0")]
		private int MegaFestivalGroupTipsNum(ActivityGroupDesc group)
		{
			return 0;
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x0002AF30 File Offset: 0x00029130
		[Token(Token = "0x600A31C")]
		[Address(RVA = "0x148E158", Offset = "0x148E158", VA = "0x7BBBC8E158")]
		public int GetActivityTipsNumForThirdTab(List<ClientActivityDesc> activityList)
		{
			return 0;
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x0002AF48 File Offset: 0x00029148
		[Token(Token = "0x600A31D")]
		[Address(RVA = "0x148DBDC", Offset = "0x148DBDC", VA = "0x7BBBC8DBDC")]
		public int ActivityGroupTipsNum(ActivityGroupDesc group)
		{
			return 0;
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x0002AF60 File Offset: 0x00029160
		[Token(Token = "0x600A31E")]
		[Address(RVA = "0x148E358", Offset = "0x148E358", VA = "0x7BBBC8E358")]
		public bool FestivalActivityAvailble(ActivityGroupDesc group)
		{
			return default(bool);
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0002AF78 File Offset: 0x00029178
		[Token(Token = "0x600A31F")]
		[Address(RVA = "0x148E738", Offset = "0x148E738", VA = "0x7BBBC8E738")]
		public bool FestivalActivityAvailble(List<ClientActivityDesc> descs)
		{
			return default(bool);
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A320")]
		[Address(RVA = "0x148B6B0", Offset = "0x148B6B0", VA = "0x7BBBC8B6B0")]
		private void UpdateFirstRecharge()
		{
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A321")]
		[Address(RVA = "0x148B984", Offset = "0x148B984", VA = "0x7BBBC8B984")]
		private void UpdateSecondRecharge()
		{
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x0002AF90 File Offset: 0x00029190
		[Token(Token = "0x600A322")]
		[Address(RVA = "0x148E898", Offset = "0x148E898", VA = "0x7BBBC8E898")]
		public EQuestState GetActivityGroupState(EEventType eventType)
		{
			return EQuestState.None;
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A323")]
		[Address(RVA = "0x148BA54", Offset = "0x148BA54", VA = "0x7BBBC8BA54")]
		private void UpdateShareImage()
		{
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A324")]
		[Address(RVA = "0x148EB94", Offset = "0x148EB94", VA = "0x7BBBC8EB94")]
		private List<uint> _GetDisplayedFriendReunionInviteeActivities()
		{
			return null;
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A325")]
		[Address(RVA = "0x148ED80", Offset = "0x148ED80", VA = "0x7BBBC8ED80")]
		private void _SetDisplayedFriendReunionInviteeActivities(List<uint> group_ids)
		{
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A326")]
		[Address(RVA = "0x148EF0C", Offset = "0x148EF0C", VA = "0x7BBBC8EF0C")]
		private UIModelActivity.FBInvited _GetFBInvited()
		{
			return null;
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A327")]
		[Address(RVA = "0x148F148", Offset = "0x148F148", VA = "0x7BBBC8F148")]
		private void _SetFBInvited(UIModelActivity.FBInvited fbInvited)
		{
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x0002AFA8 File Offset: 0x000291A8
		[Token(Token = "0x600A328")]
		[Address(RVA = "0x148F370", Offset = "0x148F370", VA = "0x7BBBC8F370")]
		public bool GetFriendReunionFBInvited(ulong uid)
		{
			return default(bool);
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x0002AFC0 File Offset: 0x000291C0
		[Token(Token = "0x600A329")]
		[Address(RVA = "0x148F4C0", Offset = "0x148F4C0", VA = "0x7BBBC8F4C0")]
		public bool GetFriendReunionFBInvited(ulong uid, uint group_id)
		{
			return default(bool);
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A32A")]
		[Address(RVA = "0x148F84C", Offset = "0x148F84C", VA = "0x7BBBC8F84C")]
		public void SetFriendReunionFBInvited(ulong uid)
		{
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A32B")]
		[Address(RVA = "0x148FEBC", Offset = "0x148FEBC", VA = "0x7BBBC8FEBC")]
		public void OnFriendReunionInviteeActivityDisplayed(ActivityGroupDesc desc)
		{
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0002AFD8 File Offset: 0x000291D8
		[Token(Token = "0x600A32C")]
		[Address(RVA = "0x148FFD4", Offset = "0x148FFD4", VA = "0x7BBBC8FFD4")]
		public bool ShowTipsForFriendReunionInviteeActivity(ActivityGroupDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x0002AFF0 File Offset: 0x000291F0
		[Token(Token = "0x600A32D")]
		[Address(RVA = "0x149005C", Offset = "0x149005C", VA = "0x7BBBC9005C")]
		public bool ShowInviterInputForFriendReunionInviteeActivity(ActivityGroupDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x0002B008 File Offset: 0x00029208
		[Token(Token = "0x600A32E")]
		[Address(RVA = "0x1490254", Offset = "0x1490254", VA = "0x7BBBC90254")]
		public bool IsFriendReunionInviteeActivityGained(ActivityGroupDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x0002B020 File Offset: 0x00029220
		[Token(Token = "0x600A32F")]
		[Address(RVA = "0x14903AC", Offset = "0x14903AC", VA = "0x7BBBC903AC")]
		public bool ShouldShowFriendReunionFor(FriendAccountInfo friend)
		{
			return default(bool);
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A330")]
		[Address(RVA = "0x14904E0", Offset = "0x14904E0", VA = "0x7BBBC904E0")]
		public void InspectFriendReunionInviteeActivity(ActivityGroupDesc desc, out bool show, out int tips)
		{
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A331")]
		[Address(RVA = "0x14906C4", Offset = "0x14906C4", VA = "0x7BBBC906C4")]
		public void InspectFriendReunionInviterActivity(ActivityGroupDesc desc, out bool show, out int tips)
		{
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A332")]
		[Address(RVA = "0x148BC28", Offset = "0x148BC28", VA = "0x7BBBC8BC28")]
		private void UpdateFriendReunion()
		{
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A333")]
		[Address(RVA = "0x14907F4", Offset = "0x14907F4", VA = "0x7BBBC907F4")]
		public void SendFriendReunion(ulong inviterID, uint activityID, bool isFriend)
		{
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x0002B038 File Offset: 0x00029238
		// (set) Token: 0x0600A335 RID: 41781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC1")]
		public bool WillRewardForVideoAds
		{
			[Token(Token = "0x600A334")]
			[Address(RVA = "0x14909F8", Offset = "0x14909F8", VA = "0x7BBBC909F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114592C", Offset = "0x114592C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A335")]
			[Address(RVA = "0x1490A00", Offset = "0x1490A00", VA = "0x7BBBC90A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114593C", Offset = "0x114593C")]
			private set
			{
			}
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x0002B050 File Offset: 0x00029250
		[Token(Token = "0x600A336")]
		[Address(RVA = "0x148E58C", Offset = "0x148E58C", VA = "0x7BBBC8E58C")]
		public int GetRedDot(EEventType eventType, uint group_id)
		{
			return 0;
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A337")]
		[Address(RVA = "0x1490A0C", Offset = "0x1490A0C", VA = "0x7BBBC90A0C")]
		private void ClearRedDot(EEventType eventType)
		{
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A338")]
		[Address(RVA = "0x1490B18", Offset = "0x1490B18", VA = "0x7BBBC90B18")]
		private void SetRedDot(EEventType eventType, uint group_id, int num)
		{
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x0002B068 File Offset: 0x00029268
		[Token(Token = "0x600A339")]
		[Address(RVA = "0x1490C3C", Offset = "0x1490C3C", VA = "0x7BBBC90C3C")]
		private int CalcRedDots(EEventType eventType)
		{
			return 0;
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A33A")]
		[Address(RVA = "0x148BDDC", Offset = "0x148BDDC", VA = "0x7BBBC8BDDC")]
		private void UpdateRewardedVideo()
		{
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600A33B RID: 41787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A33C RID: 41788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC2")]
		public ActivityGroupDesc CurrentDisplayPaymentActivity
		{
			[Token(Token = "0x600A33B")]
			[Address(RVA = "0x1490E18", Offset = "0x1490E18", VA = "0x7BBBC90E18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114594C", Offset = "0x114594C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A33C")]
			[Address(RVA = "0x1490E20", Offset = "0x1490E20", VA = "0x7BBBC90E20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114595C", Offset = "0x114595C")]
			private set
			{
			}
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A33D")]
		[Address(RVA = "0x148BF6C", Offset = "0x148BF6C", VA = "0x7BBBC8BF6C")]
		private void UpdatePaymentActivity()
		{
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A33E")]
		[Address(RVA = "0x148C13C", Offset = "0x148C13C", VA = "0x7BBBC8C13C")]
		private void UpdatePaymentTotal()
		{
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A33F")]
		[Address(RVA = "0x148C1DC", Offset = "0x148C1DC", VA = "0x7BBBC8C1DC")]
		private void UpdateOptionalDownloadRewarded()
		{
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x0002B080 File Offset: 0x00029280
		[Token(Token = "0x600A340")]
		[Address(RVA = "0x148E4D0", Offset = "0x148E4D0", VA = "0x7BBBC8E4D0")]
		public bool IsNewActivity(uint groupid)
		{
			return default(bool);
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A341")]
		[Address(RVA = "0x1490E28", Offset = "0x1490E28", VA = "0x7BBBC90E28")]
		public void SetActivityReaded(uint groupid)
		{
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x0002B098 File Offset: 0x00029298
		[Token(Token = "0x600A342")]
		[Address(RVA = "0x148B15C", Offset = "0x148B15C", VA = "0x7BBBC8B15C")]
		public bool IsSingleActivityGotoUnClicked(uint activityId)
		{
			return default(bool);
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A343")]
		[Address(RVA = "0x1490EEC", Offset = "0x1490EEC", VA = "0x7BBBC90EEC")]
		public void SetSingleActivityGotoClicked(uint activityId)
		{
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x0002B0B0 File Offset: 0x000292B0
		[Token(Token = "0x600A344")]
		[Address(RVA = "0x1491054", Offset = "0x1491054", VA = "0x7BBBC91054")]
		public bool IsActivityGotoUnClicked(uint groupid)
		{
			return default(bool);
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A345")]
		[Address(RVA = "0x1491110", Offset = "0x1491110", VA = "0x7BBBC91110")]
		public void SetActivityGotoClicked(uint groupid)
		{
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A346")]
		[Address(RVA = "0x14911D4", Offset = "0x14911D4", VA = "0x7BBBC911D4")]
		public void ResetActivityGotoClickStatus(uint id)
		{
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A347")]
		[Address(RVA = "0x149134C", Offset = "0x149134C", VA = "0x7BBBC9134C")]
		public ActivityGroupDesc GetGroupDescOfActivity(uint activityid)
		{
			return null;
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A348")]
		[Address(RVA = "0x1488BCC", Offset = "0x1488BCC", VA = "0x7BBBC88BCC")]
		public ClientActivityDesc GetActivityDesc(uint activityid)
		{
			return null;
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A349")]
		[Address(RVA = "0x14914D0", Offset = "0x14914D0", VA = "0x7BBBC914D0")]
		public ActivityFestivalDesc GetFestivalDesc(EventTabType type)
		{
			return null;
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A34A")]
		[Address(RVA = "0x14916F4", Offset = "0x14916F4", VA = "0x7BBBC916F4")]
		public ActivityFestivalDesc GetFestivalDesc(uint groupId, uint affiliateTab)
		{
			return null;
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A34B")]
		[Address(RVA = "0x148D004", Offset = "0x148D004", VA = "0x7BBBC8D004")]
		public List<ActivityGroupDesc> GetActivityGroupDescList(EventTabType type)
		{
			return null;
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x0002B0C8 File Offset: 0x000292C8
		[Token(Token = "0x600A34C")]
		[Address(RVA = "0x149180C", Offset = "0x149180C", VA = "0x7BBBC9180C")]
		public ulong GetRampageResetTime()
		{
			return 0UL;
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x0002B0E0 File Offset: 0x000292E0
		[Token(Token = "0x600A34D")]
		[Address(RVA = "0x1491920", Offset = "0x1491920", VA = "0x7BBBC91920")]
		public int GetActivityGroupAWARDEDNum(uint groupid)
		{
			return 0;
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A34E")]
		[Address(RVA = "0x1491A08", Offset = "0x1491A08", VA = "0x7BBBC91A08")]
		public void RequestBingoRowCloumReward(int row = 0, int colum = 0)
		{
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x0002B0F8 File Offset: 0x000292F8
		[Token(Token = "0x600A34F")]
		[Address(RVA = "0x1491A0C", Offset = "0x1491A0C", VA = "0x7BBBC91A0C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A350")]
		[Address(RVA = "0x1491A14", Offset = "0x1491A14", VA = "0x7BBBC91A14")]
		public HttpRequest GetMegaFestivalAttendanceInfo(bool silence = false)
		{
			return null;
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A351")]
		[Address(RVA = "0x1491C60", Offset = "0x1491C60", VA = "0x7BBBC91C60")]
		public void ClaimMegaFestivalItem(uint id)
		{
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x0002B110 File Offset: 0x00029310
		[Token(Token = "0x600A352")]
		[Address(RVA = "0x1491F58", Offset = "0x1491F58", VA = "0x7BBBC91F58")]
		public bool CheckIsNeedAutoSignMegaFestival()
		{
			return default(bool);
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A353")]
		[Address(RVA = "0x1491FD8", Offset = "0x1491FD8", VA = "0x7BBBC91FD8")]
		public void MegaFestivalAutoSignin()
		{
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x0002B128 File Offset: 0x00029328
		[Token(Token = "0x600A354")]
		[Address(RVA = "0x149227C", Offset = "0x149227C", VA = "0x7BBBC9227C")]
		public int GetNowDaysSinceMegaFestivalStartDay()
		{
			return 0;
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x0002B140 File Offset: 0x00029340
		[Token(Token = "0x600A355")]
		[Address(RVA = "0x149233C", Offset = "0x149233C", VA = "0x7BBBC9233C")]
		public static EventEntryType GetEventEntryType(EventTabType tabType)
		{
			return EventEntryType.Unkonw;
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x0002B158 File Offset: 0x00029358
		[Token(Token = "0x600A356")]
		[Address(RVA = "0x148A4CC", Offset = "0x148A4CC", VA = "0x7BBBC8A4CC")]
		public static EventEntryType GetEventEntryType(int tabType)
		{
			return EventEntryType.Unkonw;
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A357")]
		[Address(RVA = "0x1486384", Offset = "0x1486384", VA = "0x7BBBC86384")]
		public void CheckAllHintReset()
		{
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x0002B170 File Offset: 0x00029370
		[Token(Token = "0x600A358")]
		[Address(RVA = "0x1492524", Offset = "0x1492524", VA = "0x7BBBC92524")]
		private ulong GetSecondsToNearestHintResetTime(uint groupId)
		{
			return 0UL;
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A359")]
		[Address(RVA = "0x1492360", Offset = "0x1492360", VA = "0x7BBBC92360")]
		private void StartCountDownHintReset(uint groupId)
		{
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A35A")]
		[Address(RVA = "0x14851D8", Offset = "0x14851D8", VA = "0x7BBBC851D8")]
		private void ClearHintReset()
		{
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A35B")]
		[Address(RVA = "0x14926DC", Offset = "0x14926DC", VA = "0x7BBBC926DC")]
		public void DoHintReset(uint groupId)
		{
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A35C")]
		[Address(RVA = "0x149283C", Offset = "0x149283C", VA = "0x7BBBC9283C")]
		public ClientActivityDesc GetBigEventTaskDescById(uint activityID)
		{
			return null;
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A35D")]
		[Address(RVA = "0x14928BC", Offset = "0x14928BC", VA = "0x7BBBC928BC")]
		public ClientActivityDesc GetBigEventActivityDescByTwoType(EEventType type, proto.EActivity.SubType subType)
		{
			return null;
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A35E")]
		[Address(RVA = "0x14929F8", Offset = "0x14929F8", VA = "0x7BBBC929F8")]
		public List<ClientActivityDesc> GetBigEventSortedDescListByTwoType(EEventType type, proto.EActivity.SubType subType)
		{
			return null;
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A35F")]
		[Address(RVA = "0x1492C00", Offset = "0x1492C00", VA = "0x7BBBC92C00")]
		public List<ClientActivityDesc> GetBigEventActivityDesc(EEventType type)
		{
			return null;
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A360")]
		[Address(RVA = "0x1492C80", Offset = "0x1492C80", VA = "0x7BBBC92C80")]
		public Dictionary<uint, ClientActivityDesc> GetBigEventTaskDesc()
		{
			return null;
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A361")]
		[Address(RVA = "0x1492C88", Offset = "0x1492C88", VA = "0x7BBBC92C88")]
		public ClientActivityDesc GetBountyAwardActivityDesc(uint table)
		{
			return null;
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A362")]
		[Address(RVA = "0x1492E1C", Offset = "0x1492E1C", VA = "0x7BBBC92E1C")]
		public List<ClientActivityDesc> GetBountyActivityDesc()
		{
			return null;
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A363")]
		[Address(RVA = "0x1492F80", Offset = "0x1492F80", VA = "0x7BBBC92F80")]
		public UIModelActivity()
		{
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A365")]
		[Address(RVA = "0x1493540", Offset = "0x1493540", VA = "0x7BBBC93540")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114596C", Offset = "0x114596C")]
		private void <RequestActivityAwardInGameScene>b__109_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x0002B188 File Offset: 0x00029388
		[Token(Token = "0x600A366")]
		[Address(RVA = "0x1493828", Offset = "0x1493828", VA = "0x7BBBC93828")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114597C", Offset = "0x114597C")]
		private bool <GroupAwared>b__148_0(ClientActivityDesc e)
		{
			return default(bool);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x0002B1A0 File Offset: 0x000293A0
		[Token(Token = "0x600A367")]
		[Address(RVA = "0x1493870", Offset = "0x1493870", VA = "0x7BBBC93870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114598C", Offset = "0x114598C")]
		private bool <GroupAwared>b__148_1(ClientActivityDesc e)
		{
			return default(bool);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A368")]
		[Address(RVA = "0x14938B8", Offset = "0x14938B8", VA = "0x7BBBC938B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114599C", Offset = "0x114599C")]
		private void <SendFriendReunion>b__190_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x0002B1B8 File Offset: 0x000293B8
		[Token(Token = "0x600A369")]
		[Address(RVA = "0x1493DF4", Offset = "0x1493DF4", VA = "0x7BBBC93DF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11459AC", Offset = "0x11459AC")]
		private bool <UpdatePaymentActivity>b__205_0(ActivityGroupDesc g)
		{
			return default(bool);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x0002B1D0 File Offset: 0x000293D0
		[Token(Token = "0x600A36A")]
		[Address(RVA = "0x1493E38", Offset = "0x1493E38", VA = "0x7BBBC93E38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11459BC", Offset = "0x11459BC")]
		private bool <GetActivityGroupDescList>b__219_0(ActivityGroupDesc e)
		{
			return default(bool);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A36B")]
		[Address(RVA = "0x1493F08", Offset = "0x1493F08", VA = "0x7BBBC93F08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11459CC", Offset = "0x11459CC")]
		private void <GetMegaFestivalAttendanceInfo>b__224_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A36C")]
		[Address(RVA = "0x14940FC", Offset = "0x14940FC", VA = "0x7BBBC940FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11459DC", Offset = "0x11459DC")]
		private void <MegaFestivalAutoSignin>b__227_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0002B1E8 File Offset: 0x000293E8
		[Token(Token = "0x600A36D")]
		[Address(RVA = "0x14942E0", Offset = "0x14942E0", VA = "0x7BBBC942E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11459EC", Offset = "0x11459EC")]
		private bool <MegaFestivalAutoSignin>b__227_1(FestivalAttendanceItem item)
		{
			return default(bool);
		}

		// Token: 0x0400A95E RID: 43358
		[Token(Token = "0x400A95E")]
		[FieldOffset(Offset = "0x18")]
		private List<ActivityGroupDesc> m_ActivityGroupDescList;

		// Token: 0x0400A95F RID: 43359
		[Token(Token = "0x400A95F")]
		[FieldOffset(Offset = "0x20")]
		private List<ActivityFestivalDesc> m_ActivityFestivalDescList;

		// Token: 0x0400A960 RID: 43360
		[Token(Token = "0x400A960")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<uint, ActivityClientInfo> m_ActivityInfoDic;

		// Token: 0x0400A961 RID: 43361
		[Token(Token = "0x400A961")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, string> m_ActivityInfoUpdateContextCache;

		// Token: 0x0400A962 RID: 43362
		[Token(Token = "0x400A962")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, List<ActivenessReward>> m_ActivenessRewardsDic;

		// Token: 0x0400A963 RID: 43363
		[Token(Token = "0x400A963")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, ClientActivityDesc> m_BigEventTaskDescDict;

		// Token: 0x0400A964 RID: 43364
		[Token(Token = "0x400A964")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<uint> m_BigEventTaskTypeSet;

		// Token: 0x0400A965 RID: 43365
		[Token(Token = "0x400A965")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, List<ClientActivityDesc>> m_BigEventActivityDict;

		// Token: 0x0400A966 RID: 43366
		[Token(Token = "0x400A966")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<uint> m_BigEventActivityTypeSet;

		// Token: 0x0400A967 RID: 43367
		[Token(Token = "0x400A967")]
		private const string ACT_READED_FORMAT = "Activity{0}";

		// Token: 0x0400A968 RID: 43368
		[Token(Token = "0x400A968")]
		private const string ACT_GOTO_CLICK_FORMAT = "ActivityGotoClick{0}";

		// Token: 0x0400A969 RID: 43369
		[Token(Token = "0x400A969")]
		private const string ACT_EXCHANGE_REDTIPS_FORMAT = "ActivityExchangeRedTips{0}";

		// Token: 0x0400A96A RID: 43370
		[Token(Token = "0x400A96A")]
		private const string HTTPActivityNoRewardsAvailable = "BR_ACTIVITY_NO_REWARDS_AVAILABLE";

		// Token: 0x0400A96B RID: 43371
		[Token(Token = "0x400A96B")]
		private const string HTTPActivityGetRewardsFailed = "BR_ACTIVITY_GET_REWARDS_FAILED";

		// Token: 0x0400A96C RID: 43372
		[Token(Token = "0x400A96C")]
		private const string PREFS_CLOSE_ACTIVITY_EXCHANGE_RED_TIPS = "CLOSE_ACTIVITY_EXCHANGE_RED_TIPS";

		// Token: 0x0400A96D RID: 43373
		[Token(Token = "0x400A96D")]
		public const string CONFIG_CONSTANT_TIME = "2029-01-01 23:59:59";

		// Token: 0x0400A96E RID: 43374
		[Token(Token = "0x400A96E")]
		[FieldOffset(Offset = "0x60")]
		private bool m_HasFirstRecharge;

		// Token: 0x0400A96F RID: 43375
		[Token(Token = "0x400A96F")]
		[FieldOffset(Offset = "0x61")]
		private bool m_HasSecondRecharge;

		// Token: 0x0400A970 RID: 43376
		[Token(Token = "0x400A970")]
		[FieldOffset(Offset = "0x62")]
		private bool m_HasShareImage;

		// Token: 0x0400A971 RID: 43377
		[Token(Token = "0x400A971")]
		[FieldOffset(Offset = "0x68")]
		private CSGetActivityDescRes m_ActivityDescRes;

		// Token: 0x0400A972 RID: 43378
		[Token(Token = "0x400A972")]
		[FieldOffset(Offset = "0x70")]
		private CSGetActivityInfoRes m_ActivityInfoRes;

		// Token: 0x0400A973 RID: 43379
		[Token(Token = "0x400A973")]
		[FieldOffset(Offset = "0x78")]
		private ActivenessInfo m_ActivenessInfoRes;

		// Token: 0x0400A974 RID: 43380
		[Token(Token = "0x400A974")]
		[FieldOffset(Offset = "0x80")]
		private WaitingResponseHandler m_WaitingHandler;

		// Token: 0x0400A975 RID: 43381
		[Token(Token = "0x400A975")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FDBC", Offset = "0x112FDBC")]
		private ulong <EasterActivityTodayExpireTime>k__BackingField;

		// Token: 0x0400A976 RID: 43382
		[Token(Token = "0x400A976")]
		public const int PropID_UpdateActivityInfo = 2;

		// Token: 0x0400A977 RID: 43383
		[Token(Token = "0x400A977")]
		public const int PropID_GetActivityReward = 4;

		// Token: 0x0400A978 RID: 43384
		[Token(Token = "0x400A978")]
		public const int PropID_UpdateActivityDesc = 8;

		// Token: 0x0400A979 RID: 43385
		[Token(Token = "0x400A979")]
		public const int PropID_UpdateActivityDescFailed = 16;

		// Token: 0x0400A97A RID: 43386
		[Token(Token = "0x400A97A")]
		public const int PropID_UpdateActivityInfoFailed = 32;

		// Token: 0x0400A97B RID: 43387
		[Token(Token = "0x400A97B")]
		public const int PropID_ReunionFBInvited = 64;

		// Token: 0x0400A97C RID: 43388
		[Token(Token = "0x400A97C")]
		public const int PropID_MegaFestivalSignin = 128;

		// Token: 0x0400A97D RID: 43389
		[Token(Token = "0x400A97D")]
		public const int PropID_GetMegaFestivalAttendanceInfo = 256;

		// Token: 0x0400A97E RID: 43390
		[Token(Token = "0x400A97E")]
		public const int PropID_GetMegaFestivalItemInfo = 512;

		// Token: 0x0400A97F RID: 43391
		[Token(Token = "0x400A97F")]
		public const int PropID_UpdateActivenessInfo = 1024;

		// Token: 0x0400A980 RID: 43392
		[Token(Token = "0x400A980")]
		public const int PropID_UpdateActivenessRewardsList = 2048;

		// Token: 0x0400A981 RID: 43393
		[Token(Token = "0x400A981")]
		public const int PropID_GetActivenessTaskReward = 4096;

		// Token: 0x0400A982 RID: 43394
		[Token(Token = "0x400A982")]
		public const int PropID_SingleActivityReaded = 8192;

		// Token: 0x0400A983 RID: 43395
		[Token(Token = "0x400A983")]
		public const int PropID_Hint_Reset = 16384;

		// Token: 0x0400A984 RID: 43396
		[Token(Token = "0x400A984")]
		public const int PropID_FestivalGetRewards = 32768;

		// Token: 0x0400A985 RID: 43397
		[Token(Token = "0x400A985")]
		public const int PropID_GetMegaFestivalAttendanceInfoFailed = 65536;

		// Token: 0x0400A986 RID: 43398
		[Token(Token = "0x400A986")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<EEventTag, TagConfig> TagConfigDict;

		// Token: 0x0400A987 RID: 43399
		[Token(Token = "0x400A987")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FDCC", Offset = "0x112FDCC")]
		private bool <ShowFriendReunionInviter>k__BackingField;

		// Token: 0x0400A988 RID: 43400
		[Token(Token = "0x400A988")]
		[FieldOffset(Offset = "0x99")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FDDC", Offset = "0x112FDDC")]
		private bool <ShowFriendReunionInvitee>k__BackingField;

		// Token: 0x0400A989 RID: 43401
		[Token(Token = "0x400A989")]
		[FieldOffset(Offset = "0x9A")]
		private bool m_IsSignedTodayMegaFestival;

		// Token: 0x0400A98A RID: 43402
		[Token(Token = "0x400A98A")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FDEC", Offset = "0x112FDEC")]
		private CSGetFestivalAttendanceInfoRes <MegaFestivalAttendanceInfo>k__BackingField;

		// Token: 0x0400A98B RID: 43403
		[Token(Token = "0x400A98B")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FDFC", Offset = "0x112FDFC")]
		private List<FestivalAttendanceItem> <MegaFestivalSigninAwards>k__BackingField;

		// Token: 0x0400A98C RID: 43404
		[Token(Token = "0x400A98C")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE0C", Offset = "0x112FE0C")]
		private bool <HasGetMegaFestivalInfoSinceLogin>k__BackingField;

		// Token: 0x0400A98D RID: 43405
		[Token(Token = "0x400A98D")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_IsShowMegaFestivalRedDot;

		// Token: 0x0400A98E RID: 43406
		[Token(Token = "0x400A98E")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<uint, List<ulong>> m_HintResetDict;

		// Token: 0x0400A98F RID: 43407
		[Token(Token = "0x400A98F")]
		[FieldOffset(Offset = "0xC0")]
		private List<uint> m_HintResetCalls;

		// Token: 0x0400A990 RID: 43408
		[Token(Token = "0x400A990")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_PreloadActiveness;

		// Token: 0x0400A991 RID: 43409
		[Token(Token = "0x400A991")]
		[FieldOffset(Offset = "0xD0")]
		private ulong m_ToNextDailyReFreshTime;

		// Token: 0x0400A992 RID: 43410
		[Token(Token = "0x400A992")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_PreloadActivenessReward;

		// Token: 0x0400A993 RID: 43411
		[Token(Token = "0x400A993")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_HaveRewards;

		// Token: 0x0400A994 RID: 43412
		[Token(Token = "0x400A994")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_GroupID;

		// Token: 0x0400A995 RID: 43413
		[Token(Token = "0x400A995")]
		[FieldOffset(Offset = "0xE0")]
		private CSGetActivenessRewardReq m_PendingGetActivenessReward;

		// Token: 0x0400A996 RID: 43414
		[Token(Token = "0x400A996")]
		[FieldOffset(Offset = "0xE8")]
		private string PLAYER_PREFS_KEY_FRIEND_REUNION_INVITEE_ACTIVITIES;

		// Token: 0x0400A997 RID: 43415
		[Token(Token = "0x400A997")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PLAYER_PREFS_KEY_FB_INVITED;

		// Token: 0x0400A998 RID: 43416
		[Token(Token = "0x400A998")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE1C", Offset = "0x112FE1C")]
		private bool <WillRewardForVideoAds>k__BackingField;

		// Token: 0x0400A999 RID: 43417
		[Token(Token = "0x400A999")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<EEventType, Dictionary<uint, int>> m_RedDots;

		// Token: 0x0400A99A RID: 43418
		[Token(Token = "0x400A99A")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE2C", Offset = "0x112FE2C")]
		private ActivityGroupDesc <CurrentDisplayPaymentActivity>k__BackingField;

		// Token: 0x02001D40 RID: 7488
		[Token(Token = "0x2001D40")]
		[Serializable]
		private class FBInvitedPerActivity
		{
			// Token: 0x0600A36E RID: 41838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A36E")]
			[Address(RVA = "0x2351088", Offset = "0x2351088", VA = "0x7BBCB51088")]
			public FBInvitedPerActivity()
			{
			}

			// Token: 0x0400A99B RID: 43419
			[Token(Token = "0x400A99B")]
			[FieldOffset(Offset = "0x10")]
			public uint group_id;

			// Token: 0x0400A99C RID: 43420
			[Token(Token = "0x400A99C")]
			[FieldOffset(Offset = "0x18")]
			public ulong[] uids;
		}

		// Token: 0x02001D41 RID: 7489
		[Token(Token = "0x2001D41")]
		[Serializable]
		private class FBInvited
		{
			// Token: 0x0600A36F RID: 41839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A36F")]
			[Address(RVA = "0x2351080", Offset = "0x2351080", VA = "0x7BBCB51080")]
			public FBInvited()
			{
			}

			// Token: 0x0400A99D RID: 43421
			[Token(Token = "0x400A99D")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity.FBInvitedPerActivity[] Info;
		}

		// Token: 0x02001D42 RID: 7490
		[Token(Token = "0x2001D42")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBBB4", Offset = "0x10FBBB4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A371 RID: 41841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A371")]
			[Address(RVA = "0x234E598", Offset = "0x234E598", VA = "0x7BBCB4E598")]
			public <>c()
			{
			}

			// Token: 0x0600A372 RID: 41842 RVA: 0x0002B200 File Offset: 0x00029400
			[Token(Token = "0x600A372")]
			[Address(RVA = "0x234E5A0", Offset = "0x234E5A0", VA = "0x7BBCB4E5A0")]
			internal int <ProcessAllActivityDescs>b__89_0(ActivityGroupDesc a, ActivityGroupDesc b)
			{
				return 0;
			}

			// Token: 0x0600A373 RID: 41843 RVA: 0x0002B218 File Offset: 0x00029418
			[Token(Token = "0x600A373")]
			[Address(RVA = "0x234E5E8", Offset = "0x234E5E8", VA = "0x7BBCB4E5E8")]
			internal int <RequestGetActivenessRewardInfo>b__103_1(ActivenessReward a, ActivenessReward b)
			{
				return 0;
			}

			// Token: 0x0600A374 RID: 41844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A374")]
			[Address(RVA = "0x234E62C", Offset = "0x234E62C", VA = "0x7BBCB4E62C")]
			internal CommonRewardItemInfo <RequestActivenessReward>b__105_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A375 RID: 41845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A375")]
			[Address(RVA = "0x234E638", Offset = "0x234E638", VA = "0x7BBCB4E638")]
			internal CommonRewardItemInfo <RequestActivityAward>b__110_3(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A376 RID: 41846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A376")]
			[Address(RVA = "0x234E644", Offset = "0x234E644", VA = "0x7BBCB4E644")]
			internal CommonRewardItemInfo <RequestBountyActivityAward>b__111_2(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A377 RID: 41847 RVA: 0x0002B230 File Offset: 0x00029430
			[Token(Token = "0x600A377")]
			[Address(RVA = "0x234E650", Offset = "0x234E650", VA = "0x7BBCB4E650")]
			internal bool <HasClaimableReward>b__127_0(ActivityClientInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600A378 RID: 41848 RVA: 0x0002B248 File Offset: 0x00029448
			[Token(Token = "0x600A378")]
			[Address(RVA = "0x234E66C", Offset = "0x234E66C", VA = "0x7BBCB4E66C")]
			internal bool <IsUnfinished>b__128_0(ActivityClientInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600A379 RID: 41849 RVA: 0x0002B260 File Offset: 0x00029460
			[Token(Token = "0x600A379")]
			[Address(RVA = "0x234E688", Offset = "0x234E688", VA = "0x7BBCB4E688")]
			internal bool <GetEasterRedDotNum>b__139_0(ActivityGroupDesc temp)
			{
				return default(bool);
			}

			// Token: 0x0600A37A RID: 41850 RVA: 0x0002B278 File Offset: 0x00029478
			[Token(Token = "0x600A37A")]
			[Address(RVA = "0x234E6BC", Offset = "0x234E6BC", VA = "0x7BBCB4E6BC")]
			internal bool <GetOverviewRedDotNum>b__140_0(ActivityGroupDesc temp)
			{
				return default(bool);
			}

			// Token: 0x0600A37B RID: 41851 RVA: 0x0002B290 File Offset: 0x00029490
			[Token(Token = "0x600A37B")]
			[Address(RVA = "0x234E6F0", Offset = "0x234E6F0", VA = "0x7BBCB4E6F0")]
			internal bool <ExchangeActivityItemCountEnough>b__144_0(Item e)
			{
				return default(bool);
			}

			// Token: 0x0600A37C RID: 41852 RVA: 0x0002B2A8 File Offset: 0x000294A8
			[Token(Token = "0x600A37C")]
			[Address(RVA = "0x234E7D4", Offset = "0x234E7D4", VA = "0x7BBCB4E7D4")]
			internal uint <_GetDisplayedFriendReunionInviteeActivities>b__172_0(string idString)
			{
				return 0U;
			}

			// Token: 0x0600A37D RID: 41853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A37D")]
			[Address(RVA = "0x234E810", Offset = "0x234E810", VA = "0x7BBCB4E810")]
			internal string <_SetDisplayedFriendReunionInviteeActivities>b__173_0(uint id)
			{
				return null;
			}

			// Token: 0x0600A37E RID: 41854 RVA: 0x0002B2C0 File Offset: 0x000294C0
			[Token(Token = "0x600A37E")]
			[Address(RVA = "0x234E838", Offset = "0x234E838", VA = "0x7BBCB4E838")]
			internal int <GetActivityGroupDescList>b__219_1(ActivityGroupDesc a, ActivityGroupDesc b)
			{
				return 0;
			}

			// Token: 0x0600A37F RID: 41855 RVA: 0x0002B2D8 File Offset: 0x000294D8
			[Token(Token = "0x600A37F")]
			[Address(RVA = "0x234E880", Offset = "0x234E880", VA = "0x7BBCB4E880")]
			internal int <GetMegaFestivalAttendanceInfo>b__224_1(FestivalAttendanceItem x, FestivalAttendanceItem y)
			{
				return 0;
			}

			// Token: 0x0600A380 RID: 41856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A380")]
			[Address(RVA = "0x234E8C4", Offset = "0x234E8C4", VA = "0x7BBCB4E8C4")]
			internal AwardItemInfo <ClaimMegaFestivalItem>b__225_2(AwardDesc item)
			{
				return null;
			}

			// Token: 0x0600A381 RID: 41857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A381")]
			[Address(RVA = "0x234E8D0", Offset = "0x234E8D0", VA = "0x7BBCB4E8D0")]
			internal CommonRewardItemInfo <ClaimMegaFestivalItem>b__225_3(AwardItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A382 RID: 41858 RVA: 0x0002B2F0 File Offset: 0x000294F0
			[Token(Token = "0x600A382")]
			[Address(RVA = "0x234E8DC", Offset = "0x234E8DC", VA = "0x7BBCB4E8DC")]
			internal int <GetBigEventSortedDescListByTwoType>b__238_1(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x0400A99E RID: 43422
			[Token(Token = "0x400A99E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelActivity.<>c <>9;

			// Token: 0x0400A99F RID: 43423
			[Token(Token = "0x400A99F")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ActivityGroupDesc> <>9__89_0;

			// Token: 0x0400A9A0 RID: 43424
			[Token(Token = "0x400A9A0")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<ActivenessReward> <>9__103_1;

			// Token: 0x0400A9A1 RID: 43425
			[Token(Token = "0x400A9A1")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__105_1;

			// Token: 0x0400A9A2 RID: 43426
			[Token(Token = "0x400A9A2")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__110_3;

			// Token: 0x0400A9A3 RID: 43427
			[Token(Token = "0x400A9A3")]
			[FieldOffset(Offset = "0x28")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__111_2;

			// Token: 0x0400A9A4 RID: 43428
			[Token(Token = "0x400A9A4")]
			[FieldOffset(Offset = "0x30")]
			public static Predicate<ActivityClientInfo> <>9__127_0;

			// Token: 0x0400A9A5 RID: 43429
			[Token(Token = "0x400A9A5")]
			[FieldOffset(Offset = "0x38")]
			public static Predicate<ActivityClientInfo> <>9__128_0;

			// Token: 0x0400A9A6 RID: 43430
			[Token(Token = "0x400A9A6")]
			[FieldOffset(Offset = "0x40")]
			public static Predicate<ActivityGroupDesc> <>9__139_0;

			// Token: 0x0400A9A7 RID: 43431
			[Token(Token = "0x400A9A7")]
			[FieldOffset(Offset = "0x48")]
			public static Predicate<ActivityGroupDesc> <>9__140_0;

			// Token: 0x0400A9A8 RID: 43432
			[Token(Token = "0x400A9A8")]
			[FieldOffset(Offset = "0x50")]
			public static Predicate<Item> <>9__144_0;

			// Token: 0x0400A9A9 RID: 43433
			[Token(Token = "0x400A9A9")]
			[FieldOffset(Offset = "0x58")]
			public static Converter<string, uint> <>9__172_0;

			// Token: 0x0400A9AA RID: 43434
			[Token(Token = "0x400A9AA")]
			[FieldOffset(Offset = "0x60")]
			public static Converter<uint, string> <>9__173_0;

			// Token: 0x0400A9AB RID: 43435
			[Token(Token = "0x400A9AB")]
			[FieldOffset(Offset = "0x68")]
			public static Comparison<ActivityGroupDesc> <>9__219_1;

			// Token: 0x0400A9AC RID: 43436
			[Token(Token = "0x400A9AC")]
			[FieldOffset(Offset = "0x70")]
			public static Comparison<FestivalAttendanceItem> <>9__224_1;

			// Token: 0x0400A9AD RID: 43437
			[Token(Token = "0x400A9AD")]
			[FieldOffset(Offset = "0x78")]
			public static Converter<AwardDesc, AwardItemInfo> <>9__225_2;

			// Token: 0x0400A9AE RID: 43438
			[Token(Token = "0x400A9AE")]
			[FieldOffset(Offset = "0x80")]
			public static Converter<AwardItemInfo, CommonRewardItemInfo> <>9__225_3;

			// Token: 0x0400A9AF RID: 43439
			[Token(Token = "0x400A9AF")]
			[FieldOffset(Offset = "0x88")]
			public static Comparison<ClientActivityDesc> <>9__238_1;
		}

		// Token: 0x02001D43 RID: 7491
		[Token(Token = "0x2001D43")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBBC4", Offset = "0x10FBBC4")]
		private sealed class <>c__DisplayClass96_0
		{
			// Token: 0x0600A383 RID: 41859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A383")]
			[Address(RVA = "0x2350EC0", Offset = "0x2350EC0", VA = "0x7BBCB50EC0")]
			public <>c__DisplayClass96_0()
			{
			}

			// Token: 0x0600A384 RID: 41860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A384")]
			[Address(RVA = "0x2350EC8", Offset = "0x2350EC8", VA = "0x7BBCB50EC8")]
			internal void <RequestGetActivenessInfo>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400A9B0 RID: 43440
			[Token(Token = "0x400A9B0")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity <>4__this;

			// Token: 0x0400A9B1 RID: 43441
			[Token(Token = "0x400A9B1")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001D44 RID: 7492
		[Token(Token = "0x2001D44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBBD4", Offset = "0x10FBBD4")]
		private sealed class <>c__DisplayClass103_0
		{
			// Token: 0x0600A385 RID: 41861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A385")]
			[Address(RVA = "0x234E924", Offset = "0x234E924", VA = "0x7BBCB4E924")]
			public <>c__DisplayClass103_0()
			{
			}

			// Token: 0x0600A386 RID: 41862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A386")]
			[Address(RVA = "0x234E92C", Offset = "0x234E92C", VA = "0x7BBCB4E92C")]
			internal void <RequestGetActivenessRewardInfo>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400A9B2 RID: 43442
			[Token(Token = "0x400A9B2")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity <>4__this;

			// Token: 0x0400A9B3 RID: 43443
			[Token(Token = "0x400A9B3")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001D45 RID: 7493
		[Token(Token = "0x2001D45")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBBE4", Offset = "0x10FBBE4")]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x0600A387 RID: 41863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A387")]
			[Address(RVA = "0x234F190", Offset = "0x234F190", VA = "0x7BBCB4F190")]
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x0600A388 RID: 41864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A388")]
			[Address(RVA = "0x234F198", Offset = "0x234F198", VA = "0x7BBCB4F198")]
			internal void <RequestActivenessReward>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400A9B4 RID: 43444
			[Token(Token = "0x400A9B4")]
			[FieldOffset(Offset = "0x10")]
			public uint _group_id;

			// Token: 0x0400A9B5 RID: 43445
			[Token(Token = "0x400A9B5")]
			[FieldOffset(Offset = "0x14")]
			public uint _box_id;

			// Token: 0x0400A9B6 RID: 43446
			[Token(Token = "0x400A9B6")]
			[FieldOffset(Offset = "0x18")]
			public UIModelActivity <>4__this;
		}

		// Token: 0x02001D46 RID: 7494
		[Token(Token = "0x2001D46")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBBF4", Offset = "0x10FBBF4")]
		private sealed class <>c__DisplayClass110_0
		{
			// Token: 0x0600A389 RID: 41865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A389")]
			[Address(RVA = "0x234F4FC", Offset = "0x234F4FC", VA = "0x7BBCB4F4FC")]
			public <>c__DisplayClass110_0()
			{
			}

			// Token: 0x0600A38A RID: 41866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A38A")]
			[Address(RVA = "0x234F504", Offset = "0x234F504", VA = "0x7BBCB4F504")]
			internal void <RequestActivityAward>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0600A38B RID: 41867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A38B")]
			[Address(RVA = "0x234FA84", Offset = "0x234FA84", VA = "0x7BBCB4FA84")]
			internal void <RequestActivityAward>b__1()
			{
			}

			// Token: 0x0400A9B7 RID: 43447
			[Token(Token = "0x400A9B7")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity <>4__this;

			// Token: 0x0400A9B8 RID: 43448
			[Token(Token = "0x400A9B8")]
			[FieldOffset(Offset = "0x18")]
			public bool showRewardWindow;

			// Token: 0x0400A9B9 RID: 43449
			[Token(Token = "0x400A9B9")]
			[FieldOffset(Offset = "0x20")]
			public uint[] activityid;

			// Token: 0x0400A9BA RID: 43450
			[Token(Token = "0x400A9BA")]
			[FieldOffset(Offset = "0x28")]
			public bool bigPriceControlCommonRewardWnd;

			// Token: 0x0400A9BB RID: 43451
			[Token(Token = "0x400A9BB")]
			[FieldOffset(Offset = "0x30")]
			public Action <>9__1;
		}

		// Token: 0x02001D47 RID: 7495
		[Token(Token = "0x2001D47")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC04", Offset = "0x10FBC04")]
		private sealed class <>c__DisplayClass110_1
		{
			// Token: 0x0600A38C RID: 41868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A38C")]
			[Address(RVA = "0x234FA7C", Offset = "0x234FA7C", VA = "0x7BBCB4FA7C")]
			public <>c__DisplayClass110_1()
			{
			}

			// Token: 0x0600A38D RID: 41869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A38D")]
			[Address(RVA = "0x234FBD4", Offset = "0x234FBD4", VA = "0x7BBCB4FBD4")]
			internal void <RequestActivityAward>b__2()
			{
			}

			// Token: 0x0400A9BC RID: 43452
			[Token(Token = "0x400A9BC")]
			[FieldOffset(Offset = "0x10")]
			public CSGetActivityRewardsRes res;

			// Token: 0x0400A9BD RID: 43453
			[Token(Token = "0x400A9BD")]
			[FieldOffset(Offset = "0x18")]
			public UIModelActivity.<>c__DisplayClass110_0 CS$<>8__locals1;
		}

		// Token: 0x02001D48 RID: 7496
		[Token(Token = "0x2001D48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC14", Offset = "0x10FBC14")]
		private sealed class <>c__DisplayClass111_0
		{
			// Token: 0x0600A38E RID: 41870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A38E")]
			[Address(RVA = "0x234FE2C", Offset = "0x234FE2C", VA = "0x7BBCB4FE2C")]
			public <>c__DisplayClass111_0()
			{
			}

			// Token: 0x0600A38F RID: 41871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A38F")]
			[Address(RVA = "0x234FE34", Offset = "0x234FE34", VA = "0x7BBCB4FE34")]
			internal void <RequestBountyActivityAward>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400A9BE RID: 43454
			[Token(Token = "0x400A9BE")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity <>4__this;

			// Token: 0x0400A9BF RID: 43455
			[Token(Token = "0x400A9BF")]
			[FieldOffset(Offset = "0x18")]
			public uint activityid;
		}

		// Token: 0x02001D49 RID: 7497
		[Token(Token = "0x2001D49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC24", Offset = "0x10FBC24")]
		private sealed class <>c__DisplayClass111_1
		{
			// Token: 0x0600A390 RID: 41872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A390")]
			[Address(RVA = "0x2350454", Offset = "0x2350454", VA = "0x7BBCB50454")]
			public <>c__DisplayClass111_1()
			{
			}

			// Token: 0x0600A391 RID: 41873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A391")]
			[Address(RVA = "0x235045C", Offset = "0x235045C", VA = "0x7BBCB5045C")]
			internal void <RequestBountyActivityAward>b__1()
			{
			}

			// Token: 0x0400A9C0 RID: 43456
			[Token(Token = "0x400A9C0")]
			[FieldOffset(Offset = "0x10")]
			public CSGetActivityRewardsRes res;

			// Token: 0x0400A9C1 RID: 43457
			[Token(Token = "0x400A9C1")]
			[FieldOffset(Offset = "0x18")]
			public bool taskEffect;

			// Token: 0x0400A9C2 RID: 43458
			[Token(Token = "0x400A9C2")]
			[FieldOffset(Offset = "0x20")]
			public UIModelActivity.<>c__DisplayClass111_0 CS$<>8__locals1;
		}

		// Token: 0x02001D4A RID: 7498
		[Token(Token = "0x2001D4A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC34", Offset = "0x10FBC34")]
		private sealed class <>c__DisplayClass129_0
		{
			// Token: 0x0600A392 RID: 41874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A392")]
			[Address(RVA = "0x2350670", Offset = "0x2350670", VA = "0x7BBCB50670")]
			public <>c__DisplayClass129_0()
			{
			}

			// Token: 0x0600A393 RID: 41875 RVA: 0x0002B308 File Offset: 0x00029508
			[Token(Token = "0x600A393")]
			[Address(RVA = "0x2350678", Offset = "0x2350678", VA = "0x7BBCB50678")]
			internal bool <FindActivityInfosByGroupIdAndState>b__0(ActivityClientInfo info)
			{
				return default(bool);
			}

			// Token: 0x0400A9C3 RID: 43459
			[Token(Token = "0x400A9C3")]
			[FieldOffset(Offset = "0x10")]
			public proto.EActivity.State state;
		}

		// Token: 0x02001D4B RID: 7499
		[Token(Token = "0x2001D4B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC44", Offset = "0x10FBC44")]
		private sealed class <>c__DisplayClass141_0
		{
			// Token: 0x0600A394 RID: 41876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A394")]
			[Address(RVA = "0x23506B4", Offset = "0x23506B4", VA = "0x7BBCB506B4")]
			public <>c__DisplayClass141_0()
			{
			}

			// Token: 0x0600A395 RID: 41877 RVA: 0x0002B320 File Offset: 0x00029520
			[Token(Token = "0x600A395")]
			[Address(RVA = "0x23506BC", Offset = "0x23506BC", VA = "0x7BBCB506BC")]
			internal bool <IsOverviewActivityRedDotValid>b__0(AdvertDesc temp)
			{
				return default(bool);
			}

			// Token: 0x0400A9C4 RID: 43460
			[Token(Token = "0x400A9C4")]
			[FieldOffset(Offset = "0x10")]
			public ClientActivityDesc activity;
		}

		// Token: 0x02001D4C RID: 7500
		[Token(Token = "0x2001D4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC54", Offset = "0x10FBC54")]
		private sealed class <>c__DisplayClass180_0
		{
			// Token: 0x0600A396 RID: 41878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A396")]
			[Address(RVA = "0x2350708", Offset = "0x2350708", VA = "0x7BBCB50708")]
			public <>c__DisplayClass180_0()
			{
			}

			// Token: 0x0600A397 RID: 41879 RVA: 0x0002B338 File Offset: 0x00029538
			[Token(Token = "0x600A397")]
			[Address(RVA = "0x2350710", Offset = "0x2350710", VA = "0x7BBCB50710")]
			internal bool <GetFriendReunionFBInvited>b__0(UIModelActivity.FBInvitedPerActivity invited)
			{
				return default(bool);
			}

			// Token: 0x0400A9C5 RID: 43461
			[Token(Token = "0x400A9C5")]
			[FieldOffset(Offset = "0x10")]
			public uint group_id;
		}

		// Token: 0x02001D4D RID: 7501
		[Token(Token = "0x2001D4D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC64", Offset = "0x10FBC64")]
		private sealed class <>c__DisplayClass181_0
		{
			// Token: 0x0600A398 RID: 41880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A398")]
			[Address(RVA = "0x2350730", Offset = "0x2350730", VA = "0x7BBCB50730")]
			public <>c__DisplayClass181_0()
			{
			}

			// Token: 0x0600A399 RID: 41881 RVA: 0x0002B350 File Offset: 0x00029550
			[Token(Token = "0x600A399")]
			[Address(RVA = "0x2350738", Offset = "0x2350738", VA = "0x7BBCB50738")]
			internal bool <SetFriendReunionFBInvited>b__0(UIModelActivity.FBInvitedPerActivity info)
			{
				return default(bool);
			}

			// Token: 0x0400A9C6 RID: 43462
			[Token(Token = "0x400A9C6")]
			[FieldOffset(Offset = "0x10")]
			public ActivityGroupDesc desc;
		}

		// Token: 0x02001D4E RID: 7502
		[Token(Token = "0x2001D4E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC74", Offset = "0x10FBC74")]
		private sealed class <>c__DisplayClass217_0
		{
			// Token: 0x0600A39A RID: 41882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39A")]
			[Address(RVA = "0x2350784", Offset = "0x2350784", VA = "0x7BBCB50784")]
			public <>c__DisplayClass217_0()
			{
			}

			// Token: 0x0600A39B RID: 41883 RVA: 0x0002B368 File Offset: 0x00029568
			[Token(Token = "0x600A39B")]
			[Address(RVA = "0x235078C", Offset = "0x235078C", VA = "0x7BBCB5078C")]
			internal bool <GetFestivalDesc>b__0(ActivityFestivalDesc item)
			{
				return default(bool);
			}

			// Token: 0x0400A9C7 RID: 43463
			[Token(Token = "0x400A9C7")]
			[FieldOffset(Offset = "0x10")]
			public EventTabType type;
		}

		// Token: 0x02001D4F RID: 7503
		[Token(Token = "0x2001D4F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC84", Offset = "0x10FBC84")]
		private sealed class <>c__DisplayClass218_0
		{
			// Token: 0x0600A39C RID: 41884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39C")]
			[Address(RVA = "0x23507C8", Offset = "0x23507C8", VA = "0x7BBCB507C8")]
			public <>c__DisplayClass218_0()
			{
			}

			// Token: 0x0600A39D RID: 41885 RVA: 0x0002B380 File Offset: 0x00029580
			[Token(Token = "0x600A39D")]
			[Address(RVA = "0x23507D0", Offset = "0x23507D0", VA = "0x7BBCB507D0")]
			internal bool <GetFestivalDesc>b__0(ActivityFestivalDesc item)
			{
				return default(bool);
			}

			// Token: 0x0400A9C8 RID: 43464
			[Token(Token = "0x400A9C8")]
			[FieldOffset(Offset = "0x10")]
			public uint groupId;

			// Token: 0x0400A9C9 RID: 43465
			[Token(Token = "0x400A9C9")]
			[FieldOffset(Offset = "0x14")]
			public uint affiliateTab;
		}

		// Token: 0x02001D50 RID: 7504
		[Token(Token = "0x2001D50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBC94", Offset = "0x10FBC94")]
		private sealed class <>c__DisplayClass225_0
		{
			// Token: 0x0600A39E RID: 41886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39E")]
			[Address(RVA = "0x2350824", Offset = "0x2350824", VA = "0x7BBCB50824")]
			public <>c__DisplayClass225_0()
			{
			}

			// Token: 0x0600A39F RID: 41887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39F")]
			[Address(RVA = "0x235082C", Offset = "0x235082C", VA = "0x7BBCB5082C")]
			internal void <ClaimMegaFestivalItem>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A3A0 RID: 41888 RVA: 0x0002B398 File Offset: 0x00029598
			[Token(Token = "0x600A3A0")]
			[Address(RVA = "0x2350D14", Offset = "0x2350D14", VA = "0x7BBCB50D14")]
			internal bool <ClaimMegaFestivalItem>b__1(FestivalAttendanceItem item)
			{
				return default(bool);
			}

			// Token: 0x0400A9CA RID: 43466
			[Token(Token = "0x400A9CA")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity <>4__this;

			// Token: 0x0400A9CB RID: 43467
			[Token(Token = "0x400A9CB")]
			[FieldOffset(Offset = "0x18")]
			public uint id;

			// Token: 0x0400A9CC RID: 43468
			[Token(Token = "0x400A9CC")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<FestivalAttendanceItem> <>9__1;
		}

		// Token: 0x02001D51 RID: 7505
		[Token(Token = "0x2001D51")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBCA4", Offset = "0x10FBCA4")]
		private sealed class <>c__DisplayClass233_0
		{
			// Token: 0x0600A3A1 RID: 41889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A1")]
			[Address(RVA = "0x2350D50", Offset = "0x2350D50", VA = "0x7BBCB50D50")]
			public <>c__DisplayClass233_0()
			{
			}

			// Token: 0x0400A9CD RID: 43469
			[Token(Token = "0x400A9CD")]
			[FieldOffset(Offset = "0x10")]
			public UIModelActivity <>4__this;

			// Token: 0x0400A9CE RID: 43470
			[Token(Token = "0x400A9CE")]
			[FieldOffset(Offset = "0x18")]
			public uint groupId;
		}

		// Token: 0x02001D52 RID: 7506
		[Token(Token = "0x2001D52")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBCB4", Offset = "0x10FBCB4")]
		private sealed class <>c__DisplayClass233_1
		{
			// Token: 0x0600A3A2 RID: 41890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A2")]
			[Address(RVA = "0x2350D58", Offset = "0x2350D58", VA = "0x7BBCB50D58")]
			public <>c__DisplayClass233_1()
			{
			}

			// Token: 0x0600A3A3 RID: 41891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A3")]
			[Address(RVA = "0x2350D60", Offset = "0x2350D60", VA = "0x7BBCB50D60")]
			internal void <StartCountDownHintReset>b__0()
			{
			}

			// Token: 0x0400A9CF RID: 43471
			[Token(Token = "0x400A9CF")]
			[FieldOffset(Offset = "0x10")]
			public uint callId;

			// Token: 0x0400A9D0 RID: 43472
			[Token(Token = "0x400A9D0")]
			[FieldOffset(Offset = "0x18")]
			public UIModelActivity.<>c__DisplayClass233_0 CS$<>8__locals1;
		}

		// Token: 0x02001D53 RID: 7507
		[Token(Token = "0x2001D53")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBCC4", Offset = "0x10FBCC4")]
		private sealed class <>c__DisplayClass237_0
		{
			// Token: 0x0600A3A4 RID: 41892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A4")]
			[Address(RVA = "0x2350E38", Offset = "0x2350E38", VA = "0x7BBCB50E38")]
			public <>c__DisplayClass237_0()
			{
			}

			// Token: 0x0600A3A5 RID: 41893 RVA: 0x0002B3B0 File Offset: 0x000295B0
			[Token(Token = "0x600A3A5")]
			[Address(RVA = "0x2350E40", Offset = "0x2350E40", VA = "0x7BBCB50E40")]
			internal bool <GetBigEventActivityDescByTwoType>b__0(ClientActivityDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400A9D1 RID: 43473
			[Token(Token = "0x400A9D1")]
			[FieldOffset(Offset = "0x10")]
			public proto.EActivity.SubType subType;
		}

		// Token: 0x02001D54 RID: 7508
		[Token(Token = "0x2001D54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBCD4", Offset = "0x10FBCD4")]
		private sealed class <>c__DisplayClass238_0
		{
			// Token: 0x0600A3A6 RID: 41894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A6")]
			[Address(RVA = "0x2350E7C", Offset = "0x2350E7C", VA = "0x7BBCB50E7C")]
			public <>c__DisplayClass238_0()
			{
			}

			// Token: 0x0600A3A7 RID: 41895 RVA: 0x0002B3C8 File Offset: 0x000295C8
			[Token(Token = "0x600A3A7")]
			[Address(RVA = "0x2350E84", Offset = "0x2350E84", VA = "0x7BBCB50E84")]
			internal bool <GetBigEventSortedDescListByTwoType>b__0(ClientActivityDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400A9D2 RID: 43474
			[Token(Token = "0x400A9D2")]
			[FieldOffset(Offset = "0x10")]
			public proto.EActivity.SubType subType;
		}
	}
}
