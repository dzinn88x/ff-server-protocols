using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E3 RID: 8675
	[Token(Token = "0x20021E3")]
	public class UIFFWSGuessRoundItemView : UIBaseView
	{
		// Token: 0x0600BED7 RID: 48855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED7")]
		[Address(RVA = "0x227A40C", Offset = "0x227A40C", VA = "0x7BBCA7A40C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED8")]
		[Address(RVA = "0x227A570", Offset = "0x227A570", VA = "0x7BBCA7A570")]
		public UIFFWSGuessRoundItemView()
		{
		}

		// Token: 0x0400CC2D RID: 52269
		[Token(Token = "0x400CC2D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnChooseRound;

		// Token: 0x0400CC2E RID: 52270
		[Token(Token = "0x400CC2E")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpriteChosen;

		// Token: 0x0400CC2F RID: 52271
		[Token(Token = "0x400CC2F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SpriteGuessed;

		// Token: 0x0400CC30 RID: 52272
		[Token(Token = "0x400CC30")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelRoundIndex;
	}
}
