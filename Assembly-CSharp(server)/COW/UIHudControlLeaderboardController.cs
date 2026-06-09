using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200209F RID: 8351
	[Token(Token = "0x200209F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDC04", Offset = "0x10FDC04")]
	internal class UIHudControlLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
	{
		// Token: 0x0600BBCC RID: 48076 RVA: 0x00035238 File Offset: 0x00033438
		[Token(Token = "0x600BBCC")]
		[Address(RVA = "0x1A920E4", Offset = "0x1A920E4", VA = "0x7BBC2920E4")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCD")]
		[Address(RVA = "0x1A92134", Offset = "0x1A92134", VA = "0x7BBC292134", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCE")]
		[Address(RVA = "0x1A921B4", Offset = "0x1A921B4", VA = "0x7BBC2921B4", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCF")]
		[Address(RVA = "0x1A922AC", Offset = "0x1A922AC", VA = "0x7BBC2922AC", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD0")]
		[Address(RVA = "0x1A924DC", Offset = "0x1A924DC", VA = "0x7BBC2924DC", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD1")]
		[Address(RVA = "0x1A9270C", Offset = "0x1A9270C", VA = "0x7BBC29270C")]
		private void OnSyncLeaderBoard(object[] data)
		{
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD2")]
		[Address(RVA = "0x1A92A18", Offset = "0x1A92A18", VA = "0x7BBC292A18")]
		private void OnCSNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD3")]
		[Address(RVA = "0x1A92ACC", Offset = "0x1A92ACC", VA = "0x7BBC292ACC")]
		private void OnToggleRoundInfo(params object[] parap)
		{
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD4")]
		[Address(RVA = "0x1A92B28", Offset = "0x1A92B28", VA = "0x7BBC292B28")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD5")]
		[Address(RVA = "0x1A92BE4", Offset = "0x1A92BE4", VA = "0x7BBC292BE4")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD6")]
		[Address(RVA = "0x1A92C5C", Offset = "0x1A92C5C", VA = "0x7BBC292C5C")]
		public UIHudControlLeaderboardController()
		{
		}
	}
}
