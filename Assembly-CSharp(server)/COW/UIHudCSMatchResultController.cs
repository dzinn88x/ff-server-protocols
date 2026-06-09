using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015CC RID: 5580
	[Token(Token = "0x20015CC")]
	internal class UIHudCSMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062DE RID: 25310 RVA: 0x0001C740 File Offset: 0x0001A940
		[Token(Token = "0x60062DE")]
		[Address(RVA = "0x19C0C5C", Offset = "0x19C0C5C", VA = "0x7BBC1C0C5C")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DF")]
		[Address(RVA = "0x19C0CAC", Offset = "0x19C0CAC", VA = "0x7BBC1C0CAC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x0001C758 File Offset: 0x0001A958
		[Token(Token = "0x60062E0")]
		[Address(RVA = "0x19C0CD8", Offset = "0x19C0CD8", VA = "0x7BBC1C0CD8", Slot = "40")]
		protected override int SortPlayerData(PlayerData player1, PlayerData player2)
		{
			return 0;
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x0001C770 File Offset: 0x0001A970
		[Token(Token = "0x60062E1")]
		[Address(RVA = "0x19C0D34", Offset = "0x19C0D34", VA = "0x7BBC1C0D34", Slot = "41")]
		protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
		{
			return 0;
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E2")]
		[Address(RVA = "0x19C0D90", Offset = "0x19C0D90", VA = "0x7BBC1C0D90")]
		public UIHudCSMatchResultController()
		{
		}
	}
}
