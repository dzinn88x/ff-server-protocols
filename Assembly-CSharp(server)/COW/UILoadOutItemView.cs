using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023EF RID: 9199
	[Token(Token = "0x20023EF")]
	internal class UILoadOutItemView : UIBaseView
	{
		// Token: 0x0600C2EE RID: 49902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EE")]
		[Address(RVA = "0x1CC4744", Offset = "0x1CC4744", VA = "0x7BBC4C4744", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2EF RID: 49903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EF")]
		[Address(RVA = "0x1CC4B80", Offset = "0x1CC4B80", VA = "0x7BBC4C4B80")]
		public UILoadOutItemView()
		{
		}

		// Token: 0x0400E11D RID: 57629
		[Token(Token = "0x400E11D")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400E11E RID: 57630
		[Token(Token = "0x400E11E")]
		[FieldOffset(Offset = "0x28")]
		public UIButton itemBtn;

		// Token: 0x0400E11F RID: 57631
		[Token(Token = "0x400E11F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400E120 RID: 57632
		[Token(Token = "0x400E120")]
		[FieldOffset(Offset = "0x38")]
		public UILabel cnt;

		// Token: 0x0400E121 RID: 57633
		[Token(Token = "0x400E121")]
		[FieldOffset(Offset = "0x40")]
		public UILabel name;

		// Token: 0x0400E122 RID: 57634
		[Token(Token = "0x400E122")]
		[FieldOffset(Offset = "0x48")]
		public GameObject HL;

		// Token: 0x0400E123 RID: 57635
		[Token(Token = "0x400E123")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HLPlayCard;

		// Token: 0x0400E124 RID: 57636
		[Token(Token = "0x400E124")]
		[FieldOffset(Offset = "0x58")]
		public GameObject line;

		// Token: 0x0400E125 RID: 57637
		[Token(Token = "0x400E125")]
		[FieldOffset(Offset = "0x60")]
		public UIButton infoBtn;

		// Token: 0x0400E126 RID: 57638
		[Token(Token = "0x400E126")]
		[FieldOffset(Offset = "0x68")]
		public UILabel num;

		// Token: 0x0400E127 RID: 57639
		[Token(Token = "0x400E127")]
		[FieldOffset(Offset = "0x70")]
		public UIButton IncreaseBtn;

		// Token: 0x0400E128 RID: 57640
		[Token(Token = "0x400E128")]
		[FieldOffset(Offset = "0x78")]
		public UIButton DecreaseBtn;

		// Token: 0x0400E129 RID: 57641
		[Token(Token = "0x400E129")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BuyBtn;

		// Token: 0x0400E12A RID: 57642
		[Token(Token = "0x400E12A")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Price;

		// Token: 0x0400E12B RID: 57643
		[Token(Token = "0x400E12B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject PlayCardGameObj;

		// Token: 0x0400E12C RID: 57644
		[Token(Token = "0x400E12C")]
		[FieldOffset(Offset = "0x98")]
		public UISprite PlayCardIcon;

		// Token: 0x0400E12D RID: 57645
		[Token(Token = "0x400E12D")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel Remain;
	}
}
