using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002445 RID: 9285
	[Token(Token = "0x2002445")]
	public class UIMegaFestivalExchangeItemView : UIBaseView
	{
		// Token: 0x0600C39A RID: 50074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39A")]
		[Address(RVA = "0x14849A8", Offset = "0x14849A8", VA = "0x7BBBC849A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39B")]
		[Address(RVA = "0x1484C24", Offset = "0x1484C24", VA = "0x7BBBC84C24")]
		public UIMegaFestivalExchangeItemView()
		{
		}

		// Token: 0x0400E784 RID: 59268
		[Token(Token = "0x400E784")]
		[FieldOffset(Offset = "0x20")]
		public Transform ExchangeItemGrid;

		// Token: 0x0400E785 RID: 59269
		[Token(Token = "0x400E785")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Operation;

		// Token: 0x0400E786 RID: 59270
		[Token(Token = "0x400E786")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BGGray;

		// Token: 0x0400E787 RID: 59271
		[Token(Token = "0x400E787")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BGYellow;

		// Token: 0x0400E788 RID: 59272
		[Token(Token = "0x400E788")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Title;

		// Token: 0x0400E789 RID: 59273
		[Token(Token = "0x400E789")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ProgressTips;

		// Token: 0x0400E78A RID: 59274
		[Token(Token = "0x400E78A")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView AwardScrollView;

		// Token: 0x0400E78B RID: 59275
		[Token(Token = "0x400E78B")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid AwardGrid;
	}
}
