using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200228A RID: 8842
	[Token(Token = "0x200228A")]
	internal class UIHudBuffListItemView : UIBaseView
	{
		// Token: 0x0600C025 RID: 49189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C025")]
		[Address(RVA = "0x19B5248", Offset = "0x19B5248", VA = "0x7BBC1B5248", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C026 RID: 49190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C026")]
		[Address(RVA = "0x19B5338", Offset = "0x19B5338", VA = "0x7BBC1B5338")]
		public UIHudBuffListItemView()
		{
		}

		// Token: 0x0400D452 RID: 54354
		[Token(Token = "0x400D452")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SpriteItemIcon;

		// Token: 0x0400D453 RID: 54355
		[Token(Token = "0x400D453")]
		[FieldOffset(Offset = "0x28")]
		public UISprite CountDown;
	}
}
