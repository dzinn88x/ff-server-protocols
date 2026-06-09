using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002574 RID: 9588
	[Token(Token = "0x2002574")]
	internal class UIToggleSpriteItemView : UIBaseView
	{
		// Token: 0x0600C5F8 RID: 50680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F8")]
		[Address(RVA = "0x1F55210", Offset = "0x1F55210", VA = "0x7BBC755210", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F9")]
		[Address(RVA = "0x1F55328", Offset = "0x1F55328", VA = "0x7BBC755328")]
		public UIToggleSpriteItemView()
		{
		}

		// Token: 0x0400F62F RID: 63023
		[Token(Token = "0x400F62F")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle ItemToggle;

		// Token: 0x0400F630 RID: 63024
		[Token(Token = "0x400F630")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Sprite;

		// Token: 0x0400F631 RID: 63025
		[Token(Token = "0x400F631")]
		[FieldOffset(Offset = "0x30")]
		public UISprite UnselectedSprite;
	}
}
