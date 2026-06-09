using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002433 RID: 9267
	[Token(Token = "0x2002433")]
	internal class UIMapModePopMeuItemView : UIBaseView
	{
		// Token: 0x0600C376 RID: 50038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C376")]
		[Address(RVA = "0x146E530", Offset = "0x146E530", VA = "0x7BBBC6E530", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C377")]
		[Address(RVA = "0x146E6D4", Offset = "0x146E6D4", VA = "0x7BBBC6E6D4")]
		public UIMapModePopMeuItemView()
		{
		}

		// Token: 0x0400E6C9 RID: 59081
		[Token(Token = "0x400E6C9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E6CA RID: 59082
		[Token(Token = "0x400E6CA")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400E6CB RID: 59083
		[Token(Token = "0x400E6CB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400E6CC RID: 59084
		[Token(Token = "0x400E6CC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;

		// Token: 0x0400E6CD RID: 59085
		[Token(Token = "0x400E6CD")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Sprite;
	}
}
