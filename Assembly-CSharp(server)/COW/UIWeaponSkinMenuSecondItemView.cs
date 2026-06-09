using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002595 RID: 9621
	[Token(Token = "0x2002595")]
	public class UIWeaponSkinMenuSecondItemView : UIBaseView
	{
		// Token: 0x0600C63A RID: 50746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63A")]
		[Address(RVA = "0x221A52C", Offset = "0x221A52C", VA = "0x7BBCA1A52C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C63B RID: 50747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63B")]
		[Address(RVA = "0x221A744", Offset = "0x221A744", VA = "0x7BBCA1A744")]
		public UIWeaponSkinMenuSecondItemView()
		{
		}

		// Token: 0x0400F7D3 RID: 63443
		[Token(Token = "0x400F7D3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400F7D4 RID: 63444
		[Token(Token = "0x400F7D4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HighLight;

		// Token: 0x0400F7D5 RID: 63445
		[Token(Token = "0x400F7D5")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Sprite;

		// Token: 0x0400F7D6 RID: 63446
		[Token(Token = "0x400F7D6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Label;

		// Token: 0x0400F7D7 RID: 63447
		[Token(Token = "0x400F7D7")]
		[FieldOffset(Offset = "0x40")]
		public UISprite icespr;

		// Token: 0x0400F7D8 RID: 63448
		[Token(Token = "0x400F7D8")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Count;

		// Token: 0x0400F7D9 RID: 63449
		[Token(Token = "0x400F7D9")]
		[FieldOffset(Offset = "0x50")]
		public GameObject TipsGO;
	}
}
