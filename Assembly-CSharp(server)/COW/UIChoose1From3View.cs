using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200215A RID: 8538
	[Token(Token = "0x200215A")]
	public class UIChoose1From3View : UIBaseView
	{
		// Token: 0x0600BDC4 RID: 48580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC4")]
		[Address(RVA = "0x1BF4EFC", Offset = "0x1BF4EFC", VA = "0x7BBC3F4EFC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC5")]
		[Address(RVA = "0x1BF5204", Offset = "0x1BF5204", VA = "0x7BBC3F5204")]
		public UIChoose1From3View()
		{
		}

		// Token: 0x0400C559 RID: 50521
		[Token(Token = "0x400C559")]
		[FieldOffset(Offset = "0x20")]
		public UILabel DefaultLabelTitle;

		// Token: 0x0400C55A RID: 50522
		[Token(Token = "0x400C55A")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CDNTitle;

		// Token: 0x0400C55B RID: 50523
		[Token(Token = "0x400C55B")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClaim;

		// Token: 0x0400C55C RID: 50524
		[Token(Token = "0x400C55C")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnRecharge;

		// Token: 0x0400C55D RID: 50525
		[Token(Token = "0x400C55D")]
		[FieldOffset(Offset = "0x40")]
		public Transform Item0;

		// Token: 0x0400C55E RID: 50526
		[Token(Token = "0x400C55E")]
		[FieldOffset(Offset = "0x48")]
		public Transform Item1;

		// Token: 0x0400C55F RID: 50527
		[Token(Token = "0x400C55F")]
		[FieldOffset(Offset = "0x50")]
		public Transform Item2;

		// Token: 0x0400C560 RID: 50528
		[Token(Token = "0x400C560")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget RightBorder;

		// Token: 0x0400C561 RID: 50529
		[Token(Token = "0x400C561")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget LeftBorder;

		// Token: 0x0400C562 RID: 50530
		[Token(Token = "0x400C562")]
		[FieldOffset(Offset = "0x68")]
		public Transform CountDown;

		// Token: 0x0400C563 RID: 50531
		[Token(Token = "0x400C563")]
		[FieldOffset(Offset = "0x70")]
		public UIButton Close;
	}
}
