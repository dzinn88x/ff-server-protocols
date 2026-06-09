using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024AA RID: 9386
	[Token(Token = "0x20024AA")]
	public class UIProfileMarryInfoPanelView : UIBaseView
	{
		// Token: 0x0600C464 RID: 50276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C464")]
		[Address(RVA = "0x1FE2B00", Offset = "0x1FE2B00", VA = "0x7BBC7E2B00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C465")]
		[Address(RVA = "0x1FE2D54", Offset = "0x1FE2D54", VA = "0x7BBC7E2D54")]
		public UIProfileMarryInfoPanelView()
		{
		}

		// Token: 0x0400ED5C RID: 60764
		[Token(Token = "0x400ED5C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Bg;

		// Token: 0x0400ED5D RID: 60765
		[Token(Token = "0x400ED5D")]
		[FieldOffset(Offset = "0x28")]
		public UISprite PlayerIcon1;

		// Token: 0x0400ED5E RID: 60766
		[Token(Token = "0x400ED5E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel PlayerLabel1;

		// Token: 0x0400ED5F RID: 60767
		[Token(Token = "0x400ED5F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PlayerLabel2;

		// Token: 0x0400ED60 RID: 60768
		[Token(Token = "0x400ED60")]
		[FieldOffset(Offset = "0x40")]
		public UISprite PlayerIcon2;

		// Token: 0x0400ED61 RID: 60769
		[Token(Token = "0x400ED61")]
		[FieldOffset(Offset = "0x48")]
		public UISprite MarryIcon;

		// Token: 0x0400ED62 RID: 60770
		[Token(Token = "0x400ED62")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Num;

		// Token: 0x0400ED63 RID: 60771
		[Token(Token = "0x400ED63")]
		[FieldOffset(Offset = "0x58")]
		public UIButton CloseButton;
	}
}
