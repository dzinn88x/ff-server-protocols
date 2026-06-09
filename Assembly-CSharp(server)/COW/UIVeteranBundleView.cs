using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002585 RID: 9605
	[Token(Token = "0x2002585")]
	public class UIVeteranBundleView : UIBaseView
	{
		// Token: 0x0600C61A RID: 50714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61A")]
		[Address(RVA = "0x1A0B90C", Offset = "0x1A0B90C", VA = "0x7BBC20B90C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C61B RID: 50715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61B")]
		[Address(RVA = "0x1A0BC34", Offset = "0x1A0BC34", VA = "0x7BBC20BC34")]
		public UIVeteranBundleView()
		{
		}

		// Token: 0x0400F6E6 RID: 63206
		[Token(Token = "0x400F6E6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BundleImageLocal;

		// Token: 0x0400F6E7 RID: 63207
		[Token(Token = "0x400F6E7")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt BundleImageRemote;

		// Token: 0x0400F6E8 RID: 63208
		[Token(Token = "0x400F6E8")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ScrollView;

		// Token: 0x0400F6E9 RID: 63209
		[Token(Token = "0x400F6E9")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList List;

		// Token: 0x0400F6EA RID: 63210
		[Token(Token = "0x400F6EA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject WaitClaim;

		// Token: 0x0400F6EB RID: 63211
		[Token(Token = "0x400F6EB")]
		[FieldOffset(Offset = "0x48")]
		public UIButton Operation;

		// Token: 0x0400F6EC RID: 63212
		[Token(Token = "0x400F6EC")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ActualPriceLabel;

		// Token: 0x0400F6ED RID: 63213
		[Token(Token = "0x400F6ED")]
		[FieldOffset(Offset = "0x58")]
		public UILabel OriginalPriceLabel;

		// Token: 0x0400F6EE RID: 63214
		[Token(Token = "0x400F6EE")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Claimed;

		// Token: 0x0400F6EF RID: 63215
		[Token(Token = "0x400F6EF")]
		[FieldOffset(Offset = "0x68")]
		public UISprite GreySprite;

		// Token: 0x0400F6F0 RID: 63216
		[Token(Token = "0x400F6F0")]
		[FieldOffset(Offset = "0x70")]
		public UILabel ClaimedLabel;
	}
}
