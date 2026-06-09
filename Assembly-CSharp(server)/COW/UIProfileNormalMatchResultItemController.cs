using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B2A RID: 6954
	[Token(Token = "0x2001B2A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9634", Offset = "0x10F9634")]
	public class UIProfileNormalMatchResultItemController : UIHudMatchResultItemBaseController
	{
		// Token: 0x06009505 RID: 38149 RVA: 0x00027618 File Offset: 0x00025818
		[Token(Token = "0x6009505")]
		[Address(RVA = "0x1FE2D5C", Offset = "0x1FE2D5C", VA = "0x7BBC7E2D5C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009506")]
		[Address(RVA = "0x1FE2DAC", Offset = "0x1FE2DAC", VA = "0x7BBC7E2DAC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009507")]
		[Address(RVA = "0x1FE2EC4", Offset = "0x1FE2EC4", VA = "0x7BBC7E2EC4", Slot = "35")]
		protected override void OnClickAddFriendBtn()
		{
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009508")]
		[Address(RVA = "0x1FE2FAC", Offset = "0x1FE2FAC", VA = "0x7BBC7E2FAC", Slot = "34")]
		protected override void OnSetPlayerData(TeammateStats data)
		{
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009509")]
		[Address(RVA = "0x1FE3084", Offset = "0x1FE3084", VA = "0x7BBC7E3084")]
		private void UpdatePlayerData(TeammateStats player)
		{
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600950A")]
		[Address(RVA = "0x1FE38C8", Offset = "0x1FE38C8", VA = "0x7BBC7E38C8")]
		public UIProfileNormalMatchResultItemController()
		{
		}

		// Token: 0x04009E5F RID: 40543
		[Token(Token = "0x4009E5F")]
		[FieldOffset(Offset = "0x100")]
		private UIProfileNormalMatchResultItemView m_View;
	}
}
