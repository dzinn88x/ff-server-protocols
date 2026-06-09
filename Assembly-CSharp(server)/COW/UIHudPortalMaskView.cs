using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002331 RID: 9009
	[Token(Token = "0x2002331")]
	public class UIHudPortalMaskView : UIBaseView
	{
		// Token: 0x0600C172 RID: 49522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C172")]
		[Address(RVA = "0x1D859F0", Offset = "0x1D859F0", VA = "0x7BBC5859F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C173 RID: 49523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C173")]
		[Address(RVA = "0x1D85A8C", Offset = "0x1D85A8C", VA = "0x7BBC585A8C")]
		public UIHudPortalMaskView()
		{
		}

		// Token: 0x0400DA7F RID: 55935
		[Token(Token = "0x400DA7F")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha MaskBG;
	}
}
