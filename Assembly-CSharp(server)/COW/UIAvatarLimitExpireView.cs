using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020FF RID: 8447
	[Token(Token = "0x20020FF")]
	public class UIAvatarLimitExpireView : UIBaseView
	{
		// Token: 0x0600BD0F RID: 48399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0F")]
		[Address(RVA = "0x1B2A468", Offset = "0x1B2A468", VA = "0x7BBC32A468", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD10 RID: 48400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD10")]
		[Address(RVA = "0x1B2A5D4", Offset = "0x1B2A5D4", VA = "0x7BBC32A5D4")]
		public UIAvatarLimitExpireView()
		{
		}

		// Token: 0x0400C032 RID: 49202
		[Token(Token = "0x400C032")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid List;

		// Token: 0x0400C033 RID: 49203
		[Token(Token = "0x400C033")]
		[FieldOffset(Offset = "0x28")]
		public UISprite AvatarHead;

		// Token: 0x0400C034 RID: 49204
		[Token(Token = "0x400C034")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ComfirmBtn;

		// Token: 0x0400C035 RID: 49205
		[Token(Token = "0x400C035")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnBG;
	}
}
