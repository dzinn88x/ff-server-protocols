using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200226F RID: 8815
	[Token(Token = "0x200226F")]
	internal class UIHudAudioBucketsView : UIBaseView
	{
		// Token: 0x0600BFEF RID: 49135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFEF")]
		[Address(RVA = "0x18883E0", Offset = "0x18883E0", VA = "0x7BBC0883E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF0")]
		[Address(RVA = "0x1888574", Offset = "0x1888574", VA = "0x7BBC088574")]
		public UIHudAudioBucketsView()
		{
		}

		// Token: 0x0400D3AC RID: 54188
		[Token(Token = "0x400D3AC")]
		[FieldOffset(Offset = "0x20")]
		public Transform TemplateContainer;

		// Token: 0x0400D3AD RID: 54189
		[Token(Token = "0x400D3AD")]
		[FieldOffset(Offset = "0x28")]
		public GameObject AudioInfo;

		// Token: 0x0400D3AE RID: 54190
		[Token(Token = "0x400D3AE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Container;

		// Token: 0x0400D3AF RID: 54191
		[Token(Token = "0x400D3AF")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid ListGrid;

		// Token: 0x0400D3B0 RID: 54192
		[Token(Token = "0x400D3B0")]
		[FieldOffset(Offset = "0x40")]
		public UIButton ToggleAudioDebug;
	}
}
