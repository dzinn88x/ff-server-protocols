using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200258A RID: 9610
	[Token(Token = "0x200258A")]
	internal class UIVeteranView : UIBaseView
	{
		// Token: 0x0600C624 RID: 50724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C624")]
		[Address(RVA = "0x16838FC", Offset = "0x16838FC", VA = "0x7BBBE838FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C625 RID: 50725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C625")]
		[Address(RVA = "0x1683B70", Offset = "0x1683B70", VA = "0x7BBBE83B70")]
		public UIVeteranView()
		{
		}

		// Token: 0x0400F725 RID: 63269
		[Token(Token = "0x400F725")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ContentBG;

		// Token: 0x0400F726 RID: 63270
		[Token(Token = "0x400F726")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentBGWide;

		// Token: 0x0400F727 RID: 63271
		[Token(Token = "0x400F727")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButtonGroup TopTabGroup;

		// Token: 0x0400F728 RID: 63272
		[Token(Token = "0x400F728")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid Tabs;

		// Token: 0x0400F729 RID: 63273
		[Token(Token = "0x400F729")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton TopTabTemplate;

		// Token: 0x0400F72A RID: 63274
		[Token(Token = "0x400F72A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SigninRedDot;

		// Token: 0x0400F72B RID: 63275
		[Token(Token = "0x400F72B")]
		[FieldOffset(Offset = "0x50")]
		public UIButton Close;

		// Token: 0x0400F72C RID: 63276
		[Token(Token = "0x400F72C")]
		[FieldOffset(Offset = "0x58")]
		public UICountDownLabel RefreshLabel;
	}
}
