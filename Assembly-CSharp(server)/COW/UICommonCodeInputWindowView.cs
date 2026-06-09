using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200217C RID: 8572
	[Token(Token = "0x200217C")]
	public class UICommonCodeInputWindowView : UIBaseView
	{
		// Token: 0x0600BE08 RID: 48648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE08")]
		[Address(RVA = "0x20B0B68", Offset = "0x20B0B68", VA = "0x7BBC8B0B68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE09 RID: 48649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE09")]
		[Address(RVA = "0x20B0E40", Offset = "0x20B0E40", VA = "0x7BBC8B0E40")]
		public UICommonCodeInputWindowView()
		{
		}

		// Token: 0x0400C777 RID: 51063
		[Token(Token = "0x400C777")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ContentBGWide;

		// Token: 0x0400C778 RID: 51064
		[Token(Token = "0x400C778")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentBG;

		// Token: 0x0400C779 RID: 51065
		[Token(Token = "0x400C779")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400C77A RID: 51066
		[Token(Token = "0x400C77A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelTitle;

		// Token: 0x0400C77B RID: 51067
		[Token(Token = "0x400C77B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel title;

		// Token: 0x0400C77C RID: 51068
		[Token(Token = "0x400C77C")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid codeGrid;

		// Token: 0x0400C77D RID: 51069
		[Token(Token = "0x400C77D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel codeItem;

		// Token: 0x0400C77E RID: 51070
		[Token(Token = "0x400C77E")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid btnGrid;

		// Token: 0x0400C77F RID: 51071
		[Token(Token = "0x400C77F")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButtonGroup btnToggleGroup;

		// Token: 0x0400C780 RID: 51072
		[Token(Token = "0x400C780")]
		[FieldOffset(Offset = "0x68")]
		public GameObject btnItem;
	}
}
