using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002457 RID: 9303
	[Token(Token = "0x2002457")]
	public class UIMysteryMallView : UIBaseView
	{
		// Token: 0x0600C3BE RID: 50110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BE")]
		[Address(RVA = "0x14D68E8", Offset = "0x14D68E8", VA = "0x7BBBCD68E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3BF RID: 50111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BF")]
		[Address(RVA = "0x14D7250", Offset = "0x14D7250", VA = "0x7BBBCD7250")]
		public UIMysteryMallView()
		{
		}

		// Token: 0x0400E88A RID: 59530
		[Token(Token = "0x400E88A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400E88B RID: 59531
		[Token(Token = "0x400E88B")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ItemScrollView;

		// Token: 0x0400E88C RID: 59532
		[Token(Token = "0x400E88C")]
		[FieldOffset(Offset = "0x30")]
		public UITable ItemTable;

		// Token: 0x0400E88D RID: 59533
		[Token(Token = "0x400E88D")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnRule;

		// Token: 0x0400E88E RID: 59534
		[Token(Token = "0x400E88E")]
		[FieldOffset(Offset = "0x40")]
		public Transform CountDownContainer;

		// Token: 0x0400E88F RID: 59535
		[Token(Token = "0x400E88F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelLuckNum;

		// Token: 0x0400E890 RID: 59536
		[Token(Token = "0x400E890")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer VFXLuckNum;

		// Token: 0x0400E891 RID: 59537
		[Token(Token = "0x400E891")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelCostNum;

		// Token: 0x0400E892 RID: 59538
		[Token(Token = "0x400E892")]
		[FieldOffset(Offset = "0x60")]
		public UIProgressBar BarCostProgress;

		// Token: 0x0400E893 RID: 59539
		[Token(Token = "0x400E893")]
		[FieldOffset(Offset = "0x68")]
		public MeshRenderer BarUV01;

		// Token: 0x0400E894 RID: 59540
		[Token(Token = "0x400E894")]
		[FieldOffset(Offset = "0x70")]
		public MeshRenderer BarUV02;

		// Token: 0x0400E895 RID: 59541
		[Token(Token = "0x400E895")]
		[FieldOffset(Offset = "0x78")]
		public Transform BarPoint;

		// Token: 0x0400E896 RID: 59542
		[Token(Token = "0x400E896")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LabelSuperOriginalPrice;

		// Token: 0x0400E897 RID: 59543
		[Token(Token = "0x400E897")]
		[FieldOffset(Offset = "0x88")]
		public UILabel LabelSuperDiscountPrice;

		// Token: 0x0400E898 RID: 59544
		[Token(Token = "0x400E898")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnPurchaseSuper;

		// Token: 0x0400E899 RID: 59545
		[Token(Token = "0x400E899")]
		[FieldOffset(Offset = "0x98")]
		public GameObject Locked;

		// Token: 0x0400E89A RID: 59546
		[Token(Token = "0x400E89A")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Purchasable;

		// Token: 0x0400E89B RID: 59547
		[Token(Token = "0x400E89B")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Shareable;

		// Token: 0x0400E89C RID: 59548
		[Token(Token = "0x400E89C")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject TipsIcon;

		// Token: 0x0400E89D RID: 59549
		[Token(Token = "0x400E89D")]
		[FieldOffset(Offset = "0xB8")]
		public Transform ItemSuperContainer;

		// Token: 0x0400E89E RID: 59550
		[Token(Token = "0x400E89E")]
		[FieldOffset(Offset = "0xC0")]
		public Transform ItemSecondContainer;

		// Token: 0x0400E89F RID: 59551
		[Token(Token = "0x400E89F")]
		[FieldOffset(Offset = "0xC8")]
		public UINetworkTextureExt CdnSuperBg;

		// Token: 0x0400E8A0 RID: 59552
		[Token(Token = "0x400E8A0")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid ItemNormalGrid;

		// Token: 0x0400E8A1 RID: 59553
		[Token(Token = "0x400E8A1")]
		[FieldOffset(Offset = "0xD8")]
		public UIGrid BtnGrid;

		// Token: 0x0400E8A2 RID: 59554
		[Token(Token = "0x400E8A2")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton BtnGoWeb;

		// Token: 0x0400E8A3 RID: 59555
		[Token(Token = "0x400E8A3")]
		[FieldOffset(Offset = "0xE8")]
		public UINetworkTextureExt CdnGoWeb;

		// Token: 0x0400E8A4 RID: 59556
		[Token(Token = "0x400E8A4")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BtnSwitchPool;

		// Token: 0x0400E8A5 RID: 59557
		[Token(Token = "0x400E8A5")]
		[FieldOffset(Offset = "0xF8")]
		public UINetworkTextureExt CdnSwitchPool;

		// Token: 0x0400E8A6 RID: 59558
		[Token(Token = "0x400E8A6")]
		[FieldOffset(Offset = "0x100")]
		public UILabel LabelPoolPrice;

		// Token: 0x0400E8A7 RID: 59559
		[Token(Token = "0x400E8A7")]
		[FieldOffset(Offset = "0x108")]
		public UILabel LabelProgress;

		// Token: 0x0400E8A8 RID: 59560
		[Token(Token = "0x400E8A8")]
		[FieldOffset(Offset = "0x110")]
		public UIProgressBar BarSwitchProgress;

		// Token: 0x0400E8A9 RID: 59561
		[Token(Token = "0x400E8A9")]
		[FieldOffset(Offset = "0x118")]
		public GameObject TopContainer;

		// Token: 0x0400E8AA RID: 59562
		[Token(Token = "0x400E8AA")]
		[FieldOffset(Offset = "0x120")]
		public UIProgressBar BarTopCostProgress;

		// Token: 0x0400E8AB RID: 59563
		[Token(Token = "0x400E8AB")]
		[FieldOffset(Offset = "0x128")]
		public MeshRenderer BarTopUV01;

		// Token: 0x0400E8AC RID: 59564
		[Token(Token = "0x400E8AC")]
		[FieldOffset(Offset = "0x130")]
		public MeshRenderer BarTopUV02;

		// Token: 0x0400E8AD RID: 59565
		[Token(Token = "0x400E8AD")]
		[FieldOffset(Offset = "0x138")]
		public Transform TopBarPoint;

		// Token: 0x0400E8AE RID: 59566
		[Token(Token = "0x400E8AE")]
		[FieldOffset(Offset = "0x140")]
		public UILabel LabelTopCostNum;

		// Token: 0x0400E8AF RID: 59567
		[Token(Token = "0x400E8AF")]
		[FieldOffset(Offset = "0x148")]
		public Transform TopCountDownContainer;

		// Token: 0x0400E8B0 RID: 59568
		[Token(Token = "0x400E8B0")]
		[FieldOffset(Offset = "0x150")]
		public UILabel GemLabel;
	}
}
