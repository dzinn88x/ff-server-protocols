using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002372 RID: 9074
	[Token(Token = "0x2002372")]
	internal class UIHudSwapWeaponQuickView : UIBaseView
	{
		// Token: 0x0600C1F4 RID: 49652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F4")]
		[Address(RVA = "0x1675CC0", Offset = "0x1675CC0", VA = "0x7BBBE75CC0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F5")]
		[Address(RVA = "0x1675D5C", Offset = "0x1675D5C", VA = "0x7BBBE75D5C")]
		public UIHudSwapWeaponQuickView()
		{
		}

		// Token: 0x0400DBFC RID: 56316
		[Token(Token = "0x400DBFC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnSwapWeapon;
	}
}
