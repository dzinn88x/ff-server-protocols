using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002117 RID: 8471
	[Token(Token = "0x2002117")]
	internal class UIBackButtonView : UIBaseView
	{
		// Token: 0x0600BD3F RID: 48447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3F")]
		[Address(RVA = "0x141EBB8", Offset = "0x141EBB8", VA = "0x7BBBC1EBB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD40")]
		[Address(RVA = "0x141ED24", Offset = "0x141ED24", VA = "0x7BBBC1ED24")]
		public UIBackButtonView()
		{
		}

		// Token: 0x0400C1D4 RID: 49620
		[Token(Token = "0x400C1D4")]
		[FieldOffset(Offset = "0x20")]
		public UIButton leaveBtn;

		// Token: 0x0400C1D5 RID: 49621
		[Token(Token = "0x400C1D5")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ArrowSprite;

		// Token: 0x0400C1D6 RID: 49622
		[Token(Token = "0x400C1D6")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BackLabel;

		// Token: 0x0400C1D7 RID: 49623
		[Token(Token = "0x400C1D7")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ButtonBgSprite;
	}
}
