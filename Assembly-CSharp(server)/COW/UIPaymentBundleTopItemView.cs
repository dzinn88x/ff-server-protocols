using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200246F RID: 9327
	[Token(Token = "0x200246F")]
	public class UIPaymentBundleTopItemView : UIBaseView
	{
		// Token: 0x0600C3EE RID: 50158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3EE")]
		[Address(RVA = "0x16FB574", Offset = "0x16FB574", VA = "0x7BBBEFB574", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3EF RID: 50159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3EF")]
		[Address(RVA = "0x16FB8B8", Offset = "0x16FB8B8", VA = "0x7BBBEFB8B8")]
		public UIPaymentBundleTopItemView()
		{
		}

		// Token: 0x0400E9FC RID: 59900
		[Token(Token = "0x400E9FC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400E9FD RID: 59901
		[Token(Token = "0x400E9FD")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Select;

		// Token: 0x0400E9FE RID: 59902
		[Token(Token = "0x400E9FE")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SelectBg;

		// Token: 0x0400E9FF RID: 59903
		[Token(Token = "0x400E9FF")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SelectLabel;

		// Token: 0x0400EA00 RID: 59904
		[Token(Token = "0x400EA00")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SelectLine;

		// Token: 0x0400EA01 RID: 59905
		[Token(Token = "0x400EA01")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SelectIcon;

		// Token: 0x0400EA02 RID: 59906
		[Token(Token = "0x400EA02")]
		[FieldOffset(Offset = "0x50")]
		public GameObject UnSelect;

		// Token: 0x0400EA03 RID: 59907
		[Token(Token = "0x400EA03")]
		[FieldOffset(Offset = "0x58")]
		public UISprite UnSelectBg;

		// Token: 0x0400EA04 RID: 59908
		[Token(Token = "0x400EA04")]
		[FieldOffset(Offset = "0x60")]
		public UISprite UnSelectIcon;

		// Token: 0x0400EA05 RID: 59909
		[Token(Token = "0x400EA05")]
		[FieldOffset(Offset = "0x68")]
		public UILabel UnSelectLabel;

		// Token: 0x0400EA06 RID: 59910
		[Token(Token = "0x400EA06")]
		[FieldOffset(Offset = "0x70")]
		public GameObject RedPoint;

		// Token: 0x0400EA07 RID: 59911
		[Token(Token = "0x400EA07")]
		[FieldOffset(Offset = "0x78")]
		public UISprite TabIcon;
	}
}
