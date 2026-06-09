using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002499 RID: 9369
	[Token(Token = "0x2002499")]
	public class UIPopMenuItemSmallView : UIBaseView
	{
		// Token: 0x0600C442 RID: 50242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C442")]
		[Address(RVA = "0x20ECF60", Offset = "0x20ECF60", VA = "0x7BBC8ECF60", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C443")]
		[Address(RVA = "0x20ED158", Offset = "0x20ED158", VA = "0x7BBC8ED158")]
		public UIPopMenuItemSmallView()
		{
		}

		// Token: 0x0400EBD3 RID: 60371
		[Token(Token = "0x400EBD3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400EBD4 RID: 60372
		[Token(Token = "0x400EBD4")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400EBD5 RID: 60373
		[Token(Token = "0x400EBD5")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView UIDragScrollView;

		// Token: 0x0400EBD6 RID: 60374
		[Token(Token = "0x400EBD6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Label;

		// Token: 0x0400EBD7 RID: 60375
		[Token(Token = "0x400EBD7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HighLight;

		// Token: 0x0400EBD8 RID: 60376
		[Token(Token = "0x400EBD8")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Icon;
	}
}
