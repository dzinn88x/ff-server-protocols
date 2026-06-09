using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200228D RID: 8845
	[Token(Token = "0x200228D")]
	public class UIHudCamouflageView : UIBaseView
	{
		// Token: 0x0600C02B RID: 49195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C02B")]
		[Address(RVA = "0x19D095C", Offset = "0x19D095C", VA = "0x7BBC1D095C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C02C RID: 49196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C02C")]
		[Address(RVA = "0x19D0B2C", Offset = "0x19D0B2C", VA = "0x7BBC1D0B2C")]
		public UIHudCamouflageView()
		{
		}

		// Token: 0x0400D459 RID: 54361
		[Token(Token = "0x400D459")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btn;

		// Token: 0x0400D45A RID: 54362
		[Token(Token = "0x400D45A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400D45B RID: 54363
		[Token(Token = "0x400D45B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400D45C RID: 54364
		[Token(Token = "0x400D45C")]
		[FieldOffset(Offset = "0x38")]
		public UISprite getOn;

		// Token: 0x0400D45D RID: 54365
		[Token(Token = "0x400D45D")]
		[FieldOffset(Offset = "0x40")]
		public UISprite getOff;

		// Token: 0x0400D45E RID: 54366
		[Token(Token = "0x400D45E")]
		[FieldOffset(Offset = "0x48")]
		public TweenFill cdBar;
	}
}
