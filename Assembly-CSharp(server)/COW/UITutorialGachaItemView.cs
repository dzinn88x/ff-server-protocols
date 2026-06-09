using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200257D RID: 9597
	[Token(Token = "0x200257D")]
	internal class UITutorialGachaItemView : UIBaseView
	{
		// Token: 0x0600C60A RID: 50698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60A")]
		[Address(RVA = "0x19F81C4", Offset = "0x19F81C4", VA = "0x7BBC1F81C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60B")]
		[Address(RVA = "0x19F82E4", Offset = "0x19F82E4", VA = "0x7BBC1F82E4")]
		public UITutorialGachaItemView()
		{
		}

		// Token: 0x0400F6A2 RID: 63138
		[Token(Token = "0x400F6A2")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400F6A3 RID: 63139
		[Token(Token = "0x400F6A3")]
		[FieldOffset(Offset = "0x28")]
		public UIButton close;

		// Token: 0x0400F6A4 RID: 63140
		[Token(Token = "0x400F6A4")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture NetworkTexture;
	}
}
