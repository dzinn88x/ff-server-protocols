using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002209 RID: 8713
	[Token(Token = "0x2002209")]
	internal class UIGachaDrawResultItemView : UIBaseView
	{
		// Token: 0x0600BF23 RID: 48931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF23")]
		[Address(RVA = "0x2160948", Offset = "0x2160948", VA = "0x7BBC960948", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF24 RID: 48932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF24")]
		[Address(RVA = "0x2160D40", Offset = "0x2160D40", VA = "0x7BBC960D40")]
		public UIGachaDrawResultItemView()
		{
		}

		// Token: 0x0400CE5B RID: 52827
		[Token(Token = "0x400CE5B")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition FlowAnim;

		// Token: 0x0400CE5C RID: 52828
		[Token(Token = "0x400CE5C")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView RewardItem;

		// Token: 0x0400CE5D RID: 52829
		[Token(Token = "0x400CE5D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NameLabel;

		// Token: 0x0400CE5E RID: 52830
		[Token(Token = "0x400CE5E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject IconGroup;

		// Token: 0x0400CE5F RID: 52831
		[Token(Token = "0x400CE5F")]
		[FieldOffset(Offset = "0x40")]
		public UISprite VoucherIcon;

		// Token: 0x0400CE60 RID: 52832
		[Token(Token = "0x400CE60")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LimitLabel;

		// Token: 0x0400CE61 RID: 52833
		[Token(Token = "0x400CE61")]
		[FieldOffset(Offset = "0x50")]
		public UIToggle RewardToggle;

		// Token: 0x0400CE62 RID: 52834
		[Token(Token = "0x400CE62")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SelectedSprite;

		// Token: 0x0400CE63 RID: 52835
		[Token(Token = "0x400CE63")]
		[FieldOffset(Offset = "0x60")]
		public UISprite UnSelectedSprite;

		// Token: 0x0400CE64 RID: 52836
		[Token(Token = "0x400CE64")]
		[FieldOffset(Offset = "0x68")]
		public UILabel QuantityLabel;

		// Token: 0x0400CE65 RID: 52837
		[Token(Token = "0x400CE65")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ExchangeVoucher;

		// Token: 0x0400CE66 RID: 52838
		[Token(Token = "0x400CE66")]
		[FieldOffset(Offset = "0x78")]
		public TweenAlpha VoucherTweenAnim;

		// Token: 0x0400CE67 RID: 52839
		[Token(Token = "0x400CE67")]
		[FieldOffset(Offset = "0x80")]
		public UISprite VoucherSprite;

		// Token: 0x0400CE68 RID: 52840
		[Token(Token = "0x400CE68")]
		[FieldOffset(Offset = "0x88")]
		public UILabel VoucherCntLabel;

		// Token: 0x0400CE69 RID: 52841
		[Token(Token = "0x400CE69")]
		[FieldOffset(Offset = "0x90")]
		public UISprite GemSprite;
	}
}
