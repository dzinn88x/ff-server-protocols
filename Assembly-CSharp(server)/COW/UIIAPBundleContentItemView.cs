using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023BC RID: 9148
	[Token(Token = "0x20023BC")]
	internal class UIIAPBundleContentItemView : UIBaseView
	{
		// Token: 0x0600C288 RID: 49800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C288")]
		[Address(RVA = "0x1D23B0C", Offset = "0x1D23B0C", VA = "0x7BBC523B0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C289 RID: 49801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C289")]
		[Address(RVA = "0x1D23DDC", Offset = "0x1D23DDC", VA = "0x7BBC523DDC")]
		public UIIAPBundleContentItemView()
		{
		}

		// Token: 0x0400DE4A RID: 56906
		[Token(Token = "0x400DE4A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton IAPBundleButton;

		// Token: 0x0400DE4B RID: 56907
		[Token(Token = "0x400DE4B")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView IAPBundleItemView;

		// Token: 0x0400DE4C RID: 56908
		[Token(Token = "0x400DE4C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400DE4D RID: 56909
		[Token(Token = "0x400DE4D")]
		[FieldOffset(Offset = "0x38")]
		public UISprite IconSprite;

		// Token: 0x0400DE4E RID: 56910
		[Token(Token = "0x400DE4E")]
		[FieldOffset(Offset = "0x40")]
		public UISprite NotchSprite;

		// Token: 0x0400DE4F RID: 56911
		[Token(Token = "0x400DE4F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DurationLabel;

		// Token: 0x0400DE50 RID: 56912
		[Token(Token = "0x400DE50")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ClockSprite;

		// Token: 0x0400DE51 RID: 56913
		[Token(Token = "0x400DE51")]
		[FieldOffset(Offset = "0x58")]
		public UILabel AmountLabel;

		// Token: 0x0400DE52 RID: 56914
		[Token(Token = "0x400DE52")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Owned;

		// Token: 0x0400DE53 RID: 56915
		[Token(Token = "0x400DE53")]
		[FieldOffset(Offset = "0x68")]
		public UILabel OwnedLabel;
	}
}
