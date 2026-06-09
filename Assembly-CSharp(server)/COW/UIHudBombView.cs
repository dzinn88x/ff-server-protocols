using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002282 RID: 8834
	[Token(Token = "0x2002282")]
	public class UIHudBombView : UIBaseView
	{
		// Token: 0x0600C015 RID: 49173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C015")]
		[Address(RVA = "0x189C83C", Offset = "0x189C83C", VA = "0x7BBC09C83C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C016 RID: 49174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C016")]
		[Address(RVA = "0x189C9B0", Offset = "0x189C9B0", VA = "0x7BBC09C9B0")]
		public UIHudBombView()
		{
		}

		// Token: 0x0400D42D RID: 54317
		[Token(Token = "0x400D42D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnBomb;

		// Token: 0x0400D42E RID: 54318
		[Token(Token = "0x400D42E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ActionNameTxt;

		// Token: 0x0400D42F RID: 54319
		[Token(Token = "0x400D42F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BtnBg;

		// Token: 0x0400D430 RID: 54320
		[Token(Token = "0x400D430")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnIcon;
	}
}
