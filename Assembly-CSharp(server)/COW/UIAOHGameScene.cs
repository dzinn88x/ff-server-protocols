using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002062 RID: 8290
	[Token(Token = "0x2002062")]
	internal class UIAOHGameScene : UITeamModeBaseGameScene
	{
		// Token: 0x0600B8A2 RID: 47266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A2")]
		[Address(RVA = "0x1A39198", Offset = "0x1A39198", VA = "0x7BBC239198", Slot = "27")]
		protected override void OnOpenHudBeginFight()
		{
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A3")]
		[Address(RVA = "0x1A391DC", Offset = "0x1A391DC", VA = "0x7BBC2391DC", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A4")]
		[Address(RVA = "0x1A393B0", Offset = "0x1A393B0", VA = "0x7BBC2393B0", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A5")]
		[Address(RVA = "0x1A3947C", Offset = "0x1A3947C", VA = "0x7BBC23947C", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B8A6 RID: 47270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A6")]
		[Address(RVA = "0x1A39548", Offset = "0x1A39548", VA = "0x7BBC239548", Slot = "29")]
		protected override void ShowTeamScore(params object[] data)
		{
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A7")]
		[Address(RVA = "0x1A395EC", Offset = "0x1A395EC", VA = "0x7BBC2395EC")]
		private void OnShowEscortInfo(params object[] param)
		{
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8A8")]
		[Address(RVA = "0x1A397E8", Offset = "0x1A397E8", VA = "0x7BBC2397E8", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8A9")]
		[Address(RVA = "0x1A39858", Offset = "0x1A39858", VA = "0x7BBC239858")]
		public UIAOHGameScene()
		{
		}

		// Token: 0x0400BA76 RID: 47734
		[Token(Token = "0x400BA76")]
		[FieldOffset(Offset = "0x3E8")]
		private UIHudAOHTeamScoreController m_UIHUDTeamScoreBoardController;

		// Token: 0x0400BA77 RID: 47735
		[Token(Token = "0x400BA77")]
		[FieldOffset(Offset = "0x3F0")]
		private UIHudGameShowInfoController m_ShowInfoCtrl;

		// Token: 0x0400BA78 RID: 47736
		[Token(Token = "0x400BA78")]
		[FieldOffset(Offset = "0x3F8")]
		private UIHUDAOHKillPointsController m_KillPoints;

		// Token: 0x0400BA79 RID: 47737
		[Token(Token = "0x400BA79")]
		[FieldOffset(Offset = "0x400")]
		private UIHudAOHLevelUpHintController m_LevelUpHint;
	}
}
