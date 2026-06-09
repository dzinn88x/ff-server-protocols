using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002296 RID: 8854
	[Token(Token = "0x2002296")]
	internal class UIHudChangeSeatView : UIBaseView
	{
		// Token: 0x0600C03D RID: 49213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C03D")]
		[Address(RVA = "0x1A8F648", Offset = "0x1A8F648", VA = "0x7BBC28F648", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C03E")]
		[Address(RVA = "0x1A8F840", Offset = "0x1A8F840", VA = "0x7BBC28F840")]
		public UIHudChangeSeatView()
		{
		}

		// Token: 0x0400D483 RID: 54403
		[Token(Token = "0x400D483")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400D484 RID: 54404
		[Token(Token = "0x400D484")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ButtonIcon;

		// Token: 0x0400D485 RID: 54405
		[Token(Token = "0x400D485")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar ProgressBarCD;

		// Token: 0x0400D486 RID: 54406
		[Token(Token = "0x400D486")]
		[FieldOffset(Offset = "0x38")]
		public UIProgressBar ProgressConfirmationCD;

		// Token: 0x0400D487 RID: 54407
		[Token(Token = "0x400D487")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ConfirmEffectGO;

		// Token: 0x0400D488 RID: 54408
		[Token(Token = "0x400D488")]
		[FieldOffset(Offset = "0x48")]
		public TweenScale CDTween;
	}
}
