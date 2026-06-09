using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002366 RID: 9062
	[Token(Token = "0x2002366")]
	public class UIHudSkillKnockDownBleedView : UIBaseView
	{
		// Token: 0x0600C1DC RID: 49628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1DC")]
		[Address(RVA = "0x16696F8", Offset = "0x16696F8", VA = "0x7BBBE696F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1DD")]
		[Address(RVA = "0x166989C", Offset = "0x166989C", VA = "0x7BBBE6989C")]
		public UIHudSkillKnockDownBleedView()
		{
		}

		// Token: 0x0400DBC6 RID: 56262
		[Token(Token = "0x400DBC6")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SkillIcon;

		// Token: 0x0400DBC7 RID: 56263
		[Token(Token = "0x400DBC7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Tips;

		// Token: 0x0400DBC8 RID: 56264
		[Token(Token = "0x400DBC8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Effect;

		// Token: 0x0400DBC9 RID: 56265
		[Token(Token = "0x400DBC9")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Mask;

		// Token: 0x0400DBCA RID: 56266
		[Token(Token = "0x400DBCA")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnTip;
	}
}
