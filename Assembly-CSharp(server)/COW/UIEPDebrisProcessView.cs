using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021CE RID: 8654
	[Token(Token = "0x20021CE")]
	public class UIEPDebrisProcessView : UIBaseView
	{
		// Token: 0x0600BEAD RID: 48813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAD")]
		[Address(RVA = "0x2214A88", Offset = "0x2214A88", VA = "0x7BBCA14A88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEAE RID: 48814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAE")]
		[Address(RVA = "0x2214BF4", Offset = "0x2214BF4", VA = "0x7BBCA14BF4")]
		public UIEPDebrisProcessView()
		{
		}

		// Token: 0x0400CB50 RID: 52048
		[Token(Token = "0x400CB50")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BadgeIcon;

		// Token: 0x0400CB51 RID: 52049
		[Token(Token = "0x400CB51")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BadgeCnt;

		// Token: 0x0400CB52 RID: 52050
		[Token(Token = "0x400CB52")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar EpProgressBar;

		// Token: 0x0400CB53 RID: 52051
		[Token(Token = "0x400CB53")]
		[FieldOffset(Offset = "0x38")]
		public UILabel EpProcessCnt;
	}
}
