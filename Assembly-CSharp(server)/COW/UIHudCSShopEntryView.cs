using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022AD RID: 8877
	[Token(Token = "0x20022AD")]
	internal class UIHudCSShopEntryView : UIBaseView
	{
		// Token: 0x0600C06A RID: 49258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C06A")]
		[Address(RVA = "0x19CE924", Offset = "0x19CE924", VA = "0x7BBC1CE924", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C06B")]
		[Address(RVA = "0x19CEA14", Offset = "0x19CEA14", VA = "0x7BBC1CEA14")]
		public UIHudCSShopEntryView()
		{
		}

		// Token: 0x0400D536 RID: 54582
		[Token(Token = "0x400D536")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnShop;

		// Token: 0x0400D537 RID: 54583
		[Token(Token = "0x400D537")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem FlashEffect;
	}
}
