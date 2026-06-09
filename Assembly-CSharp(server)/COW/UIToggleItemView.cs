using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002573 RID: 9587
	[Token(Token = "0x2002573")]
	internal class UIToggleItemView : UIBaseView
	{
		// Token: 0x0600C5F6 RID: 50678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F6")]
		[Address(RVA = "0x1F54D14", Offset = "0x1F54D14", VA = "0x7BBC754D14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F7")]
		[Address(RVA = "0x1F54E2C", Offset = "0x1F54E2C", VA = "0x7BBC754E2C")]
		public UIToggleItemView()
		{
		}

		// Token: 0x0400F62C RID: 63020
		[Token(Token = "0x400F62C")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle ItemToggle;

		// Token: 0x0400F62D RID: 63021
		[Token(Token = "0x400F62D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SelectItemLabel;

		// Token: 0x0400F62E RID: 63022
		[Token(Token = "0x400F62E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel UnSelectItemLabel;
	}
}
