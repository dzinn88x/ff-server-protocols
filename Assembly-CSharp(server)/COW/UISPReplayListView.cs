using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200254B RID: 9547
	[Token(Token = "0x200254B")]
	internal class UISPReplayListView : UIBaseView
	{
		// Token: 0x0600C5A6 RID: 50598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A6")]
		[Address(RVA = "0x1628EF0", Offset = "0x1628EF0", VA = "0x7BBBE28EF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5A7 RID: 50599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A7")]
		[Address(RVA = "0x162919C", Offset = "0x162919C", VA = "0x7BBBE2919C")]
		public UISPReplayListView()
		{
		}

		// Token: 0x0400F460 RID: 62560
		[Token(Token = "0x400F460")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400F461 RID: 62561
		[Token(Token = "0x400F461")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ListScrollView;

		// Token: 0x0400F462 RID: 62562
		[Token(Token = "0x400F462")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList ListGrid;

		// Token: 0x0400F463 RID: 62563
		[Token(Token = "0x400F463")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Result;

		// Token: 0x0400F464 RID: 62564
		[Token(Token = "0x400F464")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SearchBarContainer;

		// Token: 0x0400F465 RID: 62565
		[Token(Token = "0x400F465")]
		[FieldOffset(Offset = "0x48")]
		public UIInput SearchInput;

		// Token: 0x0400F466 RID: 62566
		[Token(Token = "0x400F466")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SearchBtn;

		// Token: 0x0400F467 RID: 62567
		[Token(Token = "0x400F467")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SearchBtnSprite;

		// Token: 0x0400F468 RID: 62568
		[Token(Token = "0x400F468")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ClearBtn;
	}
}
