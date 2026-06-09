using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D5 RID: 8405
	[Token(Token = "0x20020D5")]
	internal class UIAccountIDNickNameLoginWindowView : UIBaseView
	{
		// Token: 0x0600BCBB RID: 48315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBB")]
		[Address(RVA = "0x1A3B3AC", Offset = "0x1A3B3AC", VA = "0x7BBC23B3AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCBC RID: 48316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBC")]
		[Address(RVA = "0x1A3B550", Offset = "0x1A3B550", VA = "0x7BBC23B550")]
		public UIAccountIDNickNameLoginWindowView()
		{
		}

		// Token: 0x0400BE7B RID: 48763
		[Token(Token = "0x400BE7B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400BE7C RID: 48764
		[Token(Token = "0x400BE7C")]
		[FieldOffset(Offset = "0x28")]
		public UIInput InputNewName;

		// Token: 0x0400BE7D RID: 48765
		[Token(Token = "0x400BE7D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelPrice;

		// Token: 0x0400BE7E RID: 48766
		[Token(Token = "0x400BE7E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnConfirm;

		// Token: 0x0400BE7F RID: 48767
		[Token(Token = "0x400BE7F")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ConfirmBtnBg;
	}
}
