using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002594 RID: 9620
	[Token(Token = "0x2002594")]
	public class UIWeaponSkinMenuFirstItemView : UIBaseView
	{
		// Token: 0x0600C638 RID: 50744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C638")]
		[Address(RVA = "0x2218F48", Offset = "0x2218F48", VA = "0x7BBCA18F48", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C639 RID: 50745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C639")]
		[Address(RVA = "0x22191A4", Offset = "0x22191A4", VA = "0x7BBCA191A4")]
		public UIWeaponSkinMenuFirstItemView()
		{
		}

		// Token: 0x0400F7CB RID: 63435
		[Token(Token = "0x400F7CB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400F7CC RID: 63436
		[Token(Token = "0x400F7CC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UnSelect;

		// Token: 0x0400F7CD RID: 63437
		[Token(Token = "0x400F7CD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel UnSelectLabel;

		// Token: 0x0400F7CE RID: 63438
		[Token(Token = "0x400F7CE")]
		[FieldOffset(Offset = "0x38")]
		public GameObject UnSelectBg;

		// Token: 0x0400F7CF RID: 63439
		[Token(Token = "0x400F7CF")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Select;

		// Token: 0x0400F7D0 RID: 63440
		[Token(Token = "0x400F7D0")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SelectLabel;

		// Token: 0x0400F7D1 RID: 63441
		[Token(Token = "0x400F7D1")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SelectBg;

		// Token: 0x0400F7D2 RID: 63442
		[Token(Token = "0x400F7D2")]
		[FieldOffset(Offset = "0x58")]
		public GameObject TipsGO;
	}
}
