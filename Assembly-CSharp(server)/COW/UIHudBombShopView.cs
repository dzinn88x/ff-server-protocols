using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002281 RID: 8833
	[Token(Token = "0x2002281")]
	public class UIHudBombShopView : UIBaseView
	{
		// Token: 0x0600C013 RID: 49171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C013")]
		[Address(RVA = "0x189C564", Offset = "0x189C564", VA = "0x7BBC09C564", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C014")]
		[Address(RVA = "0x189C834", Offset = "0x189C834", VA = "0x7BBC09C834")]
		public UIHudBombShopView()
		{
		}

		// Token: 0x0400D423 RID: 54307
		[Token(Token = "0x400D423")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Close;

		// Token: 0x0400D424 RID: 54308
		[Token(Token = "0x400D424")]
		[FieldOffset(Offset = "0x28")]
		public UIButton bgBtn;

		// Token: 0x0400D425 RID: 54309
		[Token(Token = "0x400D425")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LeftTimeShow;

		// Token: 0x0400D426 RID: 54310
		[Token(Token = "0x400D426")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LeftTime;

		// Token: 0x0400D427 RID: 54311
		[Token(Token = "0x400D427")]
		[FieldOffset(Offset = "0x40")]
		public UILabel cost;

		// Token: 0x0400D428 RID: 54312
		[Token(Token = "0x400D428")]
		[FieldOffset(Offset = "0x48")]
		public UILabel left;

		// Token: 0x0400D429 RID: 54313
		[Token(Token = "0x400D429")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView ScrollView;

		// Token: 0x0400D42A RID: 54314
		[Token(Token = "0x400D42A")]
		[FieldOffset(Offset = "0x58")]
		public UITable shopTable;

		// Token: 0x0400D42B RID: 54315
		[Token(Token = "0x400D42B")]
		[FieldOffset(Offset = "0x60")]
		public UIButton purchaseBtn;

		// Token: 0x0400D42C RID: 54316
		[Token(Token = "0x400D42C")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BuySameBtn;
	}
}
