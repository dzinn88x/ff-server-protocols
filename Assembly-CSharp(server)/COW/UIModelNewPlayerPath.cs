using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F7E RID: 8062
	[Token(Token = "0x2001F7E")]
	public class UIModelNewPlayerPath : UIBaseModel
	{
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600B254 RID: 45652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B253 RID: 45651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C00")]
		public CSGetFreshActivityInfoRes NewbieInfos
		{
			[Token(Token = "0x600B254")]
			[Address(RVA = "0x241B728", Offset = "0x241B728", VA = "0x7BBCC1B728")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146B1C", Offset = "0x1146B1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B253")]
			[Address(RVA = "0x241B720", Offset = "0x241B720", VA = "0x7BBCC1B720")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146B0C", Offset = "0x1146B0C")]
			private set
			{
			}
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x00032430 File Offset: 0x00030630
		[Token(Token = "0x600B255")]
		[Address(RVA = "0x241B730", Offset = "0x241B730", VA = "0x7BBCC1B730", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B256")]
		[Address(RVA = "0x241B738", Offset = "0x241B738", VA = "0x7BBCC1B738", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x00032448 File Offset: 0x00030648
		[Token(Token = "0x600B257")]
		[Address(RVA = "0x241B790", Offset = "0x241B790", VA = "0x7BBCC1B790")]
		public bool JudgeIsNewUser()
		{
			return default(bool);
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x00032460 File Offset: 0x00030660
		[Token(Token = "0x600B258")]
		[Address(RVA = "0x241B798", Offset = "0x241B798", VA = "0x7BBCC1B798")]
		public bool JudgeGetNewbieInfo()
		{
			return default(bool);
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x00032478 File Offset: 0x00030678
		[Token(Token = "0x600B259")]
		[Address(RVA = "0x241B7A0", Offset = "0x241B7A0", VA = "0x7BBCC1B7A0")]
		public bool HasShowedTodayItem()
		{
			return default(bool);
		}

		// Token: 0x0600B25A RID: 45658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B25A")]
		[Address(RVA = "0x241B86C", Offset = "0x241B86C", VA = "0x7BBCC1B86C")]
		public void SetShowedTodayItem()
		{
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x00032490 File Offset: 0x00030690
		[Token(Token = "0x600B25B")]
		[Address(RVA = "0x241B930", Offset = "0x241B930", VA = "0x7BBCC1B930")]
		public DayOfWeek ConvertToDayOfWeek(uint day)
		{
			return DayOfWeek.Sunday;
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B25C")]
		[Address(RVA = "0x241B95C", Offset = "0x241B95C", VA = "0x7BBCC1B95C")]
		private void OnGetNewbieInfo()
		{
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B25D")]
		[Address(RVA = "0x241BAAC", Offset = "0x241BAAC", VA = "0x7BBCC1BAAC")]
		public void GetNewbieInfos(bool forceUpdate = true, bool preload = false, bool silence = false)
		{
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B25E")]
		[Address(RVA = "0x241BD50", Offset = "0x241BD50", VA = "0x7BBCC1BD50")]
		public void ClaimReward(uint activityId, bool isDaily = false)
		{
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B25F")]
		[Address(RVA = "0x241C0D4", Offset = "0x241C0D4", VA = "0x7BBCC1C0D4")]
		public void CompleteGuide(uint eventType)
		{
		}

		// Token: 0x0600B260 RID: 45664 RVA: 0x000324A8 File Offset: 0x000306A8
		[Token(Token = "0x600B260")]
		[Address(RVA = "0x241C2FC", Offset = "0x241C2FC", VA = "0x7BBCC1C2FC")]
		public bool CheckNeedUnlock(uint day)
		{
			return default(bool);
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x000324C0 File Offset: 0x000306C0
		[Token(Token = "0x600B261")]
		[Address(RVA = "0x241C31C", Offset = "0x241C31C", VA = "0x7BBCC1C31C")]
		public int GetCertainActivityRedDotCount(uint activityId)
		{
			return 0;
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x000324D8 File Offset: 0x000306D8
		[Token(Token = "0x600B262")]
		[Address(RVA = "0x241BA30", Offset = "0x241BA30", VA = "0x7BBCC1BA30")]
		public int GetTotalRedDotCount()
		{
			return 0;
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x000324F0 File Offset: 0x000306F0
		[Token(Token = "0x600B263")]
		[Address(RVA = "0x241C414", Offset = "0x241C414", VA = "0x7BBCC1C414")]
		public int GetCertainDayRedDotCount(uint day)
		{
			return 0;
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x00032508 File Offset: 0x00030708
		[Token(Token = "0x600B264")]
		[Address(RVA = "0x241C76C", Offset = "0x241C76C", VA = "0x7BBCC1C76C")]
		public bool ExistUnClaimedOrUnFinishedTask()
		{
			return default(bool);
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B265")]
		[Address(RVA = "0x241C974", Offset = "0x241C974", VA = "0x7BBCC1C974")]
		public UIModelNewPlayerPath()
		{
		}

		// Token: 0x0400B55D RID: 46429
		[Token(Token = "0x400B55D")]
		public const uint PropID_GetNewbieInfos = 2U;

		// Token: 0x0400B55E RID: 46430
		[Token(Token = "0x400B55E")]
		public const uint PropID_GetReward = 4U;

		// Token: 0x0400B55F RID: 46431
		[Token(Token = "0x400B55F")]
		public const uint PropID_CompleteGuide = 8U;

		// Token: 0x0400B560 RID: 46432
		[Token(Token = "0x400B560")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113029C", Offset = "0x113029C")]
		private CSGetFreshActivityInfoRes <NewbieInfos>k__BackingField;

		// Token: 0x0400B561 RID: 46433
		[Token(Token = "0x400B561")]
		private const string TODAYPATHITEM_SHOWED_FORMAT = "TodayPathItemShowed{0}";

		// Token: 0x0400B562 RID: 46434
		[Token(Token = "0x400B562")]
		[FieldOffset(Offset = "0x20")]
		private WaitingResponseHandler m_WaitingHandler;

		// Token: 0x0400B563 RID: 46435
		[Token(Token = "0x400B563")]
		[FieldOffset(Offset = "0x28")]
		protected bool m_IsNewUser;

		// Token: 0x0400B564 RID: 46436
		[Token(Token = "0x400B564")]
		[FieldOffset(Offset = "0x29")]
		private bool m_GetNewbieSuccess;

		// Token: 0x0400B565 RID: 46437
		[Token(Token = "0x400B565")]
		[FieldOffset(Offset = "0x2A")]
		public bool HaveGetNewbieInfos;

		// Token: 0x0400B566 RID: 46438
		[Token(Token = "0x400B566")]
		[FieldOffset(Offset = "0x2B")]
		private bool m_PreloadNewbieInfo;

		// Token: 0x02001F7F RID: 8063
		[Token(Token = "0x2001F7F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD304", Offset = "0x10FD304")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x0600B266 RID: 45670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B266")]
			[Address(RVA = "0x241BD48", Offset = "0x241BD48", VA = "0x7BBCC1BD48")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x0600B267 RID: 45671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B267")]
			[Address(RVA = "0x241CB24", Offset = "0x241CB24", VA = "0x7BBCC1CB24")]
			internal void <GetNewbieInfos>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B567 RID: 46439
			[Token(Token = "0x400B567")]
			[FieldOffset(Offset = "0x10")]
			public UIModelNewPlayerPath <>4__this;

			// Token: 0x0400B568 RID: 46440
			[Token(Token = "0x400B568")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001F80 RID: 8064
		[Token(Token = "0x2001F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD314", Offset = "0x10FD314")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x0600B268 RID: 45672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B268")]
			[Address(RVA = "0x241C0CC", Offset = "0x241C0CC", VA = "0x7BBCC1C0CC")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x0600B269 RID: 45673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B269")]
			[Address(RVA = "0x241CDD4", Offset = "0x241CDD4", VA = "0x7BBCC1CDD4")]
			internal void <ClaimReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B569 RID: 46441
			[Token(Token = "0x400B569")]
			[FieldOffset(Offset = "0x10")]
			public UIModelNewPlayerPath <>4__this;

			// Token: 0x0400B56A RID: 46442
			[Token(Token = "0x400B56A")]
			[FieldOffset(Offset = "0x18")]
			public uint activityId;

			// Token: 0x0400B56B RID: 46443
			[Token(Token = "0x400B56B")]
			[FieldOffset(Offset = "0x1C")]
			public bool isDaily;
		}

		// Token: 0x02001F81 RID: 8065
		[Token(Token = "0x2001F81")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD324", Offset = "0x10FD324")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B26B RID: 45675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B26B")]
			[Address(RVA = "0x241CA68", Offset = "0x241CA68", VA = "0x7BBCC1CA68")]
			public <>c()
			{
			}

			// Token: 0x0600B26C RID: 45676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B26C")]
			[Address(RVA = "0x241CA70", Offset = "0x241CA70", VA = "0x7BBCC1CA70")]
			internal CommonRewardItemInfo <ClaimReward>b__22_1(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x0600B26D RID: 45677 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B26D")]
			[Address(RVA = "0x241CA7C", Offset = "0x241CA7C", VA = "0x7BBCC1CA7C")]
			internal CommonRewardItemInfo <ClaimReward>b__22_3(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600B26E RID: 45678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B26E")]
			[Address(RVA = "0x241CA88", Offset = "0x241CA88", VA = "0x7BBCC1CA88")]
			internal void <ClaimReward>b__22_2()
			{
			}

			// Token: 0x0400B56C RID: 46444
			[Token(Token = "0x400B56C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelNewPlayerPath.<>c <>9;

			// Token: 0x0400B56D RID: 46445
			[Token(Token = "0x400B56D")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__22_1;

			// Token: 0x0400B56E RID: 46446
			[Token(Token = "0x400B56E")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__22_3;

			// Token: 0x0400B56F RID: 46447
			[Token(Token = "0x400B56F")]
			[FieldOffset(Offset = "0x18")]
			public static Action <>9__22_2;
		}

		// Token: 0x02001F82 RID: 8066
		[Token(Token = "0x2001F82")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD334", Offset = "0x10FD334")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x0600B26F RID: 45679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B26F")]
			[Address(RVA = "0x241C2F4", Offset = "0x241C2F4", VA = "0x7BBCC1C2F4")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x0600B270 RID: 45680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B270")]
			[Address(RVA = "0x241D430", Offset = "0x241D430", VA = "0x7BBCC1D430")]
			internal void <CompleteGuide>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B570 RID: 46448
			[Token(Token = "0x400B570")]
			[FieldOffset(Offset = "0x10")]
			public UIModelNewPlayerPath <>4__this;

			// Token: 0x0400B571 RID: 46449
			[Token(Token = "0x400B571")]
			[FieldOffset(Offset = "0x18")]
			public uint eventType;
		}

		// Token: 0x02001F83 RID: 8067
		[Token(Token = "0x2001F83")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD344", Offset = "0x10FD344")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600B271 RID: 45681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B271")]
			[Address(RVA = "0x241C40C", Offset = "0x241C40C", VA = "0x7BBCC1C40C")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x0600B272 RID: 45682 RVA: 0x00032520 File Offset: 0x00030720
			[Token(Token = "0x600B272")]
			[Address(RVA = "0x241D530", Offset = "0x241D530", VA = "0x7BBCC1D530")]
			internal bool <GetCertainActivityRedDotCount>b__0(ActivityInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B572 RID: 46450
			[Token(Token = "0x400B572")]
			[FieldOffset(Offset = "0x10")]
			public uint activityId;
		}

		// Token: 0x02001F84 RID: 8068
		[Token(Token = "0x2001F84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD354", Offset = "0x10FD354")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600B273 RID: 45683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B273")]
			[Address(RVA = "0x241C764", Offset = "0x241C764", VA = "0x7BBCC1C764")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0600B274 RID: 45684 RVA: 0x00032538 File Offset: 0x00030738
			[Token(Token = "0x600B274")]
			[Address(RVA = "0x241D56C", Offset = "0x241D56C", VA = "0x7BBCC1D56C")]
			internal bool <GetCertainDayRedDotCount>b__0(ActivityInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B573 RID: 46451
			[Token(Token = "0x400B573")]
			[FieldOffset(Offset = "0x10")]
			public uint subId;
		}

		// Token: 0x02001F85 RID: 8069
		[Token(Token = "0x2001F85")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD364", Offset = "0x10FD364")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x0600B275 RID: 45685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B275")]
			[Address(RVA = "0x241C96C", Offset = "0x241C96C", VA = "0x7BBCC1C96C")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0600B276 RID: 45686 RVA: 0x00032550 File Offset: 0x00030750
			[Token(Token = "0x600B276")]
			[Address(RVA = "0x241D5A8", Offset = "0x241D5A8", VA = "0x7BBCC1D5A8")]
			internal bool <ExistUnClaimedOrUnFinishedTask>b__0(ActivityInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B574 RID: 46452
			[Token(Token = "0x400B574")]
			[FieldOffset(Offset = "0x10")]
			public uint subId;
		}
	}
}
