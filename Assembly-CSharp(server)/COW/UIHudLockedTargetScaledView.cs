using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022FF RID: 8959
	[Token(Token = "0x20022FF")]
	internal class UIHudLockedTargetScaledView : UIBaseView
	{
		// Token: 0x0600C10E RID: 49422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10E")]
		[Address(RVA = "0x15BBB84", Offset = "0x15BBB84", VA = "0x7BBBDBBB84", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C10F RID: 49423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10F")]
		[Address(RVA = "0x15BBC74", Offset = "0x15BBC74", VA = "0x7BBBDBBC74")]
		public UIHudLockedTargetScaledView()
		{
		}

		// Token: 0x0400D83C RID: 55356
		[Token(Token = "0x400D83C")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Boarder;

		// Token: 0x0400D83D RID: 55357
		[Token(Token = "0x400D83D")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha TweenAlpha;
	}
}
