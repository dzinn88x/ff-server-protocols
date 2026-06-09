using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002272 RID: 8818
	[Token(Token = "0x2002272")]
	internal class UIHudAuxFireView : UIBaseView
	{
		// Token: 0x0600BFF5 RID: 49141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF5")]
		[Address(RVA = "0x188BD50", Offset = "0x188BD50", VA = "0x7BBC08BD50", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFF6 RID: 49142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF6")]
		[Address(RVA = "0x188BDEC", Offset = "0x188BDEC", VA = "0x7BBC08BDEC")]
		public UIHudAuxFireView()
		{
		}

		// Token: 0x0400D3BB RID: 54203
		[Token(Token = "0x400D3BB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnFire;
	}
}
