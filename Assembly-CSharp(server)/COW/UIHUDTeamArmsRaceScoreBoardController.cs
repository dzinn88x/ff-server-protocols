using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001661 RID: 5729
	[Token(Token = "0x2001661")]
	internal class UIHUDTeamArmsRaceScoreBoardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
	{
		// Token: 0x06006778 RID: 26488 RVA: 0x0001D760 File Offset: 0x0001B960
		[Token(Token = "0x6006778")]
		[Address(RVA = "0x1D4CF74", Offset = "0x1D4CF74", VA = "0x7BBC54CF74")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006779")]
		[Address(RVA = "0x1D4CFC4", Offset = "0x1D4CFC4", VA = "0x7BBC54CFC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677A")]
		[Address(RVA = "0x1D4D014", Offset = "0x1D4D014", VA = "0x7BBC54D014", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677B")]
		[Address(RVA = "0x1D4D01C", Offset = "0x1D4D01C", VA = "0x7BBC54D01C", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677C")]
		[Address(RVA = "0x1D4D2F0", Offset = "0x1D4D2F0", VA = "0x7BBC54D2F0", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x0001D778 File Offset: 0x0001B978
		[Token(Token = "0x600677D")]
		[Address(RVA = "0x1D4D5C4", Offset = "0x1D4D5C4", VA = "0x7BBC54D5C4", Slot = "29")]
		protected override ResourceID GetTitileResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677E")]
		[Address(RVA = "0x1D4D614", Offset = "0x1D4D614", VA = "0x7BBC54D614")]
		private void OnGameArmsListCome(params object[] param)
		{
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677F")]
		[Address(RVA = "0x1D4D7B0", Offset = "0x1D4D7B0", VA = "0x7BBC54D7B0")]
		private void OnSelfArmLevelCome(params object[] param)
		{
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006780")]
		[Address(RVA = "0x1D4D86C", Offset = "0x1D4D86C", VA = "0x7BBC54D86C")]
		private void OnOpponentArmLevelCome(params object[] param)
		{
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006781")]
		[Address(RVA = "0x1D4D698", Offset = "0x1D4D698", VA = "0x7BBC54D698")]
		private void UpdateLeftWeaponIcon()
		{
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006782")]
		[Address(RVA = "0x1D4D724", Offset = "0x1D4D724", VA = "0x7BBC54D724")]
		private void UpdateRightWeaponIcon()
		{
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006783")]
		[Address(RVA = "0x1D4D928", Offset = "0x1D4D928", VA = "0x7BBC54D928")]
		public UIHUDTeamArmsRaceScoreBoardController()
		{
		}

		// Token: 0x040084D5 RID: 34005
		[Token(Token = "0x40084D5")]
		[FieldOffset(Offset = "0x84")]
		private int m_SelfArmLevel;

		// Token: 0x040084D6 RID: 34006
		[Token(Token = "0x40084D6")]
		[FieldOffset(Offset = "0x88")]
		private int m_OpponentArmLevel;
	}
}
