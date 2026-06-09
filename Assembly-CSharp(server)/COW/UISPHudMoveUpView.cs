using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200251A RID: 9498
	[Token(Token = "0x200251A")]
	internal class UISPHudMoveUpView : UIBaseView
	{
		// Token: 0x0600C544 RID: 50500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C544")]
		[Address(RVA = "0x1EEA430", Offset = "0x1EEA430", VA = "0x7BBC6EA430", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C545 RID: 50501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C545")]
		[Address(RVA = "0x1EEA548", Offset = "0x1EEA548", VA = "0x7BBC6EA548")]
		public UISPHudMoveUpView()
		{
		}

		// Token: 0x0400F289 RID: 62089
		[Token(Token = "0x400F289")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnSpeedup;

		// Token: 0x0400F28A RID: 62090
		[Token(Token = "0x400F28A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400F28B RID: 62091
		[Token(Token = "0x400F28B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;
	}
}
