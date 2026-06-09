using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02002012 RID: 8210
	[Token(Token = "0x2002012")]
	public class UIModelSuperFighter : UIBaseModel, IBigEventModel
	{
		// Token: 0x0600B6D3 RID: 46803 RVA: 0x00034260 File Offset: 0x00032460
		[Token(Token = "0x600B6D3")]
		[Address(RVA = "0x2308DA0", Offset = "0x2308DA0", VA = "0x7BBCB08DA0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D4")]
		[Address(RVA = "0x2308DA8", Offset = "0x2308DA8", VA = "0x7BBCB08DA8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D5")]
		[Address(RVA = "0x2308E54", Offset = "0x2308E54", VA = "0x7BBCB08E54", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D6")]
		[Address(RVA = "0x2308E58", Offset = "0x2308E58", VA = "0x7BBCB08E58")]
		public void RequestSetting()
		{
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D7")]
		[Address(RVA = "0x2308FCC", Offset = "0x2308FCC", VA = "0x7BBCB08FCC")]
		public void RequestStateInfo(bool force = false)
		{
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D8")]
		[Address(RVA = "0x23091F0", Offset = "0x23091F0", VA = "0x7BBCB091F0")]
		public void RequestAttack(ELimitedEvent.SuperFighterManner manner)
		{
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x00034278 File Offset: 0x00032478
		[Token(Token = "0x600B6D9")]
		[Address(RVA = "0x2309378", Offset = "0x2309378", VA = "0x7BBCB09378")]
		public uint GetToken1Id()
		{
			return 0U;
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x00034290 File Offset: 0x00032490
		[Token(Token = "0x600B6DA")]
		[Address(RVA = "0x2309390", Offset = "0x2309390", VA = "0x7BBCB09390")]
		public uint GetToken2Id()
		{
			return 0U;
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6DB")]
		[Address(RVA = "0x23093A8", Offset = "0x23093A8", VA = "0x7BBCB093A8")]
		public string GetWebUrl()
		{
			return null;
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x000342A8 File Offset: 0x000324A8
		[Token(Token = "0x600B6DC")]
		[Address(RVA = "0x230940C", Offset = "0x230940C", VA = "0x7BBCB0940C")]
		public bool IsDuringWebEvent()
		{
			return default(bool);
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x000342C0 File Offset: 0x000324C0
		[Token(Token = "0x600B6DD")]
		[Address(RVA = "0x2309494", Offset = "0x2309494", VA = "0x7BBCB09494")]
		public bool IsMissionOpen()
		{
			return default(bool);
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x000342D8 File Offset: 0x000324D8
		[Token(Token = "0x600B6DE")]
		[Address(RVA = "0x230952C", Offset = "0x230952C", VA = "0x7BBCB0952C")]
		public bool IsMissionClosed()
		{
			return default(bool);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x000342F0 File Offset: 0x000324F0
		[Token(Token = "0x600B6DF")]
		[Address(RVA = "0x23095D4", Offset = "0x23095D4", VA = "0x7BBCB095D4")]
		public uint GetTotalRounds()
		{
			return 0U;
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E0")]
		[Address(RVA = "0x23095EC", Offset = "0x23095EC", VA = "0x7BBCB095EC")]
		public List<uint> GetSmallAwardList()
		{
			return null;
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E1")]
		[Address(RVA = "0x2309778", Offset = "0x2309778", VA = "0x7BBCB09778")]
		public string GetTitleCDN()
		{
			return null;
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E2")]
		[Address(RVA = "0x2309820", Offset = "0x2309820", VA = "0x7BBCB09820")]
		public string GetBigAwardCDN()
		{
			return null;
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E3")]
		[Address(RVA = "0x23098C8", Offset = "0x23098C8", VA = "0x7BBCB098C8")]
		public SuperFighterEnemyDesc GetCurRoundDesc()
		{
			return null;
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E4")]
		[Address(RVA = "0x23098E0", Offset = "0x23098E0", VA = "0x7BBCB098E0")]
		private SuperFighterEnemyDesc GetRoundDesc(int stage)
		{
			return null;
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E5")]
		[Address(RVA = "0x230997C", Offset = "0x230997C", VA = "0x7BBCB0997C")]
		public SuperFighterBoxingDesc GetBoxingDesc(int mannerId)
		{
			return null;
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6E6")]
		[Address(RVA = "0x2309A18", Offset = "0x2309A18", VA = "0x7BBCB09A18")]
		public CSAccountSuperFighterInfo GetStateInfo()
		{
			return null;
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E7")]
		[Address(RVA = "0x2309A20", Offset = "0x2309A20", VA = "0x7BBCB09A20")]
		public void SetPeakDayTips()
		{
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E8")]
		[Address(RVA = "0x2309BCC", Offset = "0x2309BCC", VA = "0x7BBCB09BCC")]
		public void SetMissionTips()
		{
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E9")]
		[Address(RVA = "0x2309F90", Offset = "0x2309F90", VA = "0x7BBCB09F90")]
		public UIModelSuperFighter()
		{
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6EA")]
		[Address(RVA = "0x230A050", Offset = "0x230A050", VA = "0x7BBCB0A050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114765C", Offset = "0x114765C")]
		private void <RequestSetting>b__13_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6EB")]
		[Address(RVA = "0x230A2E4", Offset = "0x230A2E4", VA = "0x7BBCB0A2E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114766C", Offset = "0x114766C")]
		private void <RequestAttack>b__15_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B8CF RID: 47311
		[Token(Token = "0x400B8CF")]
		[FieldOffset(Offset = "0x18")]
		private SuperFighterSettingDesc m_SettingDesc;

		// Token: 0x0400B8D0 RID: 47312
		[Token(Token = "0x400B8D0")]
		[FieldOffset(Offset = "0x20")]
		private List<SuperFighterBoxingDesc> m_BoxingDescs;

		// Token: 0x0400B8D1 RID: 47313
		[Token(Token = "0x400B8D1")]
		[FieldOffset(Offset = "0x28")]
		private List<SuperFighterEnemyDesc> m_RoundDescs;

		// Token: 0x0400B8D2 RID: 47314
		[Token(Token = "0x400B8D2")]
		[FieldOffset(Offset = "0x30")]
		private CSAccountSuperFighterInfo m_StateInfo;

		// Token: 0x0400B8D3 RID: 47315
		[Token(Token = "0x400B8D3")]
		[FieldOffset(Offset = "0x38")]
		private bool m_NeedFetchStateInfo;

		// Token: 0x0400B8D4 RID: 47316
		[Token(Token = "0x400B8D4")]
		public const int BIG_AWARD_CDN_TYPE = 11001;

		// Token: 0x0400B8D5 RID: 47317
		[Token(Token = "0x400B8D5")]
		public const int TITLE_CDN_TYPE = 11002;

		// Token: 0x0400B8D6 RID: 47318
		[Token(Token = "0x400B8D6")]
		public const int PropID_StateInfoUpdate = 2;

		// Token: 0x0400B8D7 RID: 47319
		[Token(Token = "0x400B8D7")]
		public const int PropID_StateInfoUpdateFailed = 4;

		// Token: 0x0400B8D8 RID: 47320
		[Token(Token = "0x400B8D8")]
		public const int PropID_AfterOneRound = 8;

		// Token: 0x02002013 RID: 8211
		[Token(Token = "0x2002013")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD7A4", Offset = "0x10FD7A4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B6ED RID: 46829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6ED")]
			[Address(RVA = "0x230A550", Offset = "0x230A550", VA = "0x7BBCB0A550")]
			public <>c()
			{
			}

			// Token: 0x0600B6EE RID: 46830 RVA: 0x00034308 File Offset: 0x00032508
			[Token(Token = "0x600B6EE")]
			[Address(RVA = "0x230A558", Offset = "0x230A558", VA = "0x7BBCB0A558")]
			internal int <RequestSetting>b__13_1(SuperFighterBoxingDesc desc1, SuperFighterBoxingDesc desc2)
			{
				return 0;
			}

			// Token: 0x0600B6EF RID: 46831 RVA: 0x00034320 File Offset: 0x00032520
			[Token(Token = "0x600B6EF")]
			[Address(RVA = "0x230A644", Offset = "0x230A644", VA = "0x7BBCB0A644")]
			internal int <RequestSetting>b__13_2(SuperFighterEnemyDesc desc1, SuperFighterEnemyDesc desc2)
			{
				return 0;
			}

			// Token: 0x0400B8D9 RID: 47321
			[Token(Token = "0x400B8D9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelSuperFighter.<>c <>9;

			// Token: 0x0400B8DA RID: 47322
			[Token(Token = "0x400B8DA")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<SuperFighterBoxingDesc> <>9__13_1;

			// Token: 0x0400B8DB RID: 47323
			[Token(Token = "0x400B8DB")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<SuperFighterEnemyDesc> <>9__13_2;
		}

		// Token: 0x02002014 RID: 8212
		[Token(Token = "0x2002014")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD7B4", Offset = "0x10FD7B4")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600B6F0 RID: 46832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6F0")]
			[Address(RVA = "0x23091E8", Offset = "0x23091E8", VA = "0x7BBCB091E8")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600B6F1 RID: 46833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6F1")]
			[Address(RVA = "0x230A68C", Offset = "0x230A68C", VA = "0x7BBCB0A68C")]
			internal void <RequestStateInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B8DC RID: 47324
			[Token(Token = "0x400B8DC")]
			[FieldOffset(Offset = "0x10")]
			public UIModelSuperFighter <>4__this;

			// Token: 0x0400B8DD RID: 47325
			[Token(Token = "0x400B8DD")]
			[FieldOffset(Offset = "0x18")]
			public bool force;
		}
	}
}
