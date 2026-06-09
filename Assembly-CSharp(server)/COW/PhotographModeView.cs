using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020CB RID: 8395
	[Token(Token = "0x20020CB")]
	public class PhotographModeView : UIBaseView
	{
		// Token: 0x0600BCA7 RID: 48295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA7")]
		[Address(RVA = "0x2053090", Offset = "0x2053090", VA = "0x7BBC853090", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA8")]
		[Address(RVA = "0x2053278", Offset = "0x2053278", VA = "0x7BBC853278")]
		public PhotographModeView()
		{
		}

		// Token: 0x0400BE21 RID: 48673
		[Token(Token = "0x400BE21")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HideInShootScreen;

		// Token: 0x0400BE22 RID: 48674
		[Token(Token = "0x400BE22")]
		[FieldOffset(Offset = "0x28")]
		public UISlider ScaleBar;

		// Token: 0x0400BE23 RID: 48675
		[Token(Token = "0x400BE23")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TakePhotoBtn;

		// Token: 0x0400BE24 RID: 48676
		[Token(Token = "0x400BE24")]
		[FieldOffset(Offset = "0x38")]
		public UIButton EmoteBtn;

		// Token: 0x0400BE25 RID: 48677
		[Token(Token = "0x400BE25")]
		[FieldOffset(Offset = "0x40")]
		public UIButton ExitBtn;

		// Token: 0x0400BE26 RID: 48678
		[Token(Token = "0x400BE26")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ShareShowUIRoot;
	}
}
