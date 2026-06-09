using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025F6 RID: 9718
	[Token(Token = "0x20025F6")]
	internal class UILauncherView : UIBaseView
	{
		// Token: 0x0600C8AA RID: 51370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8AA")]
		[Address(RVA = "0x1E29700", Offset = "0x1E29700", VA = "0x7BBC629700", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C8AB RID: 51371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8AB")]
		[Address(RVA = "0x1E29820", Offset = "0x1E29820", VA = "0x7BBC629820")]
		public UILauncherView()
		{
		}

		// Token: 0x0400FB10 RID: 64272
		[Token(Token = "0x400FB10")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ProgressText;

		// Token: 0x0400FB11 RID: 64273
		[Token(Token = "0x400FB11")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400FB12 RID: 64274
		[Token(Token = "0x400FB12")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ProgressRightEnd;
	}
}
