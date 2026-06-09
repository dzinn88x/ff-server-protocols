using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A6 RID: 8870
	[Token(Token = "0x20022A6")]
	public class UIHudCSEquipItemView : UIBaseView
	{
		// Token: 0x0600C05D RID: 49245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C05D")]
		[Address(RVA = "0x19B93F8", Offset = "0x19B93F8", VA = "0x7BBC1B93F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C05E RID: 49246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C05E")]
		[Address(RVA = "0x19B96D8", Offset = "0x19B96D8", VA = "0x7BBC1B96D8")]
		public UIHudCSEquipItemView()
		{
		}

		// Token: 0x0400D4FB RID: 54523
		[Token(Token = "0x400D4FB")]
		[FieldOffset(Offset = "0x20")]
		public UISprite itemSprite;

		// Token: 0x0400D4FC RID: 54524
		[Token(Token = "0x400D4FC")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton ItemBtn;

		// Token: 0x0400D4FD RID: 54525
		[Token(Token = "0x400D4FD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel name;

		// Token: 0x0400D4FE RID: 54526
		[Token(Token = "0x400D4FE")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HL;

		// Token: 0x0400D4FF RID: 54527
		[Token(Token = "0x400D4FF")]
		[FieldOffset(Offset = "0x40")]
		public UILabel price;

		// Token: 0x0400D500 RID: 54528
		[Token(Token = "0x400D500")]
		[FieldOffset(Offset = "0x48")]
		public GameObject gray;

		// Token: 0x0400D501 RID: 54529
		[Token(Token = "0x400D501")]
		[FieldOffset(Offset = "0x50")]
		public GameObject bonus;

		// Token: 0x0400D502 RID: 54530
		[Token(Token = "0x400D502")]
		[FieldOffset(Offset = "0x58")]
		public UILabel limitation;

		// Token: 0x0400D503 RID: 54531
		[Token(Token = "0x400D503")]
		[FieldOffset(Offset = "0x60")]
		public UISprite qualityBg;

		// Token: 0x0400D504 RID: 54532
		[Token(Token = "0x400D504")]
		[FieldOffset(Offset = "0x68")]
		public GameObject VFX;
	}
}
