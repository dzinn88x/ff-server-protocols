using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200248C RID: 9356
	[Token(Token = "0x200248C")]
	public class UIpetSelectSkillItemView : UIBaseView
	{
		// Token: 0x0600C428 RID: 50216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C428")]
		[Address(RVA = "0x1793730", Offset = "0x1793730", VA = "0x7BBBF93730", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C429")]
		[Address(RVA = "0x1793910", Offset = "0x1793910", VA = "0x7BBBF93910")]
		public UIpetSelectSkillItemView()
		{
		}

		// Token: 0x0400EB22 RID: 60194
		[Token(Token = "0x400EB22")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIpetSelectSkillItem;

		// Token: 0x0400EB23 RID: 60195
		[Token(Token = "0x400EB23")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UnlockMask;

		// Token: 0x0400EB24 RID: 60196
		[Token(Token = "0x400EB24")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SkillIcon;

		// Token: 0x0400EB25 RID: 60197
		[Token(Token = "0x400EB25")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Skilltitle;

		// Token: 0x0400EB26 RID: 60198
		[Token(Token = "0x400EB26")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SkillDesc;

		// Token: 0x0400EB27 RID: 60199
		[Token(Token = "0x400EB27")]
		[FieldOffset(Offset = "0x48")]
		public UILabel levelLabel;
	}
}
