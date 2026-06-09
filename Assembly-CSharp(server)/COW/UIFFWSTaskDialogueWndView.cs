using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021EC RID: 8684
	[Token(Token = "0x20021EC")]
	public class UIFFWSTaskDialogueWndView : UIBaseView
	{
		// Token: 0x0600BEE9 RID: 48873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE9")]
		[Address(RVA = "0x228D1CC", Offset = "0x228D1CC", VA = "0x7BBCA8D1CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEEA")]
		[Address(RVA = "0x228D3B4", Offset = "0x228D3B4", VA = "0x7BBCA8D3B4")]
		public UIFFWSTaskDialogueWndView()
		{
		}

		// Token: 0x0400CCE4 RID: 52452
		[Token(Token = "0x400CCE4")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture AvatarTexture;

		// Token: 0x0400CCE5 RID: 52453
		[Token(Token = "0x400CCE5")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;

		// Token: 0x0400CCE6 RID: 52454
		[Token(Token = "0x400CCE6")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DialogueContent;

		// Token: 0x0400CCE7 RID: 52455
		[Token(Token = "0x400CCE7")]
		[FieldOffset(Offset = "0x38")]
		public UISprite DialogueContinueHint;

		// Token: 0x0400CCE8 RID: 52456
		[Token(Token = "0x400CCE8")]
		[FieldOffset(Offset = "0x40")]
		public UIButton AcceptBtn;

		// Token: 0x0400CCE9 RID: 52457
		[Token(Token = "0x400CCE9")]
		[FieldOffset(Offset = "0x48")]
		public UIButton Mask;
	}
}
