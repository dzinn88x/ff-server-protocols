using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F8 RID: 8696
	[Token(Token = "0x20021F8")]
	public class UIFriendCallbackItemView : UIBaseView
	{
		// Token: 0x0600BF01 RID: 48897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF01")]
		[Address(RVA = "0x1DC1B00", Offset = "0x1DC1B00", VA = "0x7BBC5C1B00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF02")]
		[Address(RVA = "0x1DC1D8C", Offset = "0x1DC1D8C", VA = "0x7BBC5C1D8C")]
		public UIFriendCallbackItemView()
		{
		}

		// Token: 0x0400CD86 RID: 52614
		[Token(Token = "0x400CD86")]
		[FieldOffset(Offset = "0x20")]
		public UIButton headbtn;

		// Token: 0x0400CD87 RID: 52615
		[Token(Token = "0x400CD87")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture HeadIcon;

		// Token: 0x0400CD88 RID: 52616
		[Token(Token = "0x400CD88")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HeadSprite;

		// Token: 0x0400CD89 RID: 52617
		[Token(Token = "0x400CD89")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FakeSprite;

		// Token: 0x0400CD8A RID: 52618
		[Token(Token = "0x400CD8A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel NickName;

		// Token: 0x0400CD8B RID: 52619
		[Token(Token = "0x400CD8B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PlatformName;

		// Token: 0x0400CD8C RID: 52620
		[Token(Token = "0x400CD8C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject PlatformIcon;

		// Token: 0x0400CD8D RID: 52621
		[Token(Token = "0x400CD8D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PlatformNickNameLabel;

		// Token: 0x0400CD8E RID: 52622
		[Token(Token = "0x400CD8E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LastLoginTime;
	}
}
