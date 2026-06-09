using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200236B RID: 9067
	[Token(Token = "0x200236B")]
	public class UIHudSpecialPopupView : UIBaseView
	{
		// Token: 0x0600C1E6 RID: 49638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E6")]
		[Address(RVA = "0x166DA00", Offset = "0x166DA00", VA = "0x7BBBE6DA00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E7")]
		[Address(RVA = "0x166DCF8", Offset = "0x166DCF8", VA = "0x7BBBE6DCF8")]
		public UIHudSpecialPopupView()
		{
		}

		// Token: 0x0400DBD9 RID: 56281
		[Token(Token = "0x400DBD9")]
		[FieldOffset(Offset = "0x20")]
		public Animation MainTipAnim;

		// Token: 0x0400DBDA RID: 56282
		[Token(Token = "0x400DBDA")]
		[FieldOffset(Offset = "0x28")]
		public UISprite MainIcon;

		// Token: 0x0400DBDB RID: 56283
		[Token(Token = "0x400DBDB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel MainMessage;

		// Token: 0x0400DBDC RID: 56284
		[Token(Token = "0x400DBDC")]
		[FieldOffset(Offset = "0x38")]
		public UISprite MainBg;

		// Token: 0x0400DBDD RID: 56285
		[Token(Token = "0x400DBDD")]
		[FieldOffset(Offset = "0x40")]
		public UISprite MainBg2;

		// Token: 0x0400DBDE RID: 56286
		[Token(Token = "0x400DBDE")]
		[FieldOffset(Offset = "0x48")]
		public UISprite MainBg3;

		// Token: 0x0400DBDF RID: 56287
		[Token(Token = "0x400DBDF")]
		[FieldOffset(Offset = "0x50")]
		public Animation SubTipAnim;

		// Token: 0x0400DBE0 RID: 56288
		[Token(Token = "0x400DBE0")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SubIcon;

		// Token: 0x0400DBE1 RID: 56289
		[Token(Token = "0x400DBE1")]
		[FieldOffset(Offset = "0x60")]
		public UILabel SubMessage;

		// Token: 0x0400DBE2 RID: 56290
		[Token(Token = "0x400DBE2")]
		[FieldOffset(Offset = "0x68")]
		public UISprite SubBg;

		// Token: 0x0400DBE3 RID: 56291
		[Token(Token = "0x400DBE3")]
		[FieldOffset(Offset = "0x70")]
		public UISprite SubBg2;
	}
}
