using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002447 RID: 9287
	[Token(Token = "0x2002447")]
	internal class UIModifyClanNameView : UIBaseView
	{
		// Token: 0x0600C39E RID: 50078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39E")]
		[Address(RVA = "0x14C7D00", Offset = "0x14C7D00", VA = "0x7BBBCC7D00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39F")]
		[Address(RVA = "0x14C7EF0", Offset = "0x14C7EF0", VA = "0x7BBBCC7EF0")]
		public UIModifyClanNameView()
		{
		}

		// Token: 0x0400E78D RID: 59277
		[Token(Token = "0x400E78D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400E78E RID: 59278
		[Token(Token = "0x400E78E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelCurrentName;

		// Token: 0x0400E78F RID: 59279
		[Token(Token = "0x400E78F")]
		[FieldOffset(Offset = "0x30")]
		public UIInput InputNewName;

		// Token: 0x0400E790 RID: 59280
		[Token(Token = "0x400E790")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelPrice;

		// Token: 0x0400E791 RID: 59281
		[Token(Token = "0x400E791")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnConfirm;

		// Token: 0x0400E792 RID: 59282
		[Token(Token = "0x400E792")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ConfirmBtnBg;
	}
}
