using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200249F RID: 9375
	[Token(Token = "0x200249F")]
	public class UIPPTOPView : UIBaseView
	{
		// Token: 0x0600C44E RID: 50254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44E")]
		[Address(RVA = "0x16E1F2C", Offset = "0x16E1F2C", VA = "0x7BBBEE1F2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44F")]
		[Address(RVA = "0x16E2044", Offset = "0x16E2044", VA = "0x7BBBEE2044")]
		public UIPPTOPView()
		{
		}

		// Token: 0x0400EC0B RID: 60427
		[Token(Token = "0x400EC0B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnService;

		// Token: 0x0400EC0C RID: 60428
		[Token(Token = "0x400EC0C")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnPrivacy;

		// Token: 0x0400EC0D RID: 60429
		[Token(Token = "0x400EC0D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnAgree;
	}
}
