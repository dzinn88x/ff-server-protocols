using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002596 RID: 9622
	[Token(Token = "0x2002596")]
	public class UIWeaponSkinMenuThirdItemView : UIBaseView
	{
		// Token: 0x0600C63C RID: 50748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63C")]
		[Address(RVA = "0x221C8E8", Offset = "0x221C8E8", VA = "0x7BBCA1C8E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C63D RID: 50749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63D")]
		[Address(RVA = "0x221CF40", Offset = "0x221CF40", VA = "0x7BBCA1CF40")]
		public UIWeaponSkinMenuThirdItemView()
		{
		}

		// Token: 0x0400F7DA RID: 63450
		[Token(Token = "0x400F7DA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemButton;

		// Token: 0x0400F7DB RID: 63451
		[Token(Token = "0x400F7DB")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel PanelGoToMallWeapon;

		// Token: 0x0400F7DC RID: 63452
		[Token(Token = "0x400F7DC")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnGoToMallWeapon;

		// Token: 0x0400F7DD RID: 63453
		[Token(Token = "0x400F7DD")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteBtnGoToMallWeaponBg;

		// Token: 0x0400F7DE RID: 63454
		[Token(Token = "0x400F7DE")]
		[FieldOffset(Offset = "0x40")]
		public Transform TrWeaponDetail;

		// Token: 0x0400F7DF RID: 63455
		[Token(Token = "0x400F7DF")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Quality;

		// Token: 0x0400F7E0 RID: 63456
		[Token(Token = "0x400F7E0")]
		[FieldOffset(Offset = "0x50")]
		public UISprite QualityBG;

		// Token: 0x0400F7E1 RID: 63457
		[Token(Token = "0x400F7E1")]
		[FieldOffset(Offset = "0x58")]
		public GameObject gray;

		// Token: 0x0400F7E2 RID: 63458
		[Token(Token = "0x400F7E2")]
		[FieldOffset(Offset = "0x60")]
		public GameObject effectBg;

		// Token: 0x0400F7E3 RID: 63459
		[Token(Token = "0x400F7E3")]
		[FieldOffset(Offset = "0x68")]
		public UISprite WeaponSprite;

		// Token: 0x0400F7E4 RID: 63460
		[Token(Token = "0x400F7E4")]
		[FieldOffset(Offset = "0x70")]
		public GameObject HL;

		// Token: 0x0400F7E5 RID: 63461
		[Token(Token = "0x400F7E5")]
		[FieldOffset(Offset = "0x78")]
		public GameObject WL;

		// Token: 0x0400F7E6 RID: 63462
		[Token(Token = "0x400F7E6")]
		[FieldOffset(Offset = "0x80")]
		public UISprite stateSprite;

		// Token: 0x0400F7E7 RID: 63463
		[Token(Token = "0x400F7E7")]
		[FieldOffset(Offset = "0x88")]
		public UILabel state;

		// Token: 0x0400F7E8 RID: 63464
		[Token(Token = "0x400F7E8")]
		[FieldOffset(Offset = "0x90")]
		public UISprite validSprite;

		// Token: 0x0400F7E9 RID: 63465
		[Token(Token = "0x400F7E9")]
		[FieldOffset(Offset = "0x98")]
		public UILabel valid;

		// Token: 0x0400F7EA RID: 63466
		[Token(Token = "0x400F7EA")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite descSprite;

		// Token: 0x0400F7EB RID: 63467
		[Token(Token = "0x400F7EB")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel description;

		// Token: 0x0400F7EC RID: 63468
		[Token(Token = "0x400F7EC")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite Download;

		// Token: 0x0400F7ED RID: 63469
		[Token(Token = "0x400F7ED")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject LevelObj;

		// Token: 0x0400F7EE RID: 63470
		[Token(Token = "0x400F7EE")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel LevelLabel;

		// Token: 0x0400F7EF RID: 63471
		[Token(Token = "0x400F7EF")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite LevelIcon;

		// Token: 0x0400F7F0 RID: 63472
		[Token(Token = "0x400F7F0")]
		[FieldOffset(Offset = "0xD0")]
		public Transform LevelCommonTr;

		// Token: 0x0400F7F1 RID: 63473
		[Token(Token = "0x400F7F1")]
		[FieldOffset(Offset = "0xD8")]
		public Transform LevelLeftTr;

		// Token: 0x0400F7F2 RID: 63474
		[Token(Token = "0x400F7F2")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject TipsGO;

		// Token: 0x0400F7F3 RID: 63475
		[Token(Token = "0x400F7F3")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite GrenadeSprite;
	}
}
