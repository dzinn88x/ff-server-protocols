using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200141C RID: 5148
	[Token(Token = "0x200141C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC6C0", Offset = "0x10EC6C0")]
	internal class UIHudADSTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHudADSTeamScoreItemController>
	{
		// Token: 0x060054E1 RID: 21729 RVA: 0x00019560 File Offset: 0x00017760
		[Token(Token = "0x60054E1")]
		[Address(RVA = "0x1D620D8", Offset = "0x1D620D8", VA = "0x7BBC5620D8")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E2")]
		[Address(RVA = "0x1D62128", Offset = "0x1D62128", VA = "0x7BBC562128", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E3")]
		[Address(RVA = "0x1D623A4", Offset = "0x1D623A4", VA = "0x7BBC5623A4", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x00019578 File Offset: 0x00017778
		[Token(Token = "0x60054E4")]
		[Address(RVA = "0x1D62620", Offset = "0x1D62620", VA = "0x7BBC562620", Slot = "29")]
		protected override ResourceID GetTitileResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x1D62670", Offset = "0x1D62670", VA = "0x7BBC562670", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x1D626F0", Offset = "0x1D626F0", VA = "0x7BBC5626F0", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x1D627E8", Offset = "0x1D627E8", VA = "0x7BBC5627E8")]
		protected void OnScoreChanged(params object[] param)
		{
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E8")]
		[Address(RVA = "0x1D628A0", Offset = "0x1D628A0", VA = "0x7BBC5628A0")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E9")]
		[Address(RVA = "0x1D6295C", Offset = "0x1D6295C", VA = "0x7BBC56295C")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EA")]
		[Address(RVA = "0x1D629D4", Offset = "0x1D629D4", VA = "0x7BBC5629D4")]
		private void Refresh1v1PlayerWin(params object[] param)
		{
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EB")]
		[Address(RVA = "0x1D62C2C", Offset = "0x1D62C2C", VA = "0x7BBC562C2C")]
		public UIHudADSTeamScoreController()
		{
		}
	}
}
