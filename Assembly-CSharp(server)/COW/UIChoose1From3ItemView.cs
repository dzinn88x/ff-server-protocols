using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002159 RID: 8537
	[Token(Token = "0x2002159")]
	public class UIChoose1From3ItemView : UIBaseView
	{
		// Token: 0x0600BDC2 RID: 48578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC2")]
		[Address(RVA = "0x1BF4C14", Offset = "0x1BF4C14", VA = "0x7BBC3F4C14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDC3 RID: 48579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC3")]
		[Address(RVA = "0x1BF4EF4", Offset = "0x1BF4EF4", VA = "0x7BBC3F4EF4")]
		public UIChoose1From3ItemView()
		{
		}

		// Token: 0x0400C54F RID: 50511
		[Token(Token = "0x400C54F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ItemName;

		// Token: 0x0400C550 RID: 50512
		[Token(Token = "0x400C550")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HighLight;

		// Token: 0x0400C551 RID: 50513
		[Token(Token = "0x400C551")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ItemButton;

		// Token: 0x0400C552 RID: 50514
		[Token(Token = "0x400C552")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView ItemIconContainer;

		// Token: 0x0400C553 RID: 50515
		[Token(Token = "0x400C553")]
		[FieldOffset(Offset = "0x40")]
		public UISprite NewQualityicon;

		// Token: 0x0400C554 RID: 50516
		[Token(Token = "0x400C554")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NotRecharge;

		// Token: 0x0400C555 RID: 50517
		[Token(Token = "0x400C555")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ChooseHasRecharge;

		// Token: 0x0400C556 RID: 50518
		[Token(Token = "0x400C556")]
		[FieldOffset(Offset = "0x58")]
		public GameObject PriceContent;

		// Token: 0x0400C557 RID: 50519
		[Token(Token = "0x400C557")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Price;

		// Token: 0x0400C558 RID: 50520
		[Token(Token = "0x400C558")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BG;
	}
}
