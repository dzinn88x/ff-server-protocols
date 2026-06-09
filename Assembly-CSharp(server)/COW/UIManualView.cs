using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200242D RID: 9261
	[Token(Token = "0x200242D")]
	public class UIManualView : UIBaseView
	{
		// Token: 0x0600C36A RID: 50026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C36A")]
		[Address(RVA = "0x18E73D0", Offset = "0x18E73D0", VA = "0x7BBC0E73D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C36B RID: 50027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C36B")]
		[Address(RVA = "0x18E7690", Offset = "0x18E7690", VA = "0x7BBC0E7690")]
		public UIManualView()
		{
		}

		// Token: 0x0400E622 RID: 58914
		[Token(Token = "0x400E622")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400E623 RID: 58915
		[Token(Token = "0x400E623")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnRightArrow;

		// Token: 0x0400E624 RID: 58916
		[Token(Token = "0x400E624")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnLeftArrow;

		// Token: 0x0400E625 RID: 58917
		[Token(Token = "0x400E625")]
		[FieldOffset(Offset = "0x38")]
		public Transform LeftTabContainer;

		// Token: 0x0400E626 RID: 58918
		[Token(Token = "0x400E626")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BookAnimRight1;

		// Token: 0x0400E627 RID: 58919
		[Token(Token = "0x400E627")]
		[FieldOffset(Offset = "0x48")]
		public UISprite BookAnimRight2;

		// Token: 0x0400E628 RID: 58920
		[Token(Token = "0x400E628")]
		[FieldOffset(Offset = "0x50")]
		public UISprite BookAnimMiddle;

		// Token: 0x0400E629 RID: 58921
		[Token(Token = "0x400E629")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BookAnimLeft;

		// Token: 0x0400E62A RID: 58922
		[Token(Token = "0x400E62A")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnShare;

		// Token: 0x0400E62B RID: 58923
		[Token(Token = "0x400E62B")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnHelp;
	}
}
