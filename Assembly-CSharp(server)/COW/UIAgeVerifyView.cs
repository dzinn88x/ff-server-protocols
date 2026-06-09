using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F0 RID: 8432
	[Token(Token = "0x20020F0")]
	public class UIAgeVerifyView : UIBaseView
	{
		// Token: 0x0600BCF1 RID: 48369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF1")]
		[Address(RVA = "0x1969778", Offset = "0x1969778", VA = "0x7BBC169778", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCF2 RID: 48370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF2")]
		[Address(RVA = "0x19698D4", Offset = "0x19698D4", VA = "0x7BBC1698D4")]
		public UIAgeVerifyView()
		{
		}

		// Token: 0x0400BF94 RID: 49044
		[Token(Token = "0x400BF94")]
		[FieldOffset(Offset = "0x20")]
		public UIButton LowAge;

		// Token: 0x0400BF95 RID: 49045
		[Token(Token = "0x400BF95")]
		[FieldOffset(Offset = "0x28")]
		public UIButton MidAge;

		// Token: 0x0400BF96 RID: 49046
		[Token(Token = "0x400BF96")]
		[FieldOffset(Offset = "0x30")]
		public UIButton HighAge;

		// Token: 0x0400BF97 RID: 49047
		[Token(Token = "0x400BF97")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Skip;
	}
}
