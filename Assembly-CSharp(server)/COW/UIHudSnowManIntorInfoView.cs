using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200236A RID: 9066
	[Token(Token = "0x200236A")]
	public class UIHudSnowManIntorInfoView : UIBaseView
	{
		// Token: 0x0600C1E4 RID: 49636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E4")]
		[Address(RVA = "0x166C3B4", Offset = "0x166C3B4", VA = "0x7BBBE6C3B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E5")]
		[Address(RVA = "0x166C4A4", Offset = "0x166C4A4", VA = "0x7BBBE6C4A4")]
		public UIHudSnowManIntorInfoView()
		{
		}

		// Token: 0x0400DBD7 RID: 56279
		[Token(Token = "0x400DBD7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject IntroKey;

		// Token: 0x0400DBD8 RID: 56280
		[Token(Token = "0x400DBD8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel IntroDetail;
	}
}
