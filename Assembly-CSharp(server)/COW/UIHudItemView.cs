using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F4 RID: 8948
	[Token(Token = "0x20022F4")]
	internal class UIHudItemView : UIBaseView
	{
		// Token: 0x0600C0F8 RID: 49400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F8")]
		[Address(RVA = "0x1C4C62C", Offset = "0x1C4C62C", VA = "0x7BBC44C62C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0F9 RID: 49401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F9")]
		[Address(RVA = "0x1C4C71C", Offset = "0x1C4C71C", VA = "0x7BBC44C71C")]
		public UIHudItemView()
		{
		}

		// Token: 0x0400D7D9 RID: 55257
		[Token(Token = "0x400D7D9")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SpriteItemIcon;

		// Token: 0x0400D7DA RID: 55258
		[Token(Token = "0x400D7DA")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnItemAction;
	}
}
