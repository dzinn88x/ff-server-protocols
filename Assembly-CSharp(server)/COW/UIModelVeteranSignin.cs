using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02002024 RID: 8228
	[Token(Token = "0x2002024")]
	public class UIModelVeteranSignin : UIBaseModel
	{
		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600B76F RID: 46959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAC")]
		public List<VeteranRewardItem> VeteranRewardList
		{
			[Token(Token = "0x600B76F")]
			[Address(RVA = "0x14BE6B4", Offset = "0x14BE6B4", VA = "0x7BBBCBE6B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600B770 RID: 46960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAD")]
		public List<ClientVeteranTaskDesc> TaskDescs
		{
			[Token(Token = "0x600B770")]
			[Address(RVA = "0x14BE6BC", Offset = "0x14BE6BC", VA = "0x7BBBCBE6BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600B771 RID: 46961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAE")]
		public List<VeteranTaskInfo> TaskInfos
		{
			[Token(Token = "0x600B771")]
			[Address(RVA = "0x14BE6C4", Offset = "0x14BE6C4", VA = "0x7BBBCBE6C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600B773 RID: 46963 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B772 RID: 46962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAF")]
		public VeteranBigPrizeDesc BigPrizeDesc
		{
			[Token(Token = "0x600B773")]
			[Address(RVA = "0x14BE6D4", Offset = "0x14BE6D4", VA = "0x7BBBCBE6D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114788C", Offset = "0x114788C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B772")]
			[Address(RVA = "0x14BE6CC", Offset = "0x14BE6CC", VA = "0x7BBBCBE6CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114787C", Offset = "0x114787C")]
			private set
			{
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600B775 RID: 46965 RVA: 0x00034668 File Offset: 0x00032868
		// (set) Token: 0x0600B774 RID: 46964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB0")]
		public ulong VeteranEndTimeStamp
		{
			[Token(Token = "0x600B775")]
			[Address(RVA = "0x14BE6E4", Offset = "0x14BE6E4", VA = "0x7BBBCBE6E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11478AC", Offset = "0x11478AC")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B774")]
			[Address(RVA = "0x14BE6DC", Offset = "0x14BE6DC", VA = "0x7BBBCBE6DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114789C", Offset = "0x114789C")]
			private set
			{
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600B777 RID: 46967 RVA: 0x00034680 File Offset: 0x00032880
		// (set) Token: 0x0600B776 RID: 46966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB1")]
		public EActivity.State BigPrizeState
		{
			[Token(Token = "0x600B777")]
			[Address(RVA = "0x14BE700", Offset = "0x14BE700", VA = "0x7BBBCBE700")]
			get
			{
				return EActivity.State.State_RECEIVED;
			}
			[Token(Token = "0x600B776")]
			[Address(RVA = "0x14BE6EC", Offset = "0x14BE6EC", VA = "0x7BBBCBE6EC")]
			private set
			{
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600B778 RID: 46968 RVA: 0x00034698 File Offset: 0x00032898
		[Token(Token = "0x17000CB2")]
		public bool IsVeteran
		{
			[Token(Token = "0x600B778")]
			[Address(RVA = "0x14BE898", Offset = "0x14BE898", VA = "0x7BBBCBE898")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x000346B0 File Offset: 0x000328B0
		[Token(Token = "0x600B779")]
		[Address(RVA = "0x14BE8A0", Offset = "0x14BE8A0", VA = "0x7BBBCBE8A0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B77A")]
		[Address(RVA = "0x14BE8A8", Offset = "0x14BE8A8", VA = "0x7BBBCBE8A8", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B77B")]
		[Address(RVA = "0x14BE8E4", Offset = "0x14BE8E4", VA = "0x7BBBCBE8E4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B77C")]
		[Address(RVA = "0x14BE960", Offset = "0x14BE960", VA = "0x7BBBCBE960", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x000346C8 File Offset: 0x000328C8
		[Token(Token = "0x600B77D")]
		[Address(RVA = "0x14BEA4C", Offset = "0x14BEA4C", VA = "0x7BBBCBEA4C")]
		public bool IsShowVeteranEntry()
		{
			return default(bool);
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x000346E0 File Offset: 0x000328E0
		[Token(Token = "0x600B77E")]
		[Address(RVA = "0x14BED8C", Offset = "0x14BED8C", VA = "0x7BBBCBED8C")]
		public bool HaveNewRewardAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x000346F8 File Offset: 0x000328F8
		[Token(Token = "0x600B77F")]
		[Address(RVA = "0x14BEB10", Offset = "0x14BEB10", VA = "0x7BBBCBEB10")]
		public bool IsVeteranRewardReceived()
		{
			return default(bool);
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B780")]
		[Address(RVA = "0x14BEEC4", Offset = "0x14BEEC4", VA = "0x7BBBCBEEC4")]
		public void ProcessVeteranRes(CSGetVeteranRewardListRes res)
		{
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600B781 RID: 46977 RVA: 0x00034710 File Offset: 0x00032910
		[Token(Token = "0x17000CB3")]
		private int ReminderDays
		{
			[Token(Token = "0x600B781")]
			[Address(RVA = "0x14BF650", Offset = "0x14BF650", VA = "0x7BBBCBF650")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B782")]
		[Address(RVA = "0x14BF0D0", Offset = "0x14BF0D0", VA = "0x7BBBCBF0D0")]
		private void RescheduleLocalNotifications()
		{
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B783")]
		[Address(RVA = "0x14BF710", Offset = "0x14BF710", VA = "0x7BBBCBF710")]
		public void RequestSignin(int rewardIndex)
		{
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B784")]
		[Address(RVA = "0x14BF9B4", Offset = "0x14BF9B4", VA = "0x7BBBCBF9B4")]
		public VeteranTaskInfo GetTaskInfo(uint taskId)
		{
			return null;
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B785")]
		[Address(RVA = "0x14BFA8C", Offset = "0x14BFA8C", VA = "0x7BBBCBFA8C")]
		public ClientVeteranTaskDesc GetTaskDesc(uint taskId)
		{
			return null;
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B786")]
		[Address(RVA = "0x14BFB64", Offset = "0x14BFB64", VA = "0x7BBBCBFB64")]
		private void OnGetTaskDesc()
		{
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B787")]
		[Address(RVA = "0x14BFBD8", Offset = "0x14BFBD8", VA = "0x7BBBCBFBD8")]
		public void GetTaskDesc(bool preload = false)
		{
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B788")]
		[Address(RVA = "0x14BFEF8", Offset = "0x14BFEF8", VA = "0x7BBBCBFEF8")]
		private void OnGetTaskInfo()
		{
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B789")]
		[Address(RVA = "0x14BFFCC", Offset = "0x14BFFCC", VA = "0x7BBBCBFFCC")]
		public void GetTaskInfo(bool preload = false)
		{
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B78A")]
		[Address(RVA = "0x14C0294", Offset = "0x14C0294", VA = "0x7BBBCC0294")]
		public void GetTaskRewards(uint taskId)
		{
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B78B")]
		[Address(RVA = "0x14C0594", Offset = "0x14C0594", VA = "0x7BBBCC0594")]
		public void GetTaskBigPrize()
		{
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x00034728 File Offset: 0x00032928
		[Token(Token = "0x600B78C")]
		[Address(RVA = "0x14BE768", Offset = "0x14BE768", VA = "0x7BBBCBE768")]
		public uint GetClaimedTaskNum()
		{
			return 0U;
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x00034740 File Offset: 0x00032940
		[Token(Token = "0x600B78D")]
		[Address(RVA = "0x14BEC48", Offset = "0x14BEC48", VA = "0x7BBBCBEC48")]
		public int GetWaitClaimNum()
		{
			return 0;
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B78E")]
		[Address(RVA = "0x14C0830", Offset = "0x14C0830", VA = "0x7BBBCC0830")]
		public UIModelVeteranSignin()
		{
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B78F")]
		[Address(RVA = "0x14C0930", Offset = "0x14C0930", VA = "0x7BBBCC0930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11478BC", Offset = "0x11478BC")]
		private void <GetTaskBigPrize>b__54_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B98B RID: 47499
		[Token(Token = "0x400B98B")]
		[FieldOffset(Offset = "0x18")]
		private List<VeteranRewardItem> m_VeteranRewardList;

		// Token: 0x0400B98C RID: 47500
		[Token(Token = "0x400B98C")]
		public const uint PropID_VeteranRewardUpdate = 2U;

		// Token: 0x0400B98D RID: 47501
		[Token(Token = "0x400B98D")]
		public const uint PropID_GetReward = 4U;

		// Token: 0x0400B98E RID: 47502
		[Token(Token = "0x400B98E")]
		public const uint PropID_GetTaskDesc = 8U;

		// Token: 0x0400B98F RID: 47503
		[Token(Token = "0x400B98F")]
		public const uint PropID_GetTaskInfo = 16U;

		// Token: 0x0400B990 RID: 47504
		[Token(Token = "0x400B990")]
		public const uint PropID_GetTaskRewards = 32U;

		// Token: 0x0400B991 RID: 47505
		[Token(Token = "0x400B991")]
		public const uint PropID_GetTaskBigPrize = 64U;

		// Token: 0x0400B992 RID: 47506
		[Token(Token = "0x400B992")]
		[FieldOffset(Offset = "0x20")]
		private bool m_WaitingForSigninResponse;

		// Token: 0x0400B993 RID: 47507
		[Token(Token = "0x400B993")]
		[FieldOffset(Offset = "0x28")]
		private WaitingResponseHandler m_WaitingHandler;

		// Token: 0x0400B994 RID: 47508
		[Token(Token = "0x400B994")]
		[FieldOffset(Offset = "0x30")]
		private List<ClientVeteranTaskDesc> m_TaskDescs;

		// Token: 0x0400B995 RID: 47509
		[Token(Token = "0x400B995")]
		[FieldOffset(Offset = "0x38")]
		private List<VeteranTaskInfo> m_TaskInfos;

		// Token: 0x0400B996 RID: 47510
		[Token(Token = "0x400B996")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113083C", Offset = "0x113083C")]
		private VeteranBigPrizeDesc <BigPrizeDesc>k__BackingField;

		// Token: 0x0400B997 RID: 47511
		[Token(Token = "0x400B997")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113084C", Offset = "0x113084C")]
		private ulong <VeteranEndTimeStamp>k__BackingField;

		// Token: 0x0400B998 RID: 47512
		[Token(Token = "0x400B998")]
		[FieldOffset(Offset = "0x50")]
		private EActivity.State m_BigPrizeState;

		// Token: 0x0400B999 RID: 47513
		[Token(Token = "0x400B999")]
		[FieldOffset(Offset = "0x54")]
		private bool m_IsVeteran;

		// Token: 0x0400B99A RID: 47514
		[Token(Token = "0x400B99A")]
		[FieldOffset(Offset = "0x55")]
		private bool m_HasIsVeteran;

		// Token: 0x0400B99B RID: 47515
		[Token(Token = "0x400B99B")]
		[FieldOffset(Offset = "0x56")]
		private bool m_PreloadedTaskDesc;

		// Token: 0x0400B99C RID: 47516
		[Token(Token = "0x400B99C")]
		[FieldOffset(Offset = "0x57")]
		private bool m_PreloadedTaskInfo;

		// Token: 0x02002025 RID: 8229
		[Token(Token = "0x2002025")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD804", Offset = "0x10FD804")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B791 RID: 46993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B791")]
			[Address(RVA = "0x14C0DA8", Offset = "0x14C0DA8", VA = "0x7BBBCC0DA8")]
			public <>c()
			{
			}

			// Token: 0x0600B792 RID: 46994 RVA: 0x00034758 File Offset: 0x00032958
			[Token(Token = "0x600B792")]
			[Address(RVA = "0x14C0DB0", Offset = "0x14C0DB0", VA = "0x7BBBCC0DB0")]
			internal int <ProcessVeteranRes>b__40_0(VeteranRewardItem a, VeteranRewardItem b)
			{
				return 0;
			}

			// Token: 0x0600B793 RID: 46995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B793")]
			[Address(RVA = "0x14C0E18", Offset = "0x14C0E18", VA = "0x7BBBCC0E18")]
			internal CommonRewardItemInfo <GetTaskRewards>b__53_2(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600B794 RID: 46996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B794")]
			[Address(RVA = "0x14C0E24", Offset = "0x14C0E24", VA = "0x7BBBCC0E24")]
			internal void <GetTaskRewards>b__53_3()
			{
			}

			// Token: 0x0600B795 RID: 46997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B795")]
			[Address(RVA = "0x14C0EC0", Offset = "0x14C0EC0", VA = "0x7BBBCC0EC0")]
			internal CommonRewardItemInfo <GetTaskBigPrize>b__54_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600B796 RID: 46998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B796")]
			[Address(RVA = "0x14C0ECC", Offset = "0x14C0ECC", VA = "0x7BBBCC0ECC")]
			internal void <GetTaskBigPrize>b__54_2()
			{
			}

			// Token: 0x0400B99D RID: 47517
			[Token(Token = "0x400B99D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelVeteranSignin.<>c <>9;

			// Token: 0x0400B99E RID: 47518
			[Token(Token = "0x400B99E")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<VeteranRewardItem> <>9__40_0;

			// Token: 0x0400B99F RID: 47519
			[Token(Token = "0x400B99F")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__53_2;

			// Token: 0x0400B9A0 RID: 47520
			[Token(Token = "0x400B9A0")]
			[FieldOffset(Offset = "0x18")]
			public static Action <>9__53_3;

			// Token: 0x0400B9A1 RID: 47521
			[Token(Token = "0x400B9A1")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__54_1;

			// Token: 0x0400B9A2 RID: 47522
			[Token(Token = "0x400B9A2")]
			[FieldOffset(Offset = "0x28")]
			public static Action <>9__54_2;
		}

		// Token: 0x02002026 RID: 8230
		[Token(Token = "0x2002026")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD814", Offset = "0x10FD814")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x0600B797 RID: 46999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B797")]
			[Address(RVA = "0x14BF9AC", Offset = "0x14BF9AC", VA = "0x7BBBCBF9AC")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x0600B798 RID: 47000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B798")]
			[Address(RVA = "0x14C0F68", Offset = "0x14C0F68", VA = "0x7BBBCC0F68")]
			internal void <RequestSignin>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B9A3 RID: 47523
			[Token(Token = "0x400B9A3")]
			[FieldOffset(Offset = "0x10")]
			public UIModelVeteranSignin <>4__this;

			// Token: 0x0400B9A4 RID: 47524
			[Token(Token = "0x400B9A4")]
			[FieldOffset(Offset = "0x18")]
			public int rewardIndex;
		}

		// Token: 0x02002027 RID: 8231
		[Token(Token = "0x2002027")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD824", Offset = "0x10FD824")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x0600B799 RID: 47001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B799")]
			[Address(RVA = "0x14BFA84", Offset = "0x14BFA84", VA = "0x7BBBCBFA84")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x0600B79A RID: 47002 RVA: 0x00034770 File Offset: 0x00032970
			[Token(Token = "0x600B79A")]
			[Address(RVA = "0x14C123C", Offset = "0x14C123C", VA = "0x7BBBCC123C")]
			internal bool <GetTaskInfo>b__0(VeteranTaskInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B9A5 RID: 47525
			[Token(Token = "0x400B9A5")]
			[FieldOffset(Offset = "0x10")]
			public uint taskId;
		}

		// Token: 0x02002028 RID: 8232
		[Token(Token = "0x2002028")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD834", Offset = "0x10FD834")]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x0600B79B RID: 47003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B79B")]
			[Address(RVA = "0x14BFB5C", Offset = "0x14BFB5C", VA = "0x7BBBCBFB5C")]
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x0600B79C RID: 47004 RVA: 0x00034788 File Offset: 0x00032988
			[Token(Token = "0x600B79C")]
			[Address(RVA = "0x14C1278", Offset = "0x14C1278", VA = "0x7BBBCC1278")]
			internal bool <GetTaskDesc>b__0(ClientVeteranTaskDesc temp)
			{
				return default(bool);
			}

			// Token: 0x0400B9A6 RID: 47526
			[Token(Token = "0x400B9A6")]
			[FieldOffset(Offset = "0x10")]
			public uint taskId;
		}

		// Token: 0x02002029 RID: 8233
		[Token(Token = "0x2002029")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD844", Offset = "0x10FD844")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x0600B79D RID: 47005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B79D")]
			[Address(RVA = "0x14BFEF0", Offset = "0x14BFEF0", VA = "0x7BBBCBFEF0")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0600B79E RID: 47006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B79E")]
			[Address(RVA = "0x14C12B4", Offset = "0x14C12B4", VA = "0x7BBBCC12B4")]
			internal void <GetTaskDesc>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B9A7 RID: 47527
			[Token(Token = "0x400B9A7")]
			[FieldOffset(Offset = "0x10")]
			public UIModelVeteranSignin <>4__this;

			// Token: 0x0400B9A8 RID: 47528
			[Token(Token = "0x400B9A8")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x0200202A RID: 8234
		[Token(Token = "0x200202A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD854", Offset = "0x10FD854")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x0600B79F RID: 47007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B79F")]
			[Address(RVA = "0x14C028C", Offset = "0x14C028C", VA = "0x7BBBCC028C")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x0600B7A0 RID: 47008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7A0")]
			[Address(RVA = "0x14C14A0", Offset = "0x14C14A0", VA = "0x7BBBCC14A0")]
			internal void <GetTaskInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B9A9 RID: 47529
			[Token(Token = "0x400B9A9")]
			[FieldOffset(Offset = "0x10")]
			public UIModelVeteranSignin <>4__this;

			// Token: 0x0400B9AA RID: 47530
			[Token(Token = "0x400B9AA")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x0200202B RID: 8235
		[Token(Token = "0x200202B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD864", Offset = "0x10FD864")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x0600B7A1 RID: 47009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7A1")]
			[Address(RVA = "0x14C058C", Offset = "0x14C058C", VA = "0x7BBBCC058C")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x0600B7A2 RID: 47010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7A2")]
			[Address(RVA = "0x14C166C", Offset = "0x14C166C", VA = "0x7BBBCC166C")]
			internal void <GetTaskRewards>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B7A3 RID: 47011 RVA: 0x000347A0 File Offset: 0x000329A0
			[Token(Token = "0x600B7A3")]
			[Address(RVA = "0x14C1B30", Offset = "0x14C1B30", VA = "0x7BBBCC1B30")]
			internal bool <GetTaskRewards>b__1(VeteranTaskInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B9AB RID: 47531
			[Token(Token = "0x400B9AB")]
			[FieldOffset(Offset = "0x10")]
			public UIModelVeteranSignin <>4__this;

			// Token: 0x0400B9AC RID: 47532
			[Token(Token = "0x400B9AC")]
			[FieldOffset(Offset = "0x18")]
			public uint taskId;

			// Token: 0x0400B9AD RID: 47533
			[Token(Token = "0x400B9AD")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<VeteranTaskInfo> <>9__1;
		}
	}
}
