using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002581 RID: 9601
	[Token(Token = "0x2002581")]
	public class UIUnLockSkillSlotWindowView : UIBaseView
	{
		// Token: 0x0600C612 RID: 50706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C612")]
		[Address(RVA = "0x19FB9B4", Offset = "0x19FB9B4", VA = "0x7BBC1FB9B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C613 RID: 50707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C613")]
		[Address(RVA = "0x19FBD20", Offset = "0x19FBD20", VA = "0x7BBC1FBD20")]
		public UIUnLockSkillSlotWindowView()
		{
		}

		// Token: 0x0400F6BD RID: 63165
		[Token(Token = "0x400F6BD")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SkillIcon;

		// Token: 0x0400F6BE RID: 63166
		[Token(Token = "0x400F6BE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SkillDesc;

		// Token: 0x0400F6BF RID: 63167
		[Token(Token = "0x400F6BF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ConfirmLabel;

		// Token: 0x0400F6C0 RID: 63168
		[Token(Token = "0x400F6C0")]
		[FieldOffset(Offset = "0x38")]
		public UILabel AdditionalDebrisLabel;

		// Token: 0x0400F6C1 RID: 63169
		[Token(Token = "0x400F6C1")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid BtnGrid;

		// Token: 0x0400F6C2 RID: 63170
		[Token(Token = "0x400F6C2")]
		[FieldOffset(Offset = "0x48")]
		public UIButton GemsBuyBtn;

		// Token: 0x0400F6C3 RID: 63171
		[Token(Token = "0x400F6C3")]
		[FieldOffset(Offset = "0x50")]
		public UISprite GemsBtnBG;

		// Token: 0x0400F6C4 RID: 63172
		[Token(Token = "0x400F6C4")]
		[FieldOffset(Offset = "0x58")]
		public UISprite DiamondIcon;

		// Token: 0x0400F6C5 RID: 63173
		[Token(Token = "0x400F6C5")]
		[FieldOffset(Offset = "0x60")]
		public UILabel GemsPriceLabel;

		// Token: 0x0400F6C6 RID: 63174
		[Token(Token = "0x400F6C6")]
		[FieldOffset(Offset = "0x68")]
		public UIButton CoinsBuyBtn;

		// Token: 0x0400F6C7 RID: 63175
		[Token(Token = "0x400F6C7")]
		[FieldOffset(Offset = "0x70")]
		public UISprite GoldIcon;

		// Token: 0x0400F6C8 RID: 63176
		[Token(Token = "0x400F6C8")]
		[FieldOffset(Offset = "0x78")]
		public UILabel CoinsPriceLabel;

		// Token: 0x0400F6C9 RID: 63177
		[Token(Token = "0x400F6C9")]
		[FieldOffset(Offset = "0x80")]
		public UISprite CoinsBtnBG;
	}
}
