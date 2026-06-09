using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020EF RID: 8431
	[Token(Token = "0x20020EF")]
	internal class UIAddictGuideView : UIBaseView
	{
		// Token: 0x0600BCEF RID: 48367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEF")]
		[Address(RVA = "0x1969074", Offset = "0x1969074", VA = "0x7BBC169074", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF0")]
		[Address(RVA = "0x1969300", Offset = "0x1969300", VA = "0x7BBC169300")]
		public UIAddictGuideView()
		{
		}

		// Token: 0x0400BF8B RID: 49035
		[Token(Token = "0x400BF8B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CharacterPic;

		// Token: 0x0400BF8C RID: 49036
		[Token(Token = "0x400BF8C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject CharacterPic01;

		// Token: 0x0400BF8D RID: 49037
		[Token(Token = "0x400BF8D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel title;

		// Token: 0x0400BF8E RID: 49038
		[Token(Token = "0x400BF8E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel message;

		// Token: 0x0400BF8F RID: 49039
		[Token(Token = "0x400BF8F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel tipmessage;

		// Token: 0x0400BF90 RID: 49040
		[Token(Token = "0x400BF90")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ConfirmWidget;

		// Token: 0x0400BF91 RID: 49041
		[Token(Token = "0x400BF91")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ConfirmBtn;

		// Token: 0x0400BF92 RID: 49042
		[Token(Token = "0x400BF92")]
		[FieldOffset(Offset = "0x58")]
		public UIButton YesBtn;

		// Token: 0x0400BF93 RID: 49043
		[Token(Token = "0x400BF93")]
		[FieldOffset(Offset = "0x60")]
		public UIButton NoBtn;
	}
}
