using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002148 RID: 8520
	[Token(Token = "0x2002148")]
	internal class UIChangeServerView : UIBaseView
	{
		// Token: 0x0600BDA0 RID: 48544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA0")]
		[Address(RVA = "0x1BDE898", Offset = "0x1BDE898", VA = "0x7BBC3DE898", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA1")]
		[Address(RVA = "0x1BDEAC0", Offset = "0x1BDEAC0", VA = "0x7BBC3DEAC0")]
		public UIChangeServerView()
		{
		}

		// Token: 0x0400C491 RID: 50321
		[Token(Token = "0x400C491")]
		[FieldOffset(Offset = "0x20")]
		public UISprite bg;

		// Token: 0x0400C492 RID: 50322
		[Token(Token = "0x400C492")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha BgTweenAlpha;

		// Token: 0x0400C493 RID: 50323
		[Token(Token = "0x400C493")]
		[FieldOffset(Offset = "0x30")]
		public UIButton close;

		// Token: 0x0400C494 RID: 50324
		[Token(Token = "0x400C494")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid ServerListGrid;

		// Token: 0x0400C495 RID: 50325
		[Token(Token = "0x400C495")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Instance;

		// Token: 0x0400C496 RID: 50326
		[Token(Token = "0x400C496")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ServerRegion;

		// Token: 0x0400C497 RID: 50327
		[Token(Token = "0x400C497")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnConfirm;
	}
}
