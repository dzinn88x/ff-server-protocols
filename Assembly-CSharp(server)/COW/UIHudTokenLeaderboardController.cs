using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200167E RID: 5758
	[Token(Token = "0x200167E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F039C", Offset = "0x10F039C")]
	internal class UIHudTokenLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
	{
		// Token: 0x06006887 RID: 26759 RVA: 0x0001DA30 File Offset: 0x0001BC30
		[Token(Token = "0x6006887")]
		[Address(RVA = "0x15E6994", Offset = "0x15E6994", VA = "0x7BBBDE6994")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006888")]
		[Address(RVA = "0x15E69E4", Offset = "0x15E69E4", VA = "0x7BBBDE69E4", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006889")]
		[Address(RVA = "0x15E6B6C", Offset = "0x15E6B6C", VA = "0x7BBBDE6B6C", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688A")]
		[Address(RVA = "0x15E6CF4", Offset = "0x15E6CF4", VA = "0x7BBBDE6CF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688B")]
		[Address(RVA = "0x15E6D74", Offset = "0x15E6D74", VA = "0x7BBBDE6D74", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688C")]
		[Address(RVA = "0x15E6E6C", Offset = "0x15E6E6C", VA = "0x7BBBDE6E6C")]
		private void OnTokenPlayerInfoChanged(params object[] param)
		{
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688D")]
		[Address(RVA = "0x15E6FEC", Offset = "0x15E6FEC", VA = "0x7BBBDE6FEC")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688E")]
		[Address(RVA = "0x15E70A8", Offset = "0x15E70A8", VA = "0x7BBBDE70A8")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688F")]
		[Address(RVA = "0x15E7120", Offset = "0x15E7120", VA = "0x7BBBDE7120")]
		public UIHudTokenLeaderboardController()
		{
		}

		// Token: 0x0200167F RID: 5759
		[Token(Token = "0x200167F")]
		public enum InfoType
		{
			// Token: 0x0400854B RID: 34123
			[Token(Token = "0x400854B")]
			TokenCount,
			// Token: 0x0400854C RID: 34124
			[Token(Token = "0x400854C")]
			TotalScore
		}
	}
}
