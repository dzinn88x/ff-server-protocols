using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002478 RID: 9336
	[Token(Token = "0x2002478")]
	public class UIPaymentIAPView : UIBaseView
	{
		// Token: 0x0600C400 RID: 50176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C400")]
		[Address(RVA = "0x1F2BFEC", Offset = "0x1F2BFEC", VA = "0x7BBC72BFEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C401 RID: 50177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C401")]
		[Address(RVA = "0x1F2C460", Offset = "0x1F2C460", VA = "0x7BBC72C460")]
		public UIPaymentIAPView()
		{
		}

		// Token: 0x0400EA56 RID: 59990
		[Token(Token = "0x400EA56")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPaymentIAP;

		// Token: 0x0400EA57 RID: 59991
		[Token(Token = "0x400EA57")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid PaymentItemsGrid;

		// Token: 0x0400EA58 RID: 59992
		[Token(Token = "0x400EA58")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget CdnAdContainer;

		// Token: 0x0400EA59 RID: 59993
		[Token(Token = "0x400EA59")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView ScrollView;

		// Token: 0x0400EA5A RID: 59994
		[Token(Token = "0x400EA5A")]
		[FieldOffset(Offset = "0x40")]
		public UIWrapContent WrapContent;

		// Token: 0x0400EA5B RID: 59995
		[Token(Token = "0x400EA5B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BonusContainer;

		// Token: 0x0400EA5C RID: 59996
		[Token(Token = "0x400EA5C")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SpinBtn;

		// Token: 0x0400EA5D RID: 59997
		[Token(Token = "0x400EA5D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Bonus;

		// Token: 0x0400EA5E RID: 59998
		[Token(Token = "0x400EA5E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel BonusNum;

		// Token: 0x0400EA5F RID: 59999
		[Token(Token = "0x400EA5F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BonusTips;

		// Token: 0x0400EA60 RID: 60000
		[Token(Token = "0x400EA60")]
		[FieldOffset(Offset = "0x70")]
		public UILabel BonusTipsLabel;

		// Token: 0x0400EA61 RID: 60001
		[Token(Token = "0x400EA61")]
		[FieldOffset(Offset = "0x78")]
		public UILabel BonusTipsNum;

		// Token: 0x0400EA62 RID: 60002
		[Token(Token = "0x400EA62")]
		[FieldOffset(Offset = "0x80")]
		public Transform CountDown;

		// Token: 0x0400EA63 RID: 60003
		[Token(Token = "0x400EA63")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid CdnAdDotsGrid;

		// Token: 0x0400EA64 RID: 60004
		[Token(Token = "0x400EA64")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnPaymentActivity;

		// Token: 0x0400EA65 RID: 60005
		[Token(Token = "0x400EA65")]
		[FieldOffset(Offset = "0x98")]
		public UISprite PaymentActivityRedDot;
	}
}
