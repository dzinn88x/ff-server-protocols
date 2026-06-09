using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002319 RID: 8985
	[Token(Token = "0x2002319")]
	internal class UIHudNameBattleFlagView : UIBaseView
	{
		// Token: 0x0600C142 RID: 49474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C142")]
		[Address(RVA = "0x17B7584", Offset = "0x17B7584", VA = "0x7BBBFB7584", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C143")]
		[Address(RVA = "0x17B7620", Offset = "0x17B7620", VA = "0x7BBBFB7620")]
		public UIHudNameBattleFlagView()
		{
		}

		// Token: 0x0400D99D RID: 55709
		[Token(Token = "0x400D99D")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NameLabel;
	}
}
