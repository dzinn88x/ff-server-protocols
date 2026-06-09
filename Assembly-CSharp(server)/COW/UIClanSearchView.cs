using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200216F RID: 8559
	[Token(Token = "0x200216F")]
	internal class UIClanSearchView : UIBaseView
	{
		// Token: 0x0600BDEE RID: 48622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEE")]
		[Address(RVA = "0x1D02328", Offset = "0x1D02328", VA = "0x7BBC502328", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDEF RID: 48623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEF")]
		[Address(RVA = "0x1D028F0", Offset = "0x1D028F0", VA = "0x7BBC5028F0")]
		public UIClanSearchView()
		{
		}

		// Token: 0x0400C635 RID: 50741
		[Token(Token = "0x400C635")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400C636 RID: 50742
		[Token(Token = "0x400C636")]
		[FieldOffset(Offset = "0x28")]
		public UIButton LeftBtn;

		// Token: 0x0400C637 RID: 50743
		[Token(Token = "0x400C637")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LeftSprite;

		// Token: 0x0400C638 RID: 50744
		[Token(Token = "0x400C638")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RightBtn;

		// Token: 0x0400C639 RID: 50745
		[Token(Token = "0x400C639")]
		[FieldOffset(Offset = "0x40")]
		public UISprite RightSprite;

		// Token: 0x0400C63A RID: 50746
		[Token(Token = "0x400C63A")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SlogonLabel;

		// Token: 0x0400C63B RID: 50747
		[Token(Token = "0x400C63B")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView ListScrollView;

		// Token: 0x0400C63C RID: 50748
		[Token(Token = "0x400C63C")]
		[FieldOffset(Offset = "0x58")]
		public UIEasyList ListGrid;

		// Token: 0x0400C63D RID: 50749
		[Token(Token = "0x400C63D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Result;

		// Token: 0x0400C63E RID: 50750
		[Token(Token = "0x400C63E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SearchBarContainer;

		// Token: 0x0400C63F RID: 50751
		[Token(Token = "0x400C63F")]
		[FieldOffset(Offset = "0x70")]
		public UIButton RefreshBtn;

		// Token: 0x0400C640 RID: 50752
		[Token(Token = "0x400C640")]
		[FieldOffset(Offset = "0x78")]
		public UILabel RefreshTxt;

		// Token: 0x0400C641 RID: 50753
		[Token(Token = "0x400C641")]
		[FieldOffset(Offset = "0x80")]
		public UICountDownLabel CountDownTxt;

		// Token: 0x0400C642 RID: 50754
		[Token(Token = "0x400C642")]
		[FieldOffset(Offset = "0x88")]
		public UIInput SearchInput;

		// Token: 0x0400C643 RID: 50755
		[Token(Token = "0x400C643")]
		[FieldOffset(Offset = "0x90")]
		public UIButton SearchBtn;

		// Token: 0x0400C644 RID: 50756
		[Token(Token = "0x400C644")]
		[FieldOffset(Offset = "0x98")]
		public UISprite SearchBtnSprite;

		// Token: 0x0400C645 RID: 50757
		[Token(Token = "0x400C645")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton ClearBtn;

		// Token: 0x0400C646 RID: 50758
		[Token(Token = "0x400C646")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton FilterBtn;

		// Token: 0x0400C647 RID: 50759
		[Token(Token = "0x400C647")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel FilterCDLabel;

		// Token: 0x0400C648 RID: 50760
		[Token(Token = "0x400C648")]
		[FieldOffset(Offset = "0xB8")]
		public UIWidget FilterBG;

		// Token: 0x0400C649 RID: 50761
		[Token(Token = "0x400C649")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel FilterLabel;

		// Token: 0x0400C64A RID: 50762
		[Token(Token = "0x400C64A")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject FilterIcon;

		// Token: 0x0400C64B RID: 50763
		[Token(Token = "0x400C64B")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton ClanCreate;
	}
}
