using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200247A RID: 9338
	[Token(Token = "0x200247A")]
	internal class UIPaymentShopView : UIBaseView
	{
		// Token: 0x0600C404 RID: 50180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C404")]
		[Address(RVA = "0x1F2DD8C", Offset = "0x1F2DD8C", VA = "0x7BBC72DD8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C405")]
		[Address(RVA = "0x1F2DF84", Offset = "0x1F2DF84", VA = "0x7BBC72DF84")]
		public UIPaymentShopView()
		{
		}

		// Token: 0x0400EA70 RID: 60016
		[Token(Token = "0x400EA70")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPaymentShop;

		// Token: 0x0400EA71 RID: 60017
		[Token(Token = "0x400EA71")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt MainAdNetworkTexture;

		// Token: 0x0400EA72 RID: 60018
		[Token(Token = "0x400EA72")]
		[FieldOffset(Offset = "0x30")]
		public UIButton NetworkImageBtn;

		// Token: 0x0400EA73 RID: 60019
		[Token(Token = "0x400EA73")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Button;

		// Token: 0x0400EA74 RID: 60020
		[Token(Token = "0x400EA74")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ButtonLabel;

		// Token: 0x0400EA75 RID: 60021
		[Token(Token = "0x400EA75")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BtnOperateBgYellow;
	}
}
