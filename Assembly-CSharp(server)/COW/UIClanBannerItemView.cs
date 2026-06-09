using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002163 RID: 8547
	[Token(Token = "0x2002163")]
	internal class UIClanBannerItemView : UIBaseView
	{
		// Token: 0x0600BDD6 RID: 48598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD6")]
		[Address(RVA = "0x1CEBE14", Offset = "0x1CEBE14", VA = "0x7BBC4EBE14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD7")]
		[Address(RVA = "0x1CEBFB0", Offset = "0x1CEBFB0", VA = "0x7BBC4EBFB0")]
		public UIClanBannerItemView()
		{
		}

		// Token: 0x0400C59B RID: 50587
		[Token(Token = "0x400C59B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Item;

		// Token: 0x0400C59C RID: 50588
		[Token(Token = "0x400C59C")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400C59D RID: 50589
		[Token(Token = "0x400C59D")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite Banner;

		// Token: 0x0400C59E RID: 50590
		[Token(Token = "0x400C59E")]
		[FieldOffset(Offset = "0x38")]
		public UISprite MiniBanner;

		// Token: 0x0400C59F RID: 50591
		[Token(Token = "0x400C59F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel name;
	}
}
