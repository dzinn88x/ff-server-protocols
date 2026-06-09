using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200245F RID: 9311
	[Token(Token = "0x200245F")]
	public class UINewPlayerSigninView : UIBaseView
	{
		// Token: 0x0600C3CE RID: 50126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CE")]
		[Address(RVA = "0x1AFCAF0", Offset = "0x1AFCAF0", VA = "0x7BBC2FCAF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CF")]
		[Address(RVA = "0x1AFCDC8", Offset = "0x1AFCDC8", VA = "0x7BBC2FCDC8")]
		public UINewPlayerSigninView()
		{
		}

		// Token: 0x0400E8FA RID: 59642
		[Token(Token = "0x400E8FA")]
		[FieldOffset(Offset = "0x20")]
		public UISprite bg;

		// Token: 0x0400E8FB RID: 59643
		[Token(Token = "0x400E8FB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TitleLabel;

		// Token: 0x0400E8FC RID: 59644
		[Token(Token = "0x400E8FC")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400E8FD RID: 59645
		[Token(Token = "0x400E8FD")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BundleImageLocal;

		// Token: 0x0400E8FE RID: 59646
		[Token(Token = "0x400E8FE")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture CDNEPWebSite;

		// Token: 0x0400E8FF RID: 59647
		[Token(Token = "0x400E8FF")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid NormalDaysListGrid;

		// Token: 0x0400E900 RID: 59648
		[Token(Token = "0x400E900")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid NormalDaysListGridButtom;

		// Token: 0x0400E901 RID: 59649
		[Token(Token = "0x400E901")]
		[FieldOffset(Offset = "0x58")]
		public Transform BigDayContainer;

		// Token: 0x0400E902 RID: 59650
		[Token(Token = "0x400E902")]
		[FieldOffset(Offset = "0x60")]
		public Transform CountDownContainer;

		// Token: 0x0400E903 RID: 59651
		[Token(Token = "0x400E903")]
		[FieldOffset(Offset = "0x68")]
		public GameObject NewPLayerTitle;
	}
}
