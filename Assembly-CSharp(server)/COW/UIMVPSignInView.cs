using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200244E RID: 9294
	[Token(Token = "0x200244E")]
	public class UIMVPSignInView : UIBaseView
	{
		// Token: 0x0600C3AC RID: 50092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3AC")]
		[Address(RVA = "0x1CD8F74", Offset = "0x1CD8F74", VA = "0x7BBC4D8F74", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3AD")]
		[Address(RVA = "0x1CD930C", Offset = "0x1CD930C", VA = "0x7BBC4D930C")]
		public UIMVPSignInView()
		{
		}

		// Token: 0x0400E7F9 RID: 59385
		[Token(Token = "0x400E7F9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400E7FA RID: 59386
		[Token(Token = "0x400E7FA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Label;

		// Token: 0x0400E7FB RID: 59387
		[Token(Token = "0x400E7FB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel IntroLabel;

		// Token: 0x0400E7FC RID: 59388
		[Token(Token = "0x400E7FC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Box4;

		// Token: 0x0400E7FD RID: 59389
		[Token(Token = "0x400E7FD")]
		[FieldOffset(Offset = "0x40")]
		public Animator Box4VFX;

		// Token: 0x0400E7FE RID: 59390
		[Token(Token = "0x400E7FE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ArrowVfx4;

		// Token: 0x0400E7FF RID: 59391
		[Token(Token = "0x400E7FF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Box1;

		// Token: 0x0400E800 RID: 59392
		[Token(Token = "0x400E800")]
		[FieldOffset(Offset = "0x58")]
		public Animator Box1VFX;

		// Token: 0x0400E801 RID: 59393
		[Token(Token = "0x400E801")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Box2;

		// Token: 0x0400E802 RID: 59394
		[Token(Token = "0x400E802")]
		[FieldOffset(Offset = "0x68")]
		public Animator Box2VFX;

		// Token: 0x0400E803 RID: 59395
		[Token(Token = "0x400E803")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ArrowVfx2;

		// Token: 0x0400E804 RID: 59396
		[Token(Token = "0x400E804")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Box3;

		// Token: 0x0400E805 RID: 59397
		[Token(Token = "0x400E805")]
		[FieldOffset(Offset = "0x80")]
		public Animator Box3VFX;

		// Token: 0x0400E806 RID: 59398
		[Token(Token = "0x400E806")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ArrowVfx3;
	}
}
