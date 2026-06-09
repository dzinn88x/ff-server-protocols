using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002373 RID: 9075
	[Token(Token = "0x2002373")]
	internal class UIHudSwapWeaponView : UIBaseView
	{
		// Token: 0x0600C1F6 RID: 49654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F6")]
		[Address(RVA = "0x1675D64", Offset = "0x1675D64", VA = "0x7BBBE75D64", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F7")]
		[Address(RVA = "0x1675E54", Offset = "0x1675E54", VA = "0x7BBBE75E54")]
		public UIHudSwapWeaponView()
		{
		}

		// Token: 0x0400DBFD RID: 56317
		[Token(Token = "0x400DBFD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnSwap;

		// Token: 0x0400DBFE RID: 56318
		[Token(Token = "0x400DBFE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnName;
	}
}
