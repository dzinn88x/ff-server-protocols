using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002345 RID: 9029
	[Token(Token = "0x2002345")]
	public class UIHudReaperDashBtnView : UIBaseView
	{
		// Token: 0x0600C19A RID: 49562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C19A")]
		[Address(RVA = "0x17E8628", Offset = "0x17E8628", VA = "0x7BBBFE8628", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C19B")]
		[Address(RVA = "0x17E87C4", Offset = "0x17E87C4", VA = "0x7BBBFE87C4")]
		public UIHudReaperDashBtnView()
		{
		}

		// Token: 0x0400DAC7 RID: 56007
		[Token(Token = "0x400DAC7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnSpeedup;

		// Token: 0x0400DAC8 RID: 56008
		[Token(Token = "0x400DAC8")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400DAC9 RID: 56009
		[Token(Token = "0x400DAC9")]
		[FieldOffset(Offset = "0x30")]
		public TweenFill CDBar;

		// Token: 0x0400DACA RID: 56010
		[Token(Token = "0x400DACA")]
		[FieldOffset(Offset = "0x38")]
		public UISprite normal;

		// Token: 0x0400DACB RID: 56011
		[Token(Token = "0x400DACB")]
		[FieldOffset(Offset = "0x40")]
		public UILabel CDLabel;
	}
}
