using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200249A RID: 9370
	[Token(Token = "0x200249A")]
	internal class UIPopMenuItemView : UIBaseView
	{
		// Token: 0x0600C444 RID: 50244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C444")]
		[Address(RVA = "0x20ED160", Offset = "0x20ED160", VA = "0x7BBC8ED160", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C445 RID: 50245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C445")]
		[Address(RVA = "0x20ED2D4", Offset = "0x20ED2D4", VA = "0x7BBC8ED2D4")]
		public UIPopMenuItemView()
		{
		}

		// Token: 0x0400EBD9 RID: 60377
		[Token(Token = "0x400EBD9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400EBDA RID: 60378
		[Token(Token = "0x400EBDA")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400EBDB RID: 60379
		[Token(Token = "0x400EBDB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400EBDC RID: 60380
		[Token(Token = "0x400EBDC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;
	}
}
