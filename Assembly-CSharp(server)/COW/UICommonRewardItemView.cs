using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002182 RID: 8578
	[Token(Token = "0x2002182")]
	public class UICommonRewardItemView : UIBaseView
	{
		// Token: 0x0600BE14 RID: 48660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE14")]
		[Address(RVA = "0x18063D0", Offset = "0x18063D0", VA = "0x7BBC0063D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE15 RID: 48661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE15")]
		[Address(RVA = "0x180675C", Offset = "0x180675C", VA = "0x7BBC00675C")]
		public UICommonRewardItemView()
		{
		}

		// Token: 0x0400C796 RID: 51094
		[Token(Token = "0x400C796")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale UICommonRewardItem;

		// Token: 0x0400C797 RID: 51095
		[Token(Token = "0x400C797")]
		[FieldOffset(Offset = "0x28")]
		public Animation UICommonRewardItemAnimation;

		// Token: 0x0400C798 RID: 51096
		[Token(Token = "0x400C798")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RewardItem;

		// Token: 0x0400C799 RID: 51097
		[Token(Token = "0x400C799")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LimitLabel;

		// Token: 0x0400C79A RID: 51098
		[Token(Token = "0x400C79A")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle RewardToggle;

		// Token: 0x0400C79B RID: 51099
		[Token(Token = "0x400C79B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SelectedSprite;

		// Token: 0x0400C79C RID: 51100
		[Token(Token = "0x400C79C")]
		[FieldOffset(Offset = "0x50")]
		public UISprite UnSelectedSprite;

		// Token: 0x0400C79D RID: 51101
		[Token(Token = "0x400C79D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel QuantityLabel;

		// Token: 0x0400C79E RID: 51102
		[Token(Token = "0x400C79E")]
		[FieldOffset(Offset = "0x60")]
		public UIToggle OptionalToggle;

		// Token: 0x0400C79F RID: 51103
		[Token(Token = "0x400C79F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ExchangeVoucher;

		// Token: 0x0400C7A0 RID: 51104
		[Token(Token = "0x400C7A0")]
		[FieldOffset(Offset = "0x70")]
		public TweenAlpha VoucherTweenAnim;

		// Token: 0x0400C7A1 RID: 51105
		[Token(Token = "0x400C7A1")]
		[FieldOffset(Offset = "0x78")]
		public UISprite VoucherSprite;

		// Token: 0x0400C7A2 RID: 51106
		[Token(Token = "0x400C7A2")]
		[FieldOffset(Offset = "0x80")]
		public UILabel VoucherCntLabel;
	}
}
