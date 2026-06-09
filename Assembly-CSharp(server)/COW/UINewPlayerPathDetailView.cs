using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200245B RID: 9307
	[Token(Token = "0x200245B")]
	internal class UINewPlayerPathDetailView : UIBaseView
	{
		// Token: 0x0600C3C6 RID: 50118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C6")]
		[Address(RVA = "0x1AF7A28", Offset = "0x1AF7A28", VA = "0x7BBC2F7A28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3C7 RID: 50119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C7")]
		[Address(RVA = "0x1AF7B48", Offset = "0x1AF7B48", VA = "0x7BBC2F7B48")]
		public UINewPlayerPathDetailView()
		{
		}

		// Token: 0x0400E8C6 RID: 59590
		[Token(Token = "0x400E8C6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x0400E8C7 RID: 59591
		[Token(Token = "0x400E8C7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Container;

		// Token: 0x0400E8C8 RID: 59592
		[Token(Token = "0x400E8C8")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture NetworkTexture;
	}
}
