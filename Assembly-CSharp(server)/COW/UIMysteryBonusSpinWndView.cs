using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002453 RID: 9299
	[Token(Token = "0x2002453")]
	internal class UIMysteryBonusSpinWndView : UIBaseView
	{
		// Token: 0x0600C3B6 RID: 50102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B6")]
		[Address(RVA = "0x14CDB48", Offset = "0x14CDB48", VA = "0x7BBBCCDB48", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B7")]
		[Address(RVA = "0x14CDD9C", Offset = "0x14CDD9C", VA = "0x7BBBCCDD9C")]
		public UIMysteryBonusSpinWndView()
		{
		}

		// Token: 0x0400E84F RID: 59471
		[Token(Token = "0x400E84F")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mask;

		// Token: 0x0400E850 RID: 59472
		[Token(Token = "0x400E850")]
		[FieldOffset(Offset = "0x28")]
		public UIButton StopBtn;

		// Token: 0x0400E851 RID: 59473
		[Token(Token = "0x400E851")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CofirmBtn;

		// Token: 0x0400E852 RID: 59474
		[Token(Token = "0x400E852")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SpinTips;

		// Token: 0x0400E853 RID: 59475
		[Token(Token = "0x400E853")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TopupTips;

		// Token: 0x0400E854 RID: 59476
		[Token(Token = "0x400E854")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Bonus;

		// Token: 0x0400E855 RID: 59477
		[Token(Token = "0x400E855")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EffectNum;

		// Token: 0x0400E856 RID: 59478
		[Token(Token = "0x400E856")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Effect_End;
	}
}
