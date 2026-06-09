using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002360 RID: 9056
	[Token(Token = "0x2002360")]
	public class UIHudSightView : UIBaseView
	{
		// Token: 0x0600C1D0 RID: 49616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D0")]
		[Address(RVA = "0x1665370", Offset = "0x1665370", VA = "0x7BBBE65370", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D1")]
		[Address(RVA = "0x1665550", Offset = "0x1665550", VA = "0x7BBBE65550")]
		public UIHudSightView()
		{
		}

		// Token: 0x0400DB7E RID: 56190
		[Token(Token = "0x400DB7E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnToggleSight;

		// Token: 0x0400DB7F RID: 56191
		[Token(Token = "0x400DB7F")]
		[FieldOffset(Offset = "0x28")]
		public UISprite AimHighlightSprite;

		// Token: 0x0400DB80 RID: 56192
		[Token(Token = "0x400DB80")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtClose;

		// Token: 0x0400DB81 RID: 56193
		[Token(Token = "0x400DB81")]
		[FieldOffset(Offset = "0x38")]
		public UISprite AimSprite;

		// Token: 0x0400DB82 RID: 56194
		[Token(Token = "0x400DB82")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BGToggleSight;

		// Token: 0x0400DB83 RID: 56195
		[Token(Token = "0x400DB83")]
		[FieldOffset(Offset = "0x48")]
		public UILabel BtnName;
	}
}
