using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020EE RID: 8430
	[Token(Token = "0x20020EE")]
	internal class UIAddictConfirmView : UIBaseView
	{
		// Token: 0x0600BCED RID: 48365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCED")]
		[Address(RVA = "0x1968ED8", Offset = "0x1968ED8", VA = "0x7BBC168ED8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEE")]
		[Address(RVA = "0x196906C", Offset = "0x196906C", VA = "0x7BBC16906C")]
		public UIAddictConfirmView()
		{
		}

		// Token: 0x0400BF86 RID: 49030
		[Token(Token = "0x400BF86")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CharacterPic;

		// Token: 0x0400BF87 RID: 49031
		[Token(Token = "0x400BF87")]
		[FieldOffset(Offset = "0x28")]
		public UILabel message;

		// Token: 0x0400BF88 RID: 49032
		[Token(Token = "0x400BF88")]
		[FieldOffset(Offset = "0x30")]
		public UILabel tipmessage;

		// Token: 0x0400BF89 RID: 49033
		[Token(Token = "0x400BF89")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ConfirmWidget;

		// Token: 0x0400BF8A RID: 49034
		[Token(Token = "0x400BF8A")]
		[FieldOffset(Offset = "0x40")]
		public UIButton ConfirmBtn;
	}
}
