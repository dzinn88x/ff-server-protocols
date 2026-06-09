using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002254 RID: 8788
	[Token(Token = "0x2002254")]
	public class UIHeroicMarkDetailWndView : UIBaseView
	{
		// Token: 0x0600BFB9 RID: 49081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB9")]
		[Address(RVA = "0x1D5DB8C", Offset = "0x1D5DB8C", VA = "0x7BBC55DB8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFBA RID: 49082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBA")]
		[Address(RVA = "0x1D5DDB4", Offset = "0x1D5DDB4", VA = "0x7BBC55DDB4")]
		public UIHeroicMarkDetailWndView()
		{
		}

		// Token: 0x0400D2FB RID: 54011
		[Token(Token = "0x400D2FB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400D2FC RID: 54012
		[Token(Token = "0x400D2FC")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList TabsContainer;

		// Token: 0x0400D2FD RID: 54013
		[Token(Token = "0x400D2FD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Desc;

		// Token: 0x0400D2FE RID: 54014
		[Token(Token = "0x400D2FE")]
		[FieldOffset(Offset = "0x38")]
		public UIButton MoreDetail;

		// Token: 0x0400D2FF RID: 54015
		[Token(Token = "0x400D2FF")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ScrollView;

		// Token: 0x0400D300 RID: 54016
		[Token(Token = "0x400D300")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid Grid;

		// Token: 0x0400D301 RID: 54017
		[Token(Token = "0x400D301")]
		[FieldOffset(Offset = "0x50")]
		public UIHeroicMarkItemCtrl MarkItem;
	}
}
