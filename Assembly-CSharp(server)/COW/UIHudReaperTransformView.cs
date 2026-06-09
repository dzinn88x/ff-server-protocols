using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200234C RID: 9036
	[Token(Token = "0x200234C")]
	public class UIHudReaperTransformView : UIBaseView
	{
		// Token: 0x0600C1A8 RID: 49576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A8")]
		[Address(RVA = "0x17EDECC", Offset = "0x17EDECC", VA = "0x7BBBFEDECC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A9")]
		[Address(RVA = "0x17EE0C4", Offset = "0x17EE0C4", VA = "0x7BBBFEE0C4")]
		public UIHudReaperTransformView()
		{
		}

		// Token: 0x0400DADE RID: 56030
		[Token(Token = "0x400DADE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClickBtn;

		// Token: 0x0400DADF RID: 56031
		[Token(Token = "0x400DADF")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400DAE0 RID: 56032
		[Token(Token = "0x400DAE0")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Progress;

		// Token: 0x0400DAE1 RID: 56033
		[Token(Token = "0x400DAE1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Halo;

		// Token: 0x0400DAE2 RID: 56034
		[Token(Token = "0x400DAE2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HaloSecond;

		// Token: 0x0400DAE3 RID: 56035
		[Token(Token = "0x400DAE3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject HaloThird;

		// Token: 0x0400DAE4 RID: 56036
		[Token(Token = "0x400DAE4")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HaloFull;
	}
}
