using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F47 RID: 8007
	[Token(Token = "0x2001F47")]
	internal class UIModelManual : UIBaseModel
	{
		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x000311B8 File Offset: 0x0002F3B8
		// (set) Token: 0x0600B034 RID: 45108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BB4")]
		public bool HasGetCollectInfo
		{
			[Token(Token = "0x600B035")]
			[Address(RVA = "0x150418C", Offset = "0x150418C", VA = "0x7BBBD0418C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114673C", Offset = "0x114673C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B034")]
			[Address(RVA = "0x1504180", Offset = "0x1504180", VA = "0x7BBBD04180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114672C", Offset = "0x114672C")]
			private set
			{
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600B037 RID: 45111 RVA: 0x000311D0 File Offset: 0x0002F3D0
		// (set) Token: 0x0600B036 RID: 45110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BB5")]
		public bool HasGetWeaponStatus
		{
			[Token(Token = "0x600B037")]
			[Address(RVA = "0x15041A0", Offset = "0x15041A0", VA = "0x7BBBD041A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114675C", Offset = "0x114675C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B036")]
			[Address(RVA = "0x1504194", Offset = "0x1504194", VA = "0x7BBBD04194")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114674C", Offset = "0x114674C")]
			private set
			{
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x000311E8 File Offset: 0x0002F3E8
		// (set) Token: 0x0600B038 RID: 45112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BB6")]
		public bool HasGetMapRewardStatus
		{
			[Token(Token = "0x600B039")]
			[Address(RVA = "0x15041B4", Offset = "0x15041B4", VA = "0x7BBBD041B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114677C", Offset = "0x114677C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B038")]
			[Address(RVA = "0x15041A8", Offset = "0x15041A8", VA = "0x7BBBD041A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114676C", Offset = "0x114676C")]
			private set
			{
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600B03A RID: 45114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB7")]
		public List<ManualWeaponReward> ManualWeaponRewardStatuses
		{
			[Token(Token = "0x600B03A")]
			[Address(RVA = "0x15041BC", Offset = "0x15041BC", VA = "0x7BBBD041BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600B03B RID: 45115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB8")]
		public CSGetManualAllMapRewardStatesRes MapRewardStates
		{
			[Token(Token = "0x600B03B")]
			[Address(RVA = "0x15041C4", Offset = "0x15041C4", VA = "0x7BBBD041C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x0600B03C RID: 45116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB9")]
		public List<uint> NewUnlockEvenIdsAfterMatch
		{
			[Token(Token = "0x600B03C")]
			[Address(RVA = "0x15041CC", Offset = "0x15041CC", VA = "0x7BBBD041CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x00031200 File Offset: 0x0002F400
		[Token(Token = "0x600B03D")]
		[Address(RVA = "0x15041D4", Offset = "0x15041D4", VA = "0x7BBBD041D4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B03E")]
		[Address(RVA = "0x15041DC", Offset = "0x15041DC", VA = "0x7BBBD041DC", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B03F")]
		[Address(RVA = "0x15043B4", Offset = "0x15043B4", VA = "0x7BBBD043B4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B040")]
		[Address(RVA = "0x1504458", Offset = "0x1504458", VA = "0x7BBBD04458")]
		public void ClearOldData()
		{
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B041")]
		[Address(RVA = "0x1504548", Offset = "0x1504548", VA = "0x7BBBD04548")]
		private void OnCollectInfo()
		{
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B042")]
		[Address(RVA = "0x15046E4", Offset = "0x15046E4", VA = "0x7BBBD046E4")]
		public void RequestCollectInfo(bool callFromMatchAfter = false, bool preload = false, bool silence = false)
		{
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B043")]
		[Address(RVA = "0x1504970", Offset = "0x1504970", VA = "0x7BBBD04970")]
		private void OnGetAllWeaponRewardStates()
		{
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B044")]
		[Address(RVA = "0x1504AB0", Offset = "0x1504AB0", VA = "0x7BBBD04AB0")]
		public void RequestAllWeaponRewardStates(bool preload = false, bool silence = false)
		{
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B045")]
		[Address(RVA = "0x1504D1C", Offset = "0x1504D1C", VA = "0x7BBBD04D1C")]
		private void OnGetAllMapRewardStates()
		{
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B046")]
		[Address(RVA = "0x1504E04", Offset = "0x1504E04", VA = "0x7BBBD04E04")]
		public void RequestAllMapRewardStates(bool preload = false, bool silence = false)
		{
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B047")]
		[Address(RVA = "0x1505070", Offset = "0x1505070", VA = "0x7BBBD05070")]
		public void RequestWeaponReward(uint quantity)
		{
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B048")]
		[Address(RVA = "0x1505360", Offset = "0x1505360", VA = "0x7BBBD05360")]
		public void RequestMapReward(uint mapId)
		{
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B049")]
		[Address(RVA = "0x1505650", Offset = "0x1505650", VA = "0x7BBBD05650")]
		public List<uint> GetUnlockIds(EManual.EventType type)
		{
			return null;
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x00031218 File Offset: 0x0002F418
		[Token(Token = "0x600B04A")]
		[Address(RVA = "0x15058B4", Offset = "0x15058B4", VA = "0x7BBBD058B4")]
		public bool AddUnlockIdLocal(uint evtID)
		{
			return default(bool);
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B04B")]
		[Address(RVA = "0x15059C4", Offset = "0x15059C4", VA = "0x7BBBD059C4")]
		public ManualChallenge GetLockedChallengeByParam1(uint par1, EManual.EventType type = EManual.EventType.EventType_NONE)
		{
			return null;
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B04C")]
		[Address(RVA = "0x1505B34", Offset = "0x1505B34", VA = "0x7BBBD05B34")]
		public ManualChallenge GetLockedChallengeByParam2(uint par2, EManual.EventType type = EManual.EventType.EventType_NONE)
		{
			return null;
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B04D")]
		[Address(RVA = "0x1505810", Offset = "0x1505810", VA = "0x7BBBD05810")]
		public ManualChallenge GetManualDescById(uint evtId)
		{
			return null;
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B04E")]
		[Address(RVA = "0x1505CA4", Offset = "0x1505CA4", VA = "0x7BBBD05CA4")]
		public List<ManualChallenge> GetManualDescList(EManual.EventType evtType)
		{
			return null;
		}

		// Token: 0x0600B04F RID: 45135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B04F")]
		[Address(RVA = "0x1504220", Offset = "0x1504220", VA = "0x7BBBD04220")]
		private void InitManualDesc()
		{
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x00031230 File Offset: 0x0002F430
		[Token(Token = "0x600B050")]
		[Address(RVA = "0x1504A48", Offset = "0x1504A48", VA = "0x7BBBD04A48")]
		public int CalcRedDotNumber(UIManualDataBase.Type category)
		{
			return 0;
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x00031248 File Offset: 0x0002F448
		[Token(Token = "0x600B051")]
		[Address(RVA = "0x1506194", Offset = "0x1506194", VA = "0x7BBBD06194")]
		private EManual.EventType CovertToEventType(UIManualDataBase.Type subTabType)
		{
			return EManual.EventType.EventType_NONE;
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B052")]
		[Address(RVA = "0x1505DA4", Offset = "0x1505DA4", VA = "0x7BBBD05DA4")]
		public ManualWeaponReward GetWeaponRewardFinishStatus()
		{
			return null;
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x00031260 File Offset: 0x0002F460
		[Token(Token = "0x600B053")]
		[Address(RVA = "0x15061B8", Offset = "0x15061B8", VA = "0x7BBBD061B8")]
		public int GetUnlockWeaponsCount()
		{
			return 0;
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B054")]
		[Address(RVA = "0x1506220", Offset = "0x1506220", VA = "0x7BBBD06220")]
		public List<ManualMapData> GetUnlockMapDatas()
		{
			return null;
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x00031278 File Offset: 0x0002F478
		[Token(Token = "0x600B055")]
		[Address(RVA = "0x1505E44", Offset = "0x1505E44", VA = "0x7BBBD05E44")]
		public int GetMapDebrisRewardNumber(uint mapId)
		{
			return 0;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B056")]
		[Address(RVA = "0x1506628", Offset = "0x1506628", VA = "0x7BBBD06628")]
		public void ReadNewUnlockEvent(uint evtId)
		{
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x00031290 File Offset: 0x0002F490
		[Token(Token = "0x600B057")]
		[Address(RVA = "0x1506848", Offset = "0x1506848", VA = "0x7BBBD06848")]
		public bool IsNewUnlockEvent(uint evtId)
		{
			return default(bool);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x000312A8 File Offset: 0x0002F4A8
		[Token(Token = "0x600B058")]
		[Address(RVA = "0x1504658", Offset = "0x1504658", VA = "0x7BBBD04658")]
		public int CalcMainTabNewIconNumberMap()
		{
			return 0;
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x000312C0 File Offset: 0x0002F4C0
		[Token(Token = "0x600B059")]
		[Address(RVA = "0x15046C0", Offset = "0x15046C0", VA = "0x7BBBD046C0")]
		public int CalcNewIconNumber(UIManualDataBase.Type category)
		{
			return 0;
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x000312D8 File Offset: 0x0002F4D8
		[Token(Token = "0x600B05A")]
		[Address(RVA = "0x150698C", Offset = "0x150698C", VA = "0x7BBBD0698C")]
		public int CalcNewIconNumber(EManual.EventType evtType)
		{
			return 0;
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x000312F0 File Offset: 0x0002F4F0
		[Token(Token = "0x600B05B")]
		[Address(RVA = "0x1506AA0", Offset = "0x1506AA0", VA = "0x7BBBD06AA0")]
		public int CalcWeaponSubTabNewIconNumber(uint subTitleId)
		{
			return 0;
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x00031308 File Offset: 0x0002F508
		[Token(Token = "0x600B05C")]
		[Address(RVA = "0x1506CDC", Offset = "0x1506CDC", VA = "0x7BBBD06CDC")]
		public int GetMapSubTabIndex(UIManualDataBase.Type dataType)
		{
			return 0;
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x00031320 File Offset: 0x0002F520
		[Token(Token = "0x600B05D")]
		[Address(RVA = "0x1506DD8", Offset = "0x1506DD8", VA = "0x7BBBD06DD8")]
		public int GetMapSubTabIndex(EManual.EventType type)
		{
			return 0;
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x00031338 File Offset: 0x0002F538
		[Token(Token = "0x600B05E")]
		[Address(RVA = "0x1506EB0", Offset = "0x1506EB0", VA = "0x7BBBD06EB0")]
		private int GetSubTab(EManual.EventType type, int subTab)
		{
			return 0;
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x00031350 File Offset: 0x0002F550
		[Token(Token = "0x600B05F")]
		[Address(RVA = "0x1506EC8", Offset = "0x1506EC8", VA = "0x7BBBD06EC8")]
		private UIModelManual.CheckManualRedDot GetItemPosInPage(uint eventId)
		{
			return default(UIModelManual.CheckManualRedDot);
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x00031368 File Offset: 0x0002F568
		[Token(Token = "0x600B060")]
		[Address(RVA = "0x1506F28", Offset = "0x1506F28", VA = "0x7BBBD06F28")]
		private UIManualMainTabController.EMainTab GetItemPosInPage(uint eventId, out int subTab, out int page)
		{
			return UIManualMainTabController.EMainTab.Map;
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x00031380 File Offset: 0x0002F580
		[Token(Token = "0x600B061")]
		[Address(RVA = "0x15070E8", Offset = "0x15070E8", VA = "0x7BBBD070E8")]
		private UIManualMainTabController.EMainTab GetMainTab(EManual.EventType type)
		{
			return UIManualMainTabController.EMainTab.Map;
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x00031398 File Offset: 0x0002F598
		[Token(Token = "0x600B062")]
		[Address(RVA = "0x15070F4", Offset = "0x15070F4", VA = "0x7BBBD070F4")]
		public bool ExistRedDotInPreviousContext(UIManualDataBase.Type dataType, int subTab, int page)
		{
			return default(bool);
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x000313B0 File Offset: 0x0002F5B0
		[Token(Token = "0x600B063")]
		[Address(RVA = "0x1507388", Offset = "0x1507388", VA = "0x7BBBD07388")]
		public bool ExistRedDotInNextContext(UIManualDataBase.Type dataType, int subTab, int page)
		{
			return default(bool);
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B064")]
		[Address(RVA = "0x1507630", Offset = "0x1507630", VA = "0x7BBBD07630")]
		public UIModelManual()
		{
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x000313C8 File Offset: 0x0002F5C8
		[Token(Token = "0x600B065")]
		[Address(RVA = "0x15078A8", Offset = "0x15078A8", VA = "0x7BBBD078A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114678C", Offset = "0x114678C")]
		private bool <GetWeaponRewardFinishStatus>b__57_0(ManualWeaponReward temp)
		{
			return default(bool);
		}

		// Token: 0x0400B3D4 RID: 46036
		[Token(Token = "0x400B3D4")]
		public const uint PropID_CollectInfo_Update = 2U;

		// Token: 0x0400B3D5 RID: 46037
		[Token(Token = "0x400B3D5")]
		public const uint PropID_WeaponRewardInfo_Update = 4U;

		// Token: 0x0400B3D6 RID: 46038
		[Token(Token = "0x400B3D6")]
		public const uint PropID_MapRewardInfo_Update = 8U;

		// Token: 0x0400B3D7 RID: 46039
		[Token(Token = "0x400B3D7")]
		public const uint PropID_GetWeaponReward_Success = 16U;

		// Token: 0x0400B3D8 RID: 46040
		[Token(Token = "0x400B3D8")]
		public const uint PropID_GetMapReward_Success = 32U;

		// Token: 0x0400B3D9 RID: 46041
		[Token(Token = "0x400B3D9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113013C", Offset = "0x113013C")]
		private bool <HasGetCollectInfo>k__BackingField;

		// Token: 0x0400B3DA RID: 46042
		[Token(Token = "0x400B3DA")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113014C", Offset = "0x113014C")]
		private bool <HasGetWeaponStatus>k__BackingField;

		// Token: 0x0400B3DB RID: 46043
		[Token(Token = "0x400B3DB")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113015C", Offset = "0x113015C")]
		private bool <HasGetMapRewardStatus>k__BackingField;

		// Token: 0x0400B3DC RID: 46044
		[Token(Token = "0x400B3DC")]
		[FieldOffset(Offset = "0x1B")]
		public bool HasReadNewDot;

		// Token: 0x0400B3DD RID: 46045
		[Token(Token = "0x400B3DD")]
		[FieldOffset(Offset = "0x20")]
		private List<ManualWeaponReward> m_ManualWeaponRewardStatuses;

		// Token: 0x0400B3DE RID: 46046
		[Token(Token = "0x400B3DE")]
		[FieldOffset(Offset = "0x28")]
		private CSGetManualAllMapRewardStatesRes m_MapRewardStates;

		// Token: 0x0400B3DF RID: 46047
		[Token(Token = "0x400B3DF")]
		[FieldOffset(Offset = "0x30")]
		private List<uint> m_UnlockEvtIds;

		// Token: 0x0400B3E0 RID: 46048
		[Token(Token = "0x400B3E0")]
		[FieldOffset(Offset = "0x38")]
		private List<uint> m_UnReadUnlockEvtIds;

		// Token: 0x0400B3E1 RID: 46049
		[Token(Token = "0x400B3E1")]
		[FieldOffset(Offset = "0x40")]
		private List<uint> m_NewUnlockEventIdsAfterMatch;

		// Token: 0x0400B3E2 RID: 46050
		[Token(Token = "0x400B3E2")]
		[FieldOffset(Offset = "0x48")]
		private List<ManualChallenge> m_CfgList;

		// Token: 0x0400B3E3 RID: 46051
		[Token(Token = "0x400B3E3")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, ManualChallenge> m_ManulDescDict;

		// Token: 0x0400B3E4 RID: 46052
		[Token(Token = "0x400B3E4")]
		[FieldOffset(Offset = "0x58")]
		private List<uint> m_LastUnlockEventList;

		// Token: 0x0400B3E5 RID: 46053
		[Token(Token = "0x400B3E5")]
		[FieldOffset(Offset = "0x60")]
		private WaitingResponseHandler m_WaitingHandler;

		// Token: 0x0400B3E6 RID: 46054
		[Token(Token = "0x400B3E6")]
		[FieldOffset(Offset = "0x68")]
		private bool m_PreloadedCollectInfo;

		// Token: 0x0400B3E7 RID: 46055
		[Token(Token = "0x400B3E7")]
		[FieldOffset(Offset = "0x69")]
		private bool m_PreloadWeaponReward;

		// Token: 0x0400B3E8 RID: 46056
		[Token(Token = "0x400B3E8")]
		[FieldOffset(Offset = "0x6A")]
		private bool m_PreloadMapRewards;

		// Token: 0x0400B3E9 RID: 46057
		[Token(Token = "0x400B3E9")]
		[FieldOffset(Offset = "0x70")]
		private List<UIModelManual.CheckManualRedDot> m_CheckList;

		// Token: 0x0400B3EA RID: 46058
		[Token(Token = "0x400B3EA")]
		[FieldOffset(Offset = "0x78")]
		private List<EManual.EventType> m_MapSubTabs;

		// Token: 0x02001F48 RID: 8008
		[Token(Token = "0x2001F48")]
		public struct CheckManualRedDot
		{
			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x0600B067 RID: 45159 RVA: 0x000313E0 File Offset: 0x0002F5E0
			// (set) Token: 0x0600B066 RID: 45158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000BBA")]
			public int Index
			{
				[Token(Token = "0x600B067")]
				[Address(RVA = "0x11F0054", Offset = "0x11F0054", VA = "0x7BBB9F0054")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11467AC", Offset = "0x11467AC")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600B066")]
				[Address(RVA = "0x11F004C", Offset = "0x11F004C", VA = "0x7BBB9F004C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114679C", Offset = "0x114679C")]
				private set
				{
				}
			}

			// Token: 0x0600B068 RID: 45160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B068")]
			[Address(RVA = "0x11F005C", Offset = "0x11F005C", VA = "0x7BBB9F005C")]
			public CheckManualRedDot(UIManualMainTabController.EMainTab tab, int subTab, int page, int count)
			{
			}

			// Token: 0x0600B069 RID: 45161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B069")]
			[Address(RVA = "0x11F0078", Offset = "0x11F0078", VA = "0x7BBB9F0078")]
			public void CalcIndex()
			{
			}

			// Token: 0x0600B06A RID: 45162 RVA: 0x000313F8 File Offset: 0x0002F5F8
			[Token(Token = "0x600B06A")]
			[Address(RVA = "0x1507378", Offset = "0x1507378", VA = "0x7BBBD07378")]
			public static int CalcIndex(UIManualMainTabController.EMainTab tab, int subTab, int page)
			{
				return 0;
			}

			// Token: 0x0600B06B RID: 45163 RVA: 0x00031410 File Offset: 0x0002F610
			[Token(Token = "0x600B06B")]
			[Address(RVA = "0x11F0094", Offset = "0x11F0094", VA = "0x7BBB9F0094", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600B06C RID: 45164 RVA: 0x00031428 File Offset: 0x0002F628
			[Token(Token = "0x600B06C")]
			[Address(RVA = "0x11F009C", Offset = "0x11F009C", VA = "0x7BBB9F009C", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0600B06D RID: 45165 RVA: 0x00031440 File Offset: 0x0002F640
			[Token(Token = "0x600B06D")]
			[Address(RVA = "0x15083A0", Offset = "0x15083A0", VA = "0x7BBBD083A0")]
			public static bool operator ==(UIModelManual.CheckManualRedDot x, UIModelManual.CheckManualRedDot y)
			{
				return default(bool);
			}

			// Token: 0x0600B06E RID: 45166 RVA: 0x00031458 File Offset: 0x0002F658
			[Token(Token = "0x600B06E")]
			[Address(RVA = "0x1509700", Offset = "0x1509700", VA = "0x7BBBD09700")]
			public static bool operator !=(UIModelManual.CheckManualRedDot x, UIModelManual.CheckManualRedDot y)
			{
				return default(bool);
			}

			// Token: 0x0400B3EB RID: 46059
			[Token(Token = "0x400B3EB")]
			[FieldOffset(Offset = "0x0")]
			public UIManualMainTabController.EMainTab m_MainTab;

			// Token: 0x0400B3EC RID: 46060
			[Token(Token = "0x400B3EC")]
			[FieldOffset(Offset = "0x4")]
			public int m_SubTab;

			// Token: 0x0400B3ED RID: 46061
			[Token(Token = "0x400B3ED")]
			[FieldOffset(Offset = "0x8")]
			public int m_Page;

			// Token: 0x0400B3EE RID: 46062
			[Token(Token = "0x400B3EE")]
			[FieldOffset(Offset = "0xC")]
			public int m_Count;

			// Token: 0x0400B3EF RID: 46063
			[Token(Token = "0x400B3EF")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113016C", Offset = "0x113016C")]
			private int <Index>k__BackingField;
		}

		// Token: 0x02001F49 RID: 8009
		[Token(Token = "0x2001F49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD094", Offset = "0x10FD094")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600B06F RID: 45167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B06F")]
			[Address(RVA = "0x1504968", Offset = "0x1504968", VA = "0x7BBBD04968")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x0600B070 RID: 45168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B070")]
			[Address(RVA = "0x1507BEC", Offset = "0x1507BEC", VA = "0x7BBBD07BEC")]
			internal void <RequestCollectInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3F0 RID: 46064
			[Token(Token = "0x400B3F0")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual <>4__this;

			// Token: 0x0400B3F1 RID: 46065
			[Token(Token = "0x400B3F1")]
			[FieldOffset(Offset = "0x18")]
			public bool callFromMatchAfter;

			// Token: 0x0400B3F2 RID: 46066
			[Token(Token = "0x400B3F2")]
			[FieldOffset(Offset = "0x19")]
			public bool preload;
		}

		// Token: 0x02001F4A RID: 8010
		[Token(Token = "0x2001F4A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD0A4", Offset = "0x10FD0A4")]
		private sealed class <>c__DisplayClass39_1
		{
			// Token: 0x0600B071 RID: 45169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B071")]
			[Address(RVA = "0x1508384", Offset = "0x1508384", VA = "0x7BBBD08384")]
			public <>c__DisplayClass39_1()
			{
			}

			// Token: 0x0600B072 RID: 45170 RVA: 0x00031470 File Offset: 0x0002F670
			[Token(Token = "0x600B072")]
			[Address(RVA = "0x150838C", Offset = "0x150838C", VA = "0x7BBBD0838C")]
			internal bool <RequestCollectInfo>b__1(UIModelManual.CheckManualRedDot temp)
			{
				return default(bool);
			}

			// Token: 0x0400B3F3 RID: 46067
			[Token(Token = "0x400B3F3")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual.CheckManualRedDot checkData;
		}

		// Token: 0x02001F4B RID: 8011
		[Token(Token = "0x2001F4B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD0B4", Offset = "0x10FD0B4")]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x0600B073 RID: 45171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B073")]
			[Address(RVA = "0x1504D14", Offset = "0x1504D14", VA = "0x7BBBD04D14")]
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x0600B074 RID: 45172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B074")]
			[Address(RVA = "0x15083B4", Offset = "0x15083B4", VA = "0x7BBBD083B4")]
			internal void <RequestAllWeaponRewardStates>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3F4 RID: 46068
			[Token(Token = "0x400B3F4")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual <>4__this;

			// Token: 0x0400B3F5 RID: 46069
			[Token(Token = "0x400B3F5")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001F4C RID: 8012
		[Token(Token = "0x2001F4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD0C4", Offset = "0x10FD0C4")]
		private sealed class <>c__DisplayClass42_1
		{
			// Token: 0x0600B075 RID: 45173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B075")]
			[Address(RVA = "0x1508854", Offset = "0x1508854", VA = "0x7BBBD08854")]
			public <>c__DisplayClass42_1()
			{
			}

			// Token: 0x0600B076 RID: 45174 RVA: 0x00031488 File Offset: 0x0002F688
			[Token(Token = "0x600B076")]
			[Address(RVA = "0x150885C", Offset = "0x150885C", VA = "0x7BBBD0885C")]
			internal bool <RequestAllWeaponRewardStates>b__2(ManualWeaponReward temp)
			{
				return default(bool);
			}

			// Token: 0x0400B3F6 RID: 46070
			[Token(Token = "0x400B3F6")]
			[FieldOffset(Offset = "0x10")]
			public ManualWeaponReward reward;
		}

		// Token: 0x02001F4D RID: 8013
		[Token(Token = "0x2001F4D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD0D4", Offset = "0x10FD0D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B078 RID: 45176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B078")]
			[Address(RVA = "0x1507968", Offset = "0x1507968", VA = "0x7BBBD07968")]
			public <>c()
			{
			}

			// Token: 0x0600B079 RID: 45177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B079")]
			[Address(RVA = "0x1507970", Offset = "0x1507970", VA = "0x7BBBD07970")]
			internal ManualWeaponRewardData <RequestAllWeaponRewardStates>b__42_1(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0600B07A RID: 45178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B07A")]
			[Address(RVA = "0x15079F0", Offset = "0x15079F0", VA = "0x7BBBD079F0")]
			internal CommonRewardItemInfo <RequestWeaponReward>b__46_2(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600B07B RID: 45179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B07B")]
			[Address(RVA = "0x15079FC", Offset = "0x15079FC", VA = "0x7BBBD079FC")]
			internal void <RequestWeaponReward>b__46_3()
			{
			}

			// Token: 0x0600B07C RID: 45180 RVA: 0x000314A0 File Offset: 0x0002F6A0
			[Token(Token = "0x600B07C")]
			[Address(RVA = "0x1507A98", Offset = "0x1507A98", VA = "0x7BBBD07A98")]
			internal uint <InitManualDesc>b__54_0(ManualChallenge key)
			{
				return 0U;
			}

			// Token: 0x0600B07D RID: 45181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B07D")]
			[Address(RVA = "0x1507AC4", Offset = "0x1507AC4", VA = "0x7BBBD07AC4")]
			internal ManualMapData <GetUnlockMapDatas>b__59_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0600B07E RID: 45182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B07E")]
			[Address(RVA = "0x1507B44", Offset = "0x1507B44", VA = "0x7BBBD07B44")]
			internal ManualWeaponData <CalcWeaponSubTabNewIconNumber>b__66_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0600B07F RID: 45183 RVA: 0x000314B8 File Offset: 0x0002F6B8
			[Token(Token = "0x600B07F")]
			[Address(RVA = "0x1507BC4", Offset = "0x1507BC4", VA = "0x7BBBD07BC4")]
			internal int <ExistRedDotInPreviousContext>b__76_0(UIModelManual.CheckManualRedDot x, UIModelManual.CheckManualRedDot y)
			{
				return 0;
			}

			// Token: 0x0600B080 RID: 45184 RVA: 0x000314D0 File Offset: 0x0002F6D0
			[Token(Token = "0x600B080")]
			[Address(RVA = "0x1507BDC", Offset = "0x1507BDC", VA = "0x7BBBD07BDC")]
			internal int <ExistRedDotInNextContext>b__77_0(UIModelManual.CheckManualRedDot x, UIModelManual.CheckManualRedDot y)
			{
				return 0;
			}

			// Token: 0x0400B3F7 RID: 46071
			[Token(Token = "0x400B3F7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelManual.<>c <>9;

			// Token: 0x0400B3F8 RID: 46072
			[Token(Token = "0x400B3F8")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, ManualWeaponRewardData> <>9__42_1;

			// Token: 0x0400B3F9 RID: 46073
			[Token(Token = "0x400B3F9")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__46_2;

			// Token: 0x0400B3FA RID: 46074
			[Token(Token = "0x400B3FA")]
			[FieldOffset(Offset = "0x18")]
			public static Action <>9__46_3;

			// Token: 0x0400B3FB RID: 46075
			[Token(Token = "0x400B3FB")]
			[FieldOffset(Offset = "0x20")]
			public static Func<ManualChallenge, uint> <>9__54_0;

			// Token: 0x0400B3FC RID: 46076
			[Token(Token = "0x400B3FC")]
			[FieldOffset(Offset = "0x28")]
			public static Converter<CSVBaseData, ManualMapData> <>9__59_0;

			// Token: 0x0400B3FD RID: 46077
			[Token(Token = "0x400B3FD")]
			[FieldOffset(Offset = "0x30")]
			public static Converter<CSVBaseData, ManualWeaponData> <>9__66_0;

			// Token: 0x0400B3FE RID: 46078
			[Token(Token = "0x400B3FE")]
			[FieldOffset(Offset = "0x38")]
			public static Comparison<UIModelManual.CheckManualRedDot> <>9__76_0;

			// Token: 0x0400B3FF RID: 46079
			[Token(Token = "0x400B3FF")]
			[FieldOffset(Offset = "0x40")]
			public static Comparison<UIModelManual.CheckManualRedDot> <>9__77_0;
		}

		// Token: 0x02001F4E RID: 8014
		[Token(Token = "0x2001F4E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD0E4", Offset = "0x10FD0E4")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x0600B081 RID: 45185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B081")]
			[Address(RVA = "0x1505068", Offset = "0x1505068", VA = "0x7BBBD05068")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x0600B082 RID: 45186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B082")]
			[Address(RVA = "0x15088A8", Offset = "0x15088A8", VA = "0x7BBBD088A8")]
			internal void <RequestAllMapRewardStates>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B400 RID: 46080
			[Token(Token = "0x400B400")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual <>4__this;

			// Token: 0x0400B401 RID: 46081
			[Token(Token = "0x400B401")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001F4F RID: 8015
		[Token(Token = "0x2001F4F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD0F4", Offset = "0x10FD0F4")]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x0600B083 RID: 45187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B083")]
			[Address(RVA = "0x1505358", Offset = "0x1505358", VA = "0x7BBBD05358")]
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x0600B084 RID: 45188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B084")]
			[Address(RVA = "0x15089E8", Offset = "0x15089E8", VA = "0x7BBBD089E8")]
			internal void <RequestWeaponReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B085 RID: 45189 RVA: 0x000314E8 File Offset: 0x0002F6E8
			[Token(Token = "0x600B085")]
			[Address(RVA = "0x1508EC0", Offset = "0x1508EC0", VA = "0x7BBBD08EC0")]
			internal bool <RequestWeaponReward>b__1(ManualWeaponReward temp)
			{
				return default(bool);
			}

			// Token: 0x0400B402 RID: 46082
			[Token(Token = "0x400B402")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual <>4__this;

			// Token: 0x0400B403 RID: 46083
			[Token(Token = "0x400B403")]
			[FieldOffset(Offset = "0x18")]
			public uint quantity;

			// Token: 0x0400B404 RID: 46084
			[Token(Token = "0x400B404")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<ManualWeaponReward> <>9__1;
		}

		// Token: 0x02001F50 RID: 8016
		[Token(Token = "0x2001F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD104", Offset = "0x10FD104")]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x0600B086 RID: 45190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B086")]
			[Address(RVA = "0x1505648", Offset = "0x1505648", VA = "0x7BBBD05648")]
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x0600B087 RID: 45191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B087")]
			[Address(RVA = "0x1508EFC", Offset = "0x1508EFC", VA = "0x7BBBD08EFC")]
			internal void <RequestMapReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B088 RID: 45192 RVA: 0x00031500 File Offset: 0x0002F700
			[Token(Token = "0x600B088")]
			[Address(RVA = "0x150933C", Offset = "0x150933C", VA = "0x7BBBD0933C")]
			internal bool <RequestMapReward>b__1(ManualMapReward e)
			{
				return default(bool);
			}

			// Token: 0x0400B405 RID: 46085
			[Token(Token = "0x400B405")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual <>4__this;

			// Token: 0x0400B406 RID: 46086
			[Token(Token = "0x400B406")]
			[FieldOffset(Offset = "0x18")]
			public uint mapId;

			// Token: 0x0400B407 RID: 46087
			[Token(Token = "0x400B407")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<ManualMapReward> <>9__1;
		}

		// Token: 0x02001F51 RID: 8017
		[Token(Token = "0x2001F51")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD114", Offset = "0x10FD114")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x0600B089 RID: 45193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B089")]
			[Address(RVA = "0x15059BC", Offset = "0x15059BC", VA = "0x7BBBD059BC")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0600B08A RID: 45194 RVA: 0x00031518 File Offset: 0x0002F718
			[Token(Token = "0x600B08A")]
			[Address(RVA = "0x1509378", Offset = "0x1509378", VA = "0x7BBBD09378")]
			internal bool <AddUnlockIdLocal>b__0(uint temp)
			{
				return default(bool);
			}

			// Token: 0x0400B408 RID: 46088
			[Token(Token = "0x400B408")]
			[FieldOffset(Offset = "0x10")]
			public uint evtID;
		}

		// Token: 0x02001F52 RID: 8018
		[Token(Token = "0x2001F52")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD124", Offset = "0x10FD124")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x0600B08B RID: 45195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B08B")]
			[Address(RVA = "0x1505D9C", Offset = "0x1505D9C", VA = "0x7BBBD05D9C")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x0600B08C RID: 45196 RVA: 0x00031530 File Offset: 0x0002F730
			[Token(Token = "0x600B08C")]
			[Address(RVA = "0x1509388", Offset = "0x1509388", VA = "0x7BBBD09388")]
			internal bool <GetManualDescList>b__0(ManualChallenge e)
			{
				return default(bool);
			}

			// Token: 0x0400B409 RID: 46089
			[Token(Token = "0x400B409")]
			[FieldOffset(Offset = "0x10")]
			public EManual.EventType evtType;
		}

		// Token: 0x02001F53 RID: 8019
		[Token(Token = "0x2001F53")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD134", Offset = "0x10FD134")]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x0600B08D RID: 45197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B08D")]
			[Address(RVA = "0x1506618", Offset = "0x1506618", VA = "0x7BBBD06618")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x0600B08E RID: 45198 RVA: 0x00031548 File Offset: 0x0002F748
			[Token(Token = "0x600B08E")]
			[Address(RVA = "0x15093C4", Offset = "0x15093C4", VA = "0x7BBBD093C4")]
			internal bool <GetUnlockMapDatas>b__1(ManualMapData itm)
			{
				return default(bool);
			}

			// Token: 0x0400B40A RID: 46090
			[Token(Token = "0x400B40A")]
			[FieldOffset(Offset = "0x10")]
			public uint it;
		}

		// Token: 0x02001F54 RID: 8020
		[Token(Token = "0x2001F54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD144", Offset = "0x10FD144")]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x0600B08F RID: 45199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B08F")]
			[Address(RVA = "0x1506620", Offset = "0x1506620", VA = "0x7BBBD06620")]
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x0600B090 RID: 45200 RVA: 0x00031560 File Offset: 0x0002F760
			[Token(Token = "0x600B090")]
			[Address(RVA = "0x1509400", Offset = "0x1509400", VA = "0x7BBBD09400")]
			internal bool <GetMapDebrisRewardNumber>b__0(ManualMapData e)
			{
				return default(bool);
			}

			// Token: 0x0600B091 RID: 45201 RVA: 0x00031578 File Offset: 0x0002F778
			[Token(Token = "0x600B091")]
			[Address(RVA = "0x150943C", Offset = "0x150943C", VA = "0x7BBBD0943C")]
			internal bool <GetMapDebrisRewardNumber>b__1(ManualChallenge e)
			{
				return default(bool);
			}

			// Token: 0x0600B092 RID: 45202 RVA: 0x00031590 File Offset: 0x0002F790
			[Token(Token = "0x600B092")]
			[Address(RVA = "0x1509478", Offset = "0x1509478", VA = "0x7BBBD09478")]
			internal bool <GetMapDebrisRewardNumber>b__2(ManualMapReward e)
			{
				return default(bool);
			}

			// Token: 0x0400B40B RID: 46091
			[Token(Token = "0x400B40B")]
			[FieldOffset(Offset = "0x10")]
			public uint mapId;
		}

		// Token: 0x02001F55 RID: 8021
		[Token(Token = "0x2001F55")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD154", Offset = "0x10FD154")]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x0600B093 RID: 45203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B093")]
			[Address(RVA = "0x1506840", Offset = "0x1506840", VA = "0x7BBBD06840")]
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x0600B094 RID: 45204 RVA: 0x000315A8 File Offset: 0x0002F7A8
			[Token(Token = "0x600B094")]
			[Address(RVA = "0x15094B4", Offset = "0x15094B4", VA = "0x7BBBD094B4")]
			internal bool <ReadNewUnlockEvent>b__0(UIModelManual.CheckManualRedDot temp)
			{
				return default(bool);
			}

			// Token: 0x0400B40C RID: 46092
			[Token(Token = "0x400B40C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelManual <>4__this;

			// Token: 0x0400B40D RID: 46093
			[Token(Token = "0x400B40D")]
			[FieldOffset(Offset = "0x18")]
			public uint evtId;
		}

		// Token: 0x02001F56 RID: 8022
		[Token(Token = "0x2001F56")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD164", Offset = "0x10FD164")]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x0600B095 RID: 45205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B095")]
			[Address(RVA = "0x1506984", Offset = "0x1506984", VA = "0x7BBBD06984")]
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x0600B096 RID: 45206 RVA: 0x000315C0 File Offset: 0x0002F7C0
			[Token(Token = "0x600B096")]
			[Address(RVA = "0x1509530", Offset = "0x1509530", VA = "0x7BBBD09530")]
			internal bool <IsNewUnlockEvent>b__0(uint temp)
			{
				return default(bool);
			}

			// Token: 0x0600B097 RID: 45207 RVA: 0x000315D8 File Offset: 0x0002F7D8
			[Token(Token = "0x600B097")]
			[Address(RVA = "0x1509540", Offset = "0x1509540", VA = "0x7BBBD09540")]
			internal bool <IsNewUnlockEvent>b__1(uint temp)
			{
				return default(bool);
			}

			// Token: 0x0400B40E RID: 46094
			[Token(Token = "0x400B40E")]
			[FieldOffset(Offset = "0x10")]
			public uint evtId;
		}

		// Token: 0x02001F57 RID: 8023
		[Token(Token = "0x2001F57")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD174", Offset = "0x10FD174")]
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x0600B098 RID: 45208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B098")]
			[Address(RVA = "0x1506CD4", Offset = "0x1506CD4", VA = "0x7BBBD06CD4")]
			public <>c__DisplayClass66_0()
			{
			}

			// Token: 0x0600B099 RID: 45209 RVA: 0x000315F0 File Offset: 0x0002F7F0
			[Token(Token = "0x600B099")]
			[Address(RVA = "0x1509550", Offset = "0x1509550", VA = "0x7BBBD09550")]
			internal bool <CalcWeaponSubTabNewIconNumber>b__1(ManualWeaponData temp)
			{
				return default(bool);
			}

			// Token: 0x0400B40F RID: 46095
			[Token(Token = "0x400B40F")]
			[FieldOffset(Offset = "0x10")]
			public uint subTitleId;

			// Token: 0x0400B410 RID: 46096
			[Token(Token = "0x400B410")]
			[FieldOffset(Offset = "0x18")]
			public UIModelManual <>4__this;
		}

		// Token: 0x02001F58 RID: 8024
		[Token(Token = "0x2001F58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD184", Offset = "0x10FD184")]
		private sealed class <>c__DisplayClass70_0
		{
			// Token: 0x0600B09A RID: 45210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B09A")]
			[Address(RVA = "0x1506DD0", Offset = "0x1506DD0", VA = "0x7BBBD06DD0")]
			public <>c__DisplayClass70_0()
			{
			}

			// Token: 0x0600B09B RID: 45211 RVA: 0x00031608 File Offset: 0x0002F808
			[Token(Token = "0x600B09B")]
			[Address(RVA = "0x15095B8", Offset = "0x15095B8", VA = "0x7BBBD095B8")]
			internal bool <GetMapSubTabIndex>b__0(EManual.EventType temp)
			{
				return default(bool);
			}

			// Token: 0x0400B411 RID: 46097
			[Token(Token = "0x400B411")]
			[FieldOffset(Offset = "0x10")]
			public EManual.EventType type;
		}

		// Token: 0x02001F59 RID: 8025
		[Token(Token = "0x2001F59")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD194", Offset = "0x10FD194")]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x0600B09C RID: 45212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B09C")]
			[Address(RVA = "0x1506EA8", Offset = "0x1506EA8", VA = "0x7BBBD06EA8")]
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x0600B09D RID: 45213 RVA: 0x00031620 File Offset: 0x0002F820
			[Token(Token = "0x600B09D")]
			[Address(RVA = "0x15095C8", Offset = "0x15095C8", VA = "0x7BBBD095C8")]
			internal bool <GetMapSubTabIndex>b__0(EManual.EventType temp)
			{
				return default(bool);
			}

			// Token: 0x0400B412 RID: 46098
			[Token(Token = "0x400B412")]
			[FieldOffset(Offset = "0x10")]
			public EManual.EventType type;
		}

		// Token: 0x02001F5A RID: 8026
		[Token(Token = "0x2001F5A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD1A4", Offset = "0x10FD1A4")]
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x0600B09E RID: 45214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B09E")]
			[Address(RVA = "0x1507370", Offset = "0x1507370", VA = "0x7BBBD07370")]
			public <>c__DisplayClass76_0()
			{
			}

			// Token: 0x0600B09F RID: 45215 RVA: 0x00031638 File Offset: 0x0002F838
			[Token(Token = "0x600B09F")]
			[Address(RVA = "0x15095D8", Offset = "0x15095D8", VA = "0x7BBBD095D8")]
			internal bool <ExistRedDotInPreviousContext>b__1(UIModelManual.CheckManualRedDot temp)
			{
				return default(bool);
			}

			// Token: 0x0400B413 RID: 46099
			[Token(Token = "0x400B413")]
			[FieldOffset(Offset = "0x10")]
			public int index;
		}

		// Token: 0x02001F5B RID: 8027
		[Token(Token = "0x2001F5B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD1B4", Offset = "0x10FD1B4")]
		private sealed class <>c__DisplayClass77_0
		{
			// Token: 0x0600B0A0 RID: 45216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0A0")]
			[Address(RVA = "0x1507628", Offset = "0x1507628", VA = "0x7BBBD07628")]
			public <>c__DisplayClass77_0()
			{
			}

			// Token: 0x0600B0A1 RID: 45217 RVA: 0x00031650 File Offset: 0x0002F850
			[Token(Token = "0x600B0A1")]
			[Address(RVA = "0x15095EC", Offset = "0x15095EC", VA = "0x7BBBD095EC")]
			internal bool <ExistRedDotInNextContext>b__1(UIModelManual.CheckManualRedDot temp)
			{
				return default(bool);
			}

			// Token: 0x0400B414 RID: 46100
			[Token(Token = "0x400B414")]
			[FieldOffset(Offset = "0x10")]
			public int index;
		}
	}
}
