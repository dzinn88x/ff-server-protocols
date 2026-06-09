using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002592 RID: 9618
	[Token(Token = "0x2002592")]
	public class UIWeaponSkillItemView : UIBaseView
	{
		// Token: 0x0600C634 RID: 50740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C634")]
		[Address(RVA = "0x1691808", Offset = "0x1691808", VA = "0x7BBBE91808", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C635 RID: 50741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C635")]
		[Address(RVA = "0x1691928", Offset = "0x1691928", VA = "0x7BBBE91928")]
		public UIWeaponSkillItemView()
		{
		}

		// Token: 0x0400F76D RID: 63341
		[Token(Token = "0x400F76D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIWeaponSkillItem;

		// Token: 0x0400F76E RID: 63342
		[Token(Token = "0x400F76E")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400F76F RID: 63343
		[Token(Token = "0x400F76F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel desc;
	}
}
