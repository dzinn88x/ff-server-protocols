using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C6C RID: 7276
	[Token(Token = "0x2001C6C")]
	internal class UISPHudPlayerItem : MonoBehaviour
	{
		// Token: 0x06009E9B RID: 40603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9B")]
		[Address(RVA = "0x1EED878", Offset = "0x1EED878", VA = "0x7BBC6ED878")]
		public void Init()
		{
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9C")]
		[Address(RVA = "0x1EED9F4", Offset = "0x1EED9F4", VA = "0x7BBC6ED9F4")]
		public void SelectedPlayer(Player targetPlayer)
		{
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9D")]
		[Address(RVA = "0x1EEDB14", Offset = "0x1EEDB14", VA = "0x7BBC6EDB14")]
		public void SetUIData(PlayerData data, int height, int index)
		{
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9E")]
		[Address(RVA = "0x1EEE0D8", Offset = "0x1EEE0D8", VA = "0x7BBC6EE0D8")]
		private void OnPlayerClick()
		{
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9F")]
		[Address(RVA = "0x1EEDD1C", Offset = "0x1EEDD1C", VA = "0x7BBC6EDD1C")]
		public void SetPlayerStates(bool isDead)
		{
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA0")]
		[Address(RVA = "0x1EEE200", Offset = "0x1EEE200", VA = "0x7BBC6EE200")]
		public UISPHudPlayerItem()
		{
		}

		// Token: 0x0400A4FE RID: 42238
		[Token(Token = "0x400A4FE")]
		[FieldOffset(Offset = "0x18")]
		public UIWidget Widget;

		// Token: 0x0400A4FF RID: 42239
		[Token(Token = "0x400A4FF")]
		[FieldOffset(Offset = "0x20")]
		public UILabel No;

		// Token: 0x0400A500 RID: 42240
		[Token(Token = "0x400A500")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;

		// Token: 0x0400A501 RID: 42241
		[Token(Token = "0x400A501")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Cnt;

		// Token: 0x0400A502 RID: 42242
		[Token(Token = "0x400A502")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Btn;

		// Token: 0x0400A503 RID: 42243
		[Token(Token = "0x400A503")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DeadMask;

		// Token: 0x0400A504 RID: 42244
		[Token(Token = "0x400A504")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SelectedBG;

		// Token: 0x0400A505 RID: 42245
		[Token(Token = "0x400A505")]
		[FieldOffset(Offset = "0x50")]
		private PlayerData m_PlayerData;
	}
}
