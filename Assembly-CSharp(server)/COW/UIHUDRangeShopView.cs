using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002343 RID: 9027
	[Token(Token = "0x2002343")]
	public class UIHUDRangeShopView : UIBaseView
	{
		// Token: 0x0600C196 RID: 49558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C196")]
		[Address(RVA = "0x16BDB28", Offset = "0x16BDB28", VA = "0x7BBBEBDB28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C197 RID: 49559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C197")]
		[Address(RVA = "0x16BDD40", Offset = "0x16BDD40", VA = "0x7BBBEBDD40")]
		public UIHUDRangeShopView()
		{
		}

		// Token: 0x0400DABC RID: 55996
		[Token(Token = "0x400DABC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnQuit;

		// Token: 0x0400DABD RID: 55997
		[Token(Token = "0x400DABD")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400DABE RID: 55998
		[Token(Token = "0x400DABE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject TitleLabel;

		// Token: 0x0400DABF RID: 55999
		[Token(Token = "0x400DABF")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView ScrollView;

		// Token: 0x0400DAC0 RID: 56000
		[Token(Token = "0x400DAC0")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid ItemGrid;

		// Token: 0x0400DAC1 RID: 56001
		[Token(Token = "0x400DAC1")]
		[FieldOffset(Offset = "0x48")]
		public UIButton purchaseBtn;

		// Token: 0x0400DAC2 RID: 56002
		[Token(Token = "0x400DAC2")]
		[FieldOffset(Offset = "0x50")]
		public UIButton Mask;
	}
}
