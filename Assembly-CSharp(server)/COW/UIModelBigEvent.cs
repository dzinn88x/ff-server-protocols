using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D81 RID: 7553
	[Token(Token = "0x2001D81")]
	public class UIModelBigEvent : UIBaseModel
	{
		// Token: 0x0600A518 RID: 42264 RVA: 0x0002BF98 File Offset: 0x0002A198
		[Token(Token = "0x600A518")]
		[Address(RVA = "0x22CFD0C", Offset = "0x22CFD0C", VA = "0x7BBCACFD0C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A519")]
		[Address(RVA = "0x22CFD14", Offset = "0x22CFD14", VA = "0x7BBCACFD14")]
		public CSLimitedEventOpenEntriesRes GetEventAutoEntryDesc()
		{
			return null;
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A51A")]
		[Address(RVA = "0x22CFD1C", Offset = "0x22CFD1C", VA = "0x7BBCACFD1C", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A51B")]
		[Address(RVA = "0x22CFF40", Offset = "0x22CFF40", VA = "0x7BBCACFF40", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A51C")]
		[Address(RVA = "0x22CFFD0", Offset = "0x22CFFD0", VA = "0x7BBCACFFD0", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A51D")]
		[Address(RVA = "0x22D0130", Offset = "0x22D0130", VA = "0x7BBCAD0130")]
		public void RequestGetBigEventOpenInfo()
		{
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A51E")]
		[Address(RVA = "0x22D02D4", Offset = "0x22D02D4", VA = "0x7BBCAD02D4")]
		private void ProcessAllEventOpenInfo(CSGetLimitedEventOpenInfoRes eventOpenInfo)
		{
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A51F")]
		[Address(RVA = "0x22D0D58", Offset = "0x22D0D58", VA = "0x7BBCAD0D58")]
		private void PrecessAllEventCDNSetting(CSGetLimitedEventOpenInfoRes eventOpenInfo)
		{
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A520")]
		[Address(RVA = "0x22D0F98", Offset = "0x22D0F98", VA = "0x7BBCAD0F98")]
		public List<BigEventOpenInfoDesc> GetEventOpenInfoListById(ELimitedEvent.EventID eventID)
		{
			return null;
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A521")]
		[Address(RVA = "0x22D1018", Offset = "0x22D1018", VA = "0x7BBCAD1018")]
		public List<BigEventCDNDesc> GetCDNSettingListById(ELimitedEvent.EventID eventID)
		{
			return null;
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A522")]
		[Address(RVA = "0x22D1098", Offset = "0x22D1098", VA = "0x7BBCAD1098")]
		public string GetEventCDNUrlByEventIDAndType(ELimitedEvent.EventID id, int type)
		{
			return null;
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		[Token(Token = "0x600A523")]
		[Address(RVA = "0x22D11E4", Offset = "0x22D11E4", VA = "0x7BBCAD11E4")]
		public ELimitedEvent.EventState GetBigEventStateById(ELimitedEvent.EventID eventID)
		{
			return ELimitedEvent.EventState.EventState_NONE;
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A524")]
		[Address(RVA = "0x22D0A64", Offset = "0x22D0A64", VA = "0x7BBCAD0A64")]
		public BigEventOpenInfoDesc GetEventOpenInfoByIdAndState(ELimitedEvent.EventID eventID, ELimitedEvent.EventState state)
		{
			return null;
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A525")]
		[Address(RVA = "0x22D0B40", Offset = "0x22D0B40", VA = "0x7BBCAD0B40")]
		public HttpRequest RequestEventAutoEntryDescById(ELimitedEvent.EventID eventID)
		{
			return null;
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A526")]
		[Address(RVA = "0x22D1380", Offset = "0x22D1380", VA = "0x7BBCAD1380")]
		public string GetBigEventEntryDataTitle(BigEventEntryDesc DescData)
		{
			return null;
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A527")]
		[Address(RVA = "0x22D15F8", Offset = "0x22D15F8", VA = "0x7BBCAD15F8")]
		public BigEventOpenInfoDesc GetEventAutoEntryOpenInfo()
		{
			return null;
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A528")]
		[Address(RVA = "0x22D1604", Offset = "0x22D1604", VA = "0x7BBCAD1604")]
		public BigEventOpenInfoDesc GetEventProcessOpenInfo()
		{
			return null;
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A529")]
		[Address(RVA = "0x22D1610", Offset = "0x22D1610", VA = "0x7BBCAD1610")]
		public string GetBigEventOpenPeriod(ELimitedEvent.EventID eventID)
		{
			return null;
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A52A")]
		[Address(RVA = "0x22D1804", Offset = "0x22D1804", VA = "0x7BBCAD1804")]
		public string GetBigEventPeakDayPeriod(ELimitedEvent.EventID eventId)
		{
			return null;
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52B")]
		[Address(RVA = "0x22D1B44", Offset = "0x22D1B44", VA = "0x7BBCAD1B44")]
		public void ChangeNotify(BigEventEntryDesc entryDesc, bool state)
		{
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A52C")]
		[Address(RVA = "0x22D2168", Offset = "0x22D2168", VA = "0x7BBCAD2168")]
		private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, BigEventEntryDesc entryDesc)
		{
			return null;
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52D")]
		[Address(RVA = "0x22CFF58", Offset = "0x22CFF58", VA = "0x7BBCACFF58")]
		private void ResetScheduleNotifications()
		{
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		[Token(Token = "0x600A52E")]
		[Address(RVA = "0x22D24F8", Offset = "0x22D24F8", VA = "0x7BBCAD24F8")]
		public uint GetTokenCount(uint tokenId)
		{
			return 0U;
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
		[Token(Token = "0x600A52F")]
		[Address(RVA = "0x22D25AC", Offset = "0x22D25AC", VA = "0x7BBCAD25AC")]
		public ResourceID GetTokenIconRes(uint tokenId)
		{
			return default(ResourceID);
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A530")]
		[Address(RVA = "0x22D2670", Offset = "0x22D2670", VA = "0x7BBCAD2670")]
		public void RequestTokenTipsDesc(ELimitedEvent.EventID eventID)
		{
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A531")]
		[Address(RVA = "0x22D28A0", Offset = "0x22D28A0", VA = "0x7BBCAD28A0")]
		public List<BigEventTokenTipsDesc> GetTokenTipsDescs(uint tokenId)
		{
			return null;
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A532")]
		[Address(RVA = "0x22D2920", Offset = "0x22D2920", VA = "0x7BBCAD2920")]
		public void RequestBigEventExchangeStoreData(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType)
		{
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A533")]
		[Address(RVA = "0x22D2B34", Offset = "0x22D2B34", VA = "0x7BBCAD2B34")]
		public LimitedEventStore GetBigEventExchangeStoreById(ELimitedEvent.EventID eventID, uint condition = 0U)
		{
			return null;
		}

		// Token: 0x0600A534 RID: 42292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A534")]
		[Address(RVA = "0x22D2C50", Offset = "0x22D2C50", VA = "0x7BBCAD2C50")]
		public void RequestExchangeStorePurchase(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType, BigEventStoreCommodityDesc desc, uint cnt = 1U)
		{
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A535")]
		[Address(RVA = "0x22D3178", Offset = "0x22D3178", VA = "0x7BBCAD3178")]
		public void RequestAccountAFKGroupInfo(bool force = false)
		{
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A536")]
		[Address(RVA = "0x22D339C", Offset = "0x22D339C", VA = "0x7BBCAD339C")]
		public void RequestAFKGroupInfo(ulong groupID, bool filter = true)
		{
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A537")]
		[Address(RVA = "0x22D35A0", Offset = "0x22D35A0", VA = "0x7BBCAD35A0")]
		public void RequestCreateAFKGroup()
		{
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A538")]
		[Address(RVA = "0x22D3714", Offset = "0x22D3714", VA = "0x7BBCAD3714")]
		public void RequestJoinAFKGroup(ulong groupID, ELimitedEvent.GoliathGroupJoinSource source, bool isInvitedByShare = false)
		{
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A539")]
		[Address(RVA = "0x22D3934", Offset = "0x22D3934", VA = "0x7BBCAD3934")]
		public void RequestCaptainActivity()
		{
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53A")]
		[Address(RVA = "0x22D3B18", Offset = "0x22D3B18", VA = "0x7BBCAD3B18")]
		public void ClaimAFKGroupAwards(ulong groupID, ulong captainID)
		{
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A53B")]
		[Address(RVA = "0x22D3CFC", Offset = "0x22D3CFC", VA = "0x7BBCAD3CFC")]
		public Dictionary<ulong, GoliathAFKGroupInfo> GetAllAFKGroupInfo()
		{
			return null;
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
		[Token(Token = "0x600A53C")]
		[Address(RVA = "0x22D3D04", Offset = "0x22D3D04", VA = "0x7BBCAD3D04")]
		public ulong GetAFKGroupInAdvanceStartTime(ulong groupID)
		{
			return 0UL;
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53D")]
		[Address(RVA = "0x22D3DB4", Offset = "0x22D3DB4", VA = "0x7BBCAD3DB4")]
		public void NotifyAFKGroupInfoUpdate(ulong groupID)
		{
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x0002C010 File Offset: 0x0002A210
		[Token(Token = "0x600A53E")]
		[Address(RVA = "0x22D3FD8", Offset = "0x22D3FD8", VA = "0x7BBCAD3FD8")]
		public uint GetCaptainActivityID()
		{
			return 0U;
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x0002C028 File Offset: 0x0002A228
		[Token(Token = "0x600A53F")]
		[Address(RVA = "0x22D3FE0", Offset = "0x22D3FE0", VA = "0x7BBCAD3FE0")]
		public EActivity.State GetCaptainActivityState()
		{
			return EActivity.State.State_RECEIVED;
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x0002C040 File Offset: 0x0002A240
		[Token(Token = "0x600A540")]
		[Address(RVA = "0x22D40A0", Offset = "0x22D40A0", VA = "0x7BBCAD40A0")]
		public bool CheckAFKFriendInviteable(ulong friendId)
		{
			return default(bool);
		}

		// Token: 0x0600A541 RID: 42305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A541")]
		[Address(RVA = "0x22D418C", Offset = "0x22D418C", VA = "0x7BBCAD418C")]
		public void SetAFKFriendInviteCD(ulong friendId)
		{
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x0002C058 File Offset: 0x0002A258
		[Token(Token = "0x600A542")]
		[Address(RVA = "0x22D422C", Offset = "0x22D422C", VA = "0x7BBCAD422C")]
		public UIModelBigEvent.EPeakDayState GetBigEventPeakDayState(ClientActivityDesc desc)
		{
			return UIModelBigEvent.EPeakDayState.Invalid;
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A543")]
		[Address(RVA = "0x22D43C8", Offset = "0x22D43C8", VA = "0x7BBCAD43C8")]
		public UIModelBigEvent()
		{
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A544")]
		[Address(RVA = "0x22D45E0", Offset = "0x22D45E0", VA = "0x7BBCAD45E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B7C", Offset = "0x1145B7C")]
		private void <RequestGetBigEventOpenInfo>b__36_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A545")]
		[Address(RVA = "0x22D46D4", Offset = "0x22D46D4", VA = "0x7BBCAD46D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B8C", Offset = "0x1145B8C")]
		private void <RequestEventAutoEntryDescById>b__44_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A546")]
		[Address(RVA = "0x22D4868", Offset = "0x22D4868", VA = "0x7BBCAD4868")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B9C", Offset = "0x1145B9C")]
		private void <RequestAccountAFKGroupInfo>b__60_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A547")]
		[Address(RVA = "0x22D4BB4", Offset = "0x22D4BB4", VA = "0x7BBCAD4BB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145BAC", Offset = "0x1145BAC")]
		private void <RequestCreateAFKGroup>b__62_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A548")]
		[Address(RVA = "0x22D4F4C", Offset = "0x22D4F4C", VA = "0x7BBCAD4F4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145BBC", Offset = "0x1145BBC")]
		private void <RequestCaptainActivity>b__64_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AAD5 RID: 43733
		[Token(Token = "0x400AAD5")]
		public const string NOTIFY_ANNIVERSARY_ACTIVITY_START = "NOTIFY_ANNIVERSARY_ACTIVITY_START_";

		// Token: 0x0400AAD6 RID: 43734
		[Token(Token = "0x400AAD6")]
		public const string DEFAULT = "default";

		// Token: 0x0400AAD7 RID: 43735
		[Token(Token = "0x400AAD7")]
		[FieldOffset(Offset = "0x18")]
		private ELimitedEvent.EventID m_EventAutoEntryId;

		// Token: 0x0400AAD8 RID: 43736
		[Token(Token = "0x400AAD8")]
		[FieldOffset(Offset = "0x20")]
		private CSLimitedEventOpenEntriesRes m_EventAutoEntryDesc;

		// Token: 0x0400AAD9 RID: 43737
		[Token(Token = "0x400AAD9")]
		[FieldOffset(Offset = "0x28")]
		private List<IBigEventModel> m_EventModelList;

		// Token: 0x0400AADA RID: 43738
		[Token(Token = "0x400AADA")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<int, List<BigEventOpenInfoDesc>> m_BigEventOpenInfoDict;

		// Token: 0x0400AADB RID: 43739
		[Token(Token = "0x400AADB")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<int, List<BigEventCDNDesc>> m_BigEventCDNSettingDict;

		// Token: 0x0400AADC RID: 43740
		[Token(Token = "0x400AADC")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<int, List<LimitedEventStore>> m_BigEventExchangeStoreDict;

		// Token: 0x0400AADD RID: 43741
		[Token(Token = "0x400AADD")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<uint, List<BigEventTokenTipsDesc>> m_BigEventTokenTipsDescDict;

		// Token: 0x0400AADE RID: 43742
		[Token(Token = "0x400AADE")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<uint> m_BigEventTokenTipsRequestedEventId;

		// Token: 0x0400AADF RID: 43743
		[Token(Token = "0x400AADF")]
		[FieldOffset(Offset = "0x58")]
		public Queue<LocalNotificationManager.NotifyType> m_CanUseNotifyTypes;

		// Token: 0x0400AAE0 RID: 43744
		[Token(Token = "0x400AAE0")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<uint, LocalNotificationManager.NotifyType> m_UsingNotifyTypes;

		// Token: 0x0400AAE1 RID: 43745
		[Token(Token = "0x400AAE1")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<ulong, GoliathAFKGroupInfo> m_AFKGroupInfoDict;

		// Token: 0x0400AAE2 RID: 43746
		[Token(Token = "0x400AAE2")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<ulong, uint> m_GroupMemberCnt;

		// Token: 0x0400AAE3 RID: 43747
		[Token(Token = "0x400AAE3")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<ulong, ulong> m_FuzzyStartTimeInAdvance;

		// Token: 0x0400AAE4 RID: 43748
		[Token(Token = "0x400AAE4")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<ulong, ulong> m_AFKFriendNextInviteableTimestamp;

		// Token: 0x0400AAE5 RID: 43749
		[Token(Token = "0x400AAE5")]
		private const ulong AFK_INVITE_FRIEND_CD = 4UL;

		// Token: 0x0400AAE6 RID: 43750
		[Token(Token = "0x400AAE6")]
		public const int AFK_MAX_GROUP_NUM = 3;

		// Token: 0x0400AAE7 RID: 43751
		[Token(Token = "0x400AAE7")]
		public const uint AFK_GROUP_MAX_MEMBER_NUM = 4U;

		// Token: 0x0400AAE8 RID: 43752
		[Token(Token = "0x400AAE8")]
		[FieldOffset(Offset = "0x88")]
		public bool IsAFKGroupInfoChanged;

		// Token: 0x0400AAE9 RID: 43753
		[Token(Token = "0x400AAE9")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_CaptaionActivityID;

		// Token: 0x0400AAEA RID: 43754
		[Token(Token = "0x400AAEA")]
		public const int PropID_RefreshAllBigEventEntrance = 2;

		// Token: 0x0400AAEB RID: 43755
		[Token(Token = "0x400AAEB")]
		public const int PropID_ExchangeStoreDataUpdate = 4;

		// Token: 0x0400AAEC RID: 43756
		[Token(Token = "0x400AAEC")]
		public const int PropID_AFKGroupInfoUpdate = 16;

		// Token: 0x0400AAED RID: 43757
		[Token(Token = "0x400AAED")]
		public const int PropID_AFKGroupActivityUpdate = 32;

		// Token: 0x0400AAEE RID: 43758
		[Token(Token = "0x400AAEE")]
		public const int PropID_SearchAFKGroupInfoReceived = 64;

		// Token: 0x0400AAEF RID: 43759
		[Token(Token = "0x400AAEF")]
		public const int PropID_AFKGroupStateChanged = 128;

		// Token: 0x0400AAF0 RID: 43760
		[Token(Token = "0x400AAF0")]
		public const int PropID_AFKJoinGroupSucceed = 256;

		// Token: 0x0400AAF1 RID: 43761
		[Token(Token = "0x400AAF1")]
		public const int PropID_AFKJoinGroupFailed = 512;

		// Token: 0x0400AAF2 RID: 43762
		[Token(Token = "0x400AAF2")]
		public const int PropID_AFKCreateGroupSucceed = 1024;

		// Token: 0x02001D82 RID: 7554
		[Token(Token = "0x2001D82")]
		public enum EPeakDayState
		{
			// Token: 0x0400AAF4 RID: 43764
			[Token(Token = "0x400AAF4")]
			Invalid,
			// Token: 0x0400AAF5 RID: 43765
			[Token(Token = "0x400AAF5")]
			UnClaimable,
			// Token: 0x0400AAF6 RID: 43766
			[Token(Token = "0x400AAF6")]
			Claimable,
			// Token: 0x0400AAF7 RID: 43767
			[Token(Token = "0x400AAF7")]
			Claimed,
			// Token: 0x0400AAF8 RID: 43768
			[Token(Token = "0x400AAF8")]
			Expired
		}

		// Token: 0x02001D83 RID: 7555
		[Token(Token = "0x2001D83")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE54", Offset = "0x10FBE54")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x0600A549 RID: 42313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A549")]
			[Address(RVA = "0x22D11DC", Offset = "0x22D11DC", VA = "0x7BBCAD11DC")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x0600A54A RID: 42314 RVA: 0x0002C070 File Offset: 0x0002A270
			[Token(Token = "0x600A54A")]
			[Address(RVA = "0x22D5300", Offset = "0x22D5300", VA = "0x7BBCAD5300")]
			internal bool <GetEventCDNUrlByEventIDAndType>b__0(BigEventCDNDesc info)
			{
				return default(bool);
			}

			// Token: 0x0600A54B RID: 42315 RVA: 0x0002C088 File Offset: 0x0002A288
			[Token(Token = "0x600A54B")]
			[Address(RVA = "0x22D53E8", Offset = "0x22D53E8", VA = "0x7BBCAD53E8")]
			internal bool <GetEventCDNUrlByEventIDAndType>b__1(BigEventCDNDesc info)
			{
				return default(bool);
			}

			// Token: 0x0400AAF9 RID: 43769
			[Token(Token = "0x400AAF9")]
			[FieldOffset(Offset = "0x10")]
			public int type;
		}

		// Token: 0x02001D84 RID: 7556
		[Token(Token = "0x2001D84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE64", Offset = "0x10FBE64")]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x0600A54C RID: 42316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A54C")]
			[Address(RVA = "0x22D1378", Offset = "0x22D1378", VA = "0x7BBCAD1378")]
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x0600A54D RID: 42317 RVA: 0x0002C0A0 File Offset: 0x0002A2A0
			[Token(Token = "0x600A54D")]
			[Address(RVA = "0x22D5478", Offset = "0x22D5478", VA = "0x7BBCAD5478")]
			internal bool <GetEventOpenInfoByIdAndState>b__0(BigEventOpenInfoDesc info)
			{
				return default(bool);
			}

			// Token: 0x0400AAFA RID: 43770
			[Token(Token = "0x400AAFA")]
			[FieldOffset(Offset = "0x10")]
			public ELimitedEvent.EventState state;
		}

		// Token: 0x02001D85 RID: 7557
		[Token(Token = "0x2001D85")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE74", Offset = "0x10FBE74")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A54F RID: 42319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A54F")]
			[Address(RVA = "0x22D50BC", Offset = "0x22D50BC", VA = "0x7BBCAD50BC")]
			public <>c()
			{
			}

			// Token: 0x0600A550 RID: 42320 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
			[Token(Token = "0x600A550")]
			[Address(RVA = "0x22D50C4", Offset = "0x22D50C4", VA = "0x7BBCAD50C4")]
			internal int <RequestEventAutoEntryDescById>b__44_1(BigEventEntryDesc a, BigEventEntryDesc b)
			{
				return 0;
			}

			// Token: 0x0600A551 RID: 42321 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
			[Token(Token = "0x600A551")]
			[Address(RVA = "0x22D513C", Offset = "0x22D513C", VA = "0x7BBCAD513C")]
			internal bool <GetBigEventOpenPeriod>b__48_0(BigEventOpenInfoDesc item)
			{
				return default(bool);
			}

			// Token: 0x0600A552 RID: 42322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A552")]
			[Address(RVA = "0x22D5170", Offset = "0x22D5170", VA = "0x7BBCAD5170")]
			internal string <GetNotifyInfo>b__51_1()
			{
				return null;
			}

			// Token: 0x0600A553 RID: 42323 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
			[Token(Token = "0x600A553")]
			[Address(RVA = "0x22D521C", Offset = "0x22D521C", VA = "0x7BBCAD521C")]
			internal int <GetNotifyInfo>b__51_3()
			{
				return 0;
			}

			// Token: 0x0600A554 RID: 42324 RVA: 0x0002C100 File Offset: 0x0002A300
			[Token(Token = "0x600A554")]
			[Address(RVA = "0x22D528C", Offset = "0x22D528C", VA = "0x7BBCAD528C")]
			internal int <RequestBigEventExchangeStoreData>b__57_1(LimitedEventStore a, LimitedEventStore b)
			{
				return 0;
			}

			// Token: 0x0600A555 RID: 42325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A555")]
			[Address(RVA = "0x22D52F4", Offset = "0x22D52F4", VA = "0x7BBCAD52F4")]
			internal CommonRewardItemInfo <ClaimAFKGroupAwards>b__65_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400AAFB RID: 43771
			[Token(Token = "0x400AAFB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelBigEvent.<>c <>9;

			// Token: 0x0400AAFC RID: 43772
			[Token(Token = "0x400AAFC")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<BigEventEntryDesc> <>9__44_1;

			// Token: 0x0400AAFD RID: 43773
			[Token(Token = "0x400AAFD")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<BigEventOpenInfoDesc> <>9__48_0;

			// Token: 0x0400AAFE RID: 43774
			[Token(Token = "0x400AAFE")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string> <>9__51_1;

			// Token: 0x0400AAFF RID: 43775
			[Token(Token = "0x400AAFF")]
			[FieldOffset(Offset = "0x20")]
			public static Func<int> <>9__51_3;

			// Token: 0x0400AB00 RID: 43776
			[Token(Token = "0x400AB00")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<LimitedEventStore> <>9__57_1;

			// Token: 0x0400AB01 RID: 43777
			[Token(Token = "0x400AB01")]
			[FieldOffset(Offset = "0x30")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__65_1;
		}

		// Token: 0x02001D86 RID: 7558
		[Token(Token = "0x2001D86")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE84", Offset = "0x10FBE84")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x0600A556 RID: 42326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A556")]
			[Address(RVA = "0x22D24F0", Offset = "0x22D24F0", VA = "0x7BBCAD24F0")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x0600A557 RID: 42327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A557")]
			[Address(RVA = "0x22D54B4", Offset = "0x22D54B4", VA = "0x7BBCAD54B4")]
			internal string <GetNotifyInfo>b__0(object[] parameters)
			{
				return null;
			}

			// Token: 0x0600A558 RID: 42328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A558")]
			[Address(RVA = "0x22D5538", Offset = "0x22D5538", VA = "0x7BBCAD5538")]
			internal string <GetNotifyInfo>b__2()
			{
				return null;
			}

			// Token: 0x0400AB02 RID: 43778
			[Token(Token = "0x400AB02")]
			[FieldOffset(Offset = "0x10")]
			public uint GoPos;

			// Token: 0x0400AB03 RID: 43779
			[Token(Token = "0x400AB03")]
			[FieldOffset(Offset = "0x18")]
			public string content;
		}

		// Token: 0x02001D87 RID: 7559
		[Token(Token = "0x2001D87")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE94", Offset = "0x10FBE94")]
		private sealed class <>c__DisplayClass55_0
		{
			// Token: 0x0600A559 RID: 42329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A559")]
			[Address(RVA = "0x22D2898", Offset = "0x22D2898", VA = "0x7BBCAD2898")]
			public <>c__DisplayClass55_0()
			{
			}

			// Token: 0x0600A55A RID: 42330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A55A")]
			[Address(RVA = "0x22D55EC", Offset = "0x22D55EC", VA = "0x7BBCAD55EC")]
			internal void <RequestTokenTipsDesc>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB04 RID: 43780
			[Token(Token = "0x400AB04")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBigEvent <>4__this;

			// Token: 0x0400AB05 RID: 43781
			[Token(Token = "0x400AB05")]
			[FieldOffset(Offset = "0x18")]
			public ELimitedEvent.EventID eventID;
		}

		// Token: 0x02001D88 RID: 7560
		[Token(Token = "0x2001D88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBEA4", Offset = "0x10FBEA4")]
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x0600A55B RID: 42331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A55B")]
			[Address(RVA = "0x22D2B2C", Offset = "0x22D2B2C", VA = "0x7BBCAD2B2C")]
			public <>c__DisplayClass57_0()
			{
			}

			// Token: 0x0600A55C RID: 42332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A55C")]
			[Address(RVA = "0x22D591C", Offset = "0x22D591C", VA = "0x7BBCAD591C")]
			internal void <RequestBigEventExchangeStoreData>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB06 RID: 43782
			[Token(Token = "0x400AB06")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBigEvent <>4__this;

			// Token: 0x0400AB07 RID: 43783
			[Token(Token = "0x400AB07")]
			[FieldOffset(Offset = "0x18")]
			public ELimitedEvent.EventID eventID;

			// Token: 0x0400AB08 RID: 43784
			[Token(Token = "0x400AB08")]
			[FieldOffset(Offset = "0x1C")]
			public ELimitedEvent.StoreType storeType;
		}

		// Token: 0x02001D89 RID: 7561
		[Token(Token = "0x2001D89")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBEB4", Offset = "0x10FBEB4")]
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x0600A55D RID: 42333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A55D")]
			[Address(RVA = "0x22D2C48", Offset = "0x22D2C48", VA = "0x7BBCAD2C48")]
			public <>c__DisplayClass58_0()
			{
			}

			// Token: 0x0600A55E RID: 42334 RVA: 0x0002C118 File Offset: 0x0002A318
			[Token(Token = "0x600A55E")]
			[Address(RVA = "0x22D5CC8", Offset = "0x22D5CC8", VA = "0x7BBCAD5CC8")]
			internal bool <GetBigEventExchangeStoreById>b__0(LimitedEventStore item)
			{
				return default(bool);
			}

			// Token: 0x0400AB09 RID: 43785
			[Token(Token = "0x400AB09")]
			[FieldOffset(Offset = "0x10")]
			public uint condition;
		}

		// Token: 0x02001D8A RID: 7562
		[Token(Token = "0x2001D8A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBEC4", Offset = "0x10FBEC4")]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x0600A55F RID: 42335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A55F")]
			[Address(RVA = "0x22D3170", Offset = "0x22D3170", VA = "0x7BBCAD3170")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x0600A560 RID: 42336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A560")]
			[Address(RVA = "0x22D5D14", Offset = "0x22D5D14", VA = "0x7BBCAD5D14")]
			internal void <RequestExchangeStorePurchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A561 RID: 42337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A561")]
			[Address(RVA = "0x22D63F4", Offset = "0x22D63F4", VA = "0x7BBCAD63F4")]
			internal void <RequestExchangeStorePurchase>b__1()
			{
			}

			// Token: 0x0400AB0A RID: 43786
			[Token(Token = "0x400AB0A")]
			[FieldOffset(Offset = "0x10")]
			public BigEventStoreCommodityDesc desc;

			// Token: 0x0400AB0B RID: 43787
			[Token(Token = "0x400AB0B")]
			[FieldOffset(Offset = "0x18")]
			public uint cnt;

			// Token: 0x0400AB0C RID: 43788
			[Token(Token = "0x400AB0C")]
			[FieldOffset(Offset = "0x20")]
			public UIModelBigEvent <>4__this;

			// Token: 0x0400AB0D RID: 43789
			[Token(Token = "0x400AB0D")]
			[FieldOffset(Offset = "0x28")]
			public ELimitedEvent.EventID eventID;

			// Token: 0x0400AB0E RID: 43790
			[Token(Token = "0x400AB0E")]
			[FieldOffset(Offset = "0x2C")]
			public ELimitedEvent.StoreType storeType;

			// Token: 0x0400AB0F RID: 43791
			[Token(Token = "0x400AB0F")]
			[FieldOffset(Offset = "0x30")]
			public Action <>9__1;
		}

		// Token: 0x02001D8B RID: 7563
		[Token(Token = "0x2001D8B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBED4", Offset = "0x10FBED4")]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x0600A562 RID: 42338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A562")]
			[Address(RVA = "0x22D3598", Offset = "0x22D3598", VA = "0x7BBCAD3598")]
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x0600A563 RID: 42339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A563")]
			[Address(RVA = "0x22D6434", Offset = "0x22D6434", VA = "0x7BBCAD6434")]
			internal void <RequestAFKGroupInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB10 RID: 43792
			[Token(Token = "0x400AB10")]
			[FieldOffset(Offset = "0x10")]
			public bool filter;

			// Token: 0x0400AB11 RID: 43793
			[Token(Token = "0x400AB11")]
			[FieldOffset(Offset = "0x18")]
			public UIModelBigEvent <>4__this;
		}

		// Token: 0x02001D8C RID: 7564
		[Token(Token = "0x2001D8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBEE4", Offset = "0x10FBEE4")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x0600A564 RID: 42340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A564")]
			[Address(RVA = "0x22D392C", Offset = "0x22D392C", VA = "0x7BBCAD392C")]
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x0600A565 RID: 42341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A565")]
			[Address(RVA = "0x22D663C", Offset = "0x22D663C", VA = "0x7BBCAD663C")]
			internal void <RequestJoinAFKGroup>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB12 RID: 43794
			[Token(Token = "0x400AB12")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBigEvent <>4__this;

			// Token: 0x0400AB13 RID: 43795
			[Token(Token = "0x400AB13")]
			[FieldOffset(Offset = "0x18")]
			public bool isInvitedByShare;

			// Token: 0x0400AB14 RID: 43796
			[Token(Token = "0x400AB14")]
			[FieldOffset(Offset = "0x20")]
			public ulong groupID;
		}

		// Token: 0x02001D8D RID: 7565
		[Token(Token = "0x2001D8D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBEF4", Offset = "0x10FBEF4")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600A566 RID: 42342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A566")]
			[Address(RVA = "0x22D3CF4", Offset = "0x22D3CF4", VA = "0x7BBCAD3CF4")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600A567 RID: 42343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A567")]
			[Address(RVA = "0x22D6CB0", Offset = "0x22D6CB0", VA = "0x7BBCAD6CB0")]
			internal void <ClaimAFKGroupAwards>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB15 RID: 43797
			[Token(Token = "0x400AB15")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBigEvent <>4__this;

			// Token: 0x0400AB16 RID: 43798
			[Token(Token = "0x400AB16")]
			[FieldOffset(Offset = "0x18")]
			public ulong groupID;
		}
	}
}
