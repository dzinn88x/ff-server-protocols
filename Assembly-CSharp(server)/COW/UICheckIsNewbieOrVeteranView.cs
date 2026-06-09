using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002158 RID: 8536
	[Token(Token = "0x2002158")]
	public class UICheckIsNewbieOrVeteranView : UIBaseView
	{
		// Token: 0x0600BDC0 RID: 48576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC0")]
		[Address(RVA = "0x1BF22E4", Offset = "0x1BF22E4", VA = "0x7BBC3F22E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC1")]
		[Address(RVA = "0x1BF2520", Offset = "0x1BF2520", VA = "0x7BBC3F2520")]
		public UICheckIsNewbieOrVeteranView()
		{
		}

		// Token: 0x0400C547 RID: 50503
		[Token(Token = "0x400C547")]
		[FieldOffset(Offset = "0x20")]
		public GameObject WindowContainer;

		// Token: 0x0400C548 RID: 50504
		[Token(Token = "0x400C548")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnConfirm;

		// Token: 0x0400C549 RID: 50505
		[Token(Token = "0x400C549")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnNewbie;

		// Token: 0x0400C54A RID: 50506
		[Token(Token = "0x400C54A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BtnNewbieChoosenSprite;

		// Token: 0x0400C54B RID: 50507
		[Token(Token = "0x400C54B")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnVeteran;

		// Token: 0x0400C54C RID: 50508
		[Token(Token = "0x400C54C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BtnVeteranChoosenSprite;

		// Token: 0x0400C54D RID: 50509
		[Token(Token = "0x400C54D")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnMaster;

		// Token: 0x0400C54E RID: 50510
		[Token(Token = "0x400C54E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnMasterChoosenSprite;
	}
}
