using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200249E RID: 9374
	[Token(Token = "0x200249E")]
	public class UIPortraitCloseupView : UIBaseView
	{
		// Token: 0x0600C44C RID: 50252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44C")]
		[Address(RVA = "0x216FAEC", Offset = "0x216FAEC", VA = "0x7BBC96FAEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44D")]
		[Address(RVA = "0x216FCCC", Offset = "0x216FCCC", VA = "0x7BBC96FCCC")]
		public UIPortraitCloseupView()
		{
		}

		// Token: 0x0400EC05 RID: 60421
		[Token(Token = "0x400EC05")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NormalUIRoot;

		// Token: 0x0400EC06 RID: 60422
		[Token(Token = "0x400EC06")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ExitBtn;

		// Token: 0x0400EC07 RID: 60423
		[Token(Token = "0x400EC07")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TakePhotoBtn;

		// Token: 0x0400EC08 RID: 60424
		[Token(Token = "0x400EC08")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ZoomInOutBtn;

		// Token: 0x0400EC09 RID: 60425
		[Token(Token = "0x400EC09")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ZoomInOutSpr;

		// Token: 0x0400EC0A RID: 60426
		[Token(Token = "0x400EC0A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ScreenShotUIRoot;
	}
}
