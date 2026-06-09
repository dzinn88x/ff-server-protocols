using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002207 RID: 8711
	[Token(Token = "0x2002207")]
	public class UIGachaCouponExpireInfoView : UIBaseView
	{
		// Token: 0x0600BF1F RID: 48927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1F")]
		[Address(RVA = "0x215F8F4", Offset = "0x215F8F4", VA = "0x7BBC95F8F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF20 RID: 48928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF20")]
		[Address(RVA = "0x215FA98", Offset = "0x215FA98", VA = "0x7BBC95FA98")]
		public UIGachaCouponExpireInfoView()
		{
		}

		// Token: 0x0400CE52 RID: 52818
		[Token(Token = "0x400CE52")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemGrid;

		// Token: 0x0400CE53 RID: 52819
		[Token(Token = "0x400CE53")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList ItemEasyList;

		// Token: 0x0400CE54 RID: 52820
		[Token(Token = "0x400CE54")]
		[FieldOffset(Offset = "0x30")]
		public UIButton GoToBtn;

		// Token: 0x0400CE55 RID: 52821
		[Token(Token = "0x400CE55")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnBG;

		// Token: 0x0400CE56 RID: 52822
		[Token(Token = "0x400CE56")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle ToggleTOS;
	}
}
