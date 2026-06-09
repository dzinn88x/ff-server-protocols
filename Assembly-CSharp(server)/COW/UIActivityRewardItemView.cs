using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E6 RID: 8422
	[Token(Token = "0x20020E6")]
	internal class UIActivityRewardItemView : UIBaseView
	{
		// Token: 0x0600BCDD RID: 48349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDD")]
		[Address(RVA = "0x195A8F8", Offset = "0x195A8F8", VA = "0x7BBC15A8F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDE")]
		[Address(RVA = "0x195AB5C", Offset = "0x195AB5C", VA = "0x7BBC15AB5C")]
		public UIActivityRewardItemView()
		{
		}

		// Token: 0x0400BF31 RID: 48945
		[Token(Token = "0x400BF31")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BG;

		// Token: 0x0400BF32 RID: 48946
		[Token(Token = "0x400BF32")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400BF33 RID: 48947
		[Token(Token = "0x400BF33")]
		[FieldOffset(Offset = "0x30")]
		public UISprite IconSprite;

		// Token: 0x0400BF34 RID: 48948
		[Token(Token = "0x400BF34")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CountLabel;

		// Token: 0x0400BF35 RID: 48949
		[Token(Token = "0x400BF35")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ExchangeCountLabel;

		// Token: 0x0400BF36 RID: 48950
		[Token(Token = "0x400BF36")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NameLabel;

		// Token: 0x0400BF37 RID: 48951
		[Token(Token = "0x400BF37")]
		[FieldOffset(Offset = "0x50")]
		public UISprite WeaponSprite;

		// Token: 0x0400BF38 RID: 48952
		[Token(Token = "0x400BF38")]
		[FieldOffset(Offset = "0x58")]
		public UIToggle ToggleBtn;
	}
}
