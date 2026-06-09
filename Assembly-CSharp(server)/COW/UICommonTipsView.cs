using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002188 RID: 8584
	[Token(Token = "0x2002188")]
	public class UICommonTipsView : UIBaseView
	{
		// Token: 0x0600BE20 RID: 48672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE20")]
		[Address(RVA = "0x18162C8", Offset = "0x18162C8", VA = "0x7BBC0162C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE21")]
		[Address(RVA = "0x18163E8", Offset = "0x18163E8", VA = "0x7BBC0163E8")]
		public UICommonTipsView()
		{
		}

		// Token: 0x0400C7C8 RID: 51144
		[Token(Token = "0x400C7C8")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Mask;

		// Token: 0x0400C7C9 RID: 51145
		[Token(Token = "0x400C7C9")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TipTxt;

		// Token: 0x0400C7CA RID: 51146
		[Token(Token = "0x400C7CA")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Bg;
	}
}
