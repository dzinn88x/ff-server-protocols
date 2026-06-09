using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E7 RID: 8935
	[Token(Token = "0x20022E7")]
	public class UIHudInGameShopCategoryView : UIBaseView
	{
		// Token: 0x0600C0DE RID: 49374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DE")]
		[Address(RVA = "0x1987EB4", Offset = "0x1987EB4", VA = "0x7BBC187EB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0DF RID: 49375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DF")]
		[Address(RVA = "0x1988028", Offset = "0x1988028", VA = "0x7BBC188028")]
		public UIHudInGameShopCategoryView()
		{
		}

		// Token: 0x0400D723 RID: 55075
		[Token(Token = "0x400D723")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget widget;

		// Token: 0x0400D724 RID: 55076
		[Token(Token = "0x400D724")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid ItemsGrid;

		// Token: 0x0400D725 RID: 55077
		[Token(Token = "0x400D725")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButtonGroup toggleGroup;

		// Token: 0x0400D726 RID: 55078
		[Token(Token = "0x400D726")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CategoryName;
	}
}
