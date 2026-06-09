using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002551 RID: 9553
	[Token(Token = "0x2002551")]
	public class UIStandardItemMiniView : UIBaseView
	{
		// Token: 0x0600C5B2 RID: 50610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B2")]
		[Address(RVA = "0x212FDCC", Offset = "0x212FDCC", VA = "0x7BBC92FDCC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5B3 RID: 50611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B3")]
		[Address(RVA = "0x213026C", Offset = "0x213026C", VA = "0x7BBC93026C")]
		public UIStandardItemMiniView()
		{
		}

		// Token: 0x0400F4B6 RID: 62646
		[Token(Token = "0x400F4B6")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale ItemTween;

		// Token: 0x0400F4B7 RID: 62647
		[Token(Token = "0x400F4B7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400F4B8 RID: 62648
		[Token(Token = "0x400F4B8")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView ItemDragView;

		// Token: 0x0400F4B9 RID: 62649
		[Token(Token = "0x400F4B9")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView RewardItem;

		// Token: 0x0400F4BA RID: 62650
		[Token(Token = "0x400F4BA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite QualityBG;

		// Token: 0x0400F4BB RID: 62651
		[Token(Token = "0x400F4BB")]
		[FieldOffset(Offset = "0x48")]
		public UISprite QualityNameBG01;

		// Token: 0x0400F4BC RID: 62652
		[Token(Token = "0x400F4BC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject IconGroup;

		// Token: 0x0400F4BD RID: 62653
		[Token(Token = "0x400F4BD")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Sprite_Debris;

		// Token: 0x0400F4BE RID: 62654
		[Token(Token = "0x400F4BE")]
		[FieldOffset(Offset = "0x60")]
		public UISprite VoucherIcon;

		// Token: 0x0400F4BF RID: 62655
		[Token(Token = "0x400F4BF")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LimitLabel;

		// Token: 0x0400F4C0 RID: 62656
		[Token(Token = "0x400F4C0")]
		[FieldOffset(Offset = "0x70")]
		public UILabel QuantityLabel;

		// Token: 0x0400F4C1 RID: 62657
		[Token(Token = "0x400F4C1")]
		[FieldOffset(Offset = "0x78")]
		public GameObject LimitedTitle;

		// Token: 0x0400F4C2 RID: 62658
		[Token(Token = "0x400F4C2")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ClaimedTitle;

		// Token: 0x0400F4C3 RID: 62659
		[Token(Token = "0x400F4C3")]
		[FieldOffset(Offset = "0x88")]
		public GameObject LadderGotTitle;

		// Token: 0x0400F4C4 RID: 62660
		[Token(Token = "0x400F4C4")]
		[FieldOffset(Offset = "0x90")]
		public GameObject OwnedTitle;

		// Token: 0x0400F4C5 RID: 62661
		[Token(Token = "0x400F4C5")]
		[FieldOffset(Offset = "0x98")]
		public GameObject Descargar;

		// Token: 0x0400F4C6 RID: 62662
		[Token(Token = "0x400F4C6")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject GreyBg;

		// Token: 0x0400F4C7 RID: 62663
		[Token(Token = "0x400F4C7")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject HighLightBG;
	}
}
