using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002424 RID: 9252
	[Token(Token = "0x2002424")]
	internal class UIManualGrownItemView : UIBaseView
	{
		// Token: 0x0600C358 RID: 50008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C358")]
		[Address(RVA = "0x1DFB378", Offset = "0x1DFB378", VA = "0x7BBC5FB378", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C359 RID: 50009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C359")]
		[Address(RVA = "0x1DFB588", Offset = "0x1DFB588", VA = "0x7BBC5FB588")]
		public UIManualGrownItemView()
		{
		}

		// Token: 0x0400E562 RID: 58722
		[Token(Token = "0x400E562")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Btn;

		// Token: 0x0400E563 RID: 58723
		[Token(Token = "0x400E563")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView RewardItem;

		// Token: 0x0400E564 RID: 58724
		[Token(Token = "0x400E564")]
		[FieldOffset(Offset = "0x30")]
		public GameObject IconGroup;

		// Token: 0x0400E565 RID: 58725
		[Token(Token = "0x400E565")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Sprite_Debris;

		// Token: 0x0400E566 RID: 58726
		[Token(Token = "0x400E566")]
		[FieldOffset(Offset = "0x40")]
		public UISprite VoucherIcon;

		// Token: 0x0400E567 RID: 58727
		[Token(Token = "0x400E567")]
		[FieldOffset(Offset = "0x48")]
		public UISprite DisableMask;

		// Token: 0x0400E568 RID: 58728
		[Token(Token = "0x400E568")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EnableBG;
	}
}
