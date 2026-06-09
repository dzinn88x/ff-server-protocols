using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A5 RID: 8869
	[Token(Token = "0x20022A5")]
	public class UIHudCSEquipCategoryView : UIBaseView
	{
		// Token: 0x0600C05B RID: 49243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C05B")]
		[Address(RVA = "0x19B7EEC", Offset = "0x19B7EEC", VA = "0x7BBC1B7EEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C05C")]
		[Address(RVA = "0x19B8060", Offset = "0x19B8060", VA = "0x7BBC1B8060")]
		public UIHudCSEquipCategoryView()
		{
		}

		// Token: 0x0400D4F7 RID: 54519
		[Token(Token = "0x400D4F7")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget widget;

		// Token: 0x0400D4F8 RID: 54520
		[Token(Token = "0x400D4F8")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid grid;

		// Token: 0x0400D4F9 RID: 54521
		[Token(Token = "0x400D4F9")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButtonGroup toggleGroup;

		// Token: 0x0400D4FA RID: 54522
		[Token(Token = "0x400D4FA")]
		[FieldOffset(Offset = "0x38")]
		public UILabel filterName;
	}
}
