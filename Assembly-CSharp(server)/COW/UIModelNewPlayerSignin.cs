using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F86 RID: 8070
	[Token(Token = "0x2001F86")]
	public class UIModelNewPlayerSignin : UIBaseModel
	{
		// Token: 0x0600B277 RID: 45687 RVA: 0x00032568 File Offset: 0x00030768
		[Token(Token = "0x600B277")]
		[Address(RVA = "0x241D5E4", Offset = "0x241D5E4", VA = "0x7BBCC1D5E4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C01")]
		public List<AttendaceItemInfo> NewPlayerSigninRewardsList
		{
			[Token(Token = "0x600B278")]
			[Address(RVA = "0x241D5EC", Offset = "0x241D5EC", VA = "0x7BBCC1D5EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600B279 RID: 45689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C02")]
		public AwardItemInfo CurrentSigninReward
		{
			[Token(Token = "0x600B279")]
			[Address(RVA = "0x241D5F4", Offset = "0x241D5F4", VA = "0x7BBCC1D5F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x00032580 File Offset: 0x00030780
		// (set) Token: 0x0600B27B RID: 45691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C03")]
		public ulong NewPlayerActivityExpireTime
		{
			[Token(Token = "0x600B27A")]
			[Address(RVA = "0x241D5FC", Offset = "0x241D5FC", VA = "0x7BBCC1D5FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146B2C", Offset = "0x1146B2C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B27B")]
			[Address(RVA = "0x241D604", Offset = "0x241D604", VA = "0x7BBCC1D604")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146B3C", Offset = "0x1146B3C")]
			private set
			{
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x00032598 File Offset: 0x00030798
		[Token(Token = "0x17000C04")]
		public DateTimeOffset LastRefreshedTime
		{
			[Token(Token = "0x600B27C")]
			[Address(RVA = "0x241D60C", Offset = "0x241D60C", VA = "0x7BBCC1D60C")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600B27D RID: 45693 RVA: 0x000325B0 File Offset: 0x000307B0
		[Token(Token = "0x17000C05")]
		public bool HaveNewSignin
		{
			[Token(Token = "0x600B27D")]
			[Address(RVA = "0x241D618", Offset = "0x241D618", VA = "0x7BBCC1D618")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x000325C8 File Offset: 0x000307C8
		[Token(Token = "0x600B27E")]
		[Address(RVA = "0x241D620", Offset = "0x241D620", VA = "0x7BBCC1D620")]
		public bool ExitUnSignOrNeedToSign()
		{
			return default(bool);
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x000325E0 File Offset: 0x000307E0
		[Token(Token = "0x600B27F")]
		[Address(RVA = "0x241D774", Offset = "0x241D774", VA = "0x7BBCC1D774")]
		public bool CheckIsNeedRefreshList()
		{
			return default(bool);
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B280")]
		[Address(RVA = "0x241D890", Offset = "0x241D890", VA = "0x7BBCC1D890", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B281")]
		[Address(RVA = "0x241D940", Offset = "0x241D940", VA = "0x7BBCC1D940", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B282")]
		[Address(RVA = "0x241D9BC", Offset = "0x241D9BC", VA = "0x7BBCC1D9BC")]
		public void ProcessNewPlayerRes(CSGetNewPlayerRewardsListRes res)
		{
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B283")]
		[Address(RVA = "0x241DC78", Offset = "0x241DC78", VA = "0x7BBCC1DC78")]
		public void NewPlayerSignin(int signinIndex)
		{
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B284")]
		[Address(RVA = "0x241DFBC", Offset = "0x241DFBC", VA = "0x7BBCC1DFBC")]
		public UIModelNewPlayerSignin()
		{
		}

		// Token: 0x0400B575 RID: 46453
		[Token(Token = "0x400B575")]
		public const uint PropID_NewPlayerSigninRewardLisUpdate = 2U;

		// Token: 0x0400B576 RID: 46454
		[Token(Token = "0x400B576")]
		public const uint PropID_GetReward = 4U;

		// Token: 0x0400B577 RID: 46455
		[Token(Token = "0x400B577")]
		[FieldOffset(Offset = "0x18")]
		private List<AttendaceItemInfo> m_NewPlayerSigninRewardsList;

		// Token: 0x0400B578 RID: 46456
		[Token(Token = "0x400B578")]
		[FieldOffset(Offset = "0x20")]
		private AwardItemInfo m_CurrentSigninReward;

		// Token: 0x0400B579 RID: 46457
		[Token(Token = "0x400B579")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11302AC", Offset = "0x11302AC")]
		private ulong <NewPlayerActivityExpireTime>k__BackingField;

		// Token: 0x0400B57A RID: 46458
		[Token(Token = "0x400B57A")]
		[FieldOffset(Offset = "0x30")]
		private DateTimeOffset m_BeijingLastRefreshedTime;

		// Token: 0x0400B57B RID: 46459
		[Token(Token = "0x400B57B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_HaveNewSignin;

		// Token: 0x0400B57C RID: 46460
		[Token(Token = "0x400B57C")]
		[FieldOffset(Offset = "0x41")]
		private bool m_WaitingForSignResponse;

		// Token: 0x02001F87 RID: 8071
		[Token(Token = "0x2001F87")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD374", Offset = "0x10FD374")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600B285 RID: 45701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B285")]
			[Address(RVA = "0x241DFB4", Offset = "0x241DFB4", VA = "0x7BBCC1DFB4")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x0600B286 RID: 45702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B286")]
			[Address(RVA = "0x241E07C", Offset = "0x241E07C", VA = "0x7BBCC1E07C")]
			internal void <NewPlayerSignin>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B57D RID: 46461
			[Token(Token = "0x400B57D")]
			[FieldOffset(Offset = "0x10")]
			public UIModelNewPlayerSignin <>4__this;

			// Token: 0x0400B57E RID: 46462
			[Token(Token = "0x400B57E")]
			[FieldOffset(Offset = "0x18")]
			public int signinIndex;
		}
	}
}
