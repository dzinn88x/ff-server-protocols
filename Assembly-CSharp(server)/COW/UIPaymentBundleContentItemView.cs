using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200246C RID: 9324
	[Token(Token = "0x200246C")]
	public class UIPaymentBundleContentItemView : UIBaseView
	{
		// Token: 0x0600C3E8 RID: 50152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E8")]
		[Address(RVA = "0x16F15AC", Offset = "0x16F15AC", VA = "0x7BBBEF15AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3E9 RID: 50153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E9")]
		[Address(RVA = "0x16F1800", Offset = "0x16F1800", VA = "0x7BBBEF1800")]
		public UIPaymentBundleContentItemView()
		{
		}

		// Token: 0x0400E9C1 RID: 59841
		[Token(Token = "0x400E9C1")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView ItemView;

		// Token: 0x0400E9C2 RID: 59842
		[Token(Token = "0x400E9C2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ClickButton;

		// Token: 0x0400E9C3 RID: 59843
		[Token(Token = "0x400E9C3")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView DragScrollView;

		// Token: 0x0400E9C4 RID: 59844
		[Token(Token = "0x400E9C4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite QualityBG;

		// Token: 0x0400E9C5 RID: 59845
		[Token(Token = "0x400E9C5")]
		[FieldOffset(Offset = "0x40")]
		public UISprite IconSprite;

		// Token: 0x0400E9C6 RID: 59846
		[Token(Token = "0x400E9C6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NameLabel;

		// Token: 0x0400E9C7 RID: 59847
		[Token(Token = "0x400E9C7")]
		[FieldOffset(Offset = "0x50")]
		public UILabel AmountLabel;

		// Token: 0x0400E9C8 RID: 59848
		[Token(Token = "0x400E9C8")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Quality;
	}
}
