using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002283 RID: 8835
	[Token(Token = "0x2002283")]
	public class UIHudBombZoneMarkView : UIBaseView
	{
		// Token: 0x0600C017 RID: 49175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C017")]
		[Address(RVA = "0x189E0A0", Offset = "0x189E0A0", VA = "0x7BBC09E0A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C018 RID: 49176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C018")]
		[Address(RVA = "0x189E360", Offset = "0x189E360", VA = "0x7BBC09E360")]
		public UIHudBombZoneMarkView()
		{
		}

		// Token: 0x0400D431 RID: 54321
		[Token(Token = "0x400D431")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BombFg;

		// Token: 0x0400D432 RID: 54322
		[Token(Token = "0x400D432")]
		[FieldOffset(Offset = "0x28")]
		public UISprite RemoveBombFg;

		// Token: 0x0400D433 RID: 54323
		[Token(Token = "0x400D433")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BombBg;

		// Token: 0x0400D434 RID: 54324
		[Token(Token = "0x400D434")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ZoneIDLabel;

		// Token: 0x0400D435 RID: 54325
		[Token(Token = "0x400D435")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ArrowLeft;

		// Token: 0x0400D436 RID: 54326
		[Token(Token = "0x400D436")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ArrowUp;

		// Token: 0x0400D437 RID: 54327
		[Token(Token = "0x400D437")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ArrowDown;

		// Token: 0x0400D438 RID: 54328
		[Token(Token = "0x400D438")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ArrowRight;

		// Token: 0x0400D439 RID: 54329
		[Token(Token = "0x400D439")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DistanceLabel;

		// Token: 0x0400D43A RID: 54330
		[Token(Token = "0x400D43A")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget boundWidget;
	}
}
