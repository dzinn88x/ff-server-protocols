using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002351 RID: 9041
	[Token(Token = "0x2002351")]
	public class UIHudReloadBtnView : UIBaseView
	{
		// Token: 0x0600C1B2 RID: 49586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B2")]
		[Address(RVA = "0x17F22A8", Offset = "0x17F22A8", VA = "0x7BBBFF22A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1B3 RID: 49587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B3")]
		[Address(RVA = "0x17F241C", Offset = "0x17F241C", VA = "0x7BBBFF241C")]
		public UIHudReloadBtnView()
		{
		}

		// Token: 0x0400DAF6 RID: 56054
		[Token(Token = "0x400DAF6")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnReload;

		// Token: 0x0400DAF7 RID: 56055
		[Token(Token = "0x400DAF7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Red;

		// Token: 0x0400DAF8 RID: 56056
		[Token(Token = "0x400DAF8")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400DAF9 RID: 56057
		[Token(Token = "0x400DAF9")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Progress;
	}
}
