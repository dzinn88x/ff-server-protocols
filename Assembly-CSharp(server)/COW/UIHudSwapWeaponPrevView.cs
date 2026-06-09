using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002371 RID: 9073
	[Token(Token = "0x2002371")]
	internal class UIHudSwapWeaponPrevView : UIBaseView
	{
		// Token: 0x0600C1F2 RID: 49650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F2")]
		[Address(RVA = "0x1675890", Offset = "0x1675890", VA = "0x7BBBE75890", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F3")]
		[Address(RVA = "0x167592C", Offset = "0x167592C", VA = "0x7BBBE7592C")]
		public UIHudSwapWeaponPrevView()
		{
		}

		// Token: 0x0400DBFB RID: 56315
		[Token(Token = "0x400DBFB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton swapBtn;
	}
}
