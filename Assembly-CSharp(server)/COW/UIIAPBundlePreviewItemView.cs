using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023BD RID: 9149
	[Token(Token = "0x20023BD")]
	internal class UIIAPBundlePreviewItemView : UIBaseView
	{
		// Token: 0x0600C28A RID: 49802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28A")]
		[Address(RVA = "0x1D298A4", Offset = "0x1D298A4", VA = "0x7BBC5298A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C28B RID: 49803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28B")]
		[Address(RVA = "0x1D29A84", Offset = "0x1D29A84", VA = "0x7BBC529A84")]
		public UIIAPBundlePreviewItemView()
		{
		}

		// Token: 0x0400DE54 RID: 56916
		[Token(Token = "0x400DE54")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClickBtn;

		// Token: 0x0400DE55 RID: 56917
		[Token(Token = "0x400DE55")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView IAPBundleItemView;

		// Token: 0x0400DE56 RID: 56918
		[Token(Token = "0x400DE56")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BundleIconSprite;

		// Token: 0x0400DE57 RID: 56919
		[Token(Token = "0x400DE57")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BundleNameLabel;

		// Token: 0x0400DE58 RID: 56920
		[Token(Token = "0x400DE58")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BundlePriceLabel;

		// Token: 0x0400DE59 RID: 56921
		[Token(Token = "0x400DE59")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OriginalPriceLabel;
	}
}
