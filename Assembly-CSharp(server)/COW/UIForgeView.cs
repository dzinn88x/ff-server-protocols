using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F6 RID: 8694
	[Token(Token = "0x20021F6")]
	public class UIForgeView : UIBaseView
	{
		// Token: 0x0600BEFD RID: 48893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEFD")]
		[Address(RVA = "0x1DBF4E8", Offset = "0x1DBF4E8", VA = "0x7BBC5BF4E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEFE RID: 48894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEFE")]
		[Address(RVA = "0x1DBF9B0", Offset = "0x1DBF9B0", VA = "0x7BBC5BF9B0")]
		public UIForgeView()
		{
		}

		// Token: 0x0400CD6F RID: 52591
		[Token(Token = "0x400CD6F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400CD70 RID: 52592
		[Token(Token = "0x400CD70")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget PreviewRightContainer;

		// Token: 0x0400CD71 RID: 52593
		[Token(Token = "0x400CD71")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400CD72 RID: 52594
		[Token(Token = "0x400CD72")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Toggles;

		// Token: 0x0400CD73 RID: 52595
		[Token(Token = "0x400CD73")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ToggleScrollView;

		// Token: 0x0400CD74 RID: 52596
		[Token(Token = "0x400CD74")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton Toggle;

		// Token: 0x0400CD75 RID: 52597
		[Token(Token = "0x400CD75")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid ToggleGrid;

		// Token: 0x0400CD76 RID: 52598
		[Token(Token = "0x400CD76")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButtonGroup ToggleGroup;

		// Token: 0x0400CD77 RID: 52599
		[Token(Token = "0x400CD77")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView ItemScrollView;

		// Token: 0x0400CD78 RID: 52600
		[Token(Token = "0x400CD78")]
		[FieldOffset(Offset = "0x68")]
		public UIEasyList Grid;

		// Token: 0x0400CD79 RID: 52601
		[Token(Token = "0x400CD79")]
		[FieldOffset(Offset = "0x70")]
		public UIButton ExchangeBtn;

		// Token: 0x0400CD7A RID: 52602
		[Token(Token = "0x400CD7A")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BuyBtnBG;

		// Token: 0x0400CD7B RID: 52603
		[Token(Token = "0x400CD7B")]
		[FieldOffset(Offset = "0x80")]
		public UISprite ExchangeIcon;

		// Token: 0x0400CD7C RID: 52604
		[Token(Token = "0x400CD7C")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ExchangeBtnLabel;

		// Token: 0x0400CD7D RID: 52605
		[Token(Token = "0x400CD7D")]
		[FieldOffset(Offset = "0x90")]
		public UILabel LabelLimitedCount;

		// Token: 0x0400CD7E RID: 52606
		[Token(Token = "0x400CD7E")]
		[FieldOffset(Offset = "0x98")]
		public UITable NotEnoughMaterial;

		// Token: 0x0400CD7F RID: 52607
		[Token(Token = "0x400CD7F")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite NotEnoughMaterial1;

		// Token: 0x0400CD80 RID: 52608
		[Token(Token = "0x400CD80")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite NotEnoughMaterial2;
	}
}
