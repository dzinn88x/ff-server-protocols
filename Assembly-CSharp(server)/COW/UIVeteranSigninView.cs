using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002587 RID: 9607
	[Token(Token = "0x2002587")]
	internal class UIVeteranSigninView : UIBaseView
	{
		// Token: 0x0600C61E RID: 50718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61E")]
		[Address(RVA = "0x1680520", Offset = "0x1680520", VA = "0x7BBBE80520", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C61F RID: 50719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61F")]
		[Address(RVA = "0x168078C", Offset = "0x168078C", VA = "0x7BBBE8078C")]
		public UIVeteranSigninView()
		{
		}

		// Token: 0x0400F705 RID: 63237
		[Token(Token = "0x400F705")]
		[FieldOffset(Offset = "0x20")]
		public UISprite bg;

		// Token: 0x0400F706 RID: 63238
		[Token(Token = "0x400F706")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TitleLabel;

		// Token: 0x0400F707 RID: 63239
		[Token(Token = "0x400F707")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400F708 RID: 63240
		[Token(Token = "0x400F708")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BundleImageLocal;

		// Token: 0x0400F709 RID: 63241
		[Token(Token = "0x400F709")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTextureExt BundleImageRemote;

		// Token: 0x0400F70A RID: 63242
		[Token(Token = "0x400F70A")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid NormalDaysGridTop;

		// Token: 0x0400F70B RID: 63243
		[Token(Token = "0x400F70B")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid NormalDaysGridBottom;

		// Token: 0x0400F70C RID: 63244
		[Token(Token = "0x400F70C")]
		[FieldOffset(Offset = "0x58")]
		public Transform BigDayContainer;
	}
}
