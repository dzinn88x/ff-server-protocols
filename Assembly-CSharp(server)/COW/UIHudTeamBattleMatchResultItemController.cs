using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015FA RID: 5626
	[Token(Token = "0x20015FA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF814", Offset = "0x10EF814")]
	public class UIHudTeamBattleMatchResultItemController : UIHudMatchResultItemBaseController
	{
		// Token: 0x06006467 RID: 25703 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
		[Token(Token = "0x6006467")]
		[Address(RVA = "0x167FDF0", Offset = "0x167FDF0", VA = "0x7BBBE7FDF0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006468")]
		[Address(RVA = "0x167FE40", Offset = "0x167FE40", VA = "0x7BBBE7FE40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006469")]
		[Address(RVA = "0x1680070", Offset = "0x1680070", VA = "0x7BBBE80070", Slot = "34")]
		protected override void OnSetPlayerData(TeammateStats data)
		{
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646A")]
		[Address(RVA = "0x1680120", Offset = "0x1680120", VA = "0x7BBBE80120")]
		private void UpdatePlayerData(TeammateStats player)
		{
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646B")]
		[Address(RVA = "0x1680518", Offset = "0x1680518", VA = "0x7BBBE80518")]
		public UIHudTeamBattleMatchResultItemController()
		{
		}

		// Token: 0x040082DF RID: 33503
		[Token(Token = "0x40082DF")]
		[FieldOffset(Offset = "0x100")]
		private UIHudTeamBattleMatchResultItemView m_View;
	}
}
