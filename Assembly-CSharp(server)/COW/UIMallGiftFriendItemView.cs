using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002417 RID: 9239
	[Token(Token = "0x2002417")]
	public class UIMallGiftFriendItemView : UIBaseView
	{
		// Token: 0x0600C33E RID: 49982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33E")]
		[Address(RVA = "0x1C72F98", Offset = "0x1C72F98", VA = "0x7BBC472F98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33F")]
		[Address(RVA = "0x1C73298", Offset = "0x1C73298", VA = "0x7BBC473298")]
		public UIMallGiftFriendItemView()
		{
		}

		// Token: 0x0400E497 RID: 58519
		[Token(Token = "0x400E497")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E498 RID: 58520
		[Token(Token = "0x400E498")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton SelectBtn;

		// Token: 0x0400E499 RID: 58521
		[Token(Token = "0x400E499")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite bg;

		// Token: 0x0400E49A RID: 58522
		[Token(Token = "0x400E49A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject fakeBg;

		// Token: 0x0400E49B RID: 58523
		[Token(Token = "0x400E49B")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture HeadIcon;

		// Token: 0x0400E49C RID: 58524
		[Token(Token = "0x400E49C")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite HeadSprite;

		// Token: 0x0400E49D RID: 58525
		[Token(Token = "0x400E49D")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FakeSprite;

		// Token: 0x0400E49E RID: 58526
		[Token(Token = "0x400E49E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel nickname;

		// Token: 0x0400E49F RID: 58527
		[Token(Token = "0x400E49F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Available;

		// Token: 0x0400E4A0 RID: 58528
		[Token(Token = "0x400E4A0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Mask;

		// Token: 0x0400E4A1 RID: 58529
		[Token(Token = "0x400E4A1")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Favor;
	}
}
