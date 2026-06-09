using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002562 RID: 9570
	[Token(Token = "0x2002562")]
	public class UISuperCarMainRewardItemView : UIBaseView
	{
		// Token: 0x0600C5D4 RID: 50644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D4")]
		[Address(RVA = "0x2149070", Offset = "0x2149070", VA = "0x7BBC949070", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D5")]
		[Address(RVA = "0x2149460", Offset = "0x2149460", VA = "0x7BBC949460")]
		public UISuperCarMainRewardItemView()
		{
		}

		// Token: 0x0400F54F RID: 62799
		[Token(Token = "0x400F54F")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale ItemTween;

		// Token: 0x0400F550 RID: 62800
		[Token(Token = "0x400F550")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400F551 RID: 62801
		[Token(Token = "0x400F551")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView ItemDragView;

		// Token: 0x0400F552 RID: 62802
		[Token(Token = "0x400F552")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView RewardItem;

		// Token: 0x0400F553 RID: 62803
		[Token(Token = "0x400F553")]
		[FieldOffset(Offset = "0x40")]
		public UISprite QualityBG;

		// Token: 0x0400F554 RID: 62804
		[Token(Token = "0x400F554")]
		[FieldOffset(Offset = "0x48")]
		public UISprite QualityNameBG01;

		// Token: 0x0400F555 RID: 62805
		[Token(Token = "0x400F555")]
		[FieldOffset(Offset = "0x50")]
		public GameObject IconGroup;

		// Token: 0x0400F556 RID: 62806
		[Token(Token = "0x400F556")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Sprite_Debris;

		// Token: 0x0400F557 RID: 62807
		[Token(Token = "0x400F557")]
		[FieldOffset(Offset = "0x60")]
		public UISprite VoucherIcon;

		// Token: 0x0400F558 RID: 62808
		[Token(Token = "0x400F558")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LimitLabel;

		// Token: 0x0400F559 RID: 62809
		[Token(Token = "0x400F559")]
		[FieldOffset(Offset = "0x70")]
		public UILabel QuantityLabel;

		// Token: 0x0400F55A RID: 62810
		[Token(Token = "0x400F55A")]
		[FieldOffset(Offset = "0x78")]
		public GameObject OwnedTitle;

		// Token: 0x0400F55B RID: 62811
		[Token(Token = "0x400F55B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Descargar;

		// Token: 0x0400F55C RID: 62812
		[Token(Token = "0x400F55C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject GreyBg;

		// Token: 0x0400F55D RID: 62813
		[Token(Token = "0x400F55D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject HighLightBG;
	}
}
