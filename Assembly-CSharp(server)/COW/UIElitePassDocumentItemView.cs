using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B4 RID: 8628
	[Token(Token = "0x20021B4")]
	public class UIElitePassDocumentItemView : UIBaseView
	{
		// Token: 0x0600BE78 RID: 48760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE78")]
		[Address(RVA = "0x1AE7AD4", Offset = "0x1AE7AD4", VA = "0x7BBC2E7AD4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE79 RID: 48761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE79")]
		[Address(RVA = "0x1AE7CBC", Offset = "0x1AE7CBC", VA = "0x7BBC2E7CBC")]
		public UIElitePassDocumentItemView()
		{
		}

		// Token: 0x0400CA23 RID: 51747
		[Token(Token = "0x400CA23")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelEPId;

		// Token: 0x0400CA24 RID: 51748
		[Token(Token = "0x400CA24")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelEPId2;

		// Token: 0x0400CA25 RID: 51749
		[Token(Token = "0x400CA25")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture EPTexture;

		// Token: 0x0400CA26 RID: 51750
		[Token(Token = "0x400CA26")]
		[FieldOffset(Offset = "0x38")]
		public UISprite EPBadge;

		// Token: 0x0400CA27 RID: 51751
		[Token(Token = "0x400CA27")]
		[FieldOffset(Offset = "0x40")]
		public UILabel EPBadgeNum;

		// Token: 0x0400CA28 RID: 51752
		[Token(Token = "0x400CA28")]
		[FieldOffset(Offset = "0x48")]
		public GameObject VFX_Effect;
	}
}
