using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200246A RID: 9322
	[Token(Token = "0x200246A")]
	internal class UIPaymentActivityView : UIBaseView
	{
		// Token: 0x0600C3E4 RID: 50148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E4")]
		[Address(RVA = "0x16EFF44", Offset = "0x16EFF44", VA = "0x7BBBEEFF44", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E5")]
		[Address(RVA = "0x16F0164", Offset = "0x16F0164", VA = "0x7BBBEF0164")]
		public UIPaymentActivityView()
		{
		}

		// Token: 0x0400E9B4 RID: 59828
		[Token(Token = "0x400E9B4")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPaymentActivity;

		// Token: 0x0400E9B5 RID: 59829
		[Token(Token = "0x400E9B5")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt MainAdNetworkTexture;

		// Token: 0x0400E9B6 RID: 59830
		[Token(Token = "0x400E9B6")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Button;

		// Token: 0x0400E9B7 RID: 59831
		[Token(Token = "0x400E9B7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ButtonLabel;

		// Token: 0x0400E9B8 RID: 59832
		[Token(Token = "0x400E9B8")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BtnOperateBgWhite;

		// Token: 0x0400E9B9 RID: 59833
		[Token(Token = "0x400E9B9")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BtnOperateBgGray;

		// Token: 0x0400E9BA RID: 59834
		[Token(Token = "0x400E9BA")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BtnOperateBgYellow;
	}
}
