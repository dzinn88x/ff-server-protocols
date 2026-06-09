using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002497 RID: 9367
	[Token(Token = "0x2002497")]
	public class UIPopMenuBigView : UIBaseView
	{
		// Token: 0x0600C43E RID: 50238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43E")]
		[Address(RVA = "0x20EAA5C", Offset = "0x20EAA5C", VA = "0x7BBC8EAA5C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C43F RID: 50239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43F")]
		[Address(RVA = "0x20EAF2C", Offset = "0x20EAF2C", VA = "0x7BBC8EAF2C")]
		public UIPopMenuBigView()
		{
		}

		// Token: 0x0400EBBB RID: 60347
		[Token(Token = "0x400EBBB")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget ItemWidget;

		// Token: 0x0400EBBC RID: 60348
		[Token(Token = "0x400EBBC")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel Container;

		// Token: 0x0400EBBD RID: 60349
		[Token(Token = "0x400EBBD")]
		[FieldOffset(Offset = "0x30")]
		public UIButton OpenBtn;

		// Token: 0x0400EBBE RID: 60350
		[Token(Token = "0x400EBBE")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget Bg;

		// Token: 0x0400EBBF RID: 60351
		[Token(Token = "0x400EBBF")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SourceTypeMenuBtnArrUp;

		// Token: 0x0400EBC0 RID: 60352
		[Token(Token = "0x400EBC0")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SourceTypeMenuBtnArrDown;

		// Token: 0x0400EBC1 RID: 60353
		[Token(Token = "0x400EBC1")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Title;

		// Token: 0x0400EBC2 RID: 60354
		[Token(Token = "0x400EBC2")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Icon;

		// Token: 0x0400EBC3 RID: 60355
		[Token(Token = "0x400EBC3")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ScrollViewUpContainer;

		// Token: 0x0400EBC4 RID: 60356
		[Token(Token = "0x400EBC4")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BGUp;

		// Token: 0x0400EBC5 RID: 60357
		[Token(Token = "0x400EBC5")]
		[FieldOffset(Offset = "0x70")]
		public UIScrollView ScrollViewUp;

		// Token: 0x0400EBC6 RID: 60358
		[Token(Token = "0x400EBC6")]
		[FieldOffset(Offset = "0x78")]
		public UIPanel ScrollViewUpPanel;

		// Token: 0x0400EBC7 RID: 60359
		[Token(Token = "0x400EBC7")]
		[FieldOffset(Offset = "0x80")]
		public UIGrid Table;

		// Token: 0x0400EBC8 RID: 60360
		[Token(Token = "0x400EBC8")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ScrollViewDownContainer;

		// Token: 0x0400EBC9 RID: 60361
		[Token(Token = "0x400EBC9")]
		[FieldOffset(Offset = "0x90")]
		public UISprite BGDown;

		// Token: 0x0400EBCA RID: 60362
		[Token(Token = "0x400EBCA")]
		[FieldOffset(Offset = "0x98")]
		public UIScrollView ScrollViewDown;

		// Token: 0x0400EBCB RID: 60363
		[Token(Token = "0x400EBCB")]
		[FieldOffset(Offset = "0xA0")]
		public UIPanel ScrollViewDownPanel;

		// Token: 0x0400EBCC RID: 60364
		[Token(Token = "0x400EBCC")]
		[FieldOffset(Offset = "0xA8")]
		public UIGrid ItemGrid;
	}
}
