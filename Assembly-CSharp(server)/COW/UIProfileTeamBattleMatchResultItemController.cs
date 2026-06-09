using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B33 RID: 6963
	[Token(Token = "0x2001B33")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9724", Offset = "0x10F9724")]
	public class UIProfileTeamBattleMatchResultItemController : UIHudMatchResultItemBaseController
	{
		// Token: 0x0600957B RID: 38267 RVA: 0x00027888 File Offset: 0x00025A88
		[Token(Token = "0x600957B")]
		[Address(RVA = "0x1FF18E8", Offset = "0x1FF18E8", VA = "0x7BBC7F18E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600957C RID: 38268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600957C")]
		[Address(RVA = "0x1FF1938", Offset = "0x1FF1938", VA = "0x7BBC7F1938", Slot = "35")]
		protected override void OnClickAddFriendBtn()
		{
		}

		// Token: 0x0600957D RID: 38269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600957D")]
		[Address(RVA = "0x1FF1A20", Offset = "0x1FF1A20", VA = "0x7BBC7F1A20", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600957E")]
		[Address(RVA = "0x1FF1C44", Offset = "0x1FF1C44", VA = "0x7BBC7F1C44", Slot = "34")]
		protected override void OnSetPlayerData(TeammateStats data)
		{
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600957F")]
		[Address(RVA = "0x1FF1CF4", Offset = "0x1FF1CF4", VA = "0x7BBC7F1CF4")]
		private void UpdatePlayerData(TeammateStats player)
		{
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009580")]
		[Address(RVA = "0x1FF2104", Offset = "0x1FF2104", VA = "0x7BBC7F2104")]
		public UIProfileTeamBattleMatchResultItemController()
		{
		}

		// Token: 0x04009EAA RID: 40618
		[Token(Token = "0x4009EAA")]
		[FieldOffset(Offset = "0x100")]
		private UIProfileTeamBattleMatchResultItemView m_View;
	}
}
