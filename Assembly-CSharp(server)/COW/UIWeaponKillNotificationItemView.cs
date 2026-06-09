using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002590 RID: 9616
	[Token(Token = "0x2002590")]
	public class UIWeaponKillNotificationItemView : UIBaseView
	{
		// Token: 0x0600C630 RID: 50736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C630")]
		[Address(RVA = "0x168AC64", Offset = "0x168AC64", VA = "0x7BBBE8AC64", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C631")]
		[Address(RVA = "0x168ADF0", Offset = "0x168ADF0", VA = "0x7BBBE8ADF0")]
		public UIWeaponKillNotificationItemView()
		{
		}

		// Token: 0x0400F748 RID: 63304
		[Token(Token = "0x400F748")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition tween;

		// Token: 0x0400F749 RID: 63305
		[Token(Token = "0x400F749")]
		[FieldOffset(Offset = "0x28")]
		public UISprite qualityBG;

		// Token: 0x0400F74A RID: 63306
		[Token(Token = "0x400F74A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite iconQualityBg;

		// Token: 0x0400F74B RID: 63307
		[Token(Token = "0x400F74B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite icon;

		// Token: 0x0400F74C RID: 63308
		[Token(Token = "0x400F74C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel content;
	}
}
