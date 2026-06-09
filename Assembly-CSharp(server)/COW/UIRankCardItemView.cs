using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024BF RID: 9407
	[Token(Token = "0x20024BF")]
	internal class UIRankCardItemView : UIBaseView
	{
		// Token: 0x0600C48E RID: 50318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48E")]
		[Address(RVA = "0x1E09C10", Offset = "0x1E09C10", VA = "0x7BBC609C10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48F")]
		[Address(RVA = "0x1E09EF0", Offset = "0x1E09EF0", VA = "0x7BBC609EF0")]
		public UIRankCardItemView()
		{
		}

		// Token: 0x0400EF38 RID: 61240
		[Token(Token = "0x400EF38")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseView;

		// Token: 0x0400EF39 RID: 61241
		[Token(Token = "0x400EF39")]
		[FieldOffset(Offset = "0x28")]
		public UIButton infoBtn;

		// Token: 0x0400EF3A RID: 61242
		[Token(Token = "0x400EF3A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel name;

		// Token: 0x0400EF3B RID: 61243
		[Token(Token = "0x400EF3B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel cnt;

		// Token: 0x0400EF3C RID: 61244
		[Token(Token = "0x400EF3C")]
		[FieldOffset(Offset = "0x40")]
		public UISprite iconBG01;

		// Token: 0x0400EF3D RID: 61245
		[Token(Token = "0x400EF3D")]
		[FieldOffset(Offset = "0x48")]
		public UIButton itemBtn;

		// Token: 0x0400EF3E RID: 61246
		[Token(Token = "0x400EF3E")]
		[FieldOffset(Offset = "0x50")]
		public UISprite icon;

		// Token: 0x0400EF3F RID: 61247
		[Token(Token = "0x400EF3F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HL;

		// Token: 0x0400EF40 RID: 61248
		[Token(Token = "0x400EF40")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NoGotView;

		// Token: 0x0400EF41 RID: 61249
		[Token(Token = "0x400EF41")]
		[FieldOffset(Offset = "0x68")]
		public UILabel label;
	}
}
