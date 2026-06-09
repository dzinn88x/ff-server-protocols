using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200186D RID: 6253
	[Token(Token = "0x200186D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4094", Offset = "0x10F4094")]
	internal class UIHudAOHTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
	{
		// Token: 0x06007B57 RID: 31575 RVA: 0x00021EB8 File Offset: 0x000200B8
		[Token(Token = "0x6007B57")]
		[Address(RVA = "0x1D65164", Offset = "0x1D65164", VA = "0x7BBC565164")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B58")]
		[Address(RVA = "0x1D651B4", Offset = "0x1D651B4", VA = "0x7BBC5651B4", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B59")]
		[Address(RVA = "0x1D653DC", Offset = "0x1D653DC", VA = "0x7BBC5653DC", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x06007B5A RID: 31578 RVA: 0x00021ED0 File Offset: 0x000200D0
		[Token(Token = "0x6007B5A")]
		[Address(RVA = "0x1D65604", Offset = "0x1D65604", VA = "0x7BBC565604", Slot = "29")]
		protected override ResourceID GetTitileResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5B")]
		[Address(RVA = "0x1D65654", Offset = "0x1D65654", VA = "0x7BBC565654", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5C")]
		[Address(RVA = "0x1D656D4", Offset = "0x1D656D4", VA = "0x7BBC5656D4", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5D")]
		[Address(RVA = "0x1D657CC", Offset = "0x1D657CC", VA = "0x7BBC5657CC")]
		protected void OnScoreChanged(params object[] param)
		{
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5E")]
		[Address(RVA = "0x1D65884", Offset = "0x1D65884", VA = "0x7BBC565884")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5F")]
		[Address(RVA = "0x1D65940", Offset = "0x1D65940", VA = "0x7BBC565940")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B60")]
		[Address(RVA = "0x1D659B8", Offset = "0x1D659B8", VA = "0x7BBC5659B8")]
		public UIHudAOHTeamScoreController()
		{
		}
	}
}
