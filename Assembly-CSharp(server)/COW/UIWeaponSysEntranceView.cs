using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200259E RID: 9630
	[Token(Token = "0x200259E")]
	public class UIWeaponSysEntranceView : UIBaseView
	{
		// Token: 0x0600C64C RID: 50764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64C")]
		[Address(RVA = "0x17844B4", Offset = "0x17844B4", VA = "0x7BBBF844B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64D")]
		[Address(RVA = "0x1784718", Offset = "0x1784718", VA = "0x7BBBF84718")]
		public UIWeaponSysEntranceView()
		{
		}

		// Token: 0x0400F874 RID: 63604
		[Token(Token = "0x400F874")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400F875 RID: 63605
		[Token(Token = "0x400F875")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnWeaponSkinUpgrader;

		// Token: 0x0400F876 RID: 63606
		[Token(Token = "0x400F876")]
		[FieldOffset(Offset = "0x30")]
		public GameObject UpgraderClickEffect;

		// Token: 0x0400F877 RID: 63607
		[Token(Token = "0x400F877")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelWSPName;

		// Token: 0x0400F878 RID: 63608
		[Token(Token = "0x400F878")]
		[FieldOffset(Offset = "0x40")]
		public GameObject WSUNotInOpenTime;

		// Token: 0x0400F879 RID: 63609
		[Token(Token = "0x400F879")]
		[FieldOffset(Offset = "0x48")]
		public GameObject WSUNewTag;

		// Token: 0x0400F87A RID: 63610
		[Token(Token = "0x400F87A")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnWeaponSkinEnter;

		// Token: 0x0400F87B RID: 63611
		[Token(Token = "0x400F87B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SkinLobbyClickEffect;
	}
}
