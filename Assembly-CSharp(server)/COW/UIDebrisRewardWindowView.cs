using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002196 RID: 8598
	[Token(Token = "0x2002196")]
	public class UIDebrisRewardWindowView : UIBaseView
	{
		// Token: 0x0600BE3C RID: 48700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE3C")]
		[Address(RVA = "0x1BB0040", Offset = "0x1BB0040", VA = "0x7BBC3B0040", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE3D RID: 48701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE3D")]
		[Address(RVA = "0x1BB02D4", Offset = "0x1BB02D4", VA = "0x7BBC3B02D4")]
		public UIDebrisRewardWindowView()
		{
		}

		// Token: 0x0400C8AB RID: 51371
		[Token(Token = "0x400C8AB")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TitleLabel;

		// Token: 0x0400C8AC RID: 51372
		[Token(Token = "0x400C8AC")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid AwardGrid;

		// Token: 0x0400C8AD RID: 51373
		[Token(Token = "0x400C8AD")]
		[FieldOffset(Offset = "0x30")]
		public AwardItemView ItemInstance;

		// Token: 0x0400C8AE RID: 51374
		[Token(Token = "0x400C8AE")]
		[FieldOffset(Offset = "0x38")]
		public UISprite RewardIcon;

		// Token: 0x0400C8AF RID: 51375
		[Token(Token = "0x400C8AF")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ItemNameLabel;

		// Token: 0x0400C8B0 RID: 51376
		[Token(Token = "0x400C8B0")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnConfirm;

		// Token: 0x0400C8B1 RID: 51377
		[Token(Token = "0x400C8B1")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ConfirmBtnBg;

		// Token: 0x0400C8B2 RID: 51378
		[Token(Token = "0x400C8B2")]
		[FieldOffset(Offset = "0x58")]
		public Transform BGTopPos2;

		// Token: 0x0400C8B3 RID: 51379
		[Token(Token = "0x400C8B3")]
		[FieldOffset(Offset = "0x60")]
		public Transform BGBottomPos2;
	}
}
