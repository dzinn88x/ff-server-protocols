using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002303 RID: 8963
	[Token(Token = "0x2002303")]
	public class UIHudMapMarkView : UIBaseView
	{
		// Token: 0x0600C116 RID: 49430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C116")]
		[Address(RVA = "0x15BDB00", Offset = "0x15BDB00", VA = "0x7BBBDBDB00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C117 RID: 49431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C117")]
		[Address(RVA = "0x15BDCF8", Offset = "0x15BDCF8", VA = "0x7BBBDBDCF8")]
		public UIHudMapMarkView()
		{
		}

		// Token: 0x0400D848 RID: 55368
		[Token(Token = "0x400D848")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha MarkTween;

		// Token: 0x0400D849 RID: 55369
		[Token(Token = "0x400D849")]
		[FieldOffset(Offset = "0x28")]
		public UISprite MarkIcon;

		// Token: 0x0400D84A RID: 55370
		[Token(Token = "0x400D84A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LeaderIcon;

		// Token: 0x0400D84B RID: 55371
		[Token(Token = "0x400D84B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ArrowUp;

		// Token: 0x0400D84C RID: 55372
		[Token(Token = "0x400D84C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject arrowRight;

		// Token: 0x0400D84D RID: 55373
		[Token(Token = "0x400D84D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject arrowDown;

		// Token: 0x0400D84E RID: 55374
		[Token(Token = "0x400D84E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject arrowLeft;
	}
}
