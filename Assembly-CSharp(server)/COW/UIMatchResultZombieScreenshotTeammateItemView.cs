using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200243E RID: 9278
	[Token(Token = "0x200243E")]
	internal class UIMatchResultZombieScreenshotTeammateItemView : UIBaseView
	{
		// Token: 0x0600C38C RID: 50060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38C")]
		[Address(RVA = "0x14823C8", Offset = "0x14823C8", VA = "0x7BBBC823C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38D")]
		[Address(RVA = "0x148252C", Offset = "0x148252C", VA = "0x7BBBC8252C")]
		public UIMatchResultZombieScreenshotTeammateItemView()
		{
		}

		// Token: 0x0400E73C RID: 59196
		[Token(Token = "0x400E73C")]
		[FieldOffset(Offset = "0x20")]
		public UISprite WeaponIcon;

		// Token: 0x0400E73D RID: 59197
		[Token(Token = "0x400E73D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Nickname;

		// Token: 0x0400E73E RID: 59198
		[Token(Token = "0x400E73E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Damages;

		// Token: 0x0400E73F RID: 59199
		[Token(Token = "0x400E73F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject MVPIcon;
	}
}
