using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200235F RID: 9055
	[Token(Token = "0x200235F")]
	internal class UIHudShowCaseIntroductionView : UIBaseView
	{
		// Token: 0x0600C1CE RID: 49614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1CE")]
		[Address(RVA = "0x1664B3C", Offset = "0x1664B3C", VA = "0x7BBBE64B3C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1CF")]
		[Address(RVA = "0x1664C5C", Offset = "0x1664C5C", VA = "0x7BBBE64C5C")]
		public UIHudShowCaseIntroductionView()
		{
		}

		// Token: 0x0400DB7B RID: 56187
		[Token(Token = "0x400DB7B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400DB7C RID: 56188
		[Token(Token = "0x400DB7C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Content;

		// Token: 0x0400DB7D RID: 56189
		[Token(Token = "0x400DB7D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;
	}
}
