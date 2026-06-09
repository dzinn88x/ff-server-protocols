using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002063 RID: 8291
	[Token(Token = "0x2002063")]
	internal class UIArmsRaceGameScene : UIInGameScene
	{
		// Token: 0x0600B8AA RID: 47274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8AA")]
		[Address(RVA = "0x1B15954", Offset = "0x1B15954", VA = "0x7BBC315954", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600B8AB RID: 47275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8AB")]
		[Address(RVA = "0x1B15C78", Offset = "0x1B15C78", VA = "0x7BBC315C78", Slot = "17")]
		protected override UIHudWeaponInfoController OpenCommonWeaponPanel()
		{
			return null;
		}

		// Token: 0x0600B8AC RID: 47276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8AC")]
		[Address(RVA = "0x1B15CCC", Offset = "0x1B15CCC", VA = "0x7BBC315CCC", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8AD")]
		[Address(RVA = "0x1B15E94", Offset = "0x1B15E94", VA = "0x7BBC315E94", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B8AE RID: 47278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8AE")]
		[Address(RVA = "0x1B1605C", Offset = "0x1B1605C", VA = "0x7BBC31605C", Slot = "15")]
		protected override void CloseAllUIs()
		{
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8AF")]
		[Address(RVA = "0x1B16084", Offset = "0x1B16084", VA = "0x7BBC316084")]
		public void OnArmsListDataReady(params object[] data)
		{
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8B0")]
		[Address(RVA = "0x1B16234", Offset = "0x1B16234", VA = "0x7BBC316234")]
		public void OnIntroInfoDone(params object[] data)
		{
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8B1")]
		[Address(RVA = "0x1B16088", Offset = "0x1B16088", VA = "0x7BBC316088")]
		private void TryShowArmsList()
		{
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x00034CB0 File Offset: 0x00032EB0
		[Token(Token = "0x600B8B2")]
		[Address(RVA = "0x1B16240", Offset = "0x1B16240", VA = "0x7BBC316240", Slot = "18")]
		protected override bool IsNeedDirectionRuler()
		{
			return default(bool);
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x00034CC8 File Offset: 0x00032EC8
		[Token(Token = "0x600B8B3")]
		[Address(RVA = "0x1B16248", Offset = "0x1B16248", VA = "0x7BBC316248", Slot = "19")]
		protected override bool IsNeedQuickSwitchHUD()
		{
			return default(bool);
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x00034CE0 File Offset: 0x00032EE0
		[Token(Token = "0x600B8B4")]
		[Address(RVA = "0x1B16250", Offset = "0x1B16250", VA = "0x7BBC316250", Slot = "20")]
		protected override bool IsNeedMedkitController()
		{
			return default(bool);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x00034CF8 File Offset: 0x00032EF8
		[Token(Token = "0x600B8B5")]
		[Address(RVA = "0x1B16258", Offset = "0x1B16258", VA = "0x7BBC316258", Slot = "21")]
		protected override bool IsNeedSafeZoneInfoController()
		{
			return default(bool);
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8B6")]
		[Address(RVA = "0x1B16260", Offset = "0x1B16260", VA = "0x7BBC316260", Slot = "25")]
		protected override void OnOpenHudInPregame()
		{
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8B7")]
		[Address(RVA = "0x1B16498", Offset = "0x1B16498", VA = "0x7BBC316498", Slot = "27")]
		protected override void OnOpenHudBeginFight()
		{
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8B8")]
		[Address(RVA = "0x1B165FC", Offset = "0x1B165FC", VA = "0x7BBC3165FC")]
		public void OpenScoreBoard()
		{
		}

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8B9")]
		[Address(RVA = "0x1B166A0", Offset = "0x1B166A0", VA = "0x7BBC3166A0", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8BA")]
		[Address(RVA = "0x1B1674C", Offset = "0x1B1674C", VA = "0x7BBC31674C")]
		private void OnBonusCardCome(params object[] data)
		{
		}

		// Token: 0x0600B8BB RID: 47291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8BB")]
		[Address(RVA = "0x1B16844", Offset = "0x1B16844", VA = "0x7BBC316844")]
		private void OnStartMatchEndShow(object[] data)
		{
		}

		// Token: 0x0600B8BC RID: 47292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8BC")]
		[Address(RVA = "0x1B16938", Offset = "0x1B16938", VA = "0x7BBC316938")]
		public UIArmsRaceGameScene()
		{
		}

		// Token: 0x0600B8BD RID: 47293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8BD")]
		[Address(RVA = "0x1B169A0", Offset = "0x1B169A0", VA = "0x7BBC3169A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147938", Offset = "0x1147938")]
		private void <OnOpenHudInPregame>b__19_0()
		{
		}

		// Token: 0x0400BA7A RID: 47738
		[Token(Token = "0x400BA7A")]
		[FieldOffset(Offset = "0x3D0")]
		private UIHudArmsListController m_ArmsListWndCtrl;

		// Token: 0x0400BA7B RID: 47739
		[Token(Token = "0x400BA7B")]
		[FieldOffset(Offset = "0x3D8")]
		private UIHUDArmsRaceMatchInfoController m_UIHUDArmsRaceMatchInfoController;

		// Token: 0x0400BA7C RID: 47740
		[Token(Token = "0x400BA7C")]
		[FieldOffset(Offset = "0x3E0")]
		private UIHUDArmsRaceKillPointsController m_UIHUDArmsRaceKillPointsController;

		// Token: 0x0400BA7D RID: 47741
		[Token(Token = "0x400BA7D")]
		[FieldOffset(Offset = "0x3E8")]
		private UIHUDArmsRaceTeamMatchInfoController m_UIHUDArmsRaceTeamMatchInfoController;

		// Token: 0x0400BA7E RID: 47742
		[Token(Token = "0x400BA7E")]
		[FieldOffset(Offset = "0x3F0")]
		private UIHUDTeamArmsRaceScoreBoardController m_UIHUDTeamArmsRaceScoreBoardController;

		// Token: 0x0400BA7F RID: 47743
		[Token(Token = "0x400BA7F")]
		[FieldOffset(Offset = "0x3F8")]
		private UIHUDArmsRaceBonusCardController m_BonusCardController;

		// Token: 0x0400BA80 RID: 47744
		[Token(Token = "0x400BA80")]
		[FieldOffset(Offset = "0x400")]
		private bool m_IntroInfoDone;
	}
}
