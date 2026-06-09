using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200237F RID: 9087
	[Token(Token = "0x200237F")]
	public class UIHudTestSkateBoardView : UIBaseView
	{
		// Token: 0x0600C20E RID: 49678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20E")]
		[Address(RVA = "0x15E5C54", Offset = "0x15E5C54", VA = "0x7BBBDE5C54", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20F")]
		[Address(RVA = "0x15E5E34", Offset = "0x15E5E34", VA = "0x7BBBDE5E34")]
		public UIHudTestSkateBoardView()
		{
		}

		// Token: 0x0400DC8B RID: 56459
		[Token(Token = "0x400DC8B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ToggleDebug;

		// Token: 0x0400DC8C RID: 56460
		[Token(Token = "0x400DC8C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Test;

		// Token: 0x0400DC8D RID: 56461
		[Token(Token = "0x400DC8D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject skateboardBtnTemplate;

		// Token: 0x0400DC8E RID: 56462
		[Token(Token = "0x400DC8E")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList easyList;

		// Token: 0x0400DC8F RID: 56463
		[Token(Token = "0x400DC8F")]
		[FieldOffset(Offset = "0x40")]
		public UIInput searchInput;

		// Token: 0x0400DC90 RID: 56464
		[Token(Token = "0x400DC90")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList searchEasyList;
	}
}
