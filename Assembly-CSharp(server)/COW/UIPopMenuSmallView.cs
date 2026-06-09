using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200249B RID: 9371
	[Token(Token = "0x200249B")]
	public class UIPopMenuSmallView : UIBaseView
	{
		// Token: 0x0600C446 RID: 50246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C446")]
		[Address(RVA = "0x20EF9A0", Offset = "0x20EF9A0", VA = "0x7BBC8EF9A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C447")]
		[Address(RVA = "0x20EFE1C", Offset = "0x20EFE1C", VA = "0x7BBC8EFE1C")]
		public UIPopMenuSmallView()
		{
		}

		// Token: 0x0400EBDD RID: 60381
		[Token(Token = "0x400EBDD")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget ItemWidget;

		// Token: 0x0400EBDE RID: 60382
		[Token(Token = "0x400EBDE")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel Container;

		// Token: 0x0400EBDF RID: 60383
		[Token(Token = "0x400EBDF")]
		[FieldOffset(Offset = "0x30")]
		public UIButton OpenBtn;

		// Token: 0x0400EBE0 RID: 60384
		[Token(Token = "0x400EBE0")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SourceTypeMenuBtnArrUp;

		// Token: 0x0400EBE1 RID: 60385
		[Token(Token = "0x400EBE1")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SourceTypeMenuBtnArrDown;

		// Token: 0x0400EBE2 RID: 60386
		[Token(Token = "0x400EBE2")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Title;

		// Token: 0x0400EBE3 RID: 60387
		[Token(Token = "0x400EBE3")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Icon;

		// Token: 0x0400EBE4 RID: 60388
		[Token(Token = "0x400EBE4")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ScrollViewUpContainer;

		// Token: 0x0400EBE5 RID: 60389
		[Token(Token = "0x400EBE5")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView ScrollViewUp;

		// Token: 0x0400EBE6 RID: 60390
		[Token(Token = "0x400EBE6")]
		[FieldOffset(Offset = "0x68")]
		public UIPanel ScrollViewUpPanel;

		// Token: 0x0400EBE7 RID: 60391
		[Token(Token = "0x400EBE7")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid Table;

		// Token: 0x0400EBE8 RID: 60392
		[Token(Token = "0x400EBE8")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BGUp;

		// Token: 0x0400EBE9 RID: 60393
		[Token(Token = "0x400EBE9")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ScrollViewDownContainer;

		// Token: 0x0400EBEA RID: 60394
		[Token(Token = "0x400EBEA")]
		[FieldOffset(Offset = "0x88")]
		public UIScrollView ScrollViewDown;

		// Token: 0x0400EBEB RID: 60395
		[Token(Token = "0x400EBEB")]
		[FieldOffset(Offset = "0x90")]
		public UIPanel ScrollViewDownPanel;

		// Token: 0x0400EBEC RID: 60396
		[Token(Token = "0x400EBEC")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid ItemGrid;

		// Token: 0x0400EBED RID: 60397
		[Token(Token = "0x400EBED")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite BGDown;
	}
}
