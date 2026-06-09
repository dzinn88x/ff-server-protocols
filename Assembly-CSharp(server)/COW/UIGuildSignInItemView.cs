using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200224F RID: 8783
	[Token(Token = "0x200224F")]
	public class UIGuildSignInItemView : UIBaseView
	{
		// Token: 0x0600BFAF RID: 49071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFAF")]
		[Address(RVA = "0x16AD454", Offset = "0x16AD454", VA = "0x7BBBEAD454", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB0")]
		[Address(RVA = "0x16AD72C", Offset = "0x16AD72C", VA = "0x7BBBEAD72C")]
		public UIGuildSignInItemView()
		{
		}

		// Token: 0x0400D2DE RID: 53982
		[Token(Token = "0x400D2DE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Mask;

		// Token: 0x0400D2DF RID: 53983
		[Token(Token = "0x400D2DF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ExpireLabel;

		// Token: 0x0400D2E0 RID: 53984
		[Token(Token = "0x400D2E0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GotLabel;

		// Token: 0x0400D2E1 RID: 53985
		[Token(Token = "0x400D2E1")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnItem;

		// Token: 0x0400D2E2 RID: 53986
		[Token(Token = "0x400D2E2")]
		[FieldOffset(Offset = "0x40")]
		public UISprite DateIcon;

		// Token: 0x0400D2E3 RID: 53987
		[Token(Token = "0x400D2E3")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DateLabel;

		// Token: 0x0400D2E4 RID: 53988
		[Token(Token = "0x400D2E4")]
		[FieldOffset(Offset = "0x50")]
		public BaseItemView m_BaseItem;

		// Token: 0x0400D2E5 RID: 53989
		[Token(Token = "0x400D2E5")]
		[FieldOffset(Offset = "0x58")]
		public UILabel NAME;

		// Token: 0x0400D2E6 RID: 53990
		[Token(Token = "0x400D2E6")]
		[FieldOffset(Offset = "0x60")]
		public UILabel CountLabel;

		// Token: 0x0400D2E7 RID: 53991
		[Token(Token = "0x400D2E7")]
		[FieldOffset(Offset = "0x68")]
		public TweenAlpha GlowFrame;
	}
}
