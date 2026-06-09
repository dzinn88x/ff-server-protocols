using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200228C RID: 8844
	[Token(Token = "0x200228C")]
	internal class UIHudBuildingSwitchInfoView : UIBaseView
	{
		// Token: 0x0600C029 RID: 49193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C029")]
		[Address(RVA = "0x19B5A2C", Offset = "0x19B5A2C", VA = "0x7BBC1B5A2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C02A")]
		[Address(RVA = "0x19B5B4C", Offset = "0x19B5B4C", VA = "0x7BBC1B5B4C")]
		public UIHudBuildingSwitchInfoView()
		{
		}

		// Token: 0x0400D456 RID: 54358
		[Token(Token = "0x400D456")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BuidlingSwitchButton;

		// Token: 0x0400D457 RID: 54359
		[Token(Token = "0x400D457")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400D458 RID: 54360
		[Token(Token = "0x400D458")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Highlight;
	}
}
