using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002060 RID: 8288
	[Token(Token = "0x2002060")]
	internal class UIADSGameScene : UITeamModeBaseGameScene
	{
		// Token: 0x0600B895 RID: 47253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B895")]
		[Address(RVA = "0x1A38074", Offset = "0x1A38074", VA = "0x7BBC238074", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B896")]
		[Address(RVA = "0x1A38214", Offset = "0x1A38214", VA = "0x7BBC238214", Slot = "27")]
		protected override void OnOpenHudBeginFight()
		{
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B897")]
		[Address(RVA = "0x1A38258", Offset = "0x1A38258", VA = "0x7BBC238258", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B898")]
		[Address(RVA = "0x1A383CC", Offset = "0x1A383CC", VA = "0x7BBC2383CC", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B899")]
		[Address(RVA = "0x1A38540", Offset = "0x1A38540", VA = "0x7BBC238540", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B89A")]
		[Address(RVA = "0x1A385B0", Offset = "0x1A385B0", VA = "0x7BBC2385B0")]
		private void OnADSShowHint(params object[] param)
		{
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B89B")]
		[Address(RVA = "0x1A386A8", Offset = "0x1A386A8", VA = "0x7BBC2386A8")]
		private void OnADSBonusCountdown(params object[] param)
		{
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B89C")]
		[Address(RVA = "0x1A38864", Offset = "0x1A38864", VA = "0x7BBC238864")]
		private void OnSyncBlackMask(params object[] param)
		{
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B89D")]
		[Address(RVA = "0x1A38D60", Offset = "0x1A38D60", VA = "0x7BBC238D60", Slot = "29")]
		protected override void ShowTeamScore(params object[] data)
		{
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B89E")]
		[Address(RVA = "0x1A38E04", Offset = "0x1A38E04", VA = "0x7BBC238E04")]
		public void OnMatchEnd()
		{
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B89F")]
		[Address(RVA = "0x1A390C0", Offset = "0x1A390C0", VA = "0x7BBC2390C0")]
		public UIADSGameScene()
		{
		}

		// Token: 0x0400BA70 RID: 47728
		[Token(Token = "0x400BA70")]
		[FieldOffset(Offset = "0x3E8")]
		private UIHudADSpaceHintController m_HintController;

		// Token: 0x0400BA71 RID: 47729
		[Token(Token = "0x400BA71")]
		[FieldOffset(Offset = "0x3F0")]
		private UIHudADSBonusCountdownController m_BonusCountdownController;

		// Token: 0x0400BA72 RID: 47730
		[Token(Token = "0x400BA72")]
		[FieldOffset(Offset = "0x3F8")]
		private UIHudADSTeamScoreController m_UIHUDTeamScoreBoardController;

		// Token: 0x0400BA73 RID: 47731
		[Token(Token = "0x400BA73")]
		[FieldOffset(Offset = "0x400")]
		private uint showBlackMaskDelayCall;

		// Token: 0x02002061 RID: 8289
		[Token(Token = "0x2002061")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD974", Offset = "0x10FD974")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600B8A0 RID: 47264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8A0")]
			[Address(RVA = "0x1A38D58", Offset = "0x1A38D58", VA = "0x7BBC238D58")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600B8A1 RID: 47265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8A1")]
			[Address(RVA = "0x1A390C8", Offset = "0x1A390C8", VA = "0x7BBC2390C8")]
			internal void <OnSyncBlackMask>b__0()
			{
			}

			// Token: 0x0400BA74 RID: 47732
			[Token(Token = "0x400BA74")]
			[FieldOffset(Offset = "0x10")]
			public Player localPlayer;

			// Token: 0x0400BA75 RID: 47733
			[Token(Token = "0x400BA75")]
			[FieldOffset(Offset = "0x18")]
			public UIADSGameScene <>4__this;
		}
	}
}
