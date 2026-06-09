using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B6 RID: 9398
	[Token(Token = "0x20024B6")]
	internal class UIPVEWeaponBtnView : UIBaseView
	{
		// Token: 0x0600C47C RID: 50300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47C")]
		[Address(RVA = "0x16E7458", Offset = "0x16E7458", VA = "0x7BBBEE7458", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47D")]
		[Address(RVA = "0x16E75FC", Offset = "0x16E75FC", VA = "0x7BBBEE75FC")]
		public UIPVEWeaponBtnView()
		{
		}

		// Token: 0x0400EEDA RID: 61146
		[Token(Token = "0x400EEDA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton pveWeaponBtn;

		// Token: 0x0400EEDB RID: 61147
		[Token(Token = "0x400EEDB")]
		[FieldOffset(Offset = "0x28")]
		public UISprite weaponIcon;

		// Token: 0x0400EEDC RID: 61148
		[Token(Token = "0x400EEDC")]
		[FieldOffset(Offset = "0x30")]
		public UILabel weaponName;

		// Token: 0x0400EEDD RID: 61149
		[Token(Token = "0x400EEDD")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TipsGO;

		// Token: 0x0400EEDE RID: 61150
		[Token(Token = "0x400EEDE")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TagLabel;
	}
}
