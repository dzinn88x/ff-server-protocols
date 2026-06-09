using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E01 RID: 7681
	[Token(Token = "0x2001E01")]
	public class UIModelClanRace : UIBaseModel
	{
		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x0002D528 File Offset: 0x0002B728
		// (set) Token: 0x0600A7EC RID: 42988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B09")]
		public bool m_HasShowLobbyIconAnimSinceLogin
		{
			[Token(Token = "0x600A7ED")]
			[Address(RVA = "0x210D0E4", Offset = "0x210D0E4", VA = "0x7BBC90D0E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E2C", Offset = "0x1145E2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A7EC")]
			[Address(RVA = "0x210D0D8", Offset = "0x210D0D8", VA = "0x7BBC90D0D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E1C", Offset = "0x1145E1C")]
			set
			{
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x0002D540 File Offset: 0x0002B740
		// (set) Token: 0x0600A7EE RID: 42990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0A")]
		public bool m_HasGetClanRaceInfoSinceLogin
		{
			[Token(Token = "0x600A7EF")]
			[Address(RVA = "0x210D0F8", Offset = "0x210D0F8", VA = "0x7BBC90D0F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E4C", Offset = "0x1145E4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A7EE")]
			[Address(RVA = "0x210D0EC", Offset = "0x210D0EC", VA = "0x7BBC90D0EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E3C", Offset = "0x1145E3C")]
			private set
			{
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600A7F1 RID: 42993 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A7F0 RID: 42992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0B")]
		public CSGetClanRaceInfoRes m_ClanRaceInfo
		{
			[Token(Token = "0x600A7F1")]
			[Address(RVA = "0x210D108", Offset = "0x210D108", VA = "0x7BBC90D108")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E6C", Offset = "0x1145E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A7F0")]
			[Address(RVA = "0x210D100", Offset = "0x210D100", VA = "0x7BBC90D100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E5C", Offset = "0x1145E5C")]
			private set
			{
			}
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x0002D558 File Offset: 0x0002B758
		[Token(Token = "0x600A7F2")]
		[Address(RVA = "0x210D110", Offset = "0x210D110", VA = "0x7BBC90D110", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F3")]
		[Address(RVA = "0x210D118", Offset = "0x210D118", VA = "0x7BBC90D118", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F4")]
		[Address(RVA = "0x210D158", Offset = "0x210D158", VA = "0x7BBC90D158", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F5")]
		[Address(RVA = "0x210D1A8", Offset = "0x210D1A8", VA = "0x7BBC90D1A8")]
		public void ResetClanRaceInfo()
		{
		}

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F6")]
		[Address(RVA = "0x210D23C", Offset = "0x210D23C", VA = "0x7BBC90D23C")]
		public void GetClanRaceInfoNoCalculate()
		{
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F7")]
		[Address(RVA = "0x210D2B0", Offset = "0x210D2B0", VA = "0x7BBC90D2B0")]
		private void RequestClanInfo(Action onFinish)
		{
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F8")]
		[Address(RVA = "0x210D528", Offset = "0x210D528", VA = "0x7BBC90D528")]
		public void GetClanRaceInfo(bool forceUpdate = true)
		{
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7F9")]
		[Address(RVA = "0x210D5C8", Offset = "0x210D5C8", VA = "0x7BBC90D5C8")]
		private void OnGetClanRaceInfo()
		{
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x0002D570 File Offset: 0x0002B770
		[Token(Token = "0x600A7FA")]
		[Address(RVA = "0x210DA24", Offset = "0x210DA24", VA = "0x7BBC90DA24")]
		public bool HasClaimIndividualItem(uint stage)
		{
			return default(bool);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x0002D588 File Offset: 0x0002B788
		[Token(Token = "0x600A7FB")]
		[Address(RVA = "0x210D7FC", Offset = "0x210D7FC", VA = "0x7BBC90D7FC")]
		public bool CanClaimClanItem()
		{
			return default(bool);
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7FC")]
		[Address(RVA = "0x210DC08", Offset = "0x210DC08", VA = "0x7BBC90DC08")]
		public void SetCloseRace()
		{
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		[Token(Token = "0x600A7FD")]
		[Address(RVA = "0x210DC90", Offset = "0x210DC90", VA = "0x7BBC90DC90")]
		public ulong GetOpenEndTime()
		{
			return 0UL;
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7FE")]
		[Address(RVA = "0x210DCCC", Offset = "0x210DCCC", VA = "0x7BBC90DCCC")]
		public string GetWeekTimeFormat()
		{
			return null;
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7FF")]
		[Address(RVA = "0x210DD90", Offset = "0x210DD90", VA = "0x7BBC90DD90")]
		public string GetShortKeyByDayOfWeek(DayOfWeek day)
		{
			return null;
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		[Token(Token = "0x600A800")]
		[Address(RVA = "0x210DB5C", Offset = "0x210DB5C", VA = "0x7BBC90DB5C")]
		public bool GetClaimState(ulong time)
		{
			return default(bool);
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A801")]
		[Address(RVA = "0x210DDF4", Offset = "0x210DDF4", VA = "0x7BBC90DDF4")]
		public void ClaimClanRaceAward()
		{
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		[Token(Token = "0x600A802")]
		[Address(RVA = "0x210E260", Offset = "0x210E260", VA = "0x7BBC90E260")]
		private bool ContainsAttachment()
		{
			return default(bool);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		[Token(Token = "0x600A803")]
		[Address(RVA = "0x210D984", Offset = "0x210D984", VA = "0x7BBC90D984")]
		public uint GetMyPoints()
		{
			return 0U;
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A804")]
		[Address(RVA = "0x210E3BC", Offset = "0x210E3BC", VA = "0x7BBC90E3BC")]
		public void ExchangeAwardWithRP(uint stage)
		{
		}

		// Token: 0x0600A805 RID: 43013 RVA: 0x0002D600 File Offset: 0x0002B800
		[Token(Token = "0x600A805")]
		[Address(RVA = "0x210E708", Offset = "0x210E708", VA = "0x7BBC90E708")]
		private int ChangeTipsNum(int delta = -1)
		{
			return 0;
		}

		// Token: 0x0600A806 RID: 43014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A806")]
		[Address(RVA = "0x210E79C", Offset = "0x210E79C", VA = "0x7BBC90E79C")]
		public UIModelClanRace()
		{
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A807")]
		[Address(RVA = "0x210E824", Offset = "0x210E824", VA = "0x7BBC90E824")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E7C", Offset = "0x1145E7C")]
		private void <GetClanRaceInfoNoCalculate>b__24_0()
		{
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A808")]
		[Address(RVA = "0x210E888", Offset = "0x210E888", VA = "0x7BBC90E888")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E8C", Offset = "0x1145E8C")]
		private void <ClaimClanRaceAward>b__35_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AD8C RID: 44428
		[Token(Token = "0x400AD8C")]
		public const uint PropID_GetClanRaceInfo = 2U;

		// Token: 0x0400AD8D RID: 44429
		[Token(Token = "0x400AD8D")]
		public const uint PropID_ClaimClanRaceAward = 4U;

		// Token: 0x0400AD8E RID: 44430
		[Token(Token = "0x400AD8E")]
		public const uint PropID_ExchangeAwardWithRP = 8U;

		// Token: 0x0400AD8F RID: 44431
		[Token(Token = "0x400AD8F")]
		public const uint PropID_ClaimClanAwardError_NoPermission = 16U;

		// Token: 0x0400AD90 RID: 44432
		[Token(Token = "0x400AD90")]
		public const uint PropID_ClaimClanAwardError_AlreadyClaimed = 32U;

		// Token: 0x0400AD91 RID: 44433
		[Token(Token = "0x400AD91")]
		public const uint PropID_GetClanRaceInfoNoCalculate = 64U;

		// Token: 0x0400AD92 RID: 44434
		[Token(Token = "0x400AD92")]
		[FieldOffset(Offset = "0x18")]
		private bool m_HasCalculateExInfo;

		// Token: 0x0400AD93 RID: 44435
		[Token(Token = "0x400AD93")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FECC", Offset = "0x112FECC")]
		private bool <m_HasShowLobbyIconAnimSinceLogin>k__BackingField;

		// Token: 0x0400AD94 RID: 44436
		[Token(Token = "0x400AD94")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FEDC", Offset = "0x112FEDC")]
		private bool <m_HasGetClanRaceInfoSinceLogin>k__BackingField;

		// Token: 0x0400AD95 RID: 44437
		[Token(Token = "0x400AD95")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FEEC", Offset = "0x112FEEC")]
		private CSGetClanRaceInfoRes <m_ClanRaceInfo>k__BackingField;

		// Token: 0x0400AD96 RID: 44438
		[Token(Token = "0x400AD96")]
		[FieldOffset(Offset = "0x28")]
		private WaitingResponseHandler m_WaitingHandler;

		// Token: 0x02001E02 RID: 7682
		[Token(Token = "0x2001E02")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC314", Offset = "0x10FC314")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600A809 RID: 43017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A809")]
			[Address(RVA = "0x210D520", Offset = "0x210D520", VA = "0x7BBC90D520")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x0600A80A RID: 43018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A80A")]
			[Address(RVA = "0x210ED9C", Offset = "0x210ED9C", VA = "0x7BBC90ED9C")]
			internal void <RequestClanInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AD97 RID: 44439
			[Token(Token = "0x400AD97")]
			[FieldOffset(Offset = "0x10")]
			public UIModelClanRace <>4__this;

			// Token: 0x0400AD98 RID: 44440
			[Token(Token = "0x400AD98")]
			[FieldOffset(Offset = "0x18")]
			public Action onFinish;
		}

		// Token: 0x02001E03 RID: 7683
		[Token(Token = "0x2001E03")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC324", Offset = "0x10FC324")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x0600A80B RID: 43019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A80B")]
			[Address(RVA = "0x210DB54", Offset = "0x210DB54", VA = "0x7BBC90DB54")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0600A80C RID: 43020 RVA: 0x0002D618 File Offset: 0x0002B818
			[Token(Token = "0x600A80C")]
			[Address(RVA = "0x210EE98", Offset = "0x210EE98", VA = "0x7BBC90EE98")]
			internal bool <HasClaimIndividualItem>b__0(RaceAwardExchange temp)
			{
				return default(bool);
			}

			// Token: 0x0400AD99 RID: 44441
			[Token(Token = "0x400AD99")]
			[FieldOffset(Offset = "0x10")]
			public uint stage;
		}

		// Token: 0x02001E04 RID: 7684
		[Token(Token = "0x2001E04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC334", Offset = "0x10FC334")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x0600A80D RID: 43021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A80D")]
			[Address(RVA = "0x210E700", Offset = "0x210E700", VA = "0x7BBC90E700")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x0600A80E RID: 43022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A80E")]
			[Address(RVA = "0x210EED4", Offset = "0x210EED4", VA = "0x7BBC90EED4")]
			internal void <ExchangeAwardWithRP>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A80F RID: 43023 RVA: 0x0002D630 File Offset: 0x0002B830
			[Token(Token = "0x600A80F")]
			[Address(RVA = "0x210F3C4", Offset = "0x210F3C4", VA = "0x7BBC90F3C4")]
			internal bool <ExchangeAwardWithRP>b__1(ClanRaceRewardsDesc temp)
			{
				return default(bool);
			}

			// Token: 0x0600A810 RID: 43024 RVA: 0x0002D648 File Offset: 0x0002B848
			[Token(Token = "0x600A810")]
			[Address(RVA = "0x210F400", Offset = "0x210F400", VA = "0x7BBC90F400")]
			internal bool <ExchangeAwardWithRP>b__2(RaceAwardExchange temp)
			{
				return default(bool);
			}

			// Token: 0x0400AD9A RID: 44442
			[Token(Token = "0x400AD9A")]
			[FieldOffset(Offset = "0x10")]
			public UIModelClanRace <>4__this;

			// Token: 0x0400AD9B RID: 44443
			[Token(Token = "0x400AD9B")]
			[FieldOffset(Offset = "0x18")]
			public uint stage;

			// Token: 0x0400AD9C RID: 44444
			[Token(Token = "0x400AD9C")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<ClanRaceRewardsDesc> <>9__1;

			// Token: 0x0400AD9D RID: 44445
			[Token(Token = "0x400AD9D")]
			[FieldOffset(Offset = "0x28")]
			public Predicate<RaceAwardExchange> <>9__2;
		}
	}
}
