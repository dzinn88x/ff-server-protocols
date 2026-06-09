using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E7 RID: 8423
	[Token(Token = "0x20020E7")]
	public class UIActivityScrollViewItemView : UIBaseView
	{
		// Token: 0x0600BCDF RID: 48351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDF")]
		[Address(RVA = "0x195B430", Offset = "0x195B430", VA = "0x7BBC15B430", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE0")]
		[Address(RVA = "0x195B5A4", Offset = "0x195B5A4", VA = "0x7BBC15B5A4")]
		public UIActivityScrollViewItemView()
		{
		}

		// Token: 0x0400BF39 RID: 48953
		[Token(Token = "0x400BF39")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture AD;

		// Token: 0x0400BF3A RID: 48954
		[Token(Token = "0x400BF3A")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ADBtn;

		// Token: 0x0400BF3B RID: 48955
		[Token(Token = "0x400BF3B")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView DragScroll;

		// Token: 0x0400BF3C RID: 48956
		[Token(Token = "0x400BF3C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Line;
	}
}
