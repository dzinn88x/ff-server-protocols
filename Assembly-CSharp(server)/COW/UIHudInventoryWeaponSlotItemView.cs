using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F0 RID: 8944
	[Token(Token = "0x20022F0")]
	internal class UIHudInventoryWeaponSlotItemView : UIBaseView
	{
		// Token: 0x0600C0F0 RID: 49392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F0")]
		[Address(RVA = "0x1C47BD8", Offset = "0x1C47BD8", VA = "0x7BBC447BD8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0F1 RID: 49393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F1")]
		[Address(RVA = "0x1C481A0", Offset = "0x1C481A0", VA = "0x7BBC4481A0")]
		public UIHudInventoryWeaponSlotItemView()
		{
		}

		// Token: 0x0400D7B2 RID: 55218
		[Token(Token = "0x400D7B2")]
		[FieldOffset(Offset = "0x20")]
		public UIInventoryItemDragDropContainer DragDropContainer;

		// Token: 0x0400D7B3 RID: 55219
		[Token(Token = "0x400D7B3")]
		[FieldOffset(Offset = "0x28")]
		public UIInventoryItemDrapDrop DragDropItem;

		// Token: 0x0400D7B4 RID: 55220
		[Token(Token = "0x400D7B4")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle ItemToggle;

		// Token: 0x0400D7B5 RID: 55221
		[Token(Token = "0x400D7B5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject DragGO;

		// Token: 0x0400D7B6 RID: 55222
		[Token(Token = "0x400D7B6")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ItemDragIcon;

		// Token: 0x0400D7B7 RID: 55223
		[Token(Token = "0x400D7B7")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DeleteMask;

		// Token: 0x0400D7B8 RID: 55224
		[Token(Token = "0x400D7B8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NonDragGO;

		// Token: 0x0400D7B9 RID: 55225
		[Token(Token = "0x400D7B9")]
		[FieldOffset(Offset = "0x58")]
		public UISprite WeaponIcon;

		// Token: 0x0400D7BA RID: 55226
		[Token(Token = "0x400D7BA")]
		[FieldOffset(Offset = "0x60")]
		public UILabel AmmoCount;

		// Token: 0x0400D7BB RID: 55227
		[Token(Token = "0x400D7BB")]
		[FieldOffset(Offset = "0x68")]
		public GameObject MuzzleSlotEmptyBG;

		// Token: 0x0400D7BC RID: 55228
		[Token(Token = "0x400D7BC")]
		[FieldOffset(Offset = "0x70")]
		public Transform MuzzleSlot;

		// Token: 0x0400D7BD RID: 55229
		[Token(Token = "0x400D7BD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ForegripSlotEmptyBG;

		// Token: 0x0400D7BE RID: 55230
		[Token(Token = "0x400D7BE")]
		[FieldOffset(Offset = "0x80")]
		public Transform ForegripSlot;

		// Token: 0x0400D7BF RID: 55231
		[Token(Token = "0x400D7BF")]
		[FieldOffset(Offset = "0x88")]
		public GameObject MagazineSlotEmptyBG;

		// Token: 0x0400D7C0 RID: 55232
		[Token(Token = "0x400D7C0")]
		[FieldOffset(Offset = "0x90")]
		public Transform MagazineSlot;

		// Token: 0x0400D7C1 RID: 55233
		[Token(Token = "0x400D7C1")]
		[FieldOffset(Offset = "0x98")]
		public Transform SightSlot;

		// Token: 0x0400D7C2 RID: 55234
		[Token(Token = "0x400D7C2")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject SightSlotEmptyBG;

		// Token: 0x0400D7C3 RID: 55235
		[Token(Token = "0x400D7C3")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject HighlightGO;

		// Token: 0x0400D7C4 RID: 55236
		[Token(Token = "0x400D7C4")]
		[FieldOffset(Offset = "0xB0")]
		public Transform GunstockSlot;

		// Token: 0x0400D7C5 RID: 55237
		[Token(Token = "0x400D7C5")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject GunstockSlotEmptyBG;

		// Token: 0x0400D7C6 RID: 55238
		[Token(Token = "0x400D7C6")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject GoldSlotEmptyBG;

		// Token: 0x0400D7C7 RID: 55239
		[Token(Token = "0x400D7C7")]
		[FieldOffset(Offset = "0xC8")]
		public Transform GoldSlot;

		// Token: 0x0400D7C8 RID: 55240
		[Token(Token = "0x400D7C8")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject CombineSprite;
	}
}
