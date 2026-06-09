using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C5 RID: 9157
	[Token(Token = "0x20023C5")]
	public class UIInstallmentRepayView : UIBaseView
	{
		// Token: 0x0600C29A RID: 49818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C29A")]
		[Address(RVA = "0x19107B4", Offset = "0x19107B4", VA = "0x7BBC1107B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C29B")]
		[Address(RVA = "0x1910B20", Offset = "0x1910B20", VA = "0x7BBC110B20")]
		public UIInstallmentRepayView()
		{
		}

		// Token: 0x0400DEEA RID: 57066
		[Token(Token = "0x400DEEA")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400DEEB RID: 57067
		[Token(Token = "0x400DEEB")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemIcon;

		// Token: 0x0400DEEC RID: 57068
		[Token(Token = "0x400DEEC")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WeaponIcon;

		// Token: 0x0400DEED RID: 57069
		[Token(Token = "0x400DEED")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ItemNameLabel;

		// Token: 0x0400DEEE RID: 57070
		[Token(Token = "0x400DEEE")]
		[FieldOffset(Offset = "0x40")]
		public UISprite VoucherIcon;

		// Token: 0x0400DEEF RID: 57071
		[Token(Token = "0x400DEEF")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RepayTips;

		// Token: 0x0400DEF0 RID: 57072
		[Token(Token = "0x400DEF0")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ButtonGroup;

		// Token: 0x0400DEF1 RID: 57073
		[Token(Token = "0x400DEF1")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnOKGO;

		// Token: 0x0400DEF2 RID: 57074
		[Token(Token = "0x400DEF2")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnOK;

		// Token: 0x0400DEF3 RID: 57075
		[Token(Token = "0x400DEF3")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BtnOKSprite;

		// Token: 0x0400DEF4 RID: 57076
		[Token(Token = "0x400DEF4")]
		[FieldOffset(Offset = "0x70")]
		public GameObject BtnCancelGO;

		// Token: 0x0400DEF5 RID: 57077
		[Token(Token = "0x400DEF5")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnCancel;

		// Token: 0x0400DEF6 RID: 57078
		[Token(Token = "0x400DEF6")]
		[FieldOffset(Offset = "0x80")]
		public UISprite BtnCancelSprite;
	}
}
