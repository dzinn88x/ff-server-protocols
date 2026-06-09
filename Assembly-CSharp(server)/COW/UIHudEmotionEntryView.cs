using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022C1 RID: 8897
	[Token(Token = "0x20022C1")]
	internal class UIHudEmotionEntryView : UIBaseView
	{
		// Token: 0x0600C092 RID: 49298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C092")]
		[Address(RVA = "0x1C02F00", Offset = "0x1C02F00", VA = "0x7BBC402F00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C093 RID: 49299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C093")]
		[Address(RVA = "0x1C03074", Offset = "0x1C03074", VA = "0x7BBC403074")]
		public UIHudEmotionEntryView()
		{
		}

		// Token: 0x0400D647 RID: 54855
		[Token(Token = "0x400D647")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnEmotionEntry;

		// Token: 0x0400D648 RID: 54856
		[Token(Token = "0x400D648")]
		[FieldOffset(Offset = "0x28")]
		public Transform iconEmotion;

		// Token: 0x0400D649 RID: 54857
		[Token(Token = "0x400D649")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget iconWidget;

		// Token: 0x0400D64A RID: 54858
		[Token(Token = "0x400D64A")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteNormal;
	}
}
