using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002512 RID: 9490
	[Token(Token = "0x2002512")]
	public class UISPHudHurtHintView : UIBaseView
	{
		// Token: 0x0600C534 RID: 50484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C534")]
		[Address(RVA = "0x1EE7B90", Offset = "0x1EE7B90", VA = "0x7BBC6E7B90", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C535 RID: 50485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C535")]
		[Address(RVA = "0x1EE7C2C", Offset = "0x1EE7C2C", VA = "0x7BBC6E7C2C")]
		public UISPHudHurtHintView()
		{
		}

		// Token: 0x0400F23F RID: 62015
		[Token(Token = "0x400F23F")]
		[FieldOffset(Offset = "0x20")]
		public PCHurtHint HurtHintTemplate;
	}
}
