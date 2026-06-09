using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200240B RID: 9227
	[Token(Token = "0x200240B")]
	internal class UILuckyBagItemView : UIBaseView
	{
		// Token: 0x0600C326 RID: 49958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C326")]
		[Address(RVA = "0x19EB8FC", Offset = "0x19EB8FC", VA = "0x7BBC1EB8FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C327 RID: 49959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C327")]
		[Address(RVA = "0x19EBB14", Offset = "0x19EBB14", VA = "0x7BBC1EBB14")]
		public UILuckyBagItemView()
		{
		}

		// Token: 0x0400E3B1 RID: 58289
		[Token(Token = "0x400E3B1")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LuckyBagMessage;

		// Token: 0x0400E3B2 RID: 58290
		[Token(Token = "0x400E3B2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton DrawBtn;

		// Token: 0x0400E3B3 RID: 58291
		[Token(Token = "0x400E3B3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite DrawBtnBG;

		// Token: 0x0400E3B4 RID: 58292
		[Token(Token = "0x400E3B4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DrawBtnLabel;

		// Token: 0x0400E3B5 RID: 58293
		[Token(Token = "0x400E3B5")]
		[FieldOffset(Offset = "0x40")]
		public UICountDownLabel ExpiredTime;

		// Token: 0x0400E3B6 RID: 58294
		[Token(Token = "0x400E3B6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TakenNum;

		// Token: 0x0400E3B7 RID: 58295
		[Token(Token = "0x400E3B7")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TotalNum;
	}
}
