using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001513 RID: 5395
	[Token(Token = "0x2001513")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE11C", Offset = "0x10EE11C")]
	internal class UIHudGiantTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHudADSTeamScoreItemController>
	{
		// Token: 0x06005CB4 RID: 23732 RVA: 0x0001AFA0 File Offset: 0x000191A0
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x1974700", Offset = "0x1974700", VA = "0x7BBC174700")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x1974750", Offset = "0x1974750", VA = "0x7BBC174750", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB6")]
		[Address(RVA = "0x1974A70", Offset = "0x1974A70", VA = "0x7BBC174A70", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x0001AFB8 File Offset: 0x000191B8
		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0x1974D90", Offset = "0x1974D90", VA = "0x7BBC174D90", Slot = "29")]
		protected override ResourceID GetTitileResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0x1974DE0", Offset = "0x1974DE0", VA = "0x7BBC174DE0", Slot = "40")]
		protected virtual void OnEscotTimeChanged(params object[] param)
		{
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0x1974E98", Offset = "0x1974E98", VA = "0x7BBC174E98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0x1974F18", Offset = "0x1974F18", VA = "0x7BBC174F18", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0x1975010", Offset = "0x1975010", VA = "0x7BBC175010")]
		protected void OnScoreChanged(params object[] param)
		{
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x19750C8", Offset = "0x19750C8", VA = "0x7BBC1750C8")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0x19751FC", Offset = "0x19751FC", VA = "0x7BBC1751FC")]
		private void OnCurrentMoveDistanceChanged(params object[] data)
		{
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0x1975370", Offset = "0x1975370", VA = "0x7BBC175370")]
		private void OnLastTeamScoreChanged(params object[] data)
		{
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0x1975184", Offset = "0x1975184", VA = "0x7BBC175184")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x19754E4", Offset = "0x19754E4", VA = "0x7BBC1754E4")]
		private void Refresh1v1PlayerWin(params object[] param)
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x197565C", Offset = "0x197565C", VA = "0x7BBC17565C")]
		public UIHudGiantTeamScoreController()
		{
		}
	}
}
