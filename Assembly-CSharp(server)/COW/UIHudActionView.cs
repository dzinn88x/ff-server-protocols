using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002259 RID: 8793
	[Token(Token = "0x2002259")]
	public class UIHudActionView : UIBaseView
	{
		// Token: 0x0600BFC3 RID: 49091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC3")]
		[Address(RVA = "0x1D69094", Offset = "0x1D69094", VA = "0x7BBC569094", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC4")]
		[Address(RVA = "0x1D69208", Offset = "0x1D69208", VA = "0x7BBC569208")]
		public UIHudActionView()
		{
		}

		// Token: 0x0400D328 RID: 54056
		[Token(Token = "0x400D328")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnAction;

		// Token: 0x0400D329 RID: 54057
		[Token(Token = "0x400D329")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ActionNameTxt;

		// Token: 0x0400D32A RID: 54058
		[Token(Token = "0x400D32A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BtnBg;

		// Token: 0x0400D32B RID: 54059
		[Token(Token = "0x400D32B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnIcon;
	}
}
