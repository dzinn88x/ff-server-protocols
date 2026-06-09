using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200229B RID: 8859
	[Token(Token = "0x200229B")]
	public class UIHudCommonPregameTimeTipView : UIBaseView
	{
		// Token: 0x0600C047 RID: 49223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C047")]
		[Address(RVA = "0x1A91A38", Offset = "0x1A91A38", VA = "0x7BBC291A38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C048")]
		[Address(RVA = "0x1A91AD4", Offset = "0x1A91AD4", VA = "0x7BBC291AD4")]
		public UIHudCommonPregameTimeTipView()
		{
		}

		// Token: 0x0400D49A RID: 54426
		[Token(Token = "0x400D49A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Time;
	}
}
