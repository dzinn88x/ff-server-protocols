using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023BB RID: 9147
	[Token(Token = "0x20023BB")]
	public class UIHudWolfTaskView : UIBaseView
	{
		// Token: 0x0600C286 RID: 49798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C286")]
		[Address(RVA = "0x1D23044", Offset = "0x1D23044", VA = "0x7BBC523044", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C287 RID: 49799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C287")]
		[Address(RVA = "0x1D232D0", Offset = "0x1D232D0", VA = "0x7BBC5232D0")]
		public UIHudWolfTaskView()
		{
		}

		// Token: 0x0400DE41 RID: 56897
		[Token(Token = "0x400DE41")]
		[FieldOffset(Offset = "0x20")]
		public UIButton WolfTaskBtn1;

		// Token: 0x0400DE42 RID: 56898
		[Token(Token = "0x400DE42")]
		[FieldOffset(Offset = "0x28")]
		public UISprite WolfTaskBtnSprite1;

		// Token: 0x0400DE43 RID: 56899
		[Token(Token = "0x400DE43")]
		[FieldOffset(Offset = "0x30")]
		public UIButton WolfTaskBtn2;

		// Token: 0x0400DE44 RID: 56900
		[Token(Token = "0x400DE44")]
		[FieldOffset(Offset = "0x38")]
		public UISprite WolfTaskBtnSprite2;

		// Token: 0x0400DE45 RID: 56901
		[Token(Token = "0x400DE45")]
		[FieldOffset(Offset = "0x40")]
		public UIButton WolfTaskBtn3;

		// Token: 0x0400DE46 RID: 56902
		[Token(Token = "0x400DE46")]
		[FieldOffset(Offset = "0x48")]
		public UISprite WolfTaskBtnSprite3;

		// Token: 0x0400DE47 RID: 56903
		[Token(Token = "0x400DE47")]
		[FieldOffset(Offset = "0x50")]
		public UISprite WolfTaskMask;

		// Token: 0x0400DE48 RID: 56904
		[Token(Token = "0x400DE48")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CoolDownLabel;

		// Token: 0x0400DE49 RID: 56905
		[Token(Token = "0x400DE49")]
		[FieldOffset(Offset = "0x60")]
		public UIButton WolfTaskBtnAll;
	}
}
