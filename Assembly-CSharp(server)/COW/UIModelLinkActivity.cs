using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001F0B RID: 7947
	[Token(Token = "0x2001F0B")]
	public class UIModelLinkActivity : UIBaseModel
	{
		// Token: 0x0600AE90 RID: 44688 RVA: 0x00030720 File Offset: 0x0002E920
		[Token(Token = "0x600AE90")]
		[Address(RVA = "0x2385590", Offset = "0x2385590", VA = "0x7BBCB85590", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600AE91 RID: 44689 RVA: 0x00030738 File Offset: 0x0002E938
		[Token(Token = "0x17000B8F")]
		public bool HasInfo
		{
			[Token(Token = "0x600AE91")]
			[Address(RVA = "0x2385598", Offset = "0x2385598", VA = "0x7BBCB85598")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x0600AE92 RID: 44690 RVA: 0x00030750 File Offset: 0x0002E950
		[Token(Token = "0x17000B90")]
		public uint Day
		{
			[Token(Token = "0x600AE92")]
			[Address(RVA = "0x23855A8", Offset = "0x23855A8", VA = "0x7BBCB855A8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x0600AE93 RID: 44691 RVA: 0x00030768 File Offset: 0x0002E968
		[Token(Token = "0x17000B91")]
		public uint ActivityId
		{
			[Token(Token = "0x600AE93")]
			[Address(RVA = "0x23855D4", Offset = "0x23855D4", VA = "0x7BBCB855D4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x00030780 File Offset: 0x0002E980
		[Token(Token = "0x17000B92")]
		public ELinkage.ActivityType ActivityType
		{
			[Token(Token = "0x600AE94")]
			[Address(RVA = "0x2385600", Offset = "0x2385600", VA = "0x7BBCB85600")]
			get
			{
				return ELinkage.ActivityType.Type_NONE;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x00030798 File Offset: 0x0002E998
		[Token(Token = "0x17000B93")]
		public uint TodayData
		{
			[Token(Token = "0x600AE95")]
			[Address(RVA = "0x238562C", Offset = "0x238562C", VA = "0x7BBCB8562C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x000307B0 File Offset: 0x0002E9B0
		[Token(Token = "0x17000B94")]
		public uint TotalData
		{
			[Token(Token = "0x600AE96")]
			[Address(RVA = "0x2385658", Offset = "0x2385658", VA = "0x7BBCB85658")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x000307C8 File Offset: 0x0002E9C8
		[Token(Token = "0x17000B95")]
		public bool IsFinished
		{
			[Token(Token = "0x600AE97")]
			[Address(RVA = "0x2385684", Offset = "0x2385684", VA = "0x7BBCB85684")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x000307E0 File Offset: 0x0002E9E0
		[Token(Token = "0x17000B96")]
		public bool IsRewarded
		{
			[Token(Token = "0x600AE98")]
			[Address(RVA = "0x23856B8", Offset = "0x23856B8", VA = "0x7BBCB856B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600AE99 RID: 44697 RVA: 0x000307F8 File Offset: 0x0002E9F8
		[Token(Token = "0x17000B97")]
		public bool HasActivity
		{
			[Token(Token = "0x600AE99")]
			[Address(RVA = "0x23856EC", Offset = "0x23856EC", VA = "0x7BBCB856EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600AE9A RID: 44698 RVA: 0x00030810 File Offset: 0x0002EA10
		[Token(Token = "0x17000B98")]
		public long RegionServerTimeOffset
		{
			[Token(Token = "0x600AE9A")]
			[Address(RVA = "0x238570C", Offset = "0x238570C", VA = "0x7BBCB8570C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B99")]
		public List<LinkageProcessRewards> ProcessRewardsStatus
		{
			[Token(Token = "0x600AE9B")]
			[Address(RVA = "0x2385738", Offset = "0x2385738", VA = "0x7BBCB85738")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600AE9C RID: 44700 RVA: 0x00030828 File Offset: 0x0002EA28
		[Token(Token = "0x17000B9A")]
		public ulong CurEPCount
		{
			[Token(Token = "0x600AE9C")]
			[Address(RVA = "0x2385764", Offset = "0x2385764", VA = "0x7BBCB85764")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600AE9D RID: 44701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9B")]
		public string CDNUrl
		{
			[Token(Token = "0x600AE9D")]
			[Address(RVA = "0x2385790", Offset = "0x2385790", VA = "0x7BBCB85790")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AE9E RID: 44702 RVA: 0x00030840 File Offset: 0x0002EA40
		[Token(Token = "0x600AE9E")]
		[Address(RVA = "0x23857BC", Offset = "0x23857BC", VA = "0x7BBCB857BC")]
		public DateTime GetRegionServerDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x0600AE9F RID: 44703 RVA: 0x00030858 File Offset: 0x0002EA58
		[Token(Token = "0x600AE9F")]
		[Address(RVA = "0x2385838", Offset = "0x2385838", VA = "0x7BBCB85838")]
		public int GetHoursForNextUpdate()
		{
			return 0;
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEA0")]
		[Address(RVA = "0x238587C", Offset = "0x238587C", VA = "0x7BBCB8587C")]
		public LinkActivityData GetActivityData()
		{
			return null;
		}

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEA1")]
		public T GetActivityDetailData<T>() where T : LinkActivityDetailData
		{
			return null;
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA2")]
		[Address(RVA = "0x238594C", Offset = "0x238594C", VA = "0x7BBCB8594C")]
		public void GetLinkActivityInfoFromServer(uint httpOp = 0U, bool updateEntryTick = true)
		{
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA3")]
		[Address(RVA = "0x2385A34", Offset = "0x2385A34", VA = "0x7BBCB85A34")]
		public void ClaimReward()
		{
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA4")]
		[Address(RVA = "0x2385AC4", Offset = "0x2385AC4", VA = "0x7BBCB85AC4")]
		public void ClaimOpenGame()
		{
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA5")]
		[Address(RVA = "0x2385BE0", Offset = "0x2385BE0", VA = "0x7BBCB85BE0")]
		public void ClaimPVEProcessReward(uint processID, bool isBatchClaim, [Optional] Action<List<CommonRewardItemInfo>, string> callBack)
		{
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA6")]
		[Address(RVA = "0x2385D1C", Offset = "0x2385D1C", VA = "0x7BBCB85D1C")]
		public void BatchClaimPVEProcessReward(List<uint> processIDs)
		{
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA7")]
		[Address(RVA = "0x2385F0C", Offset = "0x2385F0C", VA = "0x7BBCB85F0C")]
		private void OnTreasureBatchOpenCallback(List<CommonRewardItemInfo> list, string hint)
		{
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA8")]
		[Address(RVA = "0x23860D4", Offset = "0x23860D4", VA = "0x7BBCB860D4")]
		public void AutoOpenBundle(uint item_id, bool isBatchOpen, [Optional] Action<List<CommonRewardItemInfo>, string> callBack)
		{
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA9")]
		private void SendServerRequest<T>(ServiceMessageTypeHTTP cmd, Action<T> callback, uint httpOp = 0U) where T : class
		{
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAA")]
		private void SendServerRequestByParam<T>(ServiceMessageTypeHTTP cmd, [Optional] Action<T> callback, [Optional] object param, uint httpOp = 0U) where T : class
		{
		}

		// Token: 0x0600AEAB RID: 44715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAB")]
		[Address(RVA = "0x23862B0", Offset = "0x23862B0", VA = "0x7BBCB862B0")]
		public void GetLinkEquipSetInfoFromServer(uint httpOp = 0U, bool updateEntryTick = true)
		{
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAC")]
		[Address(RVA = "0x238634C", Offset = "0x238634C", VA = "0x7BBCB8634C")]
		private void SetTips(bool updateEntryTick)
		{
		}

		// Token: 0x0600AEAD RID: 44717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAD")]
		[Address(RVA = "0x2386398", Offset = "0x2386398", VA = "0x7BBCB86398")]
		private void UpdateTipToday(ETipsType type)
		{
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEAE")]
		[Address(RVA = "0x2386570", Offset = "0x2386570", VA = "0x7BBCB86570")]
		private string GetPrefKey(ETipsType type)
		{
			return null;
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAF")]
		[Address(RVA = "0x23865DC", Offset = "0x23865DC", VA = "0x7BBCB865DC")]
		public void OnClearTipToday(ETipsType type)
		{
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB0")]
		[Address(RVA = "0x23866E8", Offset = "0x23866E8", VA = "0x7BBCB866E8")]
		public UIModelLinkActivity()
		{
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB1")]
		[Address(RVA = "0x238675C", Offset = "0x238675C", VA = "0x7BBCB8675C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114661C", Offset = "0x114661C")]
		private void <ClaimReward>b__41_0(CSGetLinkageActivityRewardsRes data)
		{
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB2")]
		[Address(RVA = "0x2386A64", Offset = "0x2386A64", VA = "0x7BBCB86A64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114662C", Offset = "0x114662C")]
		private void <ClaimOpenGame>b__42_0(CSGetProcessRewardsRes data)
		{
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB3")]
		[Address(RVA = "0x2386BF0", Offset = "0x2386BF0", VA = "0x7BBCB86BF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114663C", Offset = "0x114663C")]
		private void <GetLinkEquipSetInfoFromServer>b__51_0(CSGetLinkEquipSetRes data)
		{
		}

		// Token: 0x0400B2BB RID: 45755
		[Token(Token = "0x400B2BB")]
		public const uint PropID_LinkActivityInfo = 1U;

		// Token: 0x0400B2BC RID: 45756
		[Token(Token = "0x400B2BC")]
		public const uint PropID_LinkActivityReward = 2U;

		// Token: 0x0400B2BD RID: 45757
		[Token(Token = "0x400B2BD")]
		public const uint PropID_LinkEquipSet = 4U;

		// Token: 0x0400B2BE RID: 45758
		[Token(Token = "0x400B2BE")]
		public const uint PropID_LinkPVEOpen = 8U;

		// Token: 0x0400B2BF RID: 45759
		[Token(Token = "0x400B2BF")]
		private const string TipPrefKey = "LinkActivityProcess";

		// Token: 0x0400B2C0 RID: 45760
		[Token(Token = "0x400B2C0")]
		private const string TipPrefEntryKey = "LinkActivityProcessEntry";

		// Token: 0x0400B2C1 RID: 45761
		[Token(Token = "0x400B2C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CSGetLinkageActivityInfoRes m_State;

		// Token: 0x0400B2C2 RID: 45762
		[Token(Token = "0x400B2C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RefreshHour;

		// Token: 0x0400B2C3 RID: 45763
		[Token(Token = "0x400B2C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int EquipSetsId;

		// Token: 0x0400B2C4 RID: 45764
		[Token(Token = "0x400B2C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CommonRewardItemInfo> m_PVEPorcessBatchReward;

		// Token: 0x0400B2C5 RID: 45765
		[Token(Token = "0x400B2C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int BatchClaimPorcessIDCount;

		// Token: 0x02001F0C RID: 7948
		[Token(Token = "0x2001F0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCDD4", Offset = "0x10FCDD4")]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x0600AEB4 RID: 44724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEB4")]
			[Address(RVA = "0x16402B0", Offset = "0x16402B0", VA = "0x7BBBE402B0")]
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x0600AEB5 RID: 44725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEB5")]
			[Address(RVA = "0x16402B8", Offset = "0x16402B8", VA = "0x7BBBE402B8")]
			internal void <GetLinkActivityInfoFromServer>b__0(CSGetLinkageActivityInfoRes data)
			{
			}

			// Token: 0x0400B2C6 RID: 45766
			[Token(Token = "0x400B2C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLinkActivity <>4__this;

			// Token: 0x0400B2C7 RID: 45767
			[Token(Token = "0x400B2C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool updateEntryTick;
		}

		// Token: 0x02001F0D RID: 7949
		[Token(Token = "0x2001F0D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCDE4", Offset = "0x10FCDE4")]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x0600AEB6 RID: 44726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEB6")]
			[Address(RVA = "0x1640378", Offset = "0x1640378", VA = "0x7BBBE40378")]
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x0600AEB7 RID: 44727 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEB7")]
			[Address(RVA = "0x1640380", Offset = "0x1640380", VA = "0x7BBBE40380")]
			internal void <ClaimPVEProcessReward>b__0(CSGetProcessRewardsRes data)
			{
			}

			// Token: 0x0400B2C8 RID: 45768
			[Token(Token = "0x400B2C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelLinkActivity <>4__this;

			// Token: 0x0400B2C9 RID: 45769
			[Token(Token = "0x400B2C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isBatchClaim;

			// Token: 0x0400B2CA RID: 45770
			[Token(Token = "0x400B2CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<List<CommonRewardItemInfo>, string> callBack;
		}

		// Token: 0x02001F0E RID: 7950
		[Token(Token = "0x2001F0E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCDF4", Offset = "0x10FCDF4")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x0600AEB8 RID: 44728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEB8")]
			[Address(RVA = "0x1640618", Offset = "0x1640618", VA = "0x7BBBE40618")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x0600AEB9 RID: 44729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEB9")]
			[Address(RVA = "0x1640620", Offset = "0x1640620", VA = "0x7BBBE40620")]
			internal void <AutoOpenBundle>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B2CB RID: 45771
			[Token(Token = "0x400B2CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isBatchOpen;

			// Token: 0x0400B2CC RID: 45772
			[Token(Token = "0x400B2CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<List<CommonRewardItemInfo>, string> callBack;
		}

		// Token: 0x02001F0F RID: 7951
		[Token(Token = "0x2001F0F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE04", Offset = "0x10FCE04")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AEBB RID: 44731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEBB")]
			[Address(RVA = "0x164029C", Offset = "0x164029C", VA = "0x7BBBE4029C")]
			public <>c()
			{
			}

			// Token: 0x0600AEBC RID: 44732 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AEBC")]
			[Address(RVA = "0x16402A4", Offset = "0x16402A4", VA = "0x7BBBE402A4")]
			internal CommonRewardItemInfo <AutoOpenBundle>b__48_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400B2CD RID: 45773
			[Token(Token = "0x400B2CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelLinkActivity.<>c <>9;

			// Token: 0x0400B2CE RID: 45774
			[Token(Token = "0x400B2CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__48_1;
		}

		// Token: 0x02001F10 RID: 7952
		[Token(Token = "0x2001F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE14", Offset = "0x10FCE14")]
		private sealed class <>c__DisplayClass49_0<T> where T : class
		{
			// Token: 0x0600AEBD RID: 44733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEBD")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0600AEBE RID: 44734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEBE")]
			internal void <SendServerRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B2CF RID: 45775
			[Token(Token = "0x400B2CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> callback;
		}

		// Token: 0x02001F11 RID: 7953
		[Token(Token = "0x2001F11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE24", Offset = "0x10FCE24")]
		private sealed class <>c__DisplayClass50_0<T> where T : class
		{
			// Token: 0x0600AEBF RID: 44735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEBF")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600AEC0 RID: 44736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEC0")]
			internal void <SendServerRequestByParam>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B2D0 RID: 45776
			[Token(Token = "0x400B2D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> callback;
		}
	}
}
