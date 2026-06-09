using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002208 RID: 8712
	[Token(Token = "0x2002208")]
	public class UIGachaCouponTipsView : UIBaseView
	{
		// Token: 0x0600BF21 RID: 48929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF21")]
		[Address(RVA = "0x2160004", Offset = "0x2160004", VA = "0x7BBC960004", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF22 RID: 48930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF22")]
		[Address(RVA = "0x2160178", Offset = "0x2160178", VA = "0x7BBC960178")]
		public UIGachaCouponTipsView()
		{
		}

		// Token: 0x0400CE57 RID: 52823
		[Token(Token = "0x400CE57")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ItemContainer;

		// Token: 0x0400CE58 RID: 52824
		[Token(Token = "0x400CE58")]
		[FieldOffset(Offset = "0x28")]
		public GameObject CountDownContent;

		// Token: 0x0400CE59 RID: 52825
		[Token(Token = "0x400CE59")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GachaCountDownLabel;

		// Token: 0x0400CE5A RID: 52826
		[Token(Token = "0x400CE5A")]
		[FieldOffset(Offset = "0x38")]
		public UICountDownLabel CountDownTxt;
	}
}
