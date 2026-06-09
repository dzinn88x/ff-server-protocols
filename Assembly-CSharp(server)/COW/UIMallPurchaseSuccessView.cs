using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200241C RID: 9244
	[Token(Token = "0x200241C")]
	internal class UIMallPurchaseSuccessView : UIBaseView
	{
		// Token: 0x0600C348 RID: 49992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C348")]
		[Address(RVA = "0x1DF0D34", Offset = "0x1DF0D34", VA = "0x7BBC5F0D34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C349")]
		[Address(RVA = "0x1DF0EA8", Offset = "0x1DF0EA8", VA = "0x7BBC5F0EA8")]
		public UIMallPurchaseSuccessView()
		{
		}

		// Token: 0x0400E4F4 RID: 58612
		[Token(Token = "0x400E4F4")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400E4F5 RID: 58613
		[Token(Token = "0x400E4F5")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OpenBtn;

		// Token: 0x0400E4F6 RID: 58614
		[Token(Token = "0x400E4F6")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnLabel;

		// Token: 0x0400E4F7 RID: 58615
		[Token(Token = "0x400E4F7")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ItemIcon;
	}
}
