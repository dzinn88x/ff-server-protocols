using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C3 RID: 9155
	[Token(Token = "0x20023C3")]
	internal class UIInstallmentMallPurchaseItemView : UIBaseView
	{
		// Token: 0x0600C296 RID: 49814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C296")]
		[Address(RVA = "0x190FD54", Offset = "0x190FD54", VA = "0x7BBC10FD54", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C297 RID: 49815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C297")]
		[Address(RVA = "0x191003C", Offset = "0x191003C", VA = "0x7BBC11003C")]
		public UIInstallmentMallPurchaseItemView()
		{
		}

		// Token: 0x0400DED0 RID: 57040
		[Token(Token = "0x400DED0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Light;

		// Token: 0x0400DED1 RID: 57041
		[Token(Token = "0x400DED1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject CurrentLight;

		// Token: 0x0400DED2 RID: 57042
		[Token(Token = "0x400DED2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HighLightLine;

		// Token: 0x0400DED3 RID: 57043
		[Token(Token = "0x400DED3")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Lock;

		// Token: 0x0400DED4 RID: 57044
		[Token(Token = "0x400DED4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject LockLine;

		// Token: 0x0400DED5 RID: 57045
		[Token(Token = "0x400DED5")]
		[FieldOffset(Offset = "0x48")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400DED6 RID: 57046
		[Token(Token = "0x400DED6")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Days;

		// Token: 0x0400DED7 RID: 57047
		[Token(Token = "0x400DED7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Term;

		// Token: 0x0400DED8 RID: 57048
		[Token(Token = "0x400DED8")]
		[FieldOffset(Offset = "0x60")]
		public GameObject GemIcon;

		// Token: 0x0400DED9 RID: 57049
		[Token(Token = "0x400DED9")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BG;

		// Token: 0x0400DEDA RID: 57050
		[Token(Token = "0x400DEDA")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PriceLabel;
	}
}
