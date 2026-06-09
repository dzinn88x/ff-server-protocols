using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200248F RID: 9359
	[Token(Token = "0x200248F")]
	public class UIPetSkinItemView : UIBaseView
	{
		// Token: 0x0600C42E RID: 50222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C42E")]
		[Address(RVA = "0x20E5A54", Offset = "0x20E5A54", VA = "0x7BBC8E5A54", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C42F")]
		[Address(RVA = "0x20E5C90", Offset = "0x20E5C90", VA = "0x7BBC8E5C90")]
		public UIPetSkinItemView()
		{
		}

		// Token: 0x0400EB3E RID: 60222
		[Token(Token = "0x400EB3E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIPetSkinItem;

		// Token: 0x0400EB3F RID: 60223
		[Token(Token = "0x400EB3F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NewTips;

		// Token: 0x0400EB40 RID: 60224
		[Token(Token = "0x400EB40")]
		[FieldOffset(Offset = "0x30")]
		public GameObject UnlockMask;

		// Token: 0x0400EB41 RID: 60225
		[Token(Token = "0x400EB41")]
		[FieldOffset(Offset = "0x38")]
		public UILabel UnlockIcon;

		// Token: 0x0400EB42 RID: 60226
		[Token(Token = "0x400EB42")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ActionName;

		// Token: 0x0400EB43 RID: 60227
		[Token(Token = "0x400EB43")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DescLabel;

		// Token: 0x0400EB44 RID: 60228
		[Token(Token = "0x400EB44")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SelectTag;

		// Token: 0x0400EB45 RID: 60229
		[Token(Token = "0x400EB45")]
		[FieldOffset(Offset = "0x58")]
		public GameObject DownloadMask;
	}
}
