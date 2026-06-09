using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020FC RID: 8444
	[Token(Token = "0x20020FC")]
	internal class UIAvatarLevelCardItemView : UIBaseView
	{
		// Token: 0x0600BD09 RID: 48393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD09")]
		[Address(RVA = "0x1B25FB8", Offset = "0x1B25FB8", VA = "0x7BBC325FB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0A")]
		[Address(RVA = "0x1B2615C", Offset = "0x1B2615C", VA = "0x7BBC32615C")]
		public UIAvatarLevelCardItemView()
		{
		}

		// Token: 0x0400C016 RID: 49174
		[Token(Token = "0x400C016")]
		[FieldOffset(Offset = "0x20")]
		public UIButton itemBtn;

		// Token: 0x0400C017 RID: 49175
		[Token(Token = "0x400C017")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400C018 RID: 49176
		[Token(Token = "0x400C018")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HL;

		// Token: 0x0400C019 RID: 49177
		[Token(Token = "0x400C019")]
		[FieldOffset(Offset = "0x38")]
		public UILabel cnt;

		// Token: 0x0400C01A RID: 49178
		[Token(Token = "0x400C01A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GraySprite;
	}
}
