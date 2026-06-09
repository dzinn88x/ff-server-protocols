using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021DE RID: 8670
	[Token(Token = "0x20021DE")]
	internal class UIFastSendGiftFriendItemView : UIBaseView
	{
		// Token: 0x0600BECD RID: 48845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BECD")]
		[Address(RVA = "0x1DB4E7C", Offset = "0x1DB4E7C", VA = "0x7BBC5B4E7C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BECE RID: 48846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BECE")]
		[Address(RVA = "0x1DB5154", Offset = "0x1DB5154", VA = "0x7BBC5B5154")]
		public UIFastSendGiftFriendItemView()
		{
		}

		// Token: 0x0400CBE9 RID: 52201
		[Token(Token = "0x400CBE9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400CBEA RID: 52202
		[Token(Token = "0x400CBEA")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton SelectBtn;

		// Token: 0x0400CBEB RID: 52203
		[Token(Token = "0x400CBEB")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite bg;

		// Token: 0x0400CBEC RID: 52204
		[Token(Token = "0x400CBEC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject fakeBg;

		// Token: 0x0400CBED RID: 52205
		[Token(Token = "0x400CBED")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture HeadIcon;

		// Token: 0x0400CBEE RID: 52206
		[Token(Token = "0x400CBEE")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite HeadSprite;

		// Token: 0x0400CBEF RID: 52207
		[Token(Token = "0x400CBEF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FakeSprite;

		// Token: 0x0400CBF0 RID: 52208
		[Token(Token = "0x400CBF0")]
		[FieldOffset(Offset = "0x58")]
		public UILabel nickname;

		// Token: 0x0400CBF1 RID: 52209
		[Token(Token = "0x400CBF1")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Available;

		// Token: 0x0400CBF2 RID: 52210
		[Token(Token = "0x400CBF2")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Mask;
	}
}
