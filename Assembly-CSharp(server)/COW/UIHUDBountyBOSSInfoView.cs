using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002284 RID: 8836
	[Token(Token = "0x2002284")]
	public class UIHUDBountyBOSSInfoView : UIBaseView
	{
		// Token: 0x0600C019 RID: 49177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C019")]
		[Address(RVA = "0x16B5DA0", Offset = "0x16B5DA0", VA = "0x7BBBEB5DA0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C01A RID: 49178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C01A")]
		[Address(RVA = "0x16B5F34", Offset = "0x16B5F34", VA = "0x7BBBEB5F34")]
		public UIHUDBountyBOSSInfoView()
		{
		}

		// Token: 0x0400D43B RID: 54331
		[Token(Token = "0x400D43B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TipRoot;

		// Token: 0x0400D43C RID: 54332
		[Token(Token = "0x400D43C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject WarningIcon;

		// Token: 0x0400D43D RID: 54333
		[Token(Token = "0x400D43D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel WarningTxt;

		// Token: 0x0400D43E RID: 54334
		[Token(Token = "0x400D43E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GameWinRoot;

		// Token: 0x0400D43F RID: 54335
		[Token(Token = "0x400D43F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BossWeakPointRoot;
	}
}
