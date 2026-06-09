using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021DB RID: 8667
	[Token(Token = "0x20021DB")]
	public class UIEscortTutorialView : UIBaseView
	{
		// Token: 0x0600BEC7 RID: 48839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC7")]
		[Address(RVA = "0x1E7D5EC", Offset = "0x1E7D5EC", VA = "0x7BBC67D5EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC8")]
		[Address(RVA = "0x1E7D878", Offset = "0x1E7D878", VA = "0x7BBC67D878")]
		public UIEscortTutorialView()
		{
		}

		// Token: 0x0400CBD3 RID: 52179
		[Token(Token = "0x400CBD3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400CBD4 RID: 52180
		[Token(Token = "0x400CBD4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400CBD5 RID: 52181
		[Token(Token = "0x400CBD5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoDots;

		// Token: 0x0400CBD6 RID: 52182
		[Token(Token = "0x400CBD6")]
		[FieldOffset(Offset = "0x38")]
		public Transform TrDots;

		// Token: 0x0400CBD7 RID: 52183
		[Token(Token = "0x400CBD7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GoWrap;

		// Token: 0x0400CBD8 RID: 52184
		[Token(Token = "0x400CBD8")]
		[FieldOffset(Offset = "0x48")]
		public Transform TrWrap;

		// Token: 0x0400CBD9 RID: 52185
		[Token(Token = "0x400CBD9")]
		[FieldOffset(Offset = "0x50")]
		public UILabel IntroTitle;

		// Token: 0x0400CBDA RID: 52186
		[Token(Token = "0x400CBDA")]
		[FieldOffset(Offset = "0x58")]
		public UIButton Left;

		// Token: 0x0400CBDB RID: 52187
		[Token(Token = "0x400CBDB")]
		[FieldOffset(Offset = "0x60")]
		public UIButton Right;
	}
}
