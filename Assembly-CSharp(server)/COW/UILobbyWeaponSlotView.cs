using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002406 RID: 9222
	[Token(Token = "0x2002406")]
	public class UILobbyWeaponSlotView : UIBaseView
	{
		// Token: 0x0600C31C RID: 49948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C31C")]
		[Address(RVA = "0x19E00A4", Offset = "0x19E00A4", VA = "0x7BBC1E00A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C31D")]
		[Address(RVA = "0x19E0310", Offset = "0x19E0310", VA = "0x7BBC1E0310")]
		public UILobbyWeaponSlotView()
		{
		}

		// Token: 0x0400E352 RID: 58194
		[Token(Token = "0x400E352")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SlotButton;

		// Token: 0x0400E353 RID: 58195
		[Token(Token = "0x400E353")]
		[FieldOffset(Offset = "0x28")]
		public WeaponRackDragDropItem DragDropItem;

		// Token: 0x0400E354 RID: 58196
		[Token(Token = "0x400E354")]
		[FieldOffset(Offset = "0x30")]
		public UIButton DeleteButton;

		// Token: 0x0400E355 RID: 58197
		[Token(Token = "0x400E355")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GunRoot;

		// Token: 0x0400E356 RID: 58198
		[Token(Token = "0x400E356")]
		[FieldOffset(Offset = "0x40")]
		public UISprite GunIcon;

		// Token: 0x0400E357 RID: 58199
		[Token(Token = "0x400E357")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GrenadeRoot;

		// Token: 0x0400E358 RID: 58200
		[Token(Token = "0x400E358")]
		[FieldOffset(Offset = "0x50")]
		public UISprite GrenadeIcon;

		// Token: 0x0400E359 RID: 58201
		[Token(Token = "0x400E359")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Mask;
	}
}
