using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002454 RID: 9300
	[Token(Token = "0x2002454")]
	public class UIMysteryMallItemView : UIBaseView
	{
		// Token: 0x0600C3B8 RID: 50104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B8")]
		[Address(RVA = "0x14D3F88", Offset = "0x14D3F88", VA = "0x7BBBCD3F88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B9")]
		[Address(RVA = "0x14D468C", Offset = "0x14D468C", VA = "0x7BBBCD468C")]
		public UIMysteryMallItemView()
		{
		}

		// Token: 0x0400E857 RID: 59479
		[Token(Token = "0x400E857")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PriceContainer;

		// Token: 0x0400E858 RID: 59480
		[Token(Token = "0x400E858")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelOriginPrice;

		// Token: 0x0400E859 RID: 59481
		[Token(Token = "0x400E859")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelDiscountPrice;

		// Token: 0x0400E85A RID: 59482
		[Token(Token = "0x400E85A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelLimit;

		// Token: 0x0400E85B RID: 59483
		[Token(Token = "0x400E85B")]
		[FieldOffset(Offset = "0x40")]
		public UIButton ItemBtn;

		// Token: 0x0400E85C RID: 59484
		[Token(Token = "0x400E85C")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget ItemWidget;

		// Token: 0x0400E85D RID: 59485
		[Token(Token = "0x400E85D")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NewLabel;

		// Token: 0x0400E85E RID: 59486
		[Token(Token = "0x400E85E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LimitedLabel;

		// Token: 0x0400E85F RID: 59487
		[Token(Token = "0x400E85F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LimitedPurchaseLabel;

		// Token: 0x0400E860 RID: 59488
		[Token(Token = "0x400E860")]
		[FieldOffset(Offset = "0x68")]
		public GameObject HotLabel;

		// Token: 0x0400E861 RID: 59489
		[Token(Token = "0x400E861")]
		[FieldOffset(Offset = "0x70")]
		public UILabel DiscountLabel;

		// Token: 0x0400E862 RID: 59490
		[Token(Token = "0x400E862")]
		[FieldOffset(Offset = "0x78")]
		public MeshRenderer VFXDiscout;

		// Token: 0x0400E863 RID: 59491
		[Token(Token = "0x400E863")]
		[FieldOffset(Offset = "0x80")]
		public GameObject EarlyBirdLabel;

		// Token: 0x0400E864 RID: 59492
		[Token(Token = "0x400E864")]
		[FieldOffset(Offset = "0x88")]
		public UISprite DiscountBg;

		// Token: 0x0400E865 RID: 59493
		[Token(Token = "0x400E865")]
		[FieldOffset(Offset = "0x90")]
		public UISprite QualityBG;

		// Token: 0x0400E866 RID: 59494
		[Token(Token = "0x400E866")]
		[FieldOffset(Offset = "0x98")]
		public GameObject BaseItemView;

		// Token: 0x0400E867 RID: 59495
		[Token(Token = "0x400E867")]
		[FieldOffset(Offset = "0xA0")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400E868 RID: 59496
		[Token(Token = "0x400E868")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite VoucherIcon;

		// Token: 0x0400E869 RID: 59497
		[Token(Token = "0x400E869")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject LockedTitle;

		// Token: 0x0400E86A RID: 59498
		[Token(Token = "0x400E86A")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject OwnedTitle;

		// Token: 0x0400E86B RID: 59499
		[Token(Token = "0x400E86B")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject ClaimedTitle;

		// Token: 0x0400E86C RID: 59500
		[Token(Token = "0x400E86C")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject LimitedTitle;

		// Token: 0x0400E86D RID: 59501
		[Token(Token = "0x400E86D")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite IPTag;

		// Token: 0x0400E86E RID: 59502
		[Token(Token = "0x400E86E")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BtnPurchase;

		// Token: 0x0400E86F RID: 59503
		[Token(Token = "0x400E86F")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite Purchased;

		// Token: 0x0400E870 RID: 59504
		[Token(Token = "0x400E870")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite Purchasable;

		// Token: 0x0400E871 RID: 59505
		[Token(Token = "0x400E871")]
		[FieldOffset(Offset = "0xF0")]
		public UINetworkTextureExt CdnItem;

		// Token: 0x0400E872 RID: 59506
		[Token(Token = "0x400E872")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite ItemNameQualityBg;

		// Token: 0x0400E873 RID: 59507
		[Token(Token = "0x400E873")]
		[FieldOffset(Offset = "0x100")]
		public UILabel LabelItemName;
	}
}
