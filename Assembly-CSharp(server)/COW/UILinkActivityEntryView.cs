using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E4 RID: 9188
	[Token(Token = "0x20023E4")]
	public class UILinkActivityEntryView : UIBaseView
	{
		// Token: 0x0600C2D8 RID: 49880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D8")]
		[Address(RVA = "0x1CBC1E0", Offset = "0x1CBC1E0", VA = "0x7BBC4BC1E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D9")]
		[Address(RVA = "0x1CBC300", Offset = "0x1CBC300", VA = "0x7BBC4BC300")]
		public UILinkActivityEntryView()
		{
		}

		// Token: 0x0400E0A1 RID: 57505
		[Token(Token = "0x400E0A1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Btn;

		// Token: 0x0400E0A2 RID: 57506
		[Token(Token = "0x400E0A2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Sprite;

		// Token: 0x0400E0A3 RID: 57507
		[Token(Token = "0x400E0A3")]
		[FieldOffset(Offset = "0x30")]
		public TweenPosition TweenPosition;
	}
}
