using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F1 RID: 8689
	[Token(Token = "0x20021F1")]
	public class UIFFWSWarmUpView : UIBaseView
	{
		// Token: 0x0600BEF3 RID: 48883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF3")]
		[Address(RVA = "0x1DB19F0", Offset = "0x1DB19F0", VA = "0x7BBC5B19F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF4")]
		[Address(RVA = "0x1DB1BE8", Offset = "0x1DB1BE8", VA = "0x7BBC5B1BE8")]
		public UIFFWSWarmUpView()
		{
		}

		// Token: 0x0400CD3F RID: 52543
		[Token(Token = "0x400CD3F")]
		[FieldOffset(Offset = "0x20")]
		public Animation AnimationEntrance;

		// Token: 0x0400CD40 RID: 52544
		[Token(Token = "0x400CD40")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt TextureTitleCDN;

		// Token: 0x0400CD41 RID: 52545
		[Token(Token = "0x400CD41")]
		[FieldOffset(Offset = "0x30")]
		public Transform TrCountDownRoot;

		// Token: 0x0400CD42 RID: 52546
		[Token(Token = "0x400CD42")]
		[FieldOffset(Offset = "0x38")]
		public UIPanel PanelCloseMask;

		// Token: 0x0400CD43 RID: 52547
		[Token(Token = "0x400CD43")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClose;

		// Token: 0x0400CD44 RID: 52548
		[Token(Token = "0x400CD44")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelCloseTip;
	}
}
