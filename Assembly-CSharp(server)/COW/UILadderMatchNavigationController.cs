using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001530 RID: 5424
	[Token(Token = "0x2001530")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE394", Offset = "0x10EE394")]
	public class UILadderMatchNavigationController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06005D7A RID: 23930 RVA: 0x0001B240 File Offset: 0x00019440
		[Token(Token = "0x6005D7A")]
		[Address(RVA = "0x1E8A564", Offset = "0x1E8A564", VA = "0x7BBC68A564")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x0001B258 File Offset: 0x00019458
		[Token(Token = "0x6005D7B")]
		[Address(RVA = "0x1E8A5B4", Offset = "0x1E8A5B4", VA = "0x7BBC68A5B4", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7C")]
		[Address(RVA = "0x1E8A5BC", Offset = "0x1E8A5BC", VA = "0x7BBC68A5BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0x1E8B154", Offset = "0x1E8B154", VA = "0x7BBC68B154")]
		private void OnSelectLadderMatch(f ladderMatchType)
		{
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0x1E8BAC4", Offset = "0x1E8BAC4", VA = "0x7BBC68BAC4")]
		private void SetSeasonCdnBg()
		{
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7F")]
		[Address(RVA = "0x1E8C2FC", Offset = "0x1E8C2FC", VA = "0x7BBC68C2FC")]
		private void OnViewAllBtnClicked()
		{
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D80")]
		[Address(RVA = "0x1E8C578", Offset = "0x1E8C578", VA = "0x7BBC68C578")]
		private void OnBtnRewardDetailClick()
		{
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D81")]
		[Address(RVA = "0x1E8C7FC", Offset = "0x1E8C7FC", VA = "0x7BBC68C7FC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D82")]
		[Address(RVA = "0x1E8C908", Offset = "0x1E8C908", VA = "0x7BBC68C908")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D83")]
		[Address(RVA = "0x1E8CAE0", Offset = "0x1E8CAE0", VA = "0x7BBC68CAE0", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D84")]
		[Address(RVA = "0x1E8CDBC", Offset = "0x1E8CDBC", VA = "0x7BBC68CDBC", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D85")]
		[Address(RVA = "0x1E8CDC4", Offset = "0x1E8CDC4", VA = "0x7BBC68CDC4")]
		private void OnQuickStartBtn()
		{
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D86")]
		[Address(RVA = "0x1E8D2C8", Offset = "0x1E8D2C8", VA = "0x7BBC68D2C8")]
		private void OnGotoMallExchangeLadderReward()
		{
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D87")]
		[Address(RVA = "0x1E8D368", Offset = "0x1E8D368", VA = "0x7BBC68D368")]
		private void OnViewRankCardListClick()
		{
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D88")]
		[Address(RVA = "0x1E8ADC4", Offset = "0x1E8ADC4", VA = "0x7BBC68ADC4")]
		private void RefreshRankCardState()
		{
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D89")]
		[Address(RVA = "0x1E8D534", Offset = "0x1E8D534", VA = "0x7BBC68D534")]
		private void OnRankCardSelectedChange(params object[] data)
		{
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D8A")]
		[Address(RVA = "0x1E8D8C0", Offset = "0x1E8D8C0", VA = "0x7BBC68D8C0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F9D8", Offset = "0x113F9D8")]
		private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
		{
			return null;
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8B")]
		[Address(RVA = "0x1E8ACB8", Offset = "0x1E8ACB8", VA = "0x7BBC68ACB8")]
		private void RefreshCurrencyCount()
		{
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8C")]
		[Address(RVA = "0x1E8D9A0", Offset = "0x1E8D9A0", VA = "0x7BBC68D9A0", Slot = "39")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x0001B270 File Offset: 0x00019470
		[Token(Token = "0x6005D8D")]
		[Address(RVA = "0x1E8DA64", Offset = "0x1E8DA64", VA = "0x7BBC68DA64", Slot = "40")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8E")]
		[Address(RVA = "0x1E8DAC8", Offset = "0x1E8DAC8", VA = "0x7BBC68DAC8")]
		public UILadderMatchNavigationController()
		{
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8F")]
		[Address(RVA = "0x1E8DAD8", Offset = "0x1E8DAD8", VA = "0x7BBC68DAD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FA3C", Offset = "0x113FA3C")]
		private void <OnUIInit>b__14_0()
		{
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D90")]
		[Address(RVA = "0x1E8DAE0", Offset = "0x1E8DAE0", VA = "0x7BBC68DAE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FA4C", Offset = "0x113FA4C")]
		private void <OnUIInit>b__14_1()
		{
		}

		// Token: 0x04007F19 RID: 32537
		[Token(Token = "0x4007F19")]
		[FieldOffset(Offset = "0xB0")]
		private LadderMatchNavigationView m_View;

		// Token: 0x04007F1A RID: 32538
		[Token(Token = "0x4007F1A")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelLadderMatch m_LadderModelBR;

		// Token: 0x04007F1B RID: 32539
		[Token(Token = "0x4007F1B")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelCSLadderMatch m_LadderModelCS;

		// Token: 0x04007F1C RID: 32540
		[Token(Token = "0x4007F1C")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelInventory m_inventoryModel;

		// Token: 0x04007F1D RID: 32541
		[Token(Token = "0x4007F1D")]
		[FieldOffset(Offset = "0xD0")]
		private RankCard m_SelectedRankCard;

		// Token: 0x04007F1E RID: 32542
		[Token(Token = "0x4007F1E")]
		[FieldOffset(Offset = "0xD8")]
		private UILadderMatchLeaderboardController m_LadderBoardCtrl;

		// Token: 0x04007F1F RID: 32543
		[Token(Token = "0x4007F1F")]
		[FieldOffset(Offset = "0xE0")]
		private UILadderMatchSeasonInfoController m_SeasonInfoCtrl;

		// Token: 0x04007F20 RID: 32544
		[Token(Token = "0x4007F20")]
		[FieldOffset(Offset = "0xE8")]
		private UISeasonStatsController m_SeasonStatsCtrl;

		// Token: 0x04007F21 RID: 32545
		[Token(Token = "0x4007F21")]
		[FieldOffset(Offset = "0xF0")]
		private UILadderMatchSeasonMiniInfoController m_SeasonMiniInfoCtrl;

		// Token: 0x04007F22 RID: 32546
		[Token(Token = "0x4007F22")]
		[FieldOffset(Offset = "0xF8")]
		private UIDailyFirstWinController m_DailyWinCtrl;

		// Token: 0x04007F23 RID: 32547
		[Token(Token = "0x4007F23")]
		[FieldOffset(Offset = "0x100")]
		private f m_LadderMatchType;

		// Token: 0x04007F24 RID: 32548
		[Token(Token = "0x4007F24")]
		[FieldOffset(Offset = "0x104")]
		private UIUtils.ScreenshotType m_CurrentScreenshotType;

		// Token: 0x02001531 RID: 5425
		[Token(Token = "0x2001531")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE3CC", Offset = "0x10EE3CC")]
		private sealed class <SetButtonCoolDown>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005D91 RID: 23953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D91")]
			[Address(RVA = "0x1E8D974", Offset = "0x1E8D974", VA = "0x7BBC68D974")]
			[DebuggerHidden]
			public <SetButtonCoolDown>d__28(int <>1__state)
			{
			}

			// Token: 0x06005D92 RID: 23954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D92")]
			[Address(RVA = "0x1E8DAE8", Offset = "0x1E8DAE8", VA = "0x7BBC68DAE8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005D93 RID: 23955 RVA: 0x0001B288 File Offset: 0x00019488
			[Token(Token = "0x6005D93")]
			[Address(RVA = "0x1E8DAEC", Offset = "0x1E8DAEC", VA = "0x7BBC68DAEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06005D94 RID: 23956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008B0")]
			private object Current
			{
				[Token(Token = "0x6005D94")]
				[Address(RVA = "0x1E8DBC8", Offset = "0x1E8DBC8", VA = "0x7BBC68DBC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005D95 RID: 23957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D95")]
			[Address(RVA = "0x1E8DBD0", Offset = "0x1E8DBD0", VA = "0x7BBC68DBD0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06005D96 RID: 23958 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008B1")]
			private object Current
			{
				[Token(Token = "0x6005D96")]
				[Address(RVA = "0x1E8DC38", Offset = "0x1E8DC38", VA = "0x7BBC68DC38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007F25 RID: 32549
			[Token(Token = "0x4007F25")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007F26 RID: 32550
			[Token(Token = "0x4007F26")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007F27 RID: 32551
			[Token(Token = "0x4007F27")]
			[FieldOffset(Offset = "0x20")]
			public float delayTime;

			// Token: 0x04007F28 RID: 32552
			[Token(Token = "0x4007F28")]
			[FieldOffset(Offset = "0x28")]
			public UILadderMatchNavigationController <>4__this;

			// Token: 0x04007F29 RID: 32553
			[Token(Token = "0x4007F29")]
			[FieldOffset(Offset = "0x30")]
			public UIButton btn;
		}
	}
}
