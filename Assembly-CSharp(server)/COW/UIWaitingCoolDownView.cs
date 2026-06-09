using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200258D RID: 9613
	[Token(Token = "0x200258D")]
	internal class UIWaitingCoolDownView : UIBaseView
	{
		// Token: 0x0600C62A RID: 50730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62A")]
		[Address(RVA = "0x1685458", Offset = "0x1685458", VA = "0x7BBBE85458", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62B")]
		[Address(RVA = "0x16854F4", Offset = "0x16854F4", VA = "0x7BBBE854F4")]
		public UIWaitingCoolDownView()
		{
		}

		// Token: 0x0400F733 RID: 63283
		[Token(Token = "0x400F733")]
		[FieldOffset(Offset = "0x20")]
		public UILabel seconds;
	}
}
