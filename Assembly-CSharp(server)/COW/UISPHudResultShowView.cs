using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002533 RID: 9523
	[Token(Token = "0x2002533")]
	internal class UISPHudResultShowView : UIBaseView
	{
		// Token: 0x0600C576 RID: 50550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C576")]
		[Address(RVA = "0x1EF22C8", Offset = "0x1EF22C8", VA = "0x7BBC6F22C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C577 RID: 50551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C577")]
		[Address(RVA = "0x1EF24E8", Offset = "0x1EF24E8", VA = "0x7BBC6F24E8")]
		public UISPHudResultShowView()
		{
		}

		// Token: 0x0400F35C RID: 62300
		[Token(Token = "0x400F35C")]
		[FieldOffset(Offset = "0x20")]
		public Animator ShowAnimator;

		// Token: 0x0400F35D RID: 62301
		[Token(Token = "0x400F35D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TeamCallSignContainer;

		// Token: 0x0400F35E RID: 62302
		[Token(Token = "0x400F35E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400F35F RID: 62303
		[Token(Token = "0x400F35F")]
		[FieldOffset(Offset = "0x38")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F360 RID: 62304
		[Token(Token = "0x400F360")]
		[FieldOffset(Offset = "0x40")]
		public UITexture BGTexture;

		// Token: 0x0400F361 RID: 62305
		[Token(Token = "0x400F361")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PersonalCallSignContainer;

		// Token: 0x0400F362 RID: 62306
		[Token(Token = "0x400F362")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnMask;
	}
}
